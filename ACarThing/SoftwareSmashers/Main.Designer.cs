namespace SoftwareSmashers
{
    partial class ACarThing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu1 = new Menu();
            myCars1 = new MyCars();
            individualCar1 = new IndividualCar();
            settings1 = new Settings();
            login1 = new Login();
            newUser1 = new NewUser();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.BackColor = Color.FromArgb(229, 155, 137);
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(267, 844);
            menu1.TabIndex = 0;
            // 
            // myCars1
            // 
            myCars1.BackColor = Color.FromArgb(227, 225, 232);
            myCars1.Location = new Point(267, 0);
            myCars1.Name = "myCars1";
            myCars1.Size = new Size(1264, 844);
            myCars1.TabIndex = 1;
            // 
            // individualCar1
            // 
            individualCar1.BackColor = Color.FromArgb(227, 225, 232);
            individualCar1.Location = new Point(267, 0);
            individualCar1.Name = "individualCar1";
            individualCar1.Size = new Size(1264, 844);
            individualCar1.TabIndex = 2;
            // 
            // settings1
            // 
            settings1.Location = new Point(267, 0);
            settings1.Name = "settings1";
            settings1.Size = new Size(1264, 844);
            settings1.TabIndex = 3;
            // 
            // login1
            // 
            login1.BackColor = Color.FromArgb(227, 225, 232);
            login1.Location = new Point(0, 0);
            login1.Name = "login1";
            login1.Size = new Size(1531, 844);
            login1.TabIndex = 4;
            // 
            // newUser1
            // 
            newUser1.BackColor = Color.FromArgb(227, 225, 232);
            newUser1.Location = new Point(0, 0);
            newUser1.Name = "newUser1";
            newUser1.Size = new Size(1531, 844);
            newUser1.TabIndex = 5;
            // 
            // ACarThing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 842);
            Controls.Add(menu1);
            Controls.Add(settings1);
            Controls.Add(individualCar1);
            Controls.Add(myCars1);
            Controls.Add(newUser1);
            Controls.Add(login1);
            ForeColor = SystemColors.ControlText;
            Name = "ACarThing";
            Text = "Software Smashers";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private MyCars myCars1;
        private IndividualCar individualCar1;
        private Settings settings1;
        private Login login1;
        private NewUser newUser1;
    }
}
