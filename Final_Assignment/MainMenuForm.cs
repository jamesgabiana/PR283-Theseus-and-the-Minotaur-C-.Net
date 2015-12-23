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
    public partial class MainMenuForm : Form
    {
        //List<Panel> ListPanel = new List<Panel>();
        //int index;
        GameMenuForm gf;

        LevelDesignMain ldf;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MainMenuLabel.Left = (this.MainMenuPanel.Width - MainMenuLabel.Size.Width) / 2;
            MainGotoGameBtn.Left = (this.MainMenuPanel.Width - MainGotoGameBtn.Size.Width) / 2;
            MainGoToDesignBtn.Left = (this.MainMenuPanel.Width - MainGoToDesignBtn.Size.Width) / 2;
            MainExitBtn.Left = (this.MainMenuPanel.Width - MainExitBtn.Size.Width) / 2;
        }

        private void MainGotoGameBtn_Click(object sender, EventArgs e)
        {
            if (gf == null)
            {
                gf = new GameMenuForm();
                gf.FormClosed += Gf_FormClosed;
                gf.Show();
                this.Hide();
            }
            else
            {
                gf.Activate();
            }
        }

        private void Gf_FormClosed(object sender, FormClosedEventArgs e)
        {
            gf = null;
            //throw new NotImplementedException();
        }

        private void MainGoToDesignBtn_Click(object sender, EventArgs e)
        {
            if (ldf == null)
            {
                ldf = new LevelDesignMain();
                ldf.FormClosed += Ldf_FormClosed;
                //gf.FormClosed += Gf_FormClosed;
                ldf.Show();
                this.Hide();
            }

            else
            {
                ldf.Activate();
            }

            //ListPanel[2].Visible = true;
            //ListPanel[2].BringToFront();
            //ListPanel[0].SendToBack();

            //MainMenuPanel.Visible = false;
            //LevelDesignPanel.BringToFront();

            //panel1.Show();
            //panel1.BringToFront();
        }

        private void Ldf_FormClosed(object sender, FormClosedEventArgs e)
        {
            ldf = null;
            //throw new NotImplementedException();
        }

        private void MainExitBtn_Click(object sender, EventArgs e)
        {
            //panel1.Show();
            //panel2.Show();
            //panel2.BringToFront();
            Application.Exit();

        }

    }
}
