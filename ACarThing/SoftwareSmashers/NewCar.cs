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
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

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
            InitializeComponent();
            newCar = false;
            btn_NewCar_Delete.Show();
            this.carID = carID;
            txt_NewCar_vehicleName.Text = dbData.getCarName(carID);
            txt_NewCar_Make.Text = dbData.getCarMake(carID);
            txt_NewCar_Model.Text = dbData.getCarModel(carID);
            txt_NewCar_Year.Text = dbData.getCarYear(carID);
            txt_NewCar_VIN.Text = dbData.getCarVin(carID);
            switch (dbData.getCarType(carID))
            {
                case 0:
                    radiobtn_NewCar_Gas.Checked = true;
                    break;
                case 1:
                    radiobtn_NewCar_Electric.Checked = true;
                    break;
                case 2:
                    radiobtn_NewCar_Hybrid.Checked = true;
                    break;
                default:
                    break;
            }
        }
        public NewCar(int userID)
        {
            // being used as new car (we don't already have carID)
            InitializeComponent();
            newCar = true;
            btn_NewCar_Delete.Hide();
            this.userID = userID;
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

            string name = txt_NewCar_vehicleName.Text;
            string make = txt_NewCar_Make.Text;
            string model = txt_NewCar_Model.Text;
            string year = txt_NewCar_Year.Text;
            string vin = txt_NewCar_VIN.Text;
            int type = 0;
            if (radiobtn_NewCar_Gas.Checked)
            {
                type = 0;
            }
            else if (radiobtn_NewCar_Electric.Checked)
            {
                type = 1;
            }
            else if (radiobtn_NewCar_Hybrid.Checked)
            {
                type = 2;
            }

            if (newCar)
            {
                Random random = new Random();
                float v1 = (float)(random.NextDouble() * 100);
                float v2 = (float)(random.NextDouble() * 100);
                float v3 = (float)(random.NextDouble() * 100);
                float v4 = (float)(random.NextDouble() * 70 + 70);
                carID = dbData.addVehicle(userID, make, model, year, vin, type, 42f, 34f, 45f, 98f, name);

                if (carID == 0)
                {
                    ((ACarThing)this.Parent).loadCarList();
                }
                else
                {
                    ((ACarThing)this.Parent).loadCurrCar(carID);
                }

            }
            else
            {
                dbData.editVehicle(carID, make, model, year, vin, type, name);
                ((ACarThing)this.Parent).loadCurrCar(carID);
            }
        }

        private void btn_NewCar_Delete_Click(object sender, EventArgs e)
        {
            // double checking, but the user shouldn't be in edit car if they are not the owner

            if (dbData.checkOwner(userID, carID))
            {
                dbData.deleteCar(userID);
            }
            else
            {
                MessageBox.Show("Oops something went wrong.");
            }
        }
    }
}

