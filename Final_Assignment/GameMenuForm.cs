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
    public partial class GameMenuForm : Form
    {
        GameForm gf;
        MainMenuForm mmf;
        FilerLoad fl;
        public GameMenuForm()
        {
            InitializeComponent();
        }

        private void GameMenuForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void GamePlayBtn_Click(object sender, EventArgs e)
        {
            gf = new GameForm(PlayByLevel.Maps[0]);
            gf.Show();
            //GamePanel = MapPanel.map;
            gf.BringToFront();

        }

        private void Mmf_FormClosed(object sender, FormClosedEventArgs e)
        {
            mmf = null;
        }

        private void GameGoBackBtn_Click_1(object sender, EventArgs e)
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

        private void GameLoadBtn_Click(object sender, EventArgs e)
        {
            fl = new FilerLoad("Game");

            //flr.mapTextBox.AppendText(ConverToString());
            fl.Show();
        }

        private void GameExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
