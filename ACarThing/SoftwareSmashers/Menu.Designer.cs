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
            btn_Menu_Settings = new Button();
            btn_Menu_MyCars = new Button();
            pictureBox1 = new PictureBox();
            btn_Menu_Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Menu_Settings
            // 
            btn_Menu_Settings.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_Settings.FlatAppearance.BorderSize = 3;
            btn_Menu_Settings.FlatStyle = FlatStyle.Flat;
            btn_Menu_Settings.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Menu_Settings.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_Settings.Location = new Point(0, 147);
            btn_Menu_Settings.Margin = new Padding(2, 2, 2, 2);
            btn_Menu_Settings.Name = "btn_Menu_Settings";
            btn_Menu_Settings.Size = new Size(187, 51);
            btn_Menu_Settings.TabIndex = 0;
            btn_Menu_Settings.Text = "Welcome, Name";
            btn_Menu_Settings.UseVisualStyleBackColor = true;
            btn_Menu_Settings.Click += button1_Click;
            // 
            // btn_Menu_MyCars
            // 
            btn_Menu_MyCars.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_MyCars.FlatAppearance.BorderSize = 3;
            btn_Menu_MyCars.FlatStyle = FlatStyle.Flat;
            btn_Menu_MyCars.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Menu_MyCars.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_MyCars.Location = new Point(0, 197);
            btn_Menu_MyCars.Margin = new Padding(2, 2, 2, 2);
            btn_Menu_MyCars.Name = "btn_Menu_MyCars";
            btn_Menu_MyCars.Size = new Size(187, 51);
            btn_Menu_MyCars.TabIndex = 1;
            btn_Menu_MyCars.Text = "My Cars";
            btn_Menu_MyCars.UseVisualStyleBackColor = true;
            btn_Menu_MyCars.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.software_smashers_noText;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_Menu_Logout
            // 
            btn_Menu_Logout.FlatAppearance.BorderColor = Color.FromArgb(197, 120, 112);
            btn_Menu_Logout.FlatAppearance.BorderSize = 3;
            btn_Menu_Logout.FlatStyle = FlatStyle.Flat;
            btn_Menu_Logout.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btn_Menu_Logout.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Menu_Logout.Location = new Point(34, 437);
            btn_Menu_Logout.Margin = new Padding(2);
            btn_Menu_Logout.Name = "btn_Menu_Logout";
            btn_Menu_Logout.Size = new Size(118, 51);
            btn_Menu_Logout.TabIndex = 6;
            btn_Menu_Logout.Text = "Log Out";
            btn_Menu_Logout.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 166, 145);
            Controls.Add(btn_Menu_Logout);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Menu_MyCars);
            Controls.Add(btn_Menu_Settings);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Menu";
            Size = new Size(187, 506);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Menu_Settings;
        private Button btn_Menu_MyCars;
        private PictureBox pictureBox1;
        private Button btn_Menu_Logout;
    }
}
