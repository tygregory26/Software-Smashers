namespace SoftwareSmashers
{
    partial class Menu
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
            btn_Menu_settings = new Button();
            btn_Menu_myVehicles = new Button();
            pic_Menu_logo = new PictureBox();
            btn_Menu_logout = new Button();
            btn_Menu_viewLogs = new Button();
            btn_Menu_editVehicle = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Menu_logo).BeginInit();
            SuspendLayout();
            // 
            // btn_Menu_settings
            // 
            btn_Menu_settings.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_settings.FlatAppearance.BorderSize = 3;
            btn_Menu_settings.FlatStyle = FlatStyle.Flat;
            btn_Menu_settings.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Menu_settings.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_settings.Location = new Point(0, 245);
            btn_Menu_settings.Name = "btn_Menu_settings";
            btn_Menu_settings.Size = new Size(267, 85);
            btn_Menu_settings.TabIndex = 0;
            btn_Menu_settings.Text = "Welcome, Name";
            btn_Menu_settings.UseVisualStyleBackColor = true;
            btn_Menu_settings.Click += button1_Click;
            // 
            // btn_Menu_myVehicles
            // 
            btn_Menu_myVehicles.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_myVehicles.FlatAppearance.BorderSize = 3;
            btn_Menu_myVehicles.FlatStyle = FlatStyle.Flat;
            btn_Menu_myVehicles.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Menu_myVehicles.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_myVehicles.Location = new Point(0, 327);
            btn_Menu_myVehicles.Name = "btn_Menu_myVehicles";
            btn_Menu_myVehicles.Size = new Size(267, 85);
            btn_Menu_myVehicles.TabIndex = 1;
            btn_Menu_myVehicles.Text = "My Vehicles";
            btn_Menu_myVehicles.UseVisualStyleBackColor = true;
            btn_Menu_myVehicles.Click += button2_Click;
            // 
            // pic_Menu_logo
            // 
            pic_Menu_logo.Image = Properties.Resources.software_smashers_noText;
            pic_Menu_logo.Location = new Point(3, 0);
            pic_Menu_logo.Name = "pic_Menu_logo";
            pic_Menu_logo.Size = new Size(261, 238);
            pic_Menu_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Menu_logo.TabIndex = 5;
            pic_Menu_logo.TabStop = false;
            // 
            // btn_Menu_logout
            // 
            btn_Menu_logout.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_logout.FlatAppearance.BorderSize = 3;
            btn_Menu_logout.FlatStyle = FlatStyle.Flat;
            btn_Menu_logout.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btn_Menu_logout.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_logout.Location = new Point(49, 728);
            btn_Menu_logout.Name = "btn_Menu_logout";
            btn_Menu_logout.Size = new Size(169, 85);
            btn_Menu_logout.TabIndex = 6;
            btn_Menu_logout.Text = "Log Out";
            btn_Menu_logout.UseVisualStyleBackColor = true;
            btn_Menu_logout.Click += btn_Menu_logout_Click;
            // 
            // btn_Menu_viewLogs
            // 
            btn_Menu_viewLogs.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_viewLogs.FlatAppearance.BorderSize = 3;
            btn_Menu_viewLogs.FlatStyle = FlatStyle.Flat;
            btn_Menu_viewLogs.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Menu_viewLogs.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_viewLogs.Location = new Point(0, 408);
            btn_Menu_viewLogs.Name = "btn_Menu_viewLogs";
            btn_Menu_viewLogs.Size = new Size(267, 85);
            btn_Menu_viewLogs.TabIndex = 7;
            btn_Menu_viewLogs.Text = "Activity";
            btn_Menu_viewLogs.UseVisualStyleBackColor = true;
            btn_Menu_viewLogs.Click += btn_Menu_viewLogs_Click;
            // 
            // btn_Menu_editVehicle
            // 
            btn_Menu_editVehicle.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_editVehicle.FlatAppearance.BorderSize = 3;
            btn_Menu_editVehicle.FlatStyle = FlatStyle.Flat;
            btn_Menu_editVehicle.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Menu_editVehicle.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_editVehicle.Location = new Point(0, 490);
            btn_Menu_editVehicle.Name = "btn_Menu_editVehicle";
            btn_Menu_editVehicle.Size = new Size(267, 85);
            btn_Menu_editVehicle.TabIndex = 8;
            btn_Menu_editVehicle.Text = "Edit Vehicle";
            btn_Menu_editVehicle.UseVisualStyleBackColor = true;
            btn_Menu_editVehicle.Click += btn_Menu_editVehicle_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 155, 137);
            Controls.Add(btn_Menu_editVehicle);
            Controls.Add(btn_Menu_viewLogs);
            Controls.Add(btn_Menu_logout);
            Controls.Add(pic_Menu_logo);
            Controls.Add(btn_Menu_myVehicles);
            Controls.Add(btn_Menu_settings);
            Name = "Menu";
            Size = new Size(267, 843);
            ((System.ComponentModel.ISupportInitialize)pic_Menu_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Menu_settings;
        private Button btn_Menu_myVehicles;
        private PictureBox pic_Menu_logo;
        private Button btn_Menu_logout;
        private Button btn_Menu_viewLogs;
        private Button btn_Menu_editVehicle;

        public Button Btn_Menu_viewLogs { get => btn_Menu_viewLogs; set => btn_Menu_viewLogs = value; }
        public Button Btn_Menu_editVehicle { get => btn_Menu_editVehicle; set => btn_Menu_editVehicle = value; }
    }
}
