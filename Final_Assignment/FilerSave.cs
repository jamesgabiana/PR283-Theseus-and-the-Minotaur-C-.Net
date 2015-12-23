using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilerTATM;
using System.IO;

namespace Final_Assignment
{
    public partial class FilerSave : Form
    {
        IMapHandler mph;
        public FilerSave()
        {
            InitializeComponent();
        }

        private void Filer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            String defaultLocation = "H:\\C#\\Final_Assignment\\Maps\\MAP2.txt";
            fileLocationTxtBox.Text = defaultLocation;
            String map = CompressMap();
            mapTextBox.Clear();
            mapTextBox.AppendText(map);

        }

        private String CompressMap()
        {
            mph = new MapHandler();
            StringBuilder sb = new StringBuilder();
            using (StringReader reader = new StringReader(mapTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sb.Append(mph.CompressMap(line + System.Environment.NewLine));
                }
            }
            return sb.ToString();
        }

        private void WriteMapToFile()
        {
            using (StreamWriter sw = new StreamWriter(@fileLocationTxtBox.Text))
            using (StringReader reader = new StringReader(mapTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                }
            }
        }

        private void SaveMapBtn_Click(object sender, EventArgs e)
        {
            String txt;
                try
                {
                    txt = fileLocationTxtBox.Text.Substring((@fileLocationTxtBox.Text.Length) - 4, 4);
                    if (txt != ".txt")
                    {
                        MessageBox.Show("Please input The txt File name (e.g. Map.Txt)");
                    }
                    else
                    {
                        WriteMapToFile();
                        MessageBox.Show(AlertOutput.alertSSave);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("File Location Does Not Exist");
                }
                
            
        }

    }
}
