namespace Final_Assignment
{
    partial class LevelDesignMain
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
            this.LevelDesignMenuPanel = new System.Windows.Forms.Panel();
            this.LevelExitBtn = new System.Windows.Forms.Button();
            this.LevelGoBackBtn = new System.Windows.Forms.Button();
            this.levelNewMapBtn = new System.Windows.Forms.Button();
            this.LevelLoadBtn = new System.Windows.Forms.Button();
            this.LevelDesignLabel = new System.Windows.Forms.Label();
            this.LevelDesignMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelDesignMenuPanel
            // 
            this.LevelDesignMenuPanel.Controls.Add(this.LevelExitBtn);
            this.LevelDesignMenuPanel.Controls.Add(this.LevelGoBackBtn);
            this.LevelDesignMenuPanel.Controls.Add(this.levelNewMapBtn);
            this.LevelDesignMenuPanel.Controls.Add(this.LevelLoadBtn);
            this.LevelDesignMenuPanel.Controls.Add(this.LevelDesignLabel);
            this.LevelDesignMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelDesignMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LevelDesignMenuPanel.Name = "LevelDesignMenuPanel";
            this.LevelDesignMenuPanel.Size = new System.Drawing.Size(808, 698);
            this.LevelDesignMenuPanel.TabIndex = 7;
            // 
            // LevelExitBtn
            // 
            this.LevelExitBtn.Location = new System.Drawing.Point(333, 300);
            this.LevelExitBtn.Name = "LevelExitBtn";
            this.LevelExitBtn.Size = new System.Drawing.Size(75, 23);
            this.LevelExitBtn.TabIndex = 4;
            this.LevelExitBtn.Text = "Exit";
            this.LevelExitBtn.UseVisualStyleBackColor = true;
            this.LevelExitBtn.Click += new System.EventHandler(this.LevelExitBtn_Click);
            // 
            // LevelGoBackBtn
            // 
            this.LevelGoBackBtn.Location = new System.Drawing.Point(333, 247);
            this.LevelGoBackBtn.Name = "LevelGoBackBtn";
            this.LevelGoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.LevelGoBackBtn.TabIndex = 3;
            this.LevelGoBackBtn.Text = "Go Back";
            this.LevelGoBackBtn.UseVisualStyleBackColor = true;
            this.LevelGoBackBtn.Click += new System.EventHandler(this.LevelGoBackBtn_Click);
            // 
            // levelNewMapBtn
            // 
            this.levelNewMapBtn.Location = new System.Drawing.Point(333, 201);
            this.levelNewMapBtn.Name = "levelNewMapBtn";
            this.levelNewMapBtn.Size = new System.Drawing.Size(75, 23);
            this.levelNewMapBtn.TabIndex = 2;
            this.levelNewMapBtn.Text = "Create New Map";
            this.levelNewMapBtn.UseVisualStyleBackColor = true;
            this.levelNewMapBtn.Click += new System.EventHandler(this.levelNewMapBtn_Click);
            // 
            // LevelLoadBtn
            // 
            this.LevelLoadBtn.Location = new System.Drawing.Point(333, 156);
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
            this.LevelDesignLabel.Location = new System.Drawing.Point(328, 113);
            this.LevelDesignLabel.Name = "LevelDesignLabel";
            this.LevelDesignLabel.Size = new System.Drawing.Size(94, 13);
            this.LevelDesignLabel.TabIndex = 0;
            this.LevelDesignLabel.Text = "Design Map Menu";
            // 
            // LevelDesignMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 698);
            this.Controls.Add(this.LevelDesignMenuPanel);
            this.Name = "LevelDesignMain";
            this.Text = "LevelDesignMain";
            this.Load += new System.EventHandler(this.LevelDesignMain_Load);
            this.LevelDesignMenuPanel.ResumeLayout(false);
            this.LevelDesignMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LevelDesignMenuPanel;
        private System.Windows.Forms.Button LevelExitBtn;
        private System.Windows.Forms.Button LevelGoBackBtn;
        private System.Windows.Forms.Button levelNewMapBtn;
        private System.Windows.Forms.Button LevelLoadBtn;
        private System.Windows.Forms.Label LevelDesignLabel;
    }
}