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

namespace ATCLauncher
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string appdataEnv = Environment.GetEnvironmentVariable("appdata");
		string appdata;

		private void vrcFolderDialog_HelpRequest(object sender, EventArgs e)
		{

		}

		private void saveAndCloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void vrcInstallPath_Click(object sender, EventArgs e)
		{
			string vrcUserPath;
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			vrcUserPath = dialog.SelectedPath;
			Console.WriteLine("User Path was     " + vrcUserPath);
		}

		private void vstars_Click(object sender, EventArgs e)
		{
			string vstarsUserPath;
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			vstarsUserPath = dialog.SelectedPath;
			Console.WriteLine("User Path was     " + vstarsUserPath);
		}

		private void veramInstallPath_Click(object sender, EventArgs e)
		{
			string veramUserPath;
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			veramUserPath = dialog.SelectedPath;
			Console.WriteLine("User Path was     " + veramUserPath);
		}

		private void AFVInstallPath_Click(object sender, EventArgs e)
		{
			string AFVUserPath;
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			AFVUserPath = dialog.SelectedPath;
			Console.WriteLine("User Path was     " + AFVUserPath);
		}

		private async void vatisInstallPath_Click(object sender, EventArgs e)
		{
			appdata = (appdataEnv + @"\ATCLauncher\");
			string vatisUserPath;
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			vatisUserPath = dialog.SelectedPath;
			Console.WriteLine("User Path was     " + vatisUserPath);

			//! below was an attempt ot write to a file in roaming app data. need to get this to work without exceptions. perhaps we need to try a different method, and use an async class here? 
			UnicodeEncoding uniencoding = new UnicodeEncoding();
			string dirOut = (@Path.Combine(directory, "ATCLauncher", "vATISSettings.txt"));
			byte[] result = uniencoding.GetBytes(vatisUserPath);

			if (File.Exists(dirOut))
			{
				File.Delete(dirOut);
			}
			else
            {
				FileInfo file = new FileInfo(dirOut);
				file.Directory.Create();
            }

			using (FileStream SourceStream = File.Open(dirOut, FileMode.OpenOrCreate))
			{
				SourceStream.Seek(0, SeekOrigin.End);
				await SourceStream.WriteAsync(result, 0, result.Length);
			}




			/* try
			 {
				 if (File.Exists(Path.Combine(directory, "ATCLauncher", "vATISSettings.txt"))
				 { 
				 File.Delete(Path.Combine(directory, "ATCLauncher", "vATISSettings.txt"));
				 }
				 using (FileStream fs = File.Create(Path.Combine(directory, "ATCLauncher", "vATISSettings.txt")))
				 {
					 AddText(fs, vatisUserPath);
					 for (int i = 1; i < 120; i++)
					 {
						 AddText(fs, Convert.ToChar(i).ToString());
					 }
				 }
			 }
			 catch (DirectoryNotFoundException dirEX)
			 {
				 Console.WriteLine("An Error Has Occured with Writing to " + dirEX);
			 }
			*/
		}

		private static void AddText(FileStream fs, string value)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(value);
			fs.Write(info, 0, info.Length);
		}
	}
}
