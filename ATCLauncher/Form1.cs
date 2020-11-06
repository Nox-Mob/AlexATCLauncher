using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCLauncher
{
    public partial class MainLauncher : Form
    {
        public MainLauncher()
        {
            InitializeComponent();
        }

        private void VRCButton_Click(object sender, EventArgs e)
        {

        }

        private void VSTARSButton_Click(object sender, EventArgs e)
        {

        }

        private void VERAMButton_Click(object sender, EventArgs e)
        {

        }

        private void AFVButton_Click(object sender, EventArgs e)
        {

        }

        private void VATISButton_Click(object sender, EventArgs e)
        {

        }

        private void AIRNAVButton_Click(object sender, EventArgs e)
        {
            // Display 
            //
            MessageBox.Show("No valid ICAO Airport entered", "AirNav Website Load Failure",
               MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
