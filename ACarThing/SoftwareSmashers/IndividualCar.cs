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

            if (dbData.checkOwner(userID, carID))
            {
                btn_IndCar_EditVehicle.Show();
                btn_IndCar_EditDriver.Show();
            }
            else
            {
                btn_IndCar_EditVehicle.Hide();
                btn_IndCar_EditDriver.Hide();
            }

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

            if (dbData.getCarArmStatus(carID))
            {
                pic_IndCar_armed.Show();
                pic_IndCar_Unarmed.Hide();
            }
            else
            {
                pic_IndCar_armed.Hide();
                pic_IndCar_Unarmed.Show();
            }

            if (dbData.getCarLockStatus(carID))
            {
                pic_IndCar_locked.Show();
                pic_IndCar_unlocked.Hide();
            }
            else
            {
                pic_IndCar_locked.Hide();
                pic_IndCar_unlocked.Show();
            }

            if (dbData.getCarWindowStatus(carID))
            {
                pic_IndCar_windowUp.Show();
                pic_IndCar_windowDown.Hide();
            }
            else
            {
                pic_IndCar_windowUp.Hide();
                pic_IndCar_windowDown.Show();
            }

            if (dbData.getCarStartStatus(carID))
            {
                pic_IndCar_started.Show();
                pic_IndCar_stopped.Hide();
            }
            else
            {
                pic_IndCar_started.Hide();
                pic_IndCar_stopped.Show();
            }
        }

        private void btn_IndCar_start_Click(object sender, EventArgs e)
        {
            dbData.swapStartCar(carID);

            if (dbData.getCarStartStatus(carID))
            {
                pic_IndCar_started.Show();
                pic_IndCar_stopped.Hide();
            }
            else
            {
                pic_IndCar_started.Hide();
                pic_IndCar_stopped.Show();
            }
        }

        private void btn_IndCar_windows_Click(object sender, EventArgs e)
        {
            dbData.swapWindow(carID);

            if (dbData.getCarWindowStatus(carID))
            {
                pic_IndCar_windowUp.Show();
                pic_IndCar_windowDown.Hide();
            }
            else
            {
                pic_IndCar_windowUp.Hide();
                pic_IndCar_windowDown.Show();
            }
        }

        private void btn_IndCar_arm_Click(object sender, EventArgs e)
        {
            dbData.swapArm(carID);

            if (dbData.getCarArmStatus(carID))
            {
                pic_IndCar_armed.Show();
                pic_IndCar_Unarmed.Hide();
            }
            else
            {
                pic_IndCar_armed.Hide();
                pic_IndCar_Unarmed.Show();
            }
        }

        private void btn_IndCar_lock_Click(object sender, EventArgs e)
        {
            dbData.swapLock(carID);

            if (dbData.getCarLockStatus(carID))
            {
                pic_IndCar_locked.Show();
                pic_IndCar_unlocked.Hide();
            }
            else
            {
                pic_IndCar_locked.Hide();
                pic_IndCar_unlocked.Show();
            }
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
            ((ACarThing)this.Parent).loadDeleteDriver(carID);
        }

        private void btn_IndCar_ViewActivity_Click(object sender, EventArgs e)
        {

            ((ACarThing)this.Parent).loadLogs(carID);
        }
    }
}
