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
    public partial class DeleteDriver : UserControl
    {
        private int carID;
        private string driverEmail;
        private int userID;

        public DeleteDriver()
        {
            InitializeComponent();
        }
        public DeleteDriver(int carID, int userID)
        {
            InitializeComponent();
            this.carID = carID;
            this.userID = userID;
            dataGrid_Driver_data.DataSource = dbData.viewDrivers(carID);
        }

        private void btn_DeleteCar_deleteDriver_Click(object sender, EventArgs e)
        {
            driverEmail = txt_DeleteDriver_email.Text;

            if (String.IsNullOrEmpty(driverEmail))
            {
                MessageBox.Show("Please enter a valid email.");
            }
            else if (dbData.getEmail(userID) == driverEmail)
            {
                MessageBox.Show("You cannot remove the owner of the vehicle.");
            }
            else if (dbData.isDriver(driverEmail, carID))
            {
                dbData.removeDriver(driverEmail, carID);
            }
            else
            {
                MessageBox.Show(driverEmail + " is not a driver of this vehicle.");
            }

            dataGrid_Driver_data.DataSource = dbData.viewDrivers(carID);
        }
        private void btn_DeleteCar_addDriver_Click(object sender, EventArgs e)
        {
            driverEmail = txt_DeleteDriver_email.Text;

            if (String.IsNullOrEmpty(driverEmail))
            {
                MessageBox.Show("Please enter a valid email.");
            }
            else if (dbData.isDriver(driverEmail, carID))
            {
                MessageBox.Show(driverEmail + " is already a driver of this vehicle");
            }
            else
            {
                dbData.addDriver(driverEmail, carID);
            }

            dataGrid_Driver_data.DataSource = dbData.viewDrivers(carID);
        }

        private void btn_DeleteCar_cancel_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadCurrCar(carID);
            this.Hide();
        }
    }
}
