using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Registrar
{
    public partial class CaseWriter : Form
    {
        public Dashboard dashboard = null;
        public DataManager dataManager = null;
        bool isCaseSaved = false;
        public string uniqueCaseID = "";
        public bool isNewCase = true;
        public CaseWriter()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(!isCaseSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the case without saving ?", "Close Unsaved Case - PS Registrar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dashboard.Show();
                    this.Close();
                }
            }
            else
            {
                dashboard.Show();
                this.Close();
            }
        }

        private void saveCaseButton_Click(object sender, EventArgs e)
        {
            if(dataManager!=null)
            {
                isCaseSaved = dataManager.SaveData(uniqueCaseID, caseNameBox.Text, slNoBox.Text,FIRBox.Text, DORBox.Text, CPDetailsBox.Text, accusedDetailsBox.Text, modeOfCrimeBox.Text,propertyLostBox.Text,remarksBox.Text);
            }
            else
            {
                MessageBox.Show("Data Manager Not Initialised");
            }
        }
        private void FileNameGen()
        {
           // var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            uniqueCaseID = new String(stringChars);
        }

        private void CaseWriter_Load(object sender, EventArgs e)
        {
            if(isNewCase)
            {
                FileNameGen();    
            }
            caseIDLabel.Text = "Case ID: " + uniqueCaseID;
        }
    }
}
