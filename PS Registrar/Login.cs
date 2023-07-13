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
    public partial class Login : Form
    {
        public Dashboard dashboard = null;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(true)//Apply Login Logic Here Later !
            {
                dashboard = new Dashboard();
                dashboard.Show();
                dashboard.login = this;
                this.Hide();
            }
        }
    }
}
