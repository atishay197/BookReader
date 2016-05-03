namespace I2T2S_1._0
{
    partial class Form1
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
            this.BrowseLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseLabel
            // 
            this.BrowseLabel.AutoSize = true;
            this.BrowseLabel.Location = new System.Drawing.Point(25, 16);
            this.BrowseLabel.MaximumSize = new System.Drawing.Size(600, 20);
            this.BrowseLabel.MinimumSize = new System.Drawing.Size(600, 20);
            this.BrowseLabel.Name = "BrowseLabel";
            this.BrowseLabel.Size = new System.Drawing.Size(600, 20);
            this.BrowseLabel.TabIndex = 3;
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(446, 55);
            this.TextBox.MaximumSize = new System.Drawing.Size(360, 360);
            this.TextBox.MinimumSize = new System.Drawing.Size(360, 360);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(360, 360);
            this.TextBox.TabIndex = 7;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Image = global::I2T2S_1._0.Properties.Resources.CLEAR;
            this.ClearButton.Location = new System.Drawing.Point(449, 424);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 60);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PauseButton.Image = global::I2T2S_1._0.Properties.Resources.PAUSE;
            this.PauseButton.Location = new System.Drawing.Point(668, 424);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(60, 60);
            this.PauseButton.TabIndex = 11;
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopButton.Image = global::I2T2S_1._0.Properties.Resources.STOP;
            this.StopButton.Location = new System.Drawing.Point(734, 424);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(60, 60);
            this.StopButton.TabIndex = 10;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CopyButton.Image = global::I2T2S_1._0.Properties.Resources.COPY;
            this.CopyButton.Location = new System.Drawing.Point(516, 424);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(60, 60);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayButton.Image = global::I2T2S_1._0.Properties.Resources.PLAY;
            this.PlayButton.Location = new System.Drawing.Point(602, 424);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(60, 60);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox.Location = new System.Drawing.Point(12, 55);
            this.PictureBox.MaximumSize = new System.Drawing.Size(410, 430);
            this.PictureBox.MinimumSize = new System.Drawing.Size(410, 360);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(410, 360);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.AccessibleDescription = "Press to browse to new Image";
            this.BrowseButton.Image = global::I2T2S_1._0.Properties.Resources.BROWSE;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.Location = new System.Drawing.Point(644, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(150, 42);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(12, 430);
            this.UpdateLabel.MaximumSize = new System.Drawing.Size(410, 50);
            this.UpdateLabel.MinimumSize = new System.Drawing.Size(410, 50);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(410, 50);
            this.UpdateLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 494);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.BrowseLabel);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.BrowseButton);
            this.Name = "Form1";
            this.Text = "Image-Text-Speech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label BrowseLabel;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label UpdateLabel;
    }
}

