using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace ATCLauncher
{
    public partial class MainLauncher : Form
    {
        string userEnvPath = Environment.GetEnvironmentVariable("userprofile");
        string vrcDefPath = @"C:\Program Files (x86)\VRC\VRC.exe";
        string vstarsDefPath = @"C:\Program Files (x86)\vSTARS\vSTARS.exe";

        // Cannot give string data here due to using string in same class. Must supply data down in Specific Class for the data call section. 
        string veramDefPath; 
        string vatisDefPath;


        public MainLauncher()
        {
            InitializeComponent();
        }

        private void VRCButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(vrcDefPath))
            {
                Process.Start(vrcDefPath);
            }
            //TODO Need to enter else for using user defined location 
        }

        private void VSTARSButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(vstarsDefPath))
            {
                Process.Start(vstarsDefPath);
            }
        }

        private void VERAMButton_Click(object sender, EventArgs e)
        {
            veramDefPath = (userEnvPath + @"\AppData\Local\vERAM\vERAM.exe");
            
            if (File.Exists(veramDefPath))
            {
                Console.WriteLine("vERAM Path Found, Running.");
                Process.Start(veramDefPath);
            }
            
        }

        private void AFVButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\AudioForVATSIM\AudioForVATSIM.exe"))
            {
                Process.Start(@"C:\AudioForVATSIM\AudioForVATSIM.exe");
            }
        }

        private void VATISButton_Click(object sender, EventArgs e)
        {
            // \AppData\Local\vATIS
            vatisDefPath = (userEnvPath + @"\AppData\Local\vATIS\vATIS.exe");

            if (File.Exists(veramDefPath))
            {
                Console.WriteLine("vATIS Path Found, Running.");
                Process.Start(vatisDefPath);
            }
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
