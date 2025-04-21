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
    public partial class MyCars : UserControl
    {
        private int userID;
        public static DataGridView carsData = new DataGridView();

        public MyCars(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void MyCars_Load(object sender, EventArgs e)
        {
            carsData = dataGrid_MyCars_CarsView;
            carsData.DataSource = dbData.listVehicles(userID);
        }

        private void btn_MyCars_selectVehicle_Click(object sender, EventArgs e)
        {
            //Check if txt box contains a car that userID is a driver for
            //load IndividualCar page with carID
            //((ACarThing)this.Parent).loadMenu(true);
            this.Hide();
        }
    }
}
