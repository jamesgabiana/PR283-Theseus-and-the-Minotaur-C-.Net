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
    public partial class NewMapForm : Form
    {
        NumericTextBox mapHeight;
        NumericTextBox mapWidth;
        LevelDesignForm ldf;
        public NewMapForm()
        {
            InitializeComponent();
        }

        private void MapSizeBtn_Click(object sender, EventArgs e)
        {
            if (mapHeight.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Height!");
            }
            else if (mapWidth.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Width!");
            }
            else if (mapWidth.IntValue <= 1 | mapHeight.IntValue <= 1)
            {
                MessageBox.Show("Map Size too small!");
            }
            else
            {
                ldf = new LevelDesignForm(CreateNewMap());
                //MessageBox.Show(CreateNewMap());
                this.Hide();
                ldf.Show();
            }
            
        }

        private String CreateNewMap()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < (mapHeight.IntValue * 2) + 1; i++)
            {
                for (int j = 0; j < (mapWidth.IntValue) + 1 ; j++)
                {
                    if (i == (mapHeight.IntValue * 2) || i == 0)
                    {
                        
                        if (j == mapWidth.IntValue)
                        {
                            sb.Append(".");
                        }
                        else
                        {
                            sb.Append(".___");   
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        
                        if (j == mapWidth.IntValue)
                        {
                            sb.Append(".");
                        }
                        else
                        {
                            sb.Append(".   ");
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            sb.Append("|   ");
                        }
                        else if (j == mapWidth.IntValue)
                        {
                            sb.Append("|");
                        }
                        else
                        {
                            sb.Append("    ");
                        }
                    }
                }
                if (i < (mapHeight.IntValue * 2))
                {
                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }

        private void NewMapForm_Load(object sender, EventArgs e)
        {
            // Create an instance of NumericTextBox.
            mapWidth = new NumericTextBox();
            mapWidth.Parent = this;

            mapHeight = new NumericTextBox();
            mapHeight.Parent = this;
            //Draw the bounds of the NumericTextBox.
            mapWidth.Bounds = new Rectangle(100, 100, 150, 100);
            mapHeight.Bounds = new Rectangle(100, 150, 150, 100);
            this.CenterToScreen();
        }
    }
}
