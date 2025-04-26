using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSmashers
{
    public partial class NewCar : UserControl
    {
        // Radio button engine types selection has the relevant integer asssociations
        // Gas:        0
        // Electric:   1
        // Hybrid:     2

        int carID;
        int userID;
        Boolean newCar = false;

        public NewCar()
        {
            InitializeComponent();
        }
        public NewCar(int userID, int carID)
        {
            // being used as edit car (we already have carID)
            newCar = false;
            InitializeComponent();
            this.carID = carID;
            txt_NewCar_vehicleName.Text = dbData.getCarName(carID);
            txt_NewCar_Make.Text = dbData.getCarMake(carID);
            txt_NewCar_Model.Text = dbData.getCarModel(carID);
            txt_NewCar_Year.Text = dbData.getCarYear(carID);
            txt_NewCar_VIN.Text = dbData.getCarVin(carID);
        }
        public NewCar(int userID)
        {
            // being used as new car (we don't already have carID)
            newCar = true;
            InitializeComponent();
        }

        private void btn_NewCar_Cancel_Click(object sender, EventArgs e)
        {
            if (newCar)
            {
                ((ACarThing)this.Parent).loadCarList();
            }
            else
            {
                ((ACarThing)this.Parent).loadCurrCar(carID);
            }
        }

        private void btn_NewCar_Save_Click_1(object sender, EventArgs e)
        {
            if (newCar)
            {
                dbData.addVehicle(userID, txt_NewCar_Make.Text, txt_NewCar_Model.Text, txt_NewCar_Year.Text, txt_NewCar_VIN.Text, 1, .42f, .34f, .45f, .98f, txt_NewCar_vehicleName.Text);
                // will need to get vehicleID back from this?
                ((ACarThing)this.Parent).loadCurrCar(carID);

            }
            else
            {
                //dbData.editVehicle();
                ((ACarThing)this.Parent).loadCurrCar(carID);
            }
        }
    }
}

