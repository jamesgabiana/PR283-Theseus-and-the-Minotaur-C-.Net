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
    public partial class Form1 : Form
    {
        List<Panel> ListPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            ListPanel.Add(MainMenuPanel);
            ListPanel.Add(GamePanel);
            ListPanel.Add(LevelDesignPanel);



            MainMenuLabel.Left = (this.MainMenuPanel.Width - MainMenuLabel.Size.Width) / 2;
            GameLabel.Left = (this.GamePanel.Width - GameLabel.Size.Width) / 2;
            GamePanel.BringToFront();
            //lblReport.Left = (this.ClientSize.Width - lblReport.Size.Width) / 2;
        }*/

        private void MainGotoGameBtn_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            GamePanel.BringToFront();
            LevelDesignPanel.Visible = false;
            LevelDesignPanel.SendToBack();
            MainMenuPanel.SendToBack();
        }

        private void MainGoToDesignBtn_Click(object sender, EventArgs e)
        {
            //ListPanel[2].Visible = true;
            //ListPanel[2].BringToFront();
            //ListPanel[0].SendToBack();
            LevelDesignPanel.Visible = true;
            GamePanel.Visible = true;
            GamePanel.BringToFront();
            MainMenuPanel.Visible = false;
            LevelDesignPanel.BringToFront();
            
            
            
            //MainMenuPanel.Visible = false;
            //LevelDesignPanel.BringToFront();
        }

        private void MainExitBtn_Click(object sender, EventArgs e)
        {

        }

        private void GamePlayBtn_Click(object sender, EventArgs e)
        {
            LevelDesignPanel.Visible = true;
        }

        private void GameLoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void GameGoBackBtn_Click(object sender, EventArgs e)
        {

        }

        private void GameExitBtn_Click(object sender, EventArgs e)
        {

        }

        private void LevelLoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void levelNewMapBtn_Click(object sender, EventArgs e)
        {

        }

        private void LevelGoBackBtn_Click(object sender, EventArgs e)
        {

        }

        private void LevelExitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
