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

namespace PS_Registrar
{
    public partial class CaseWriter : Form
    {
        public Dashboard dashboard = null;
        public DataManager dataManager = null;
        bool isCaseSaved = false;
        public string uniqueCaseID = "";
        public bool isNewCase = true;
        string caseName = "", slNo = "", FIRNo = "", DOR = "", complaintantDetails = "", accusedDetails = "", modeOfCrime = "", propertyLost = "", remarks = "", accusedPictureLoc = "";
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
                isCaseSaved = dataManager.SaveData(uniqueCaseID, caseNameBox.Text, slNoBox.Text,FIRBox.Text, DORBox.Text, CPDetailsBox.Text, accusedDetailsBox.Text, modeOfCrimeBox.Text,propertyLostBox.Text,remarksBox.Text, dataManager.path + "Pictures\\" + uniqueCaseID + " " + openFileDialog1.SafeFileName);
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
                DORBox.Text = dateTimePicker1.Text;
            }
            else
            {
                DORBox.Text = DOR;
            }
            caseIDLabel.Text = "Case ID: " + uniqueCaseID;
            
        }

        private void CPDetailsBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadData(string ID)
        {
            //string caseName = "", slNo = "", FIRNo = "", DOR = "", complaintantDetails = "", accusedDetails = "", modeOfCrime = "", propertyLost = "", remarks = "",accusedPictureLoc = "";
            dataManager.CheckDataUpdate();
            try
            {
                
               // string fileName = dataManager.caseFiles.ElementAt(dataManager.getFileID(ID));
                //MessageBox.Show("File name: " + fileName);
                //  string caseFiles = File.ReadAllText(fileName);
                string caseFiles = File.ReadAllText(dataManager.getCaseFileWithID(ID));
                caseIDLabel.Text = "Case ID: " + uniqueCaseID;
                uniqueCaseID = ID;
                caseName = Between(caseFiles.ToString(), "caseName:", ":caseName");
                slNo = Between(caseFiles.ToString(), "slNo:", ":slNo");
                FIRNo = Between(caseFiles.ToString(), "FIRNo:", ":FIRNo");
                DOR = Between(caseFiles.ToString(), "DOR:", ":DOR");
                complaintantDetails = Between(caseFiles.ToString(), "complaintantDetails:", ":complaintantDetails");
                accusedDetails = Between(caseFiles.ToString(), "accusedDetails:", ":accusedDetails");
                modeOfCrime = Between(caseFiles.ToString(), "modeOfCrime:", ":modeOfCrime");
                propertyLost = Between(caseFiles.ToString(), "propertyLost:", ":propertyLost");
                remarks = Between(caseFiles.ToString(), "remarks:", ":remarks");
                accusedPictureLoc = Between(caseFiles.ToString(), "accusedPictureLoc:", ":accusedPictureLoc");
            }
            catch (Exception e1)
            {
                MessageBox.Show("File Busy - Case Writer");
            }
            caseNameBox.Text = caseName;
            slNoBox.Text = slNo;
            FIRBox.Text = FIRNo;
            DORBox.Text = DOR;
            CPDetailsBox.Text = complaintantDetails;
            accusedDetailsBox.Text = accusedDetails;
            modeOfCrimeBox.Text = modeOfCrime;
            propertyLostBox.Text = propertyLost;
            remarksBox.Text = remarks;
            DORBox.Text = dateTimePicker1.Text;
            if (File.Exists(accusedPictureLoc))
            {
                accusedPictureBox.Image = new Bitmap(accusedPictureLoc);
            }
            
            isCaseSaved = true;
        }
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void accusedPictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(!Directory.Exists(dataManager.path + "Pictures\\"))
                {
                    Directory.CreateDirectory(dataManager.path + "Pictures\\");
                }
                try
                {
                    string DestFilePath = dataManager.path + "Pictures\\" + uniqueCaseID + " " + openFileDialog1.SafeFileName;
                    if (!File.Exists(DestFilePath))
                    {
                        File.Copy(openFileDialog1.FileName, DestFilePath);

                        //Bitmap picture = new Bitmap(openFileDialog1.FileName);
                        Bitmap picture = new Bitmap(DestFilePath);
                        accusedPictureBox.Image = picture;
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DORBox.Text = dateTimePicker1.Text;
        }
    }
}
