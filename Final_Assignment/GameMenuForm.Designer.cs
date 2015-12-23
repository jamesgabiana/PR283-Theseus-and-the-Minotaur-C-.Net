namespace Final_Assignment
{
    partial class GameMenuForm
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
            this.GameMenuPanel = new System.Windows.Forms.Panel();
            this.GameExitBtn = new System.Windows.Forms.Button();
            this.GameGoBackBtn = new System.Windows.Forms.Button();
            this.GameLoadBtn = new System.Windows.Forms.Button();
            this.GamePlayBtn = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.Label();
            this.GameMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenuPanel
            // 
            this.GameMenuPanel.Controls.Add(this.GameExitBtn);
            this.GameMenuPanel.Controls.Add(this.GameGoBackBtn);
            this.GameMenuPanel.Controls.Add(this.GameLoadBtn);
            this.GameMenuPanel.Controls.Add(this.GamePlayBtn);
            this.GameMenuPanel.Controls.Add(this.GameLabel);
            this.GameMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.GameMenuPanel.Name = "GameMenuPanel";
            this.GameMenuPanel.Size = new System.Drawing.Size(808, 591);
            this.GameMenuPanel.TabIndex = 6;
            // 
            // GameExitBtn
            // 
            this.GameExitBtn.Location = new System.Drawing.Point(369, 254);
            this.GameExitBtn.Name = "GameExitBtn";
            this.GameExitBtn.Size = new System.Drawing.Size(75, 23);
            this.GameExitBtn.TabIndex = 4;
            this.GameExitBtn.Text = "Exit";
            this.GameExitBtn.UseVisualStyleBackColor = true;
            this.GameExitBtn.Click += new System.EventHandler(this.GameExitBtn_Click);
            // 
            // GameGoBackBtn
            // 
            this.GameGoBackBtn.Location = new System.Drawing.Point(369, 216);
            this.GameGoBackBtn.Name = "GameGoBackBtn";
            this.GameGoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.GameGoBackBtn.TabIndex = 3;
            this.GameGoBackBtn.Text = "Go Back";
            this.GameGoBackBtn.UseVisualStyleBackColor = true;
            this.GameGoBackBtn.Click += new System.EventHandler(this.GameGoBackBtn_Click_1);
            // 
            // GameLoadBtn
            // 
            this.GameLoadBtn.Location = new System.Drawing.Point(369, 170);
            this.GameLoadBtn.Name = "GameLoadBtn";
            this.GameLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.GameLoadBtn.TabIndex = 2;
            this.GameLoadBtn.Text = "Load Game";
            this.GameLoadBtn.UseVisualStyleBackColor = true;
            this.GameLoadBtn.Click += new System.EventHandler(this.GameLoadBtn_Click);
            // 
            // GamePlayBtn
            // 
            this.GamePlayBtn.Location = new System.Drawing.Point(369, 125);
            this.GamePlayBtn.Name = "GamePlayBtn";
            this.GamePlayBtn.Size = new System.Drawing.Size(75, 23);
            this.GamePlayBtn.TabIndex = 1;
            this.GamePlayBtn.Text = "Play Game";
            this.GamePlayBtn.UseVisualStyleBackColor = true;
            this.GamePlayBtn.Click += new System.EventHandler(this.GamePlayBtn_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameLabel.Location = new System.Drawing.Point(375, 82);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(65, 13);
            this.GameLabel.TabIndex = 0;
            this.GameLabel.Text = "Game Menu";
            // 
            // GameMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 591);
            this.Controls.Add(this.GameMenuPanel);
            this.Name = "GameMenuForm";
            this.Text = "GameMenuForm";
            this.Load += new System.EventHandler(this.GameMenuForm_Load);
            this.GameMenuPanel.ResumeLayout(false);
            this.GameMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameMenuPanel;
        private System.Windows.Forms.Button GameExitBtn;
        private System.Windows.Forms.Button GameGoBackBtn;
        private System.Windows.Forms.Button GameLoadBtn;
        private System.Windows.Forms.Button GamePlayBtn;
        private System.Windows.Forms.Label GameLabel;
    }
}