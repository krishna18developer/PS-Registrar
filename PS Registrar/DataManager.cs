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
        public DataManager() 
        {
            if(!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            
            
            IEnumerable<string> AllfilePaths = Directory.EnumerateFiles(path);
            //Directory.EnumerateFiles(path);
            foreach (string filePath in AllfilePaths)
            {
                //MessageBox.Show(filePath);
                if(filePath.Contains(caseFilesPrefix))
                {
                    caseFiles.Add(filePath);
                   // MessageBox.Show(filePath);
                }
            }
            NumberOfCases = caseFiles.Count;
            
        }
        public bool SaveData(string uniqueCaseID, string caseName,string slNo,string FIRNo,string DOR,string complaintantDetails,string accusedDetails,string modeOfCrime,string propertyLost,string remarks)
        {
            bool isSaveSuccessful = true;
            string filePath = path + caseFilesPrefix + uniqueCaseID + ".bin";
            string filePathWithoutExt = path + caseFilesPrefix + uniqueCaseID;         
            if(!File.Exists(filePath))
            {
                File.Create(filePath);
            }          
            try
            {
                File.Copy(filePath, filePathWithoutExt + "-B"+".bin");
                File.WriteAllText(filePath, String.Empty);
                File.AppendAllText(filePath, "caseName:" + caseName);
                /*
                File.AppendAllText(filePath, "slNo:" + slNo);
                File.AppendAllText(filePath, "FIRNo:" + FIRNo);
                File.AppendAllText(filePath, "DOR:" + caseName);
                File.AppendAllText(filePath, "complaintantDetails:" + complaintantDetails);
                File.AppendAllText(filePath, "accusedDetails:" + accusedDetails);
                File.AppendAllText(filePath, "modeOfCrime:" + modeOfCrime);
                File.AppendAllText(filePath, "propertyLost:" + propertyLost);
                File.AppendAllText(filePath, "remarks:" + remarks);
                */
                MessageBox.Show("Case Saved!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception e : " + e);
            }
            return isSaveSuccessful;
        }
    }
}
