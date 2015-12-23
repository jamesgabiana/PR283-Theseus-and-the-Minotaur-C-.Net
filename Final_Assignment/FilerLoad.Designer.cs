namespace Final_Assignment
{
    partial class FilerLoad
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
            this.LoadMapBtn = new System.Windows.Forms.Button();
            this.fileLocTxtBox = new System.Windows.Forms.TextBox();
            this.fileLocationLbl = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LoadMapBtn
            // 
            this.LoadMapBtn.Location = new System.Drawing.Point(25, 323);
            this.LoadMapBtn.Name = "LoadMapBtn";
            this.LoadMapBtn.Size = new System.Drawing.Size(79, 54);
            this.LoadMapBtn.TabIndex = 0;
            this.LoadMapBtn.Text = "LoadMap";
            this.LoadMapBtn.UseVisualStyleBackColor = true;
            this.LoadMapBtn.Click += new System.EventHandler(this.LoadMapBtn_Click);
            // 
            // fileLocTxtBox
            // 
            this.fileLocTxtBox.Location = new System.Drawing.Point(221, 341);
            this.fileLocTxtBox.Name = "fileLocTxtBox";
            this.fileLocTxtBox.Size = new System.Drawing.Size(383, 20);
            this.fileLocTxtBox.TabIndex = 2;
            // 
            // fileLocationLbl
            // 
            this.fileLocationLbl.AutoSize = true;
            this.fileLocationLbl.Location = new System.Drawing.Point(218, 364);
            this.fileLocationLbl.Name = "fileLocationLbl";
            this.fileLocationLbl.Size = new System.Drawing.Size(67, 13);
            this.fileLocationLbl.TabIndex = 3;
            this.fileLocationLbl.Text = "File Location";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(121, 323);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(80, 54);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh List";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // FileListBox
            // 
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(25, 23);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(176, 290);
            this.FileListBox.TabIndex = 5;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // FilerLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 466);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.fileLocationLbl);
            this.Controls.Add(this.fileLocTxtBox);
            this.Controls.Add(this.LoadMapBtn);
            this.Name = "FilerLoad";
            this.Text = "FilerLoad";
            this.Load += new System.EventHandler(this.FilerLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadMapBtn;
        public System.Windows.Forms.TextBox fileLocTxtBox;
        private System.Windows.Forms.Label fileLocationLbl;
        private System.Windows.Forms.Button RefreshBtn;
        public System.Windows.Forms.ListBox FileListBox;
    }
}