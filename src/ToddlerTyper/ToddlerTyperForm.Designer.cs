namespace ToddlerTyper
{
    partial class ToddlerTyperForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxTextBox = new RichTextBox();
            uxInfo = new Label();
            SuspendLayout();
            // 
            // uxTextBox
            // 
            uxTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            uxTextBox.ForeColor = System.Drawing.Color.White;
            uxTextBox.BorderStyle = BorderStyle.None;
            uxTextBox.Font = new Font("Calibri", 128.25F);
            uxTextBox.Location = new Point(12, 12);
            uxTextBox.Name = "uxTextBox";
            uxTextBox.Size = new Size(776, 411);
            uxTextBox.TabIndex = 0;
            uxTextBox.Text = "";
            // 
            // uxInfo
            // 
            uxInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            uxInfo.AutoSize = true;
            uxInfo.ForeColor = Color.DarkGray;
            uxInfo.Location = new Point(12, 426);
            uxInfo.Name = "uxInfo";
            uxInfo.Size = new Size(36, 15);
            uxInfo.TabIndex = 1;
            uxInfo.Text = "{info}";
            // 
            // ToddlerTyperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 58, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(uxInfo);
            Controls.Add(uxTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToddlerTyperForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Toddler Typer";
            TopMost = true;
            Load += ToddlerTyperForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox uxTextBox;
        private Label uxInfo;
    }
}
