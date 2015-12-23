namespace Final_Assignment
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.GameMenuPanel = new System.Windows.Forms.Panel();
            this.GameControlPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.restartMazeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePrevBtn = new System.Windows.Forms.Button();
            this.GameNextBtn = new System.Windows.Forms.Button();
            this.GameQuitBtn = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.TimeMover = new System.Windows.Forms.Timer(this.components);
            this.GameMenuPanel.SuspendLayout();
            this.GameControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenuPanel
            // 
            this.GameMenuPanel.Controls.Add(this.GameControlPanel);
            this.GameMenuPanel.Controls.Add(this.GamePanel);
            this.GameMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.GameMenuPanel.Name = "GameMenuPanel";
            this.GameMenuPanel.Size = new System.Drawing.Size(808, 591);
            this.GameMenuPanel.TabIndex = 5;
            // 
            // GameControlPanel
            // 
            this.GameControlPanel.Controls.Add(this.label5);
            this.GameControlPanel.Controls.Add(this.restartMazeBtn);
            this.GameControlPanel.Controls.Add(this.label4);
            this.GameControlPanel.Controls.Add(this.label3);
            this.GameControlPanel.Controls.Add(this.label2);
            this.GameControlPanel.Controls.Add(this.label1);
            this.GameControlPanel.Controls.Add(this.GamePrevBtn);
            this.GameControlPanel.Controls.Add(this.GameNextBtn);
            this.GameControlPanel.Controls.Add(this.GameQuitBtn);
            this.GameControlPanel.Location = new System.Drawing.Point(14, 438);
            this.GameControlPanel.Name = "GameControlPanel";
            this.GameControlPanel.Size = new System.Drawing.Size(773, 150);
            this.GameControlPanel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delay = D";
            // 
            // restartMazeBtn
            // 
            this.restartMazeBtn.Location = new System.Drawing.Point(581, 107);
            this.restartMazeBtn.Name = "restartMazeBtn";
            this.restartMazeBtn.Size = new System.Drawing.Size(93, 23);
            this.restartMazeBtn.TabIndex = 14;
            this.restartMazeBtn.Text = "Restart Maze";
            this.restartMazeBtn.UseVisualStyleBackColor = true;
            this.restartMazeBtn.Click += new System.EventHandler(this.restartMazeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Left = Left Arrow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Down = Down Arrow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Right = Right Arrow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Up = Up Arrow";
            // 
            // GamePrevBtn
            // 
            this.GamePrevBtn.Location = new System.Drawing.Point(364, 107);
            this.GamePrevBtn.Name = "GamePrevBtn";
            this.GamePrevBtn.Size = new System.Drawing.Size(114, 23);
            this.GamePrevBtn.TabIndex = 9;
            this.GamePrevBtn.Text = "Previous Level";
            this.GamePrevBtn.UseVisualStyleBackColor = true;
            this.GamePrevBtn.Click += new System.EventHandler(this.GamePrevBtn_Click);
            // 
            // GameNextBtn
            // 
            this.GameNextBtn.Location = new System.Drawing.Point(493, 107);
            this.GameNextBtn.Name = "GameNextBtn";
            this.GameNextBtn.Size = new System.Drawing.Size(75, 23);
            this.GameNextBtn.TabIndex = 8;
            this.GameNextBtn.Text = "Next Level";
            this.GameNextBtn.UseVisualStyleBackColor = true;
            this.GameNextBtn.Click += new System.EventHandler(this.GameNextBtn_Click);
            // 
            // GameQuitBtn
            // 
            this.GameQuitBtn.Location = new System.Drawing.Point(680, 107);
            this.GameQuitBtn.Name = "GameQuitBtn";
            this.GameQuitBtn.Size = new System.Drawing.Size(75, 23);
            this.GameQuitBtn.TabIndex = 7;
            this.GameQuitBtn.Text = "Quit Game";
            this.GameQuitBtn.UseVisualStyleBackColor = true;
            this.GameQuitBtn.Click += new System.EventHandler(this.GameQuitBtn_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Location = new System.Drawing.Point(14, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(773, 406);
            this.GamePanel.TabIndex = 5;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // TimeMover
            // 
            this.TimeMover.Enabled = true;
            this.TimeMover.Interval = 50;
            this.TimeMover.Tick += new System.EventHandler(this.TimeMover_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 591);
            this.Controls.Add(this.GameMenuPanel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.GameMenuPanel.ResumeLayout(false);
            this.GameControlPanel.ResumeLayout(false);
            this.GameControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameMenuPanel;
        private System.Windows.Forms.Timer TimeMover;
        private System.Windows.Forms.Panel GameControlPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restartMazeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GamePrevBtn;
        private System.Windows.Forms.Button GameNextBtn;
        private System.Windows.Forms.Button GameQuitBtn;
        private System.Windows.Forms.Panel GamePanel;

    }
}