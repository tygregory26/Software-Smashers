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
    public partial class IndividualCar : UserControl
    {
        private int userID;
        private int carID;
        private float fuelpercent1;
        private float fuelpercent2;
        private float fuelwidth = 747f;

        public IndividualCar()
        {
            InitializeComponent();
        }
        public IndividualCar(int userID, int carID)
        {
            InitializeComponent();
            //btn_IndCar_Edit.Hide();
            //btn_IndCar_EditDriver.Hide();

            this.userID = userID;
            this.carID = carID;

            this.lbl_IndCar_carName.Text = dbData.getCarName(carID);

            int carType = dbData.getCarType(carID);

            lbl_IndCar_carName.Text = dbData.getCarName(carID);


            switch (carType)
            {
                case 0:
                    // gas type is fuel
                    // remove bottom fuel percent and set top one to correct type
                    this.fuelpercent1 = dbData.getCarFuel(carID);
                    grp_IndCar_primaryFuel.Text = "Gas Percentage";
                    lbl_IndCar_primaryPercent.Text = "%";
                    lbl_IndCar_primaryFuelNum.Text = (Math.Round(fuelpercent1, 2)).ToString();
                    grp_IndCar_secondaryFuel.Hide();
                    lbl_IndCar_primaryFG.Width = (int)Math.Round(fuelwidth * fuelpercent1);
                    break;
                case 1:
                    // gas type is electric
                    // remove bottom fuel percent and set top one to correct type
                    this.fuelpercent1 = dbData.getCarBattery(carID);
                    grp_IndCar_primaryFuel.Text = "Battery Percentage";
                    lbl_IndCar_primaryPercent.Text = "%";
                    lbl_IndCar_primaryFuelNum.Text = (Math.Round(fuelpercent1, 2)).ToString();
                    grp_IndCar_secondaryFuel.Hide();
                    lbl_IndCar_primaryFG.Width = (int)Math.Round(fuelwidth * fuelpercent1);
                    break;
                case 2:
                    // gas type is hybrid
                    // keep both fuel percents and set them
                    this.fuelpercent1 = dbData.getCarFuel(carID);
                    this.fuelpercent2 = dbData.getCarBattery(carID);
                    grp_IndCar_primaryFuel.Text = "Fuel Percentages";
                    lbl_IndCar_primaryPercent.Text = "%";
                    lbl_IndCar_primaryFuelNum.Text = (Math.Round(fuelpercent1, 2)).ToString();
                    lbl_IndCar_secondaryPercent.Text = "%";
                    lbl_IndCar_secondaryFuelNum.Text = (Math.Round(fuelpercent2, 2)).ToString();
                    grp_IndCar_secondaryFuel.Show();
                    lbl_IndCar_primaryFG.Width = (int)Math.Round(fuelwidth * fuelpercent1);
                    lbl_IndCar_secondaryFG.Width = (int)Math.Round(fuelwidth * fuelpercent2);
                    break;
                default:
                    // error message?
                    break;
            }
        }

        private void btn_IndCar_start_Click(object sender, EventArgs e)
        {

        }

        private void btn_IndCar_windows_Click(object sender, EventArgs e)
        {

        }

        private void btn_IndCar_arm_Click(object sender, EventArgs e)
        {

        }

        private void btn_IndCar_lock_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dbData.checkOwner(userID, carID))
            {
                ((ACarThing)this.Parent).loadEditCar(carID);
            }
        }

        private void btn_IndCar_EditDriver_Click(object sender, EventArgs e)
        {

        }

        private void pic_IndCar_locked_Click(object sender, EventArgs e)
        {

        }
    }
}
