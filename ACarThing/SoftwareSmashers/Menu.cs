using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace SoftwareSmashers
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        // Opening Settings
        private void button1_Click(object sender, EventArgs e)
        {
            ((ACarThing)this.Parent).loadSettings();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
