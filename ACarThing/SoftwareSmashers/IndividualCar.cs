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

        public IndividualCar()
        {
            InitializeComponent();
        }
        public IndividualCar(int userID, int carID)
        {
            InitializeComponent();
            this.userID = userID;
            this.carID = carID;

            this.lbl_IndCar_carName.Text = dbData.getCarName(carID);

            int carType = dbData.getCarType(carID);
            switch (carType)
            {
                case 0:
                    // gas type is fuel
                    // remove bottom fuel percent and set top one to correct type
                    break;
                case 1:
                    // gas type is electric
                    // remove bottom fuel percent and set top one to correct type
                    break;
                case 2:
                    // gas type is hybrid
                    // keep both fuel percents and set them
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

    }
}
