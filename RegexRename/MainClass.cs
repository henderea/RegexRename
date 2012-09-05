using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace RegexRename
{
// ReSharper disable InconsistentNaming
    public partial class MainClass : Form
    {
        public MainClass()
        {
            InitializeComponent();
            fnames = new List<string>(0);
            ReloadData();
        }

        private readonly List<string> fnames;
        private volatile bool cancel;

        private delegate void NoParamDel();

        private delegate void ListDictionaryParamDel(List<string> list, Dictionary<string, string> dictionary, List<string> list2);

        private void ReloadData()
        {
            new NoParamDel(ReloadDataBG).BeginInvoke(null, null);
        }//( \(.*\))|( - \D[^.]*vs\.[^.]*)|( - \D[^.]*)

        private void ReloadDataBG()
        {
            try
            {
                cancel = true;
                Thread.Sleep(10);
                cancel = false;
                Regex r = new Regex(regexField.Text);
                Dictionary<string, string> fnameMods = new Dictionary<string, string>(0);
                List<string> fnameUsed = new List<string>(0);
                List<string> fnameUsedMulti = new List<string>(0);
                List<string> fnameUnchanged = new List<string>(0);
                fnameUsedMulti.Add("Error");
                foreach (string f in fnames)
                {
                    if (cancel)
                        return;
                    string fnameMod;
                    try
                    {
                        fnameMod = f.Remove(f.LastIndexOf("\\") + 1) + r.Replace(f.Substring(f.LastIndexOf("\\") + 1), replaceField.Text);
                        if (fnameUsed.Contains(fnameMod))
                        {
                            if (!fnameUsedMulti.Contains(fnameMod))
                                fnameUsedMulti.Add(fnameMod);
                        }
                        else
                            fnameUsed.Add(fnameMod);
                    }
                    catch
                    {
                        fnameMod = "Error";
                    }
                    if(f.Equals(fnameMod))
                        fnameUnchanged.Add(f);
                    else
                    fnameMods[f] = fnameMod;
                }
                UpdateDataView(fnameUsedMulti, fnameMods, fnameUnchanged);
            }
            catch
            {
                ResetDataView();
            }
        }

        private void ResetDataView()
        {
            if(dataView.InvokeRequired)
            {
                NoParamDel d = ResetDataView;
                Invoke(d, null);
                return;
            }
            dataView.Rows.Clear();
            foreach (string f in fnames)
            {
                if (cancel)
                    return;
                dataView.Rows.Add(new object[] { f, f });
            }
        }

        private void UpdateDataView(List<string> fnameUsedMulti, Dictionary<string, string> fnameMods, List<string> fnameUnchanged)
        {
            if(dataView.InvokeRequired)
            {
                ListDictionaryParamDel d = UpdateDataView;
                Invoke(d, new object[] { fnameUsedMulti, fnameMods, fnameUnchanged });
                return;
            }
            dataView.Rows.Clear();
            foreach (KeyValuePair<string, string> kvp in fnameMods)
            {
                if (cancel)
                    return;
                dataView.Rows.Add(new object[] { kvp.Key, kvp.Value });
                if (kvp.Key.Equals(kvp.Value))
                    dataView.Rows[dataView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGray;
                if (fnameUsedMulti.Contains(kvp.Value))
                    dataView.Rows[dataView.Rows.Count - 1].Cells[1].Style.BackColor = Color.Red;
            }

            foreach (string s in fnameUnchanged)
            {
                if (cancel)
                    return;
                dataView.Rows.Add(new object[] { s, s });
                dataView.Rows[dataView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGray;
                if (fnameUsedMulti.Contains(s))
                    dataView.Rows[dataView.Rows.Count - 1].Cells[1].Style.BackColor = Color.Red;
            }
        }

        private void Rename()
        {
            try
            {
                Regex r = new Regex(regexField.Text);
                Dictionary<string, string> fnameMods = new Dictionary<string, string>(0);
                foreach (string f in fnames)
                {
                    try
                    {
                        fnameMods[f] = f.Remove(f.LastIndexOf("\\") + 1) + r.Replace(f.Substring(f.LastIndexOf("\\") + 1), replaceField.Text);
                    }
                    catch {}
                }
                foreach (KeyValuePair<string, string> kvp in fnameMods)
                {
                    try
                    {
                        File.Move(kvp.Key, kvp.Value);
                    }
                    catch {}
                }
            }
            catch {}
        }

        private void dataView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void dataView_DragDrop(object sender, DragEventArgs e)
        {
            Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
            foreach(object i in a)
            {
                fnames.Add(i.ToString());
            }
            fnames.Sort();
            ReloadData();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fnames.Clear();
            ReloadData();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            RenameDialog d = new RenameDialog();
            d.ShowDialog(this);
            if (!d.Result) return;
            Rename();
            fnames.Clear();
            ReloadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MainClass_Load(object sender, EventArgs e)
        {
            const Keys k = Keys.R | Keys.Control | Keys.Alt | Keys.Shift;
            WindowsShell.RegisterHotKey(this, k);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != WindowsShell.WM_HOTKEY) return;
            Show();
            BringToFront();
            CenterToScreen();
        }

        private void MainClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            else
            {
                try
                {
                    WindowsShell.UnregisterHotKey(this);
                }
                catch {}
                return;
            }
            Hide();
        }

        private void showItem_Click(object sender, EventArgs e)
        {
            Show();
            BringToFront();
            CenterToScreen();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            WindowsShell.UnregisterHotKey(this);
            Application.Exit();
        }

        private void taskIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            BringToFront();
            CenterToScreen();
        }

        private void MainClass_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void field_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ReloadData();
        }
    }
// ReSharper restore InconsistentNaming
    public class WindowsShell
    {
        #region fields
        // ReSharper disable InconsistentNaming
        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;
        public static int WM_HOTKEY = 0x312;
        // ReSharper restore InconsistentNaming
        #endregion

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static int keyId;
        public static void RegisterHotKey(Form f, Keys key)
        {
            int modifiers = 0;
            if ((key & Keys.Alt) == Keys.Alt)
                modifiers = modifiers | MOD_ALT;
            if ((key & Keys.Control) == Keys.Control)
                modifiers = modifiers | MOD_CONTROL;
            if ((key & Keys.Shift) == Keys.Shift)
                modifiers = modifiers | MOD_SHIFT;
            Keys k = key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;
            keyId = f.GetHashCode(); // this should be a key unique ID, modify this if you want more than one hotkey
            RegisterHotKey(f.Handle, keyId, (uint)modifiers, (uint)k);
        }

        public static void UnregisterHotKey(Form f)
        {
            try
            {
                UnregisterHotKey(f.Handle, keyId); // modify this if you want more than one hotkey
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}