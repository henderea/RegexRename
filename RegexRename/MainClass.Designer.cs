namespace RegexRename
{
    partial class MainClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainClass));
            this.regexLabel = new System.Windows.Forms.Label();
            this.regexField = new System.Windows.Forms.TextBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.replaceField = new System.Windows.Forms.TextBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.oldNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renameButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // regexLabel
            // 
            this.regexLabel.AutoSize = true;
            this.regexLabel.Location = new System.Drawing.Point(0, 0);
            this.regexLabel.Margin = new System.Windows.Forms.Padding(0);
            this.regexLabel.Name = "regexLabel";
            this.regexLabel.Padding = new System.Windows.Forms.Padding(5);
            this.regexLabel.Size = new System.Drawing.Size(51, 23);
            this.regexLabel.TabIndex = 1;
            this.regexLabel.Text = "Regex:";
            // 
            // regexField
            // 
            this.regexField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regexField.Location = new System.Drawing.Point(60, 2);
            this.regexField.Name = "regexField";
            this.regexField.Size = new System.Drawing.Size(690, 20);
            this.regexField.TabIndex = 2;
            this.regexField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.field_KeyUp);
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(0, 25);
            this.replaceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Padding = new System.Windows.Forms.Padding(5);
            this.replaceLabel.Size = new System.Drawing.Size(83, 23);
            this.replaceLabel.TabIndex = 3;
            this.replaceLabel.Text = "Replacement:";
            // 
            // replaceField
            // 
            this.replaceField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceField.Location = new System.Drawing.Point(90, 28);
            this.replaceField.Name = "replaceField";
            this.replaceField.Size = new System.Drawing.Size(660, 20);
            this.replaceField.TabIndex = 4;
            // 
            // dataView
            // 
            this.dataView.AllowDrop = true;
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AllowUserToResizeRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oldNameCol,
            this.newNameCol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.Location = new System.Drawing.Point(0, 50);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataView.Size = new System.Drawing.Size(750, 500);
            this.dataView.TabIndex = 5;
            this.dataView.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataView_DragDrop);
            this.dataView.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataView_DragEnter);
            // 
            // oldNameCol
            // 
            this.oldNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oldNameCol.HeaderText = "Old Name";
            this.oldNameCol.Name = "oldNameCol";
            this.oldNameCol.ReadOnly = true;
            this.oldNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oldNameCol.Width = 79;
            // 
            // newNameCol
            // 
            this.newNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.newNameCol.HeaderText = "New Name";
            this.newNameCol.Name = "newNameCol";
            this.newNameCol.ReadOnly = true;
            this.newNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newNameCol.Width = 85;
            // 
            // renameButton
            // 
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.Location = new System.Drawing.Point(0, 550);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(750, 25);
            this.renameButton.TabIndex = 6;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(0, 575);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(750, 25);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(0, 600);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(750, 25);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showItem,
            this.exitItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.ShowImageMargin = false;
            this.contextMenu.Size = new System.Drawing.Size(183, 48);
            // 
            // showItem
            // 
            this.showItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showItem.Name = "showItem";
            this.showItem.ShortcutKeyDisplayString = "Ctrl+Alt+Shift+R";
            this.showItem.Size = new System.Drawing.Size(182, 22);
            this.showItem.Text = "Show";
            this.showItem.Click += new System.EventHandler(this.showItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(182, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // taskIcon
            // 
            this.taskIcon.ContextMenuStrip = this.contextMenu;
            this.taskIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskIcon.Icon")));
            this.taskIcon.Text = "Regex Rename";
            this.taskIcon.Visible = true;
            this.taskIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskIcon_MouseDoubleClick);
            // 
            // MainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 625);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.replaceField);
            this.Controls.Add(this.regexField);
            this.Controls.Add(this.regexLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regex Rename";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainClass_FormClosing);
            this.Load += new System.EventHandler(this.MainClass_Load);
            this.Shown += new System.EventHandler(this.MainClass_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regexLabel;
        private System.Windows.Forms.TextBox regexField;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.TextBox replaceField;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn newNameCol;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem showItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.NotifyIcon taskIcon;

    }
}

