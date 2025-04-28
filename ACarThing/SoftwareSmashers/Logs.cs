using MySql.Data.MySqlClient;
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
    public partial class Logs : UserControl
    {
        private int carID;

        public Logs()
        {
            InitializeComponent();
        }
        public Logs(int carID)
        {
            this.carID = carID;
            InitializeComponent();
            dataGrid_Logs_data.DataSource = dbData.viewLogs(carID);
        }

        private void btn_Logs_back_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadCurrCar(carID);
        }
    }
}
