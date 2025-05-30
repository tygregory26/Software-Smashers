﻿namespace SoftwareSmashers
{
    partial class InfoBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoBar));
            imgNotification = new PictureBox();
            imgBattery = new PictureBox();
            imgWifi = new PictureBox();
            imgCelular = new PictureBox();
            lblDate = new Label();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)imgNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBattery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgWifi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCelular).BeginInit();
            SuspendLayout();
            // 
            // imgNotification
            // 
            imgNotification.BackgroundImage = Properties.Resources.software_smashers_noText;
            imgNotification.BackgroundImageLayout = ImageLayout.Zoom;
            imgNotification.Location = new Point(0, 0);
            imgNotification.Name = "imgNotification";
            imgNotification.Size = new Size(50, 50);
            imgNotification.TabIndex = 0;
            imgNotification.TabStop = false;
            // 
            // imgBattery
            // 
            imgBattery.BackgroundImage = (Image)resources.GetObject("imgBattery.BackgroundImage");
            imgBattery.BackgroundImageLayout = ImageLayout.Zoom;
            imgBattery.Location = new Point(1474, 0);
            imgBattery.Name = "imgBattery";
            imgBattery.Size = new Size(50, 50);
            imgBattery.TabIndex = 1;
            imgBattery.TabStop = false;
            // 
            // imgWifi
            // 
            imgWifi.BackgroundImage = (Image)resources.GetObject("imgWifi.BackgroundImage");
            imgWifi.BackgroundImageLayout = ImageLayout.Zoom;
            imgWifi.Location = new Point(1418, 0);
            imgWifi.Name = "imgWifi";
            imgWifi.Size = new Size(50, 50);
            imgWifi.TabIndex = 2;
            imgWifi.TabStop = false;
            // 
            // imgCelular
            // 
            imgCelular.BackgroundImage = (Image)resources.GetObject("imgCelular.BackgroundImage");
            imgCelular.BackgroundImageLayout = ImageLayout.Zoom;
            imgCelular.Location = new Point(1362, 0);
            imgCelular.Name = "imgCelular";
            imgCelular.Size = new Size(50, 50);
            imgCelular.TabIndex = 3;
            imgCelular.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(648, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(224, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Wednesday, April 30, 2025";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(887, 12);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(77, 25);
            lblTime.TabIndex = 5;
            lblTime.Text = "3:54 PM";
            // 
            // InfoBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(imgCelular);
            Controls.Add(imgWifi);
            Controls.Add(imgBattery);
            Controls.Add(imgNotification);
            Name = "InfoBar";
            Size = new Size(1531, 50);
            ((System.ComponentModel.ISupportInitialize)imgNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBattery).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgWifi).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCelular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgNotification;
        private PictureBox imgBattery;
        private PictureBox imgWifi;
        private PictureBox imgCelular;
        private Label lblDate;
        private Label lblTime;
    }
}
