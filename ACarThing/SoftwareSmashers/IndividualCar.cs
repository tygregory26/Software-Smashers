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
