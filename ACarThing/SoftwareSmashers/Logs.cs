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
        public Logs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_Logs_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Logs_Load(object sender, EventArgs e)
        {
            dataGrid_Logs_data.DataSource = dbData.viewLogs();
        }
    }
}
