using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment
{
    public partial class LevelDesignMain : Form
    {
        FilerLoad fl;
        NewMapForm fnm;
        MainMenuForm mmf;
        public LevelDesignMain()
        {
            InitializeComponent();
        }

        private void LevelDesignMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LevelDesignLabel.Left = (this.LevelDesignMenuPanel.Width - LevelDesignLabel.Size.Width) / 2;
            LevelLoadBtn.Left = (this.LevelDesignMenuPanel.Width - LevelLoadBtn.Size.Width) / 2;
            levelNewMapBtn.Left = (this.LevelDesignMenuPanel.Width - levelNewMapBtn.Size.Width) / 2;
            LevelGoBackBtn.Left = (this.LevelDesignMenuPanel.Width - LevelGoBackBtn.Size.Width) / 2;
            LevelExitBtn.Left = (this.LevelDesignMenuPanel.Width - LevelExitBtn.Size.Width) / 2;
        }

        private void LevelLoadBtn_Click(object sender, EventArgs e)
        {
            fl = new FilerLoad("Design");

            //flr.mapTextBox.AppendText(ConverToString());
            fl.Show();
        }

        private void levelNewMapBtn_Click(object sender, EventArgs e)
        {
            fnm = new NewMapForm();
            fnm.Show();
        }

        private void LevelGoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mmf == null)
            {
                mmf = new MainMenuForm();
                mmf.FormClosed += Mmf_FormClosed;
                mmf.Show();
            }

            else
            {
                mmf.Activate();
            }
        }

        private void Mmf_FormClosed(object sender, FormClosedEventArgs e)
        {
            mmf = null;
        }


        private void LevelExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
