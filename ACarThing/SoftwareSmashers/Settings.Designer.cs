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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label6 = new Label();
            comboBox5 = new ComboBox();
            btnSaveSettings = new Button();
            btnCancelSettings = new Button();
            comboBox6 = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(632, 85);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 204);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Time Zone: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eastern Time", "Central Time", "Mountain Time", "Pacific Time", "Alaska Time", "Hawaii Time" });
            comboBox1.Location = new Point(689, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 273);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 3;
            label3.Text = "Notifications";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All Notifications", "Important Notifications", "Notifications Off" });
            comboBox2.Location = new Point(689, 265);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Miles", "Kilometers" });
            comboBox3.Location = new Point(689, 342);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 350);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 7;
            label4.Text = "Length Units";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 420);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 8;
            label5.Text = "Volume Units";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Gallons", "Liters" });
            comboBox4.Location = new Point(689, 412);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(516, 498);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 10;
            label6.Text = "Temperature Units";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Fahrenheit", "Celsius" });
            comboBox5.Location = new Point(689, 495);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(182, 33);
            comboBox5.TabIndex = 11;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(725, 656);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(112, 34);
            btnSaveSettings.TabIndex = 12;
            btnSaveSettings.Text = "Save";
            btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // btnCancelSettings
            // 
            btnCancelSettings.Location = new Point(559, 656);
            btnCancelSettings.Name = "btnCancelSettings";
            btnCancelSettings.Size = new Size(112, 34);
            btnCancelSettings.TabIndex = 13;
            btnCancelSettings.Text = "Cancel";
            btnCancelSettings.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "12 hour", "24 hour" });
            comboBox6.Location = new Point(689, 553);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(182, 33);
            comboBox6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(516, 556);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 14;
            label7.Text = "Time Units";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox6);
            Controls.Add(label7);
            Controls.Add(btnCancelSettings);
            Controls.Add(btnSaveSettings);
            Controls.Add(comboBox5);
            Controls.Add(label6);
            Controls.Add(comboBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Settings";
            Size = new Size(1264, 844);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox4;
        private Label label6;
        private ComboBox comboBox5;
        private Button btnSaveSettings;
        private Button btnCancelSettings;
        private ComboBox comboBox6;
        private Label label7;
    }
}
