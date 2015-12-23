namespace Final_Assignment
{
    partial class MainMenuForm
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
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.MainExitBtn);
            this.MainMenuPanel.Controls.Add(this.MainGoToDesignBtn);
            this.MainMenuPanel.Controls.Add(this.MainGotoGameBtn);
            this.MainMenuPanel.Controls.Add(this.MainMenuLabel);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(808, 591);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // MainExitBtn
            // 
            this.MainExitBtn.Location = new System.Drawing.Point(349, 243);
            this.MainExitBtn.Name = "MainExitBtn";
            this.MainExitBtn.Size = new System.Drawing.Size(75, 23);
            this.MainExitBtn.TabIndex = 3;
            this.MainExitBtn.Text = "Exit";
            this.MainExitBtn.UseVisualStyleBackColor = true;
            this.MainExitBtn.Click += new System.EventHandler(this.MainExitBtn_Click);
            // 
            // MainGoToDesignBtn
            // 
            this.MainGoToDesignBtn.Location = new System.Drawing.Point(349, 197);
            this.MainGoToDesignBtn.Name = "MainGoToDesignBtn";
            this.MainGoToDesignBtn.Size = new System.Drawing.Size(75, 23);
            this.MainGoToDesignBtn.TabIndex = 2;
            this.MainGoToDesignBtn.Text = "Create Map";
            this.MainGoToDesignBtn.UseVisualStyleBackColor = true;
            this.MainGoToDesignBtn.Click += new System.EventHandler(this.MainGoToDesignBtn_Click);
            // 
            // MainGotoGameBtn
            // 
            this.MainGotoGameBtn.Location = new System.Drawing.Point(349, 152);
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
            this.MainMenuLabel.Location = new System.Drawing.Point(355, 109);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(60, 13);
            this.MainMenuLabel.TabIndex = 0;
            this.MainMenuLabel.Text = "Main Menu";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 591);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load_1);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button MainGotoGameBtn;
        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.Button MainExitBtn;
        private System.Windows.Forms.Button MainGoToDesignBtn;
    }
}

