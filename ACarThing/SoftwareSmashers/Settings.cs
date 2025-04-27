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
    public partial class Settings : UserControl
    {
        private int userID;
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(int userID)
        {
            this.userID = userID;
            InitializeComponent();
            combo_Settings_timeZone.Text = dbData.getTimeZone(userID);
            combo_Settings_notifs.Text = dbData.getNotifications(userID);
            combo_Settings_lengthUnits.Text = dbData.getLengthUnits(userID);
            combo_Settings_volumeUnits.Text = dbData.getVolumeUnits(userID);
            combo_Settings_tempUnits.Text = dbData.getTempUnits(userID);
            combo_Settings_timeUnits.Text = dbData.getTimeUnits(userID);
        }

        private void btn_Settings_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((ACarThing)this.Parent).loadMenu(userID);
            return;
        }

        private void btn_Settings_save_Click(object sender, EventArgs e)
        {
            Boolean send = dbData.setSettings(userID, combo_Settings_timeZone.Text, combo_Settings_notifs.Text, combo_Settings_lengthUnits.Text, combo_Settings_volumeUnits.Text, combo_Settings_tempUnits.Text, combo_Settings_timeUnits.Text);
            //if (send)
            //{
            //    this.Hide();
            //    ((ACarThing)this.Parent).loadMenu(userID);
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Error saving settings");
            //}
            this.Hide();
            ((ACarThing)this.Parent).loadMenu(userID);
            return;
        }
    }
}
