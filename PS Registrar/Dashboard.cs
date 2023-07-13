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
            dataManager.dashboard = this;
            CaseLoader();
        }
        public void CaseLoader()
        {
            caseFilesPanel.Controls.Clear();
            dataManager.CheckDataUpdate();
            try
            {
                for (int i = 0; i < dataManager.NumberOfCases; i++)
                {
                    string fileName = dataManager.caseFiles.ElementAt(i);
                    //MessageBox.Show(fileName);
                    string ID = fileName.Replace("PSC-", "");
                    //MessageBox.Show("Pre - " +ID);
                    string caseName = "ABCD";
                    string DOR = "23-05-2036";
                    ID = ID.Substring(ID.Length - 10, 6);
                    //MessageBox.Show("ID - " + ID);
                    //MessageBox.Show(ID);
                    //FileStream fs = new FileStream(fileName, FileMode.Open);
                    //fs.Close();
                    StreamReader stream = new StreamReader(fileName);
                    string caseFiles = stream.ReadToEnd();
                    // string caseFiles = File.ReadAllText(fileName);
                    caseName = Between(caseFiles.ToString(), "caseName:", ":caseName");
                    DOR = Between(caseFiles.ToString(), "DOR:", ":DOR");
                    LoadCaseFiles(caseName, DOR, ID);
                    stream.Close();
                }
            }
            catch (Exception ek)
            {
                MessageBox.Show("Dashboard - File Busy");
                Console.WriteLine(ek);
            }
        }
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString = "";
            if(STR!="")
            {
                int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
                int Pos2 = STR.IndexOf(LastString);
                FinalString = STR.Substring(Pos1, Pos2 - Pos1);
                
            }
            return FinalString;
        }
        private void LoadCaseFiles(string caseName,string DOR,string ID)
        {
            CaseBox caseBox = new CaseBox();
            caseBox.TopLevel = false;
            caseBox.AutoScroll = true;
            caseBox.SetDetails(caseName,DOR,ID);
            caseFilesPanel.Controls.Add(caseBox);
            caseBox.dataManager = dataManager;
            caseBox.dashboard = this;
            caseBox.Show();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            CaseBox caseBox = new CaseBox();
            caseBox.TopLevel = false;
            caseBox.AutoScroll = true;
            caseBox.dashboard = this;
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
        public void openExistingCase(string ID)
        {
            CaseWriter caseWriter = new CaseWriter();
            caseWriter.dashboard = this;
            caseWriter.dataManager = dataManager;
            caseWriter.isNewCase = false;
            caseWriter.LoadData(ID);
            caseWriter.Show();
            this.Hide();
        }

        private void openDataFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", dataManager.path);
        }

        private void reloadCasesButton_Click(object sender, EventArgs e)
        {
            caseFilesPanel.Controls.Clear();
            CaseLoader();
        }

        private void caseFilesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
