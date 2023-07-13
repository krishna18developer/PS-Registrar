using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Registrar
{
    public partial class Dashboard : Form
    {
        public Login login = null;
        DataManager dataManager;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(login != null)
            {
                login.Show();
                login.dashboard = this;
                this.Hide();
            }
            else
            {
                login = new Login();
                login.Show();
                login.dashboard = this;
                this.Hide();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + Directory.GetCurrentDirectory());
            dataManager = new DataManager();
            for(int i = 0; i<dataManager.NumberOfCases;i++)
            {
                string fileName = dataManager.caseFiles.ElementAt(i);
                string ID = fileName.Replace("PSC-","");
                string caseName = "ABCD";
                string DOR = "23-05-2036";
                ID = ID.Substring(ID.Length-10,6);
                //MessageBox.Show(ID);
                foreach(string line in File.ReadLines(fileName))
                {
                    if(line.StartsWith("caseName:"))
                    {
                        caseName = line.Replace("caseName:","");
                    }
                    else if(line.StartsWith("DOR:"))
                    {
                        DOR = line.Replace("DOR:", "");
                    }
                }
                LoadCaseFiles(caseName,DOR, ID);
            }
        }

        private void LoadCaseFiles(string caseName,string DOR,string ID)
        {
            CaseBox caseBox = new CaseBox();
            caseBox.TopLevel = false;
            caseBox.AutoScroll = true;
            caseBox.SetDetails(caseName,DOR,ID);
            caseFilesPanel.Controls.Add(caseBox);
            caseBox.Show();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            CaseBox caseBox = new CaseBox();
            caseBox.TopLevel = false;
            caseBox.AutoScroll = true;
            caseFilesPanel.Controls.Add(caseBox);
            caseBox.Show();
        }

        private void newCaseButton_Click(object sender, EventArgs e)
        {
            CaseWriter caseWriter = new CaseWriter();
            caseWriter.dashboard = this;
            caseWriter.dataManager = dataManager;
            caseWriter.Show();
            this.Hide();
        }

        private void openDataFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", dataManager.path);
        }
    }
}
