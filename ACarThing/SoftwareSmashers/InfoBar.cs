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
    public partial class InfoBar : UserControl
    {
        public InfoBar()
        {
            InitializeComponent();
            imgNotification.Hide();
            //imgWifi.Hide();
            //imgCelular.Hide();
            //imgBattery.Hide();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("h:mm tt:");
        }
    }
}
