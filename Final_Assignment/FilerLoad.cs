using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using FilerTATM;

namespace Final_Assignment
{
    public partial class FilerLoad : Form
    {
        IValidator validator;
        FileInfo[] Files;
        private String mapLoc;
        public LevelDesignForm ldf;
        GameForm gf;
        String myForm;

        public FilerLoad(String newForm)
        {
            myForm = newForm;
            InitializeComponent();
        }

        private void FilerLoad_Load(object sender, EventArgs e)
        {
            String defaultLocation;
            defaultLocation = Interaction.InputBox("Enter the folder location of files", "File Location", "H:\\C#\\Final_Assignment\\Maps");
            this.CenterToScreen();
            fileLocTxtBox.Text = defaultLocation;
            try
            {
                GetAllMap();
            }
            catch (Exception)
            {
                MessageBox.Show("File Location Not Found!\nPlease Try Again");
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            
        }

        private void LoadMapBtn_Click(object sender, EventArgs e)
        {
            String map;
            map = ReadFile();
            if (myForm == "Game")
            {
                if (mapLoc != null && map != "")
                {
                    gf = new GameForm(map);
                    gf.Show();
                }
            }
            else if (myForm == "Design")
            {
                if (mapLoc != null && map != "")
                {
                    ldf = new LevelDesignForm(map);
                    ldf.Show();
                }
            }
            
        }


        private String ReadFile()
        {
            validator = new Validator();
            String map;
            MapHandler mph = new MapHandler();
            StringBuilder sb = new StringBuilder();
            
            map = sb.Append(@File.ReadAllText(mapLoc)).ToString();
            try
            {
                validator.ValidateMap(map);
                return mph.DecompressMap(map);
            }
            catch (InvalidInputError ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            //this.map = sb.Append(@File.ReadAllText(loc)).ToString();
        }

        private void GetAllMap()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@fileLocTxtBox.Text);
            Files = dinfo.GetFiles("*.txt");

            foreach (FileInfo file in Files)
            {
                FileListBox.Items.Add(file.Name);
            }
        }

        private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapLoc = Files[FileListBox.SelectedIndex].FullName;
        }



    }
}
