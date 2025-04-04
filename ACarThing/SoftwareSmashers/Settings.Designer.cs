namespace SoftwareSmashers
{
    partial class Settings
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
            lbl_Settings_timeZone = new Label();
            combo_Settings_timeZone = new ComboBox();
            lbl_Settings_notifs = new Label();
            combo_Settings_notifs = new ComboBox();
            combo_Settings_lengthUnits = new ComboBox();
            lbl_Settings_lengthUnits = new Label();
            lbl_Settings_volumeUnits = new Label();
            combo_Settings_volumeUnits = new ComboBox();
            lbl_Settings_tempUnits = new Label();
            combo_Settings_tempUnits = new ComboBox();
            btn_Settings_save = new Button();
            btn_Settings_cancel = new Button();
            combo_Settings_timeUnits = new ComboBox();
            lbl_Settings_timeUnits = new Label();
            grp_Settings_settings = new Panel();
            lbl_Settings_title = new Label();
            grp_Settings_settings.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Settings_timeZone
            // 
            lbl_Settings_timeZone.AutoSize = true;
            lbl_Settings_timeZone.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbl_Settings_timeZone.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_timeZone.Location = new Point(60, 160);
            lbl_Settings_timeZone.Name = "lbl_Settings_timeZone";
            lbl_Settings_timeZone.Size = new Size(170, 29);
            lbl_Settings_timeZone.TabIndex = 1;
            lbl_Settings_timeZone.Text = "Time Zone: ";
            // 
            // combo_Settings_timeZone
            // 
            combo_Settings_timeZone.BackColor = Color.FromArgb(227, 225, 232);
            combo_Settings_timeZone.FlatStyle = FlatStyle.Flat;
            combo_Settings_timeZone.ForeColor = Color.FromArgb(37, 30, 56);
            combo_Settings_timeZone.FormattingEnabled = true;
            combo_Settings_timeZone.Items.AddRange(new object[] { "Eastern Time", "Central Time", "Mountain Time", "Pacific Time", "Alaska Time", "Hawaii Time" });
            combo_Settings_timeZone.Location = new Point(374, 160);
            combo_Settings_timeZone.Name = "combo_Settings_timeZone";
            combo_Settings_timeZone.Size = new Size(183, 33);
            combo_Settings_timeZone.TabIndex = 2;
            // 
            // lbl_Settings_notifs
            // 
            lbl_Settings_notifs.AutoSize = true;
            lbl_Settings_notifs.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbl_Settings_notifs.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_notifs.Location = new Point(60, 228);
            lbl_Settings_notifs.Name = "lbl_Settings_notifs";
            lbl_Settings_notifs.Size = new Size(182, 29);
            lbl_Settings_notifs.TabIndex = 3;
            lbl_Settings_notifs.Text = "Notifications";
            // 
            // combo_Settings_notifs
            // 
            combo_Settings_notifs.BackColor = Color.FromArgb(227, 225, 232);
            combo_Settings_notifs.FlatStyle = FlatStyle.Flat;
            combo_Settings_notifs.ForeColor = Color.FromArgb(37, 30, 56);
            combo_Settings_notifs.FormattingEnabled = true;
            combo_Settings_notifs.Items.AddRange(new object[] { "All Notifications", "Important Notifications", "Notifications Off" });
            combo_Settings_notifs.Location = new Point(374, 228);
            combo_Settings_notifs.Name = "combo_Settings_notifs";
            combo_Settings_notifs.Size = new Size(183, 33);
            combo_Settings_notifs.TabIndex = 5;
            // 
            // combo_Settings_lengthUnits
            // 
            combo_Settings_lengthUnits.BackColor = Color.FromArgb(227, 225, 232);
            combo_Settings_lengthUnits.FlatStyle = FlatStyle.Flat;
            combo_Settings_lengthUnits.ForeColor = Color.FromArgb(37, 30, 56);
            combo_Settings_lengthUnits.FormattingEnabled = true;
            combo_Settings_lengthUnits.Items.AddRange(new object[] { "Miles", "Kilometers" });
            combo_Settings_lengthUnits.Location = new Point(374, 305);
            combo_Settings_lengthUnits.Name = "combo_Settings_lengthUnits";
            combo_Settings_lengthUnits.Size = new Size(183, 33);
            combo_Settings_lengthUnits.TabIndex = 6;
            // 
            // lbl_Settings_lengthUnits
            // 
            lbl_Settings_lengthUnits.AutoSize = true;
            lbl_Settings_lengthUnits.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbl_Settings_lengthUnits.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_lengthUnits.Location = new Point(60, 305);
            lbl_Settings_lengthUnits.Name = "lbl_Settings_lengthUnits";
            lbl_Settings_lengthUnits.Size = new Size(183, 29);
            lbl_Settings_lengthUnits.TabIndex = 7;
            lbl_Settings_lengthUnits.Text = "Length Units";
            // 
            // lbl_Settings_volumeUnits
            // 
            lbl_Settings_volumeUnits.AutoSize = true;
            lbl_Settings_volumeUnits.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbl_Settings_volumeUnits.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_volumeUnits.Location = new Point(60, 375);
            lbl_Settings_volumeUnits.Name = "lbl_Settings_volumeUnits";
            lbl_Settings_volumeUnits.Size = new Size(190, 29);
            lbl_Settings_volumeUnits.TabIndex = 8;
            lbl_Settings_volumeUnits.Text = "Volume Units";
            // 
            // combo_Settings_volumeUnits
            // 
            combo_Settings_volumeUnits.BackColor = Color.FromArgb(227, 225, 232);
            combo_Settings_volumeUnits.FlatStyle = FlatStyle.Flat;
            combo_Settings_volumeUnits.ForeColor = Color.FromArgb(37, 30, 56);
            combo_Settings_volumeUnits.FormattingEnabled = true;
            combo_Settings_volumeUnits.Items.AddRange(new object[] { "Gallons", "Liters" });
            combo_Settings_volumeUnits.Location = new Point(374, 375);
            combo_Settings_volumeUnits.Name = "combo_Settings_volumeUnits";
            combo_Settings_volumeUnits.Size = new Size(183, 33);
            combo_Settings_volumeUnits.TabIndex = 9;
            // 
            // lbl_Settings_tempUnits
            // 
            lbl_Settings_tempUnits.AutoSize = true;
            lbl_Settings_tempUnits.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbl_Settings_tempUnits.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_tempUnits.Location = new Point(50, 443);
            lbl_Settings_tempUnits.Name = "lbl_Settings_tempUnits";
            lbl_Settings_tempUnits.Size = new Size(264, 29);
            lbl_Settings_tempUnits.TabIndex = 10;
            lbl_Settings_tempUnits.Text = "Temperature Units";
            // 
            // combo_Settings_tempUnits
            // 
            combo_Settings_tempUnits.BackColor = Color.FromArgb(227, 225, 232);
            combo_Settings_tempUnits.FlatStyle = FlatStyle.Flat;
            combo_Settings_tempUnits.ForeColor = Color.FromArgb(37, 30, 56);
            combo_Settings_tempUnits.FormattingEnabled = true;
            combo_Settings_tempUnits.Items.AddRange(new object[] { "Fahrenheit", "Celsius" });
            combo_Settings_tempUnits.Location = new Point(374, 443);
            combo_Settings_tempUnits.Name = "combo_Settings_tempUnits";
            combo_Settings_tempUnits.Size = new Size(183, 33);
            combo_Settings_tempUnits.TabIndex = 11;
            // 
            // btn_Settings_save
            // 
            btn_Settings_save.BackColor = Color.FromArgb(229, 155, 137);
            btn_Settings_save.FlatAppearance.BorderSize = 0;
            btn_Settings_save.FlatStyle = FlatStyle.Flat;
            btn_Settings_save.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Settings_save.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Settings_save.Location = new Point(677, 720);
            btn_Settings_save.Name = "btn_Settings_save";
            btn_Settings_save.Size = new Size(184, 60);
            btn_Settings_save.TabIndex = 12;
            btn_Settings_save.Text = "Save";
            btn_Settings_save.UseVisualStyleBackColor = false;
            // 
            // btn_Settings_cancel
            // 
            btn_Settings_cancel.BackColor = Color.FromArgb(229, 155, 137);
            btn_Settings_cancel.FlatAppearance.BorderSize = 0;
            btn_Settings_cancel.FlatStyle = FlatStyle.Flat;
            btn_Settings_cancel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Settings_cancel.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Settings_cancel.Location = new Point(409, 720);
            btn_Settings_cancel.Name = "btn_Settings_cancel";
            btn_Settings_cancel.Size = new Size(184, 60);
            btn_Settings_cancel.TabIndex = 13;
            btn_Settings_cancel.Text = "Cancel";
            btn_Settings_cancel.UseVisualStyleBackColor = false;
            // 
            // combo_Settings_timeUnits
            // 
            combo_Settings_timeUnits.BackColor = Color.FromArgb(227, 225, 232);
            combo_Settings_timeUnits.FlatStyle = FlatStyle.Flat;
            combo_Settings_timeUnits.ForeColor = Color.FromArgb(37, 30, 56);
            combo_Settings_timeUnits.FormattingEnabled = true;
            combo_Settings_timeUnits.Items.AddRange(new object[] { "12 hour", "24 hour" });
            combo_Settings_timeUnits.Location = new Point(374, 512);
            combo_Settings_timeUnits.Name = "combo_Settings_timeUnits";
            combo_Settings_timeUnits.Size = new Size(183, 33);
            combo_Settings_timeUnits.TabIndex = 15;
            // 
            // lbl_Settings_timeUnits
            // 
            lbl_Settings_timeUnits.AutoSize = true;
            lbl_Settings_timeUnits.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lbl_Settings_timeUnits.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_timeUnits.Location = new Point(60, 512);
            lbl_Settings_timeUnits.Name = "lbl_Settings_timeUnits";
            lbl_Settings_timeUnits.Size = new Size(155, 29);
            lbl_Settings_timeUnits.TabIndex = 14;
            lbl_Settings_timeUnits.Text = "Time Units";
            // 
            // grp_Settings_settings
            // 
            grp_Settings_settings.BackColor = Color.FromArgb(229, 155, 137);
            grp_Settings_settings.Controls.Add(lbl_Settings_title);
            grp_Settings_settings.Controls.Add(combo_Settings_timeUnits);
            grp_Settings_settings.Controls.Add(lbl_Settings_timeZone);
            grp_Settings_settings.Controls.Add(lbl_Settings_timeUnits);
            grp_Settings_settings.Controls.Add(combo_Settings_timeZone);
            grp_Settings_settings.Controls.Add(lbl_Settings_notifs);
            grp_Settings_settings.Controls.Add(combo_Settings_notifs);
            grp_Settings_settings.Controls.Add(combo_Settings_tempUnits);
            grp_Settings_settings.Controls.Add(combo_Settings_lengthUnits);
            grp_Settings_settings.Controls.Add(lbl_Settings_tempUnits);
            grp_Settings_settings.Controls.Add(lbl_Settings_lengthUnits);
            grp_Settings_settings.Controls.Add(combo_Settings_volumeUnits);
            grp_Settings_settings.Controls.Add(lbl_Settings_volumeUnits);
            grp_Settings_settings.Location = new Point(336, 67);
            grp_Settings_settings.Margin = new Padding(4, 5, 4, 5);
            grp_Settings_settings.Name = "grp_Settings_settings";
            grp_Settings_settings.Size = new Size(600, 615);
            grp_Settings_settings.TabIndex = 16;
            // 
            // lbl_Settings_title
            // 
            lbl_Settings_title.CausesValidation = false;
            lbl_Settings_title.Font = new Font("Verdana", 20F, FontStyle.Bold);
            lbl_Settings_title.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Settings_title.Location = new Point(144, 17);
            lbl_Settings_title.Margin = new Padding(14, 17, 14, 17);
            lbl_Settings_title.Name = "lbl_Settings_title";
            lbl_Settings_title.Padding = new Padding(14, 17, 14, 17);
            lbl_Settings_title.Size = new Size(314, 105);
            lbl_Settings_title.TabIndex = 21;
            lbl_Settings_title.Text = "Settings";
            lbl_Settings_title.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Settings_title.UseWaitCursor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(grp_Settings_settings);
            Controls.Add(btn_Settings_save);
            Controls.Add(btn_Settings_cancel);
            Location = new Point(267, 0);
            Name = "Settings";
            Size = new Size(1264, 843);
            grp_Settings_settings.ResumeLayout(false);
            grp_Settings_settings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Settings_timeZone;
        private ComboBox combo_Settings_timeZone;
        private Label lbl_Settings_notifs;
        private ComboBox combo_Settings_notifs;
        private ComboBox combo_Settings_lengthUnits;
        private Label lbl_Settings_lengthUnits;
        private Label lbl_Settings_volumeUnits;
        private ComboBox combo_Settings_volumeUnits;
        private Label lbl_Settings_tempUnits;
        private ComboBox combo_Settings_tempUnits;
        private Button btn_Settings_save;
        private Button btn_Settings_cancel;
        private ComboBox combo_Settings_timeUnits;
        private Label lbl_Settings_timeUnits;
        private Panel grp_Settings_settings;
        private Label lbl_Settings_title;
    }
}
