using PS_Registrar.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PS_Registrar
{
    public partial class CaseWriter : Form
    {
        public Dashboard dashboard = null;
        public DataManager dataManager = null;
        bool isCaseSaved = false;
        public string uniqueCaseID = "";
        public bool isNewCase = true;
        string caseType = "", slNo = "", FIRNo = "", DOR = "", complaintantDetails = "", accusedDetails = "", modeOfCrime = "", propertyLost = "", remarks = "", accusedPictureLoc = "";
        float defaultFontSize = Settings.Default.FontSizeCaseWriter;
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

        void setFontSize(float size)
        {
            caseTypeBox.Font = new Font("Microsoft Sans Serif", size);
            slNoBox.Font = new Font("Microsoft Sans Serif", size);
            FIRBox.Font = new Font("Microsoft Sans Serif", size);
            DORBox.Font = new Font("Microsoft Sans Serif", size);
            CPDetailsBox.Font = new Font("Microsoft Sans Serif", size);
            accusedDetailsBox.Font = new Font("Microsoft Sans Serif", size);
            modeOfCrimeBox.Font = new Font("Microsoft Sans Serif", size);
            propertyLostBox.Font = new Font("Microsoft Sans Serif", size);
            remarksBox.Font = new Font("Microsoft Sans Serif", size);
        }
        private void increaseFontContextButton_Click(object sender, EventArgs e)
        {
            defaultFontSize += 2;
            Settings.Default.FontSizeCaseWriter = defaultFontSize;
            Settings.Default.Save();
            setFontSize(defaultFontSize);
        }

        private void decreaseFontContextButton_Click(object sender, EventArgs e)
        {
            defaultFontSize -= 2;
            Settings.Default.FontSizeCaseWriter = defaultFontSize;
            Settings.Default.Save();
            setFontSize(defaultFontSize);
        }

        private void saveCaseButton_Click(object sender, EventArgs e)
        {
            saveCase();
        }

        private void saveCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveCase();
        }

        private void saveCase()
        {
            if (dataManager != null)
            {
                isCaseSaved = dataManager.SaveData(uniqueCaseID, caseTypeBox.Text, slNoBox.Text, FIRBox.Text, DORBox.Text, CPDetailsBox.Text, accusedDetailsBox.Text, modeOfCrimeBox.Text, propertyLostBox.Text, remarksBox.Text, dataManager.path + "Pictures\\" + uniqueCaseID + " " + openFileDialog1.SafeFileName);
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
            setFontSize(defaultFontSize);
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
                caseType = Between(caseFiles.ToString(), "caseType:", ":caseType");
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
            caseTypeBox.Text = caseType;
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
