﻿namespace ATCLauncher
{
    partial class MainLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLauncher));
            this.VRCButton = new System.Windows.Forms.Button();
            this.VSTARSButton = new System.Windows.Forms.Button();
            this.VERAMButton = new System.Windows.Forms.Button();
            this.AFVButton = new System.Windows.Forms.Button();
            this.VATISButton = new System.Windows.Forms.Button();
            this.AIRNAVButton = new System.Windows.Forms.Button();
            this.airnavTextBox = new System.Windows.Forms.TextBox();
            this.ICAOLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VRCButton
            // 
            this.VRCButton.Location = new System.Drawing.Point(12, 13);
            this.VRCButton.Name = "VRCButton";
            this.VRCButton.Size = new System.Drawing.Size(120, 23);
            this.VRCButton.TabIndex = 0;
            this.VRCButton.Text = "VRC";
            this.VRCButton.UseVisualStyleBackColor = true;
            this.VRCButton.Click += new System.EventHandler(this.VRCButton_Click);
            // 
            // VSTARSButton
            // 
            this.VSTARSButton.Location = new System.Drawing.Point(12, 42);
            this.VSTARSButton.Name = "VSTARSButton";
            this.VSTARSButton.Size = new System.Drawing.Size(120, 23);
            this.VSTARSButton.TabIndex = 1;
            this.VSTARSButton.Text = "vSTARS";
            this.VSTARSButton.UseVisualStyleBackColor = true;
            this.VSTARSButton.Click += new System.EventHandler(this.VSTARSButton_Click);
            // 
            // VERAMButton
            // 
            this.VERAMButton.Location = new System.Drawing.Point(12, 71);
            this.VERAMButton.Name = "VERAMButton";
            this.VERAMButton.Size = new System.Drawing.Size(120, 23);
            this.VERAMButton.TabIndex = 2;
            this.VERAMButton.Text = "vERAM";
            this.VERAMButton.UseVisualStyleBackColor = true;
            this.VERAMButton.Click += new System.EventHandler(this.VERAMButton_Click);
            // 
            // AFVButton
            // 
            this.AFVButton.Location = new System.Drawing.Point(152, 12);
            this.AFVButton.Name = "AFVButton";
            this.AFVButton.Size = new System.Drawing.Size(120, 23);
            this.AFVButton.TabIndex = 3;
            this.AFVButton.Text = "AFV";
            this.AFVButton.UseVisualStyleBackColor = true;
            this.AFVButton.Click += new System.EventHandler(this.AFVButton_Click);
            // 
            // VATISButton
            // 
            this.VATISButton.Location = new System.Drawing.Point(152, 42);
            this.VATISButton.Name = "VATISButton";
            this.VATISButton.Size = new System.Drawing.Size(120, 23);
            this.VATISButton.TabIndex = 4;
            this.VATISButton.Text = "vATIS";
            this.VATISButton.UseVisualStyleBackColor = true;
            this.VATISButton.Click += new System.EventHandler(this.VATISButton_Click);
            // 
            // AIRNAVButton
            // 
            this.AIRNAVButton.Location = new System.Drawing.Point(152, 71);
            this.AIRNAVButton.Name = "AIRNAVButton";
            this.AIRNAVButton.Size = new System.Drawing.Size(120, 23);
            this.AIRNAVButton.TabIndex = 5;
            this.AIRNAVButton.Text = "AirNav";
            this.AIRNAVButton.UseVisualStyleBackColor = true;
            this.AIRNAVButton.Click += new System.EventHandler(this.AIRNAVButton_Click);
            // 
            // airnavTextBox
            // 
            this.airnavTextBox.Location = new System.Drawing.Point(210, 112);
            this.airnavTextBox.MaxLength = 4;
            this.airnavTextBox.Name = "airnavTextBox";
            this.airnavTextBox.Size = new System.Drawing.Size(62, 20);
            this.airnavTextBox.TabIndex = 6;
            this.airnavTextBox.TextChanged += new System.EventHandler(this.airnavTextBox_TextChanged);
            // 
            // ICAOLabel
            // 
            this.ICAOLabel.AutoSize = true;
            this.ICAOLabel.Location = new System.Drawing.Point(111, 115);
            this.ICAOLabel.Name = "ICAOLabel";
            this.ICAOLabel.Size = new System.Drawing.Size(93, 13);
            this.ICAOLabel.TabIndex = 7;
            this.ICAOLabel.Text = "Airport ICAO Code";
            this.ICAOLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ICAOLabel);
            this.Controls.Add(this.airnavTextBox);
            this.Controls.Add(this.AIRNAVButton);
            this.Controls.Add(this.VATISButton);
            this.Controls.Add(this.AFVButton);
            this.Controls.Add(this.VERAMButton);
            this.Controls.Add(this.VSTARSButton);
            this.Controls.Add(this.VRCButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLauncher";
            this.Text = "vZDV Quick Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VRCButton;
        private System.Windows.Forms.Button VSTARSButton;
        private System.Windows.Forms.Button VERAMButton;
        private System.Windows.Forms.Button AFVButton;
        private System.Windows.Forms.Button VATISButton;
        private System.Windows.Forms.Button AIRNAVButton;
        private System.Windows.Forms.TextBox airnavTextBox;
        private System.Windows.Forms.Label ICAOLabel;
        private System.Windows.Forms.Button button1;
    }
}

