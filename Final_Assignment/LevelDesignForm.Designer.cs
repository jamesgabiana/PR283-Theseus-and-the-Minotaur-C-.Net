namespace Final_Assignment
{
    partial class LevelDesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDesignForm));
            this.LevelDesignMenuPanel = new System.Windows.Forms.Panel();
            this.LevelDesignPanel = new System.Windows.Forms.Panel();
            this.LevelDesignButtonsPanel = new System.Windows.Forms.Panel();
            this.SaveMapBtn = new System.Windows.Forms.Button();
            this.ResetMapBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmptyRightWallBtn = new System.Windows.Forms.Button();
            this.EmptyBotWallBtn = new System.Windows.Forms.Button();
            this.AddExitBtn = new System.Windows.Forms.Button();
            this.AddTheseusButton = new System.Windows.Forms.Button();
            this.AddMinotaurButton = new System.Windows.Forms.Button();
            this.VerticalWallButton = new System.Windows.Forms.Button();
            this.HorizontalWallButton = new System.Windows.Forms.Button();
            this.EmptyTileButton = new System.Windows.Forms.Button();
            this.LeftWallButton = new System.Windows.Forms.Button();
            this.TopWallButton = new System.Windows.Forms.Button();
            this.TopLeftWallButton = new System.Windows.Forms.Button();
            this.LevelDesignMenuPanel.SuspendLayout();
            this.LevelDesignButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelDesignMenuPanel
            // 
            this.LevelDesignMenuPanel.Controls.Add(this.LevelDesignPanel);
            this.LevelDesignMenuPanel.Controls.Add(this.LevelDesignButtonsPanel);
            this.LevelDesignMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelDesignMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LevelDesignMenuPanel.Name = "LevelDesignMenuPanel";
            this.LevelDesignMenuPanel.Size = new System.Drawing.Size(808, 698);
            this.LevelDesignMenuPanel.TabIndex = 6;
            // 
            // LevelDesignPanel
            // 
            this.LevelDesignPanel.Location = new System.Drawing.Point(12, 12);
            this.LevelDesignPanel.Name = "LevelDesignPanel";
            this.LevelDesignPanel.Size = new System.Drawing.Size(784, 440);
            this.LevelDesignPanel.TabIndex = 5;
            this.LevelDesignPanel.Click += new System.EventHandler(this.LevelDesignPanel_Click);
            this.LevelDesignPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelDesignPanel_Paint);
            // 
            // LevelDesignButtonsPanel
            // 
            this.LevelDesignButtonsPanel.Controls.Add(this.SaveMapBtn);
            this.LevelDesignButtonsPanel.Controls.Add(this.ResetMapBtn);
            this.LevelDesignButtonsPanel.Controls.Add(this.button1);
            this.LevelDesignButtonsPanel.Controls.Add(this.EmptyRightWallBtn);
            this.LevelDesignButtonsPanel.Controls.Add(this.EmptyBotWallBtn);
            this.LevelDesignButtonsPanel.Controls.Add(this.AddExitBtn);
            this.LevelDesignButtonsPanel.Controls.Add(this.AddTheseusButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.AddMinotaurButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.VerticalWallButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.HorizontalWallButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.EmptyTileButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.LeftWallButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.TopWallButton);
            this.LevelDesignButtonsPanel.Controls.Add(this.TopLeftWallButton);
            this.LevelDesignButtonsPanel.Location = new System.Drawing.Point(95, 468);
            this.LevelDesignButtonsPanel.Name = "LevelDesignButtonsPanel";
            this.LevelDesignButtonsPanel.Size = new System.Drawing.Size(615, 201);
            this.LevelDesignButtonsPanel.TabIndex = 6;
            this.LevelDesignButtonsPanel.Visible = false;
            // 
            // SaveMapBtn
            // 
            this.SaveMapBtn.BackColor = System.Drawing.Color.White;
            this.SaveMapBtn.Location = new System.Drawing.Point(431, 118);
            this.SaveMapBtn.Name = "SaveMapBtn";
            this.SaveMapBtn.Size = new System.Drawing.Size(75, 62);
            this.SaveMapBtn.TabIndex = 17;
            this.SaveMapBtn.Text = "Save Map";
            this.SaveMapBtn.UseVisualStyleBackColor = false;
            this.SaveMapBtn.Click += new System.EventHandler(this.SaveMapBtn_Click);
            // 
            // ResetMapBtn
            // 
            this.ResetMapBtn.BackColor = System.Drawing.Color.White;
            this.ResetMapBtn.Location = new System.Drawing.Point(348, 152);
            this.ResetMapBtn.Name = "ResetMapBtn";
            this.ResetMapBtn.Size = new System.Drawing.Size(75, 28);
            this.ResetMapBtn.TabIndex = 16;
            this.ResetMapBtn.Text = "Reset Map";
            this.ResetMapBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmptyRightWallBtn
            // 
            this.EmptyRightWallBtn.BackColor = System.Drawing.Color.White;
            this.EmptyRightWallBtn.Location = new System.Drawing.Point(465, 13);
            this.EmptyRightWallBtn.Name = "EmptyRightWallBtn";
            this.EmptyRightWallBtn.Size = new System.Drawing.Size(28, 75);
            this.EmptyRightWallBtn.TabIndex = 14;
            this.EmptyRightWallBtn.UseVisualStyleBackColor = false;
            this.EmptyRightWallBtn.Click += new System.EventHandler(this.EmptyRightWallBtn_Click);
            // 
            // EmptyBotWallBtn
            // 
            this.EmptyBotWallBtn.BackColor = System.Drawing.Color.White;
            this.EmptyBotWallBtn.Location = new System.Drawing.Point(348, 26);
            this.EmptyBotWallBtn.Name = "EmptyBotWallBtn";
            this.EmptyBotWallBtn.Size = new System.Drawing.Size(75, 28);
            this.EmptyBotWallBtn.TabIndex = 13;
            this.EmptyBotWallBtn.UseVisualStyleBackColor = false;
            this.EmptyBotWallBtn.Click += new System.EventHandler(this.EmptyBotWallBtn_Click);
            // 
            // AddExitBtn
            // 
            this.AddExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddExitBtn.BackgroundImage")));
            this.AddExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExitBtn.Location = new System.Drawing.Point(267, 105);
            this.AddExitBtn.Name = "AddExitBtn";
            this.AddExitBtn.Size = new System.Drawing.Size(75, 75);
            this.AddExitBtn.TabIndex = 12;
            this.AddExitBtn.Text = "EXIT";
            this.AddExitBtn.UseVisualStyleBackColor = true;
            this.AddExitBtn.Click += new System.EventHandler(this.AddExitBtn_Click);
            // 
            // AddTheseusButton
            // 
            this.AddTheseusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTheseusButton.BackgroundImage")));
            this.AddTheseusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTheseusButton.Location = new System.Drawing.Point(99, 105);
            this.AddTheseusButton.Name = "AddTheseusButton";
            this.AddTheseusButton.Size = new System.Drawing.Size(75, 75);
            this.AddTheseusButton.TabIndex = 11;
            this.AddTheseusButton.UseVisualStyleBackColor = true;
            this.AddTheseusButton.Click += new System.EventHandler(this.AddTheseusButton_Click);
            // 
            // AddMinotaurButton
            // 
            this.AddMinotaurButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddMinotaurButton.BackgroundImage")));
            this.AddMinotaurButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddMinotaurButton.Location = new System.Drawing.Point(183, 105);
            this.AddMinotaurButton.Name = "AddMinotaurButton";
            this.AddMinotaurButton.Size = new System.Drawing.Size(75, 75);
            this.AddMinotaurButton.TabIndex = 12;
            this.AddMinotaurButton.UseVisualStyleBackColor = true;
            this.AddMinotaurButton.Click += new System.EventHandler(this.AddMinotaurButton_Click);
            // 
            // VerticalWallButton
            // 
            this.VerticalWallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerticalWallButton.BackgroundImage")));
            this.VerticalWallButton.Location = new System.Drawing.Point(431, 13);
            this.VerticalWallButton.Name = "VerticalWallButton";
            this.VerticalWallButton.Size = new System.Drawing.Size(28, 75);
            this.VerticalWallButton.TabIndex = 10;
            this.VerticalWallButton.UseVisualStyleBackColor = true;
            this.VerticalWallButton.Click += new System.EventHandler(this.VerticalWallButton_Click);
            // 
            // HorizontalWallButton
            // 
            this.HorizontalWallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HorizontalWallButton.BackgroundImage")));
            this.HorizontalWallButton.Location = new System.Drawing.Point(348, 60);
            this.HorizontalWallButton.Name = "HorizontalWallButton";
            this.HorizontalWallButton.Size = new System.Drawing.Size(75, 28);
            this.HorizontalWallButton.TabIndex = 9;
            this.HorizontalWallButton.UseVisualStyleBackColor = true;
            this.HorizontalWallButton.Click += new System.EventHandler(this.HorizontalWallButton_Click);
            // 
            // EmptyTileButton
            // 
            this.EmptyTileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmptyTileButton.BackgroundImage")));
            this.EmptyTileButton.Location = new System.Drawing.Point(267, 13);
            this.EmptyTileButton.Name = "EmptyTileButton";
            this.EmptyTileButton.Size = new System.Drawing.Size(75, 75);
            this.EmptyTileButton.TabIndex = 8;
            this.EmptyTileButton.UseVisualStyleBackColor = true;
            this.EmptyTileButton.Click += new System.EventHandler(this.EmptyTileButton_Click);
            // 
            // LeftWallButton
            // 
            this.LeftWallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftWallButton.BackgroundImage")));
            this.LeftWallButton.Location = new System.Drawing.Point(183, 13);
            this.LeftWallButton.Name = "LeftWallButton";
            this.LeftWallButton.Size = new System.Drawing.Size(75, 75);
            this.LeftWallButton.TabIndex = 7;
            this.LeftWallButton.UseVisualStyleBackColor = true;
            this.LeftWallButton.Click += new System.EventHandler(this.LeftWallButton_Click);
            // 
            // TopWallButton
            // 
            this.TopWallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopWallButton.BackgroundImage")));
            this.TopWallButton.Location = new System.Drawing.Point(99, 13);
            this.TopWallButton.Name = "TopWallButton";
            this.TopWallButton.Size = new System.Drawing.Size(75, 75);
            this.TopWallButton.TabIndex = 6;
            this.TopWallButton.UseVisualStyleBackColor = true;
            this.TopWallButton.Click += new System.EventHandler(this.TopWallButton_Click);
            // 
            // TopLeftWallButton
            // 
            this.TopLeftWallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopLeftWallButton.BackgroundImage")));
            this.TopLeftWallButton.Location = new System.Drawing.Point(15, 13);
            this.TopLeftWallButton.Name = "TopLeftWallButton";
            this.TopLeftWallButton.Size = new System.Drawing.Size(75, 75);
            this.TopLeftWallButton.TabIndex = 5;
            this.TopLeftWallButton.UseVisualStyleBackColor = true;
            this.TopLeftWallButton.Click += new System.EventHandler(this.TopLeftWallButton_Click);
            // 
            // LevelDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 698);
            this.Controls.Add(this.LevelDesignMenuPanel);
            this.Name = "LevelDesignForm";
            this.Text = "LevelDesignForm";
            this.Load += new System.EventHandler(this.LevelDesignForm_Load);
            this.LevelDesignMenuPanel.ResumeLayout(false);
            this.LevelDesignButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LevelDesignMenuPanel;
        public System.Windows.Forms.Panel LevelDesignPanel;
        private System.Windows.Forms.Button TopLeftWallButton;
        private System.Windows.Forms.Panel LevelDesignButtonsPanel;
        private System.Windows.Forms.Button VerticalWallButton;
        private System.Windows.Forms.Button HorizontalWallButton;
        private System.Windows.Forms.Button EmptyTileButton;
        private System.Windows.Forms.Button LeftWallButton;
        private System.Windows.Forms.Button TopWallButton;
        private System.Windows.Forms.Button AddExitBtn;
        private System.Windows.Forms.Button AddMinotaurButton;
        private System.Windows.Forms.Button AddTheseusButton;
        private System.Windows.Forms.Button EmptyRightWallBtn;
        private System.Windows.Forms.Button EmptyBotWallBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetMapBtn;
        private System.Windows.Forms.Button SaveMapBtn;
    }
}