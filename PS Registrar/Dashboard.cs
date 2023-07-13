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
            CaseBox caseBox = new CaseBox();
            caseBox.TopLevel = false;
            caseBox.AutoScroll = true;
            caseListView.Controls.Add(caseBox);
            caseBox.Show();
            CaseBox caseBox2 = new CaseBox();
            caseBox2.TopLevel = false;
            caseBox2.AutoScroll = true;
            caseListView.Controls.Add(caseBox2);
            caseBox2.Show();

            //MessageBox.Show("" + Directory.GetCurrentDirectory());
            dataManager = new DataManager();


        }
    }
}
