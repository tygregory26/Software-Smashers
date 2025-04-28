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
            btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
        }

        // Opening Settings
        private void button1_Click(object sender, EventArgs e)
        {
            btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            ((ACarThing)this.Parent).loadSettings();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            ((ACarThing)this.Parent).loadCarList();
        }

        private void btn_Menu_viewLogs_Click(object sender, EventArgs e)
        {
            btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            //((ACarThing)this.Parent).loadLogs(carID);
        }

        private void btn_Menu_logout_Click(object sender, EventArgs e)
        {
            btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            this.Hide();
            ((ACarThing)this.Parent).loadLogin();
        }

        private void btn_Menu_editVehicle_Click(object sender, EventArgs e)
        {
            //((ACarThing)this.Parent).loadCurrCar();
        }

        public void showEditButtons()
        {
            btn_Menu_editVehicle.Show();
            btn_Menu_viewLogs.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            ((ACarThing)this.Parent).loadEditUser(userID);
        }
    }
}
