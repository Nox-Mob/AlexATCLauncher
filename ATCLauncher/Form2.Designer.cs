namespace ATCLauncher
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vrcFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.vstars = new System.Windows.Forms.Button();
            this.veramInstallPath = new System.Windows.Forms.Button();
            this.AFVInstallPath = new System.Windows.Forms.Button();
            this.vatisInstallPath = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.vrcInstallPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vrcFolderDialog
            // 
            this.vrcFolderDialog.ShowNewFolderButton = false;
            this.vrcFolderDialog.HelpRequest += new System.EventHandler(this.vrcFolderDialog_HelpRequest);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(118, 112);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(94, 23);
            this.saveAndCloseButton.TabIndex = 3;
            this.saveAndCloseButton.Text = "Save And Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // vstars
            // 
            this.vstars.Location = new System.Drawing.Point(21, 42);
            this.vstars.Name = "vstars";
            this.vstars.Size = new System.Drawing.Size(145, 23);
            this.vstars.TabIndex = 4;
            this.vstars.Text = "Select vSTARS Install Path";
            this.vstars.UseVisualStyleBackColor = true;
            this.vstars.Click += new System.EventHandler(this.vstars_Click);
            // 
            // veramInstallPath
            // 
            this.veramInstallPath.Location = new System.Drawing.Point(21, 72);
            this.veramInstallPath.Name = "veramInstallPath";
            this.veramInstallPath.Size = new System.Drawing.Size(145, 23);
            this.veramInstallPath.TabIndex = 5;
            this.veramInstallPath.Text = "Select vERAM Install Path";
            this.veramInstallPath.UseVisualStyleBackColor = true;
            this.veramInstallPath.Click += new System.EventHandler(this.veramInstallPath_Click);
            // 
            // AFVInstallPath
            // 
            this.AFVInstallPath.Location = new System.Drawing.Point(171, 12);
            this.AFVInstallPath.Name = "AFVInstallPath";
            this.AFVInstallPath.Size = new System.Drawing.Size(145, 23);
            this.AFVInstallPath.TabIndex = 6;
            this.AFVInstallPath.Text = "Select AFV Install Path";
            this.AFVInstallPath.UseVisualStyleBackColor = true;
            this.AFVInstallPath.Click += new System.EventHandler(this.AFVInstallPath_Click);
            // 
            // vatisInstallPath
            // 
            this.vatisInstallPath.Location = new System.Drawing.Point(172, 43);
            this.vatisInstallPath.Name = "vatisInstallPath";
            this.vatisInstallPath.Size = new System.Drawing.Size(145, 23);
            this.vatisInstallPath.TabIndex = 7;
            this.vatisInstallPath.Text = "Select vATIS Install Path";
            this.vatisInstallPath.UseVisualStyleBackColor = true;
            this.vatisInstallPath.Click += new System.EventHandler(this.vatisInstallPath_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(172, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // vrcInstallPath
            // 
            this.vrcInstallPath.Location = new System.Drawing.Point(21, 13);
            this.vrcInstallPath.Name = "vrcInstallPath";
            this.vrcInstallPath.Size = new System.Drawing.Size(144, 23);
            this.vrcInstallPath.TabIndex = 9;
            this.vrcInstallPath.Text = "Select VRC Install Path";
            this.vrcInstallPath.UseVisualStyleBackColor = true;
            this.vrcInstallPath.Click += new System.EventHandler(this.vrcInstallPath_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 160);
            this.Controls.Add(this.vrcInstallPath);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.vatisInstallPath);
            this.Controls.Add(this.AFVInstallPath);
            this.Controls.Add(this.veramInstallPath);
            this.Controls.Add(this.vstars);
            this.Controls.Add(this.saveAndCloseButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog vrcFolderDialog;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button vstars;
        private System.Windows.Forms.Button veramInstallPath;
        private System.Windows.Forms.Button AFVInstallPath;
        private System.Windows.Forms.Button vatisInstallPath;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button vrcInstallPath;
    }
}