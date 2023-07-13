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
    public partial class CaseBox : Form
    {
        public DataManager dataManager = null;
        public Dashboard dashboard = null;
        public CaseBox()
        {
            InitializeComponent();
        }

        private void deleteCaseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the case ?", "Delete Case - PS Registrar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataManager.DeleteCase(uniqueIDLabel.Text);
            }
        }
        public void SetDetails(string caseName,string DOR,string uniqueID)
        {
            caseNameLabel.Text = caseName;
            caseDateReported.Text = DOR;
            uniqueIDLabel.Text = uniqueID;
        }
    }
}
