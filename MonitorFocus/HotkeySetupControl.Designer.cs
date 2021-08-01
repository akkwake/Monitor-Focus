namespace MonitorFocus
{
    partial class HotkeySetupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxModifiers = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxModifiers
            // 
            this.textBoxModifiers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModifiers.Location = new System.Drawing.Point(0, 0);
            this.textBoxModifiers.Name = "textBoxModifiers";
            this.textBoxModifiers.ReadOnly = true;
            this.textBoxModifiers.Size = new System.Drawing.Size(173, 20);
            this.textBoxModifiers.TabIndex = 0;
            this.textBoxModifiers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxModifiers_KeyDown);
            this.textBoxModifiers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxModifiers_KeyUp);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxKey.Location = new System.Drawing.Point(172, 0);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(30, 20);
            this.textBoxKey.TabIndex = 1;
            this.textBoxKey.Text = "Z";
            this.textBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKey_KeyPress);
            // 
            // HotkeySetupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxModifiers);
            this.Name = "HotkeySetupControl";
            this.Size = new System.Drawing.Size(202, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxModifiers;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}
