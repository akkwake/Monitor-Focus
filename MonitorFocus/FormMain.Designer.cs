namespace MonitorFocus
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comboBoxQuickRelease = new System.Windows.Forms.ComboBox();
            this.labelToggleHotkey = new System.Windows.Forms.Label();
            this.labelQuickReleaseHotkey = new System.Windows.Forms.Label();
            this.panelHotkeySetup = new System.Windows.Forms.Panel();
            this.checkBoxStartup = new System.Windows.Forms.CheckBox();
            this.checkBoxStartMinimized = new System.Windows.Forms.CheckBox();
            this.hotkeySetupControl = new MonitorFocus.HotkeySetupControl();
            this.contextMenuStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
            this.trayIcon.Text = "Cursor Released";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(156, 54);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.toggleToolStripMenuItem.Text = "Confine Mouse";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Goldenrod;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(294, 36);
            this.panelTop.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMinimize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMinimize.Location = new System.Drawing.Point(225, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(28, 28);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.Text = "__";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExit.Location = new System.Drawing.Point(259, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(28, 28);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(13, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Cursor Released";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // comboBoxQuickRelease
            // 
            this.comboBoxQuickRelease.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuickRelease.DisplayMember = "Shift";
            this.comboBoxQuickRelease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuickRelease.FormattingEnabled = true;
            this.comboBoxQuickRelease.Items.AddRange(new object[] {
            "Alt",
            "Control",
            "Shift"});
            this.comboBoxQuickRelease.Location = new System.Drawing.Point(11, 113);
            this.comboBoxQuickRelease.Name = "comboBoxQuickRelease";
            this.comboBoxQuickRelease.Size = new System.Drawing.Size(271, 23);
            this.comboBoxQuickRelease.TabIndex = 3;
            this.comboBoxQuickRelease.ValueMember = "Shift";
            this.comboBoxQuickRelease.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuickRelease_SelectedIndexChanged);
            // 
            // labelToggleHotkey
            // 
            this.labelToggleHotkey.AutoSize = true;
            this.labelToggleHotkey.Location = new System.Drawing.Point(9, 47);
            this.labelToggleHotkey.Name = "labelToggleHotkey";
            this.labelToggleHotkey.Size = new System.Drawing.Size(81, 15);
            this.labelToggleHotkey.TabIndex = 4;
            this.labelToggleHotkey.Text = "Toggle Hotkey";
            // 
            // labelQuickReleaseHotkey
            // 
            this.labelQuickReleaseHotkey.AutoSize = true;
            this.labelQuickReleaseHotkey.Location = new System.Drawing.Point(9, 95);
            this.labelQuickReleaseHotkey.Name = "labelQuickReleaseHotkey";
            this.labelQuickReleaseHotkey.Size = new System.Drawing.Size(124, 15);
            this.labelQuickReleaseHotkey.TabIndex = 5;
            this.labelQuickReleaseHotkey.Text = "Quick Release Hotkey";
            // 
            // panelHotkeySetup
            // 
            this.panelHotkeySetup.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelHotkeySetup.Location = new System.Drawing.Point(9, 65);
            this.panelHotkeySetup.Name = "panelHotkeySetup";
            this.panelHotkeySetup.Size = new System.Drawing.Size(276, 29);
            this.panelHotkeySetup.TabIndex = 6;
            this.panelHotkeySetup.Visible = false;
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Location = new System.Drawing.Point(11, 156);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(134, 19);
            this.checkBoxStartup.TabIndex = 7;
            this.checkBoxStartup.Text = "Start with Windows";
            this.checkBoxStartup.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartMinimized
            // 
            this.checkBoxStartMinimized.AutoSize = true;
            this.checkBoxStartMinimized.Location = new System.Drawing.Point(169, 156);
            this.checkBoxStartMinimized.Name = "checkBoxStartMinimized";
            this.checkBoxStartMinimized.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxStartMinimized.Size = new System.Drawing.Size(113, 19);
            this.checkBoxStartMinimized.TabIndex = 8;
            this.checkBoxStartMinimized.Text = "Start Minimized";
            this.checkBoxStartMinimized.UseVisualStyleBackColor = true;
            // 
            // hotkeySetupControl
            // 
            this.hotkeySetupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotkeySetupControl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeySetupControl.Location = new System.Drawing.Point(12, 68);
            this.hotkeySetupControl.Name = "hotkeySetupControl";
            this.hotkeySetupControl.Size = new System.Drawing.Size(271, 24);
            this.hotkeySetupControl.TabIndex = 2;
            this.hotkeySetupControl.Enter += new System.EventHandler(this.hotkeySetupControl_Enter);
            this.hotkeySetupControl.Leave += new System.EventHandler(this.hotkeySetupControl_Leave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.buttonMinimize;
            this.ClientSize = new System.Drawing.Size(294, 187);
            this.Controls.Add(this.checkBoxStartMinimized);
            this.Controls.Add(this.checkBoxStartup);
            this.Controls.Add(this.labelQuickReleaseHotkey);
            this.Controls.Add(this.labelToggleHotkey);
            this.Controls.Add(this.comboBoxQuickRelease);
            this.Controls.Add(this.hotkeySetupControl);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelHotkeySetup);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Monitor Focus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private HotkeySetupControl hotkeySetupControl;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBoxQuickRelease;
        private System.Windows.Forms.Label labelToggleHotkey;
        private System.Windows.Forms.Label labelQuickReleaseHotkey;
        private System.Windows.Forms.Panel panelHotkeySetup;
        private System.Windows.Forms.CheckBox checkBoxStartup;
        private System.Windows.Forms.CheckBox checkBoxStartMinimized;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

