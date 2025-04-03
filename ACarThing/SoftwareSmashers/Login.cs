using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace SoftwareSmashers
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_login_Click(object sender, EventArgs e)
        {
            string user = txt_Login_email.Text;
            string pass = txt_Login_password.Text;

            if (user.Length == 0 && pass.Length == 0)
            {
                this.Hide();
                ((ACarThing)this.Parent).loadMenu();
                return;
            }
        }

        private void btn_Login_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((ACarThing)this.Parent).loadNewUser();
        }

        private void txt_Login_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Login_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
