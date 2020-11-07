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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string vrcUserPath;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            vrcUserPath = dialog.SelectedPath;
            Console.WriteLine("User Path was     " + vrcUserPath);
        }

        private void vrcFolderDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
