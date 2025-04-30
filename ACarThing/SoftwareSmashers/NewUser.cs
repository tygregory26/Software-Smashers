using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Metrics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace SoftwareSmashers
{
    public partial class NewUser : UserControl
    {
        private int userID;
        Boolean edit = false;
        public NewUser()
        {
            InitializeComponent();
            lbl_NewUser_register.Text = "Register";
            lbl_NewUser_password.Show();
            txt_NewUser_password.Show();
            edit = false;
            pic_NewUser_logo.Show();
        }

        public NewUser(int userID)
        {
            InitializeComponent();
            lbl_NewUser_register.Text = "Edit";
            lbl_NewUser_password.Hide();
            txt_NewUser_password.Hide();
            this.userID = userID;
            edit = true;
            pic_NewUser_logo.Hide();

            txt_NewUser_fname.Text = dbData.getName(userID);
            txt_NewUser_lname.Text = dbData.getLastName(userID);
            txt_NewUser_email.Text = dbData.getEmail(userID);
            txt_NewUser_phoneNum.Text = dbData.getPhone(userID);
        }

        private void btn_NewUser_save_Click(object sender, EventArgs e)
        {
            string email = txt_NewUser_email.Text;
            string pass = txt_NewUser_password.Text;
            string fName = txt_NewUser_fname.Text;
            string lName = txt_NewUser_lname.Text;
            string phone = txt_NewUser_phoneNum.Text;

            // todo - will need to add default settings info to this when the newUser function is updated (but only when new user - not when editing
            dbData.newUser(fName, lName, email, phone, pass);

            int? userID = dbData.login(email, pass);

            if (userID.HasValue)
            {
                this.Hide();
                ((ACarThing)this.Parent).loadMenu(userID.Value);
            }
            else
            {
                this.Hide();
                ((ACarThing)this.Parent).loadLogin();
            }
            return;
        }

        private void btn_NewUser_cancel_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                this.Hide();
                ((ACarThing)this.Parent).loadMenu(userID);
                return;
            }
            else
            {
                this.Hide();
                ((ACarThing)this.Parent).loadLogin();
                return;
            }
        }
    }
}
