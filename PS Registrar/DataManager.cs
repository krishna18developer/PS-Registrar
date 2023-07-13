using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Registrar
{
    class DataManager
    {
        string path = Directory.GetCurrentDirectory() + "\\Data\\";
        List<string> caseFiles = new List<string>();
        public DataManager() 
        {
            if(!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            
            string searchPattern = "PSC-";
            IEnumerable<string> AllfilePaths = Directory.EnumerateFiles(path);
            //Directory.EnumerateFiles(path);
            foreach (string filePath in AllfilePaths)
            {
                //MessageBox.Show(filePath);
                if(filePath.Contains(searchPattern))
                {
                    caseFiles.Add(filePath);
                   // MessageBox.Show(filePath);
                }
            }
            foreach(string filePath in caseFiles)
            {
                MessageBox.Show(filePath);
            }
            
        }

    }
}
