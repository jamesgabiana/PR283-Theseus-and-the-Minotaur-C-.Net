namespace Final_Assignment
{
    partial class FilerSave
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
            this.fileLocationTxtBox = new System.Windows.Forms.TextBox();
            this.SaveMapBtn = new System.Windows.Forms.Button();
            this.FileLocLbl = new System.Windows.Forms.Label();
            this.mapTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fileLocationTxtBox
            // 
            this.fileLocationTxtBox.Location = new System.Drawing.Point(166, 344);
            this.fileLocationTxtBox.Name = "fileLocationTxtBox";
            this.fileLocationTxtBox.Size = new System.Drawing.Size(338, 20);
            this.fileLocationTxtBox.TabIndex = 1;
            // 
            // SaveMapBtn
            // 
            this.SaveMapBtn.Location = new System.Drawing.Point(22, 267);
            this.SaveMapBtn.Name = "SaveMapBtn";
            this.SaveMapBtn.Size = new System.Drawing.Size(94, 45);
            this.SaveMapBtn.TabIndex = 2;
            this.SaveMapBtn.Text = "Save Map";
            this.SaveMapBtn.UseVisualStyleBackColor = true;
            this.SaveMapBtn.Click += new System.EventHandler(this.SaveMapBtn_Click);
            // 
            // FileLocLbl
            // 
            this.FileLocLbl.AutoSize = true;
            this.FileLocLbl.Location = new System.Drawing.Point(93, 347);
            this.FileLocLbl.Name = "FileLocLbl";
            this.FileLocLbl.Size = new System.Drawing.Size(67, 13);
            this.FileLocLbl.TabIndex = 3;
            this.FileLocLbl.Text = "File Location";
            // 
            // mapTextBox
            // 
            this.mapTextBox.Location = new System.Drawing.Point(166, 40);
            this.mapTextBox.Name = "mapTextBox";
            this.mapTextBox.Size = new System.Drawing.Size(338, 272);
            this.mapTextBox.TabIndex = 4;
            this.mapTextBox.Text = "";
            // 
            // Filer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 454);
            this.Controls.Add(this.mapTextBox);
            this.Controls.Add(this.FileLocLbl);
            this.Controls.Add(this.SaveMapBtn);
            this.Controls.Add(this.fileLocationTxtBox);
            this.Name = "Filer";
            this.Text = "Filer";
            this.Load += new System.EventHandler(this.Filer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileLocationTxtBox;
        private System.Windows.Forms.Button SaveMapBtn;
        private System.Windows.Forms.Label FileLocLbl;
        public System.Windows.Forms.RichTextBox mapTextBox;
    }
}