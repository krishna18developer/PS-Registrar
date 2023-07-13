using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Registrar
{
    public class DataManager
    {
        public string path = Directory.GetCurrentDirectory() + "\\Data\\";
        public List<string> caseFiles = new List<string>();
        string caseFilesPrefix = "PSC-";
        public int NumberOfCases = 0;
        public Dashboard dashboard = null;
        public StreamWriter writer;
        public StreamReader reader;
        public DataManager() 
        {
            if(!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            CheckDataUpdate();   
        }
        public void CheckDataUpdate()
        {
            IEnumerable<string> AllfilePaths = Directory.EnumerateFiles(path);
            //Directory.EnumerateFiles(path);
            foreach (string filePath in AllfilePaths)
            {
                //MessageBox.Show(filePath);
                if (filePath.Contains(caseFilesPrefix))
                {
                    if(!caseFiles.Contains(filePath))
                    caseFiles.Add(filePath);
                    // MessageBox.Show(filePath);
                }
            }
            NumberOfCases = caseFiles.Count;
        }
        public bool SaveData(string uniqueCaseID, string caseName,string slNo,string FIRNo,string DOR,string complaintantDetails,string accusedDetails,string modeOfCrime,string propertyLost,string remarks,string accusedPictureLoc)
        {
            bool isSaveSuccessful = true;
            string filePath = path + caseFilesPrefix + uniqueCaseID + ".bin";
            /*if(!File.Exists(filePath))
            {
                File.Create(filePath);
            }     */
            try
            {
                
                FileStream fs = new FileStream(filePath, FileMode.Truncate);
                fs.Close();
                TextWriter tw = new StreamWriter(filePath, true);
                //File.Copy(filePath, filePathWithoutExt + "-B"+".bin");
                // File.WriteAllText(filePath, String.Empty);
                // File.AppendAllText(filePath, "caseName:" + caseName);
                tw.WriteLine(String.Empty);
                tw.WriteLine("caseName:" + caseName + ":caseName");
                tw.WriteLine("slNo:" + slNo + ":slNo");
                tw.WriteLine("FIRNo:" + FIRNo + ":FIRNo");
                tw.WriteLine("DOR:" + DOR + ":DOR");
                tw.WriteLine("complaintantDetails:" + complaintantDetails + ":complaintantDetails");
                tw.WriteLine("accusedDetails:" + accusedDetails + ":accusedDetails");
                tw.WriteLine("modeOfCrime:" + modeOfCrime + ":modeOfCrime");
                tw.WriteLine("propertyLost:" + propertyLost + ":propertyLost");
                tw.WriteLine("remarks:" + remarks + ":remarks");
                tw.WriteLine("accusedPictureLoc:" + accusedPictureLoc + ":accusedPictureLoc");
                tw.Close();
                MessageBox.Show("Case Saved!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception e : " + e);
            }
            return isSaveSuccessful;
        }
        public void LoadData()
        {
            
        }
        public string getCaseFileWithID(string ID)
        {
            string n = "";

            foreach(string caseFile in caseFiles)
            {
                if (caseFile.Contains("PSC-" + ID))
                {
                    n = caseFile;
                    break;
                }
            }
            //MessageBox.Show("Data Manager - " + n);
            return n;
        }
        public void DeleteCase(string ID)
        {
            ID = "PSC-" + ID + ".bin";
            foreach (string filePath in caseFiles)
            {
                if (filePath.Contains(ID))
                {
                    File.Delete(filePath);
                    caseFiles.Remove(filePath);
                    dashboard.CaseLoader();
                    break;
                }
            }
        }
    }
}
