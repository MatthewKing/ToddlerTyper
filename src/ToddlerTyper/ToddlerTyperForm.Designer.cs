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
            this.uxTextBox = new System.Windows.Forms.RichTextBox();
            this.uxInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTextBox
            // 
            this.uxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxTextBox.Font = new System.Drawing.Font("Calibri", 128.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTextBox.Location = new System.Drawing.Point(12, 12);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(776, 411);
            this.uxTextBox.TabIndex = 0;
            this.uxTextBox.Text = "";
            // 
            // uxInfo
            // 
            this.uxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxInfo.AutoSize = true;
            this.uxInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.uxInfo.Location = new System.Drawing.Point(12, 426);
            this.uxInfo.Name = "uxInfo";
            this.uxInfo.Size = new System.Drawing.Size(36, 15);
            this.uxInfo.TabIndex = 1;
            this.uxInfo.Text = "{info}";
            // 
            // ToddlerTyperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxInfo);
            this.Controls.Add(this.uxTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToddlerTyperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Toddler Typer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ToddlerTyperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox uxTextBox;
        private Label uxInfo;
    }
}
