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
        public MyCars()
        {
            InitializeComponent();
        }

        private void MyCars_Load(object sender, EventArgs e)
        {

        }

        private void btn_MyCars_selectVehicle_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadMenu(true);
            this.Hide();
        }
    }
}
