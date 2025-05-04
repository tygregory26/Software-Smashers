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

            // this should "hide" the button better - this button is our notification button
            btn_Menu_editVehicle.Text = "";
            //btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
        }

        // Opening Settings
        private void button1_Click(object sender, EventArgs e)
        {
            //btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            ((ACarThing)this.Parent).loadSettings();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            ((ACarThing)this.Parent).loadCarList();
        }

        private void btn_Menu_viewLogs_Click(object sender, EventArgs e)
        {
            //btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            //((ACarThing)this.Parent).loadLogs(carID);
        }

        private void btn_Menu_logout_Click(object sender, EventArgs e)
        {
            //btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            this.Hide();
            ((ACarThing)this.Parent).loadLogin();
        }

        private void btn_Menu_editVehicle_Click(object sender, EventArgs e)
        {
            // this is to "fake" a notification - we are going to update this to match the car we want to be looking at.

            int carID = 7;
            string type = "Break in";
            string message = "The door sensor has gone off";

            if (dbData.createLog(carID, type, message))
            {
                MessageBox.Show("Alert! Your car, " + dbData.getCarName(carID) + " has a new message.\n" + message);
            }
        }

        public void showEditButtons()
        {
            //btn_Menu_editVehicle.Show();
            btn_Menu_viewLogs.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //btn_Menu_editVehicle.Hide();
            btn_Menu_viewLogs.Hide();
            ((ACarThing)this.Parent).loadEditUser(userID);
        }
    }
}
