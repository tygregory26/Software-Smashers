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
    public partial class Menu : UserControl
    {
        private int userID;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(int user)
        {
            InitializeComponent();
            this.userID = user;
            string name = dbData.getName(userID);
            this.btn_Menu_settings.Text = "Welcome, " + name;
        }

        // Opening Settings
        private void button1_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadSettings();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadCarList();
        }

        private void btn_Menu_viewLogs_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadLogs();
        }

        private void btn_Menu_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((ACarThing)this.Parent).loadLogin();
        }

        private void btn_Menu_editVehicle_Click(object sender, EventArgs e)
        {
            //((ACarThing)this.Parent).loadCurrCar();
        }
    }
}
