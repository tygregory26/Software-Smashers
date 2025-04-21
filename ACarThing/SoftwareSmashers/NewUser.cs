using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSmashers
{
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btn_NewUser_save_Click(object sender, EventArgs e)
        {
            string email = txt_NewUser_email.Text;
            string pass = txt_NewUser_password.Text;
            string fName = txt_NewUser_fname.Text;
            string lName = txt_NewUser_lname.Text;
            string phone = txt_NewUser_phoneNum.Text;

            this.Hide();
            //((ACarThing)this.Parent).loadMenu(false);
            return;
        }

        private void btn_NewUser_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((ACarThing)this.Parent).loadLogin();
            return;
        }
    }
}
