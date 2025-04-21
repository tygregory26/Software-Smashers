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
                ((ACarThing)this.Parent).loadMenu(1);
                return;
            }

            int? userID = dbData.login(user, pass);

            if (userID.HasValue)
            {
                this.Hide();
                ((ACarThing)this.Parent).loadMenu(userID.Value);
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void btn_Login_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((ACarThing)this.Parent).loadNewUser();

        }
    }
}
