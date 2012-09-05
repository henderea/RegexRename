using System;
using System.Windows.Forms;

namespace RegexRename
{
// ReSharper disable InconsistentNaming
    public partial class RenameDialog : Form
    {
        public RenameDialog()
        {
            InitializeComponent();
        }

        public bool Result { get; set; }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Result = true;
            Hide();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Result = false;
            Hide();
        }

        private void RenameDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            Hide();
        }
    }
// ReSharper restore InconsistentNaming
}