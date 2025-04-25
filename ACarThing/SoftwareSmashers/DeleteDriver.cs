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
    public partial class DeleteDriver : UserControl
    {
        private int userID;
        public DeleteDriver()
        {
            InitializeComponent();
        }
        public DeleteDriver(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void btn_DeleteCar_deleteDriver_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_DeleteDriver_email.Text))
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }

        private void btn_DeleteCar_addDriver_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_DeleteDriver_email.Text))
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }

        private void btn_DeleteCar_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
