namespace Final_Assignment
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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.MainExitBtn = new System.Windows.Forms.Button();
            this.MainGoToDesignBtn = new System.Windows.Forms.Button();
            this.MainGotoGameBtn = new System.Windows.Forms.Button();
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameExitBtn = new System.Windows.Forms.Button();
            this.GameGoBackBtn = new System.Windows.Forms.Button();
            this.GameLoadBtn = new System.Windows.Forms.Button();
            this.GamePlayBtn = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.Label();
            this.LevelDesignPanel = new System.Windows.Forms.Panel();
            this.LevelExitBtn = new System.Windows.Forms.Button();
            this.LevelGoBackBtn = new System.Windows.Forms.Button();
            this.levelNewMapBtn = new System.Windows.Forms.Button();
            this.LevelLoadBtn = new System.Windows.Forms.Button();
            this.LevelDesignLabel = new System.Windows.Forms.Label();
            this.MainMenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.LevelDesignPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.MainExitBtn);
            this.MainMenuPanel.Controls.Add(this.MainGoToDesignBtn);
            this.MainMenuPanel.Controls.Add(this.MainGotoGameBtn);
            this.MainMenuPanel.Controls.Add(this.MainMenuLabel);
            this.MainMenuPanel.Controls.Add(this.GamePanel);
            this.MainMenuPanel.Location = new System.Drawing.Point(130, 73);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(585, 420);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // MainExitBtn
            // 
            this.MainExitBtn.Location = new System.Drawing.Point(248, 195);
            this.MainExitBtn.Name = "MainExitBtn";
            this.MainExitBtn.Size = new System.Drawing.Size(75, 23);
            this.MainExitBtn.TabIndex = 3;
            this.MainExitBtn.Text = "Exit";
            this.MainExitBtn.UseVisualStyleBackColor = true;
            this.MainExitBtn.Click += new System.EventHandler(this.MainExitBtn_Click);
            // 
            // MainGoToDesignBtn
            // 
            this.MainGoToDesignBtn.Location = new System.Drawing.Point(248, 149);
            this.MainGoToDesignBtn.Name = "MainGoToDesignBtn";
            this.MainGoToDesignBtn.Size = new System.Drawing.Size(75, 23);
            this.MainGoToDesignBtn.TabIndex = 2;
            this.MainGoToDesignBtn.Text = "Create Map";
            this.MainGoToDesignBtn.UseVisualStyleBackColor = true;
            this.MainGoToDesignBtn.Click += new System.EventHandler(this.MainGoToDesignBtn_Click);
            // 
            // MainGotoGameBtn
            // 
            this.MainGotoGameBtn.Location = new System.Drawing.Point(248, 104);
            this.MainGotoGameBtn.Name = "MainGotoGameBtn";
            this.MainGotoGameBtn.Size = new System.Drawing.Size(75, 23);
            this.MainGotoGameBtn.TabIndex = 1;
            this.MainGotoGameBtn.Text = "Game";
            this.MainGotoGameBtn.UseVisualStyleBackColor = true;
            this.MainGotoGameBtn.Click += new System.EventHandler(this.MainGotoGameBtn_Click);
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuLabel.Location = new System.Drawing.Point(254, 61);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(60, 13);
            this.MainMenuLabel.TabIndex = 0;
            this.MainMenuLabel.Text = "Main Menu";
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.GameExitBtn);
            this.GamePanel.Controls.Add(this.GameGoBackBtn);
            this.GamePanel.Controls.Add(this.GameLoadBtn);
            this.GamePanel.Controls.Add(this.GamePlayBtn);
            this.GamePanel.Controls.Add(this.GameLabel);
            this.GamePanel.Controls.Add(this.LevelDesignPanel);
            this.GamePanel.Location = new System.Drawing.Point(108, 51);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(585, 420);
            this.GamePanel.TabIndex = 4;
            this.GamePanel.Visible = false;
            // 
            // GameExitBtn
            // 
            this.GameExitBtn.Location = new System.Drawing.Point(248, 233);
            this.GameExitBtn.Name = "GameExitBtn";
            this.GameExitBtn.Size = new System.Drawing.Size(75, 23);
            this.GameExitBtn.TabIndex = 4;
            this.GameExitBtn.Text = "Exit";
            this.GameExitBtn.UseVisualStyleBackColor = true;
            this.GameExitBtn.Click += new System.EventHandler(this.GameExitBtn_Click);
            // 
            // GameGoBackBtn
            // 
            this.GameGoBackBtn.Location = new System.Drawing.Point(248, 195);
            this.GameGoBackBtn.Name = "GameGoBackBtn";
            this.GameGoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.GameGoBackBtn.TabIndex = 3;
            this.GameGoBackBtn.Text = "Go Back";
            this.GameGoBackBtn.UseVisualStyleBackColor = true;
            this.GameGoBackBtn.Click += new System.EventHandler(this.GameGoBackBtn_Click);
            // 
            // GameLoadBtn
            // 
            this.GameLoadBtn.Location = new System.Drawing.Point(248, 149);
            this.GameLoadBtn.Name = "GameLoadBtn";
            this.GameLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.GameLoadBtn.TabIndex = 2;
            this.GameLoadBtn.Text = "Load Game";
            this.GameLoadBtn.UseVisualStyleBackColor = true;
            this.GameLoadBtn.Click += new System.EventHandler(this.GameLoadBtn_Click);
            // 
            // GamePlayBtn
            // 
            this.GamePlayBtn.Location = new System.Drawing.Point(248, 104);
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
            this.GameLabel.Location = new System.Drawing.Point(254, 61);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(65, 13);
            this.GameLabel.TabIndex = 0;
            this.GameLabel.Text = "Game Menu";
            // 
            // LevelDesignPanel
            // 
            this.LevelDesignPanel.Controls.Add(this.LevelExitBtn);
            this.LevelDesignPanel.Controls.Add(this.LevelGoBackBtn);
            this.LevelDesignPanel.Controls.Add(this.levelNewMapBtn);
            this.LevelDesignPanel.Controls.Add(this.LevelLoadBtn);
            this.LevelDesignPanel.Controls.Add(this.LevelDesignLabel);
            this.LevelDesignPanel.Location = new System.Drawing.Point(85, 53);
            this.LevelDesignPanel.Name = "LevelDesignPanel";
            this.LevelDesignPanel.Size = new System.Drawing.Size(585, 420);
            this.LevelDesignPanel.TabIndex = 5;
            this.LevelDesignPanel.Visible = false;
            // 
            // LevelExitBtn
            // 
            this.LevelExitBtn.Location = new System.Drawing.Point(248, 233);
            this.LevelExitBtn.Name = "LevelExitBtn";
            this.LevelExitBtn.Size = new System.Drawing.Size(75, 23);
            this.LevelExitBtn.TabIndex = 4;
            this.LevelExitBtn.Text = "Exit";
            this.LevelExitBtn.UseVisualStyleBackColor = true;
            this.LevelExitBtn.Click += new System.EventHandler(this.LevelExitBtn_Click);
            // 
            // LevelGoBackBtn
            // 
            this.LevelGoBackBtn.Location = new System.Drawing.Point(248, 195);
            this.LevelGoBackBtn.Name = "LevelGoBackBtn";
            this.LevelGoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.LevelGoBackBtn.TabIndex = 3;
            this.LevelGoBackBtn.Text = "Go Back";
            this.LevelGoBackBtn.UseVisualStyleBackColor = true;
            this.LevelGoBackBtn.Click += new System.EventHandler(this.LevelGoBackBtn_Click);
            // 
            // levelNewMapBtn
            // 
            this.levelNewMapBtn.Location = new System.Drawing.Point(248, 149);
            this.levelNewMapBtn.Name = "levelNewMapBtn";
            this.levelNewMapBtn.Size = new System.Drawing.Size(75, 23);
            this.levelNewMapBtn.TabIndex = 2;
            this.levelNewMapBtn.Text = "Create New Map";
            this.levelNewMapBtn.UseVisualStyleBackColor = true;
            this.levelNewMapBtn.Click += new System.EventHandler(this.levelNewMapBtn_Click);
            // 
            // LevelLoadBtn
            // 
            this.LevelLoadBtn.Location = new System.Drawing.Point(248, 104);
            this.LevelLoadBtn.Name = "LevelLoadBtn";
            this.LevelLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LevelLoadBtn.TabIndex = 1;
            this.LevelLoadBtn.Text = "Load Map";
            this.LevelLoadBtn.UseVisualStyleBackColor = true;
            this.LevelLoadBtn.Click += new System.EventHandler(this.LevelLoadBtn_Click);
            // 
            // LevelDesignLabel
            // 
            this.LevelDesignLabel.AutoSize = true;
            this.LevelDesignLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LevelDesignLabel.Location = new System.Drawing.Point(254, 61);
            this.LevelDesignLabel.Name = "LevelDesignLabel";
            this.LevelDesignLabel.Size = new System.Drawing.Size(94, 13);
            this.LevelDesignLabel.TabIndex = 0;
            this.LevelDesignLabel.Text = "Design Map Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 591);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.LevelDesignPanel.ResumeLayout(false);
            this.LevelDesignPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button MainGotoGameBtn;
        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.Button MainExitBtn;
        private System.Windows.Forms.Button MainGoToDesignBtn;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button GameExitBtn;
        private System.Windows.Forms.Button GameGoBackBtn;
        private System.Windows.Forms.Button GameLoadBtn;
        private System.Windows.Forms.Button GamePlayBtn;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.Panel LevelDesignPanel;
        private System.Windows.Forms.Button LevelExitBtn;
        private System.Windows.Forms.Button LevelGoBackBtn;
        private System.Windows.Forms.Button levelNewMapBtn;
        private System.Windows.Forms.Button LevelLoadBtn;
        private System.Windows.Forms.Label LevelDesignLabel;
    }
}

