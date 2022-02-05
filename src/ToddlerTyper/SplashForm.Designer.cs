namespace ToddlerTyper
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.uxLogo = new System.Windows.Forms.PictureBox();
            this.uxInfoLabel = new System.Windows.Forms.Label();
            this.uxStartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLogo
            // 
            this.uxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uxLogo.Location = new System.Drawing.Point(12, 12);
            this.uxLogo.Name = "uxLogo";
            this.uxLogo.Size = new System.Drawing.Size(760, 291);
            this.uxLogo.TabIndex = 0;
            this.uxLogo.TabStop = false;
            // 
            // uxInfoLabel
            // 
            this.uxInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxInfoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxInfoLabel.ForeColor = System.Drawing.Color.White;
            this.uxInfoLabel.Location = new System.Drawing.Point(12, 306);
            this.uxInfoLabel.Name = "uxInfoLabel";
            this.uxInfoLabel.Size = new System.Drawing.Size(760, 180);
            this.uxInfoLabel.TabIndex = 1;
            this.uxInfoLabel.Text = resources.GetString("uxInfoLabel.Text");
            // 
            // uxStartButton
            // 
            this.uxStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStartButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxStartButton.Location = new System.Drawing.Point(12, 489);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(760, 60);
            this.uxStartButton.TabIndex = 2;
            this.uxStartButton.Text = "Click here to start typing!";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.uxStartButton_Click);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.uxInfoLabel);
            this.Controls.Add(this.uxLogo);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toddler Typer";
            ((System.ComponentModel.ISupportInitialize)(this.uxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox uxLogo;
        private Label uxInfoLabel;
        private Button uxStartButton;
    }
}