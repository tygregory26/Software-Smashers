namespace SoftwareSmashers
{
    partial class IndividualCar
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
            pic_IndCar_car = new PictureBox();
            lbl_IndCar_CarName = new Label();
            btn_IndCar_Start = new Button();
            btn_IndCar_Windows = new Button();
            btn_IndCar_Arm = new Button();
            btn_IndCar_Lock = new Button();
            this.lbl_IndCar_Outside = new Label();
            this.lbl_IndCar_inside = new Label();
            this.lbl_IndCar_Degree2 = new Label();
            lbl_IndCar_Degree1 = new Label();
            lbl_IndCar_InTemp = new Label();
            lbl_IndCar_OutTemp = new Label();
            grp_Temps = new GroupBox();
            pic_IndCar_start = new PictureBox();
            pic_IndCar_window = new PictureBox();
            pic_IndCar_lock = new PictureBox();
            pic_IndCar_Arm = new PictureBox();
            grp_Fuel = new GroupBox();
            lbl_IndCar_percentSymbol = new Label();
            lbl_IndCar_FuelNum = new Label();
            lbl_IndCar_FuelBG = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_car).BeginInit();
            grp_Temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_window).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_lock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_Arm).BeginInit();
            grp_Fuel.SuspendLayout();
            SuspendLayout();
            // 
            // pic_IndCar_car
            // 
            pic_IndCar_car.BackgroundImage = Properties.Resources.software_smashers_noText;
            pic_IndCar_car.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_car.Location = new Point(436, 32);
            pic_IndCar_car.Name = "pic_IndCar_car";
            pic_IndCar_car.Size = new Size(320, 147);
            pic_IndCar_car.TabIndex = 1;
            pic_IndCar_car.TabStop = false;
            // 
            // lbl_IndCar_CarName
            // 
            lbl_IndCar_CarName.BackColor = Color.FromArgb(225, 166, 145);
            lbl_IndCar_CarName.CausesValidation = false;
            lbl_IndCar_CarName.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_CarName.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_CarName.Location = new Point(137, 53);
            lbl_IndCar_CarName.Margin = new Padding(10);
            lbl_IndCar_CarName.Name = "lbl_IndCar_CarName";
            lbl_IndCar_CarName.Padding = new Padding(10);
            lbl_IndCar_CarName.Size = new Size(263, 108);
            lbl_IndCar_CarName.TabIndex = 2;
            lbl_IndCar_CarName.Text = "Car Name";
            lbl_IndCar_CarName.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_CarName.UseWaitCursor = true;
            // 
            // btn_IndCar_Start
            // 
            btn_IndCar_Start.BackColor = Color.FromArgb(225, 166, 145);
            btn_IndCar_Start.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_Start.FlatAppearance.BorderSize = 0;
            btn_IndCar_Start.FlatStyle = FlatStyle.Flat;
            btn_IndCar_Start.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_Start.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_Start.Location = new Point(92, 226);
            btn_IndCar_Start.Name = "btn_IndCar_Start";
            btn_IndCar_Start.Size = new Size(158, 38);
            btn_IndCar_Start.TabIndex = 3;
            btn_IndCar_Start.Text = "Start";
            btn_IndCar_Start.UseVisualStyleBackColor = false;
            btn_IndCar_Start.Click += btn_IndCar_Start_Click;
            // 
            // btn_IndCar_Windows
            // 
            btn_IndCar_Windows.BackColor = Color.FromArgb(225, 166, 145);
            btn_IndCar_Windows.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_Windows.FlatAppearance.BorderSize = 0;
            btn_IndCar_Windows.FlatStyle = FlatStyle.Flat;
            btn_IndCar_Windows.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_Windows.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_Windows.Location = new Point(275, 226);
            btn_IndCar_Windows.Name = "btn_IndCar_Windows";
            btn_IndCar_Windows.Size = new Size(158, 38);
            btn_IndCar_Windows.TabIndex = 4;
            btn_IndCar_Windows.Text = "Windows";
            btn_IndCar_Windows.UseVisualStyleBackColor = false;
            btn_IndCar_Windows.Click += this.btn_IndCar_Windows_Click;
            // 
            // btn_IndCar_Arm
            // 
            btn_IndCar_Arm.BackColor = Color.FromArgb(225, 166, 145);
            btn_IndCar_Arm.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_Arm.FlatAppearance.BorderSize = 0;
            btn_IndCar_Arm.FlatStyle = FlatStyle.Flat;
            btn_IndCar_Arm.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_Arm.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_Arm.Location = new Point(637, 226);
            btn_IndCar_Arm.Name = "btn_IndCar_Arm";
            btn_IndCar_Arm.Size = new Size(158, 38);
            btn_IndCar_Arm.TabIndex = 6;
            btn_IndCar_Arm.Text = "Arm";
            btn_IndCar_Arm.UseVisualStyleBackColor = false;
            btn_IndCar_Arm.Click += this.button1_Click;
            // 
            // btn_IndCar_Lock
            // 
            btn_IndCar_Lock.BackColor = Color.FromArgb(225, 166, 145);
            btn_IndCar_Lock.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_Lock.FlatAppearance.BorderSize = 0;
            btn_IndCar_Lock.FlatStyle = FlatStyle.Flat;
            btn_IndCar_Lock.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_Lock.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_Lock.Location = new Point(454, 226);
            btn_IndCar_Lock.Name = "btn_IndCar_Lock";
            btn_IndCar_Lock.Size = new Size(158, 38);
            btn_IndCar_Lock.TabIndex = 5;
            btn_IndCar_Lock.Text = "Lock";
            btn_IndCar_Lock.UseVisualStyleBackColor = false;
            btn_IndCar_Lock.Click += this.button2_Click;
            // 
            // lbl_IndCar_Outside
            // 
            this.lbl_IndCar_Outside.BackColor = Color.FromArgb(227, 225, 232);
            this.lbl_IndCar_Outside.CausesValidation = false;
            this.lbl_IndCar_Outside.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            this.lbl_IndCar_Outside.ForeColor = Color.FromArgb(37, 30, 56);
            this.lbl_IndCar_Outside.Location = new Point(403, 22);
            this.lbl_IndCar_Outside.Margin = new Padding(10);
            this.lbl_IndCar_Outside.Name = "lbl_IndCar_Outside";
            this.lbl_IndCar_Outside.Padding = new Padding(10);
            this.lbl_IndCar_Outside.Size = new Size(152, 65);
            this.lbl_IndCar_Outside.TabIndex = 9;
            this.lbl_IndCar_Outside.Text = "Outside:";
            this.lbl_IndCar_Outside.TextAlign = ContentAlignment.MiddleLeft;
            this.lbl_IndCar_Outside.UseWaitCursor = true;
            // 
            // lbl_IndCar_inside
            // 
            this.lbl_IndCar_inside.BackColor = Color.FromArgb(227, 225, 232);
            this.lbl_IndCar_inside.CausesValidation = false;
            this.lbl_IndCar_inside.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            this.lbl_IndCar_inside.ForeColor = Color.FromArgb(37, 30, 56);
            this.lbl_IndCar_inside.Location = new Point(79, 22);
            this.lbl_IndCar_inside.Margin = new Padding(10);
            this.lbl_IndCar_inside.Name = "lbl_IndCar_inside";
            this.lbl_IndCar_inside.Padding = new Padding(10);
            this.lbl_IndCar_inside.Size = new Size(130, 65);
            this.lbl_IndCar_inside.TabIndex = 10;
            this.lbl_IndCar_inside.Text = "Inside:";
            this.lbl_IndCar_inside.TextAlign = ContentAlignment.MiddleLeft;
            this.lbl_IndCar_inside.UseWaitCursor = true;
            // 
            // lbl_IndCar_Degree2
            // 
            this.lbl_IndCar_Degree2.BackColor = Color.FromArgb(227, 225, 232);
            this.lbl_IndCar_Degree2.CausesValidation = false;
            this.lbl_IndCar_Degree2.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            this.lbl_IndCar_Degree2.ForeColor = Color.FromArgb(37, 30, 56);
            this.lbl_IndCar_Degree2.Location = new Point(616, 22);
            this.lbl_IndCar_Degree2.Margin = new Padding(10);
            this.lbl_IndCar_Degree2.Name = "lbl_IndCar_Degree2";
            this.lbl_IndCar_Degree2.Padding = new Padding(10);
            this.lbl_IndCar_Degree2.Size = new Size(67, 65);
            this.lbl_IndCar_Degree2.TabIndex = 11;
            this.lbl_IndCar_Degree2.Text = "°F";
            this.lbl_IndCar_Degree2.TextAlign = ContentAlignment.MiddleLeft;
            this.lbl_IndCar_Degree2.UseWaitCursor = true;
            // 
            // lbl_IndCar_Degree1
            // 
            lbl_IndCar_Degree1.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_Degree1.CausesValidation = false;
            lbl_IndCar_Degree1.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_Degree1.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_Degree1.Location = new Point(276, 22);
            lbl_IndCar_Degree1.Margin = new Padding(10);
            lbl_IndCar_Degree1.Name = "lbl_IndCar_Degree1";
            lbl_IndCar_Degree1.Padding = new Padding(10);
            lbl_IndCar_Degree1.Size = new Size(67, 65);
            lbl_IndCar_Degree1.TabIndex = 12;
            lbl_IndCar_Degree1.Text = "°F";
            lbl_IndCar_Degree1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_Degree1.UseWaitCursor = true;
            // 
            // lbl_IndCar_InTemp
            // 
            lbl_IndCar_InTemp.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_InTemp.CausesValidation = false;
            lbl_IndCar_InTemp.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_InTemp.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_InTemp.Location = new Point(183, 22);
            lbl_IndCar_InTemp.Margin = new Padding(10);
            lbl_IndCar_InTemp.Name = "lbl_IndCar_InTemp";
            lbl_IndCar_InTemp.Padding = new Padding(10);
            lbl_IndCar_InTemp.Size = new Size(102, 65);
            lbl_IndCar_InTemp.TabIndex = 13;
            lbl_IndCar_InTemp.Text = "000";
            lbl_IndCar_InTemp.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_InTemp.UseWaitCursor = true;
            lbl_IndCar_InTemp.Click += lbl_IndCar_InTemp_Click;
            // 
            // lbl_IndCar_OutTemp
            // 
            lbl_IndCar_OutTemp.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_OutTemp.CausesValidation = false;
            lbl_IndCar_OutTemp.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_OutTemp.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_OutTemp.Location = new Point(521, 22);
            lbl_IndCar_OutTemp.Margin = new Padding(10);
            lbl_IndCar_OutTemp.Name = "lbl_IndCar_OutTemp";
            lbl_IndCar_OutTemp.Padding = new Padding(10);
            lbl_IndCar_OutTemp.Size = new Size(101, 65);
            lbl_IndCar_OutTemp.TabIndex = 14;
            lbl_IndCar_OutTemp.Text = "000";
            lbl_IndCar_OutTemp.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_OutTemp.UseWaitCursor = true;
            // 
            // grp_Temps
            // 
            grp_Temps.Controls.Add(this.lbl_IndCar_inside);
            grp_Temps.Controls.Add(this.lbl_IndCar_Degree2);
            grp_Temps.Controls.Add(lbl_IndCar_OutTemp);
            grp_Temps.Controls.Add(lbl_IndCar_InTemp);
            grp_Temps.Controls.Add(lbl_IndCar_Degree1);
            grp_Temps.Controls.Add(this.lbl_IndCar_Outside);
            grp_Temps.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_Temps.ForeColor = Color.FromArgb(37, 30, 56);
            grp_Temps.Location = new Point(92, 279);
            grp_Temps.Name = "grp_Temps";
            grp_Temps.Size = new Size(703, 100);
            grp_Temps.TabIndex = 15;
            grp_Temps.TabStop = false;
            grp_Temps.Text = "Temperatures";
            // 
            // pic_IndCar_start
            // 
            pic_IndCar_start.BackgroundImage = Properties.Resources.software_smashers_noText;
            pic_IndCar_start.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_start.Location = new Point(150, 174);
            pic_IndCar_start.Name = "pic_IndCar_start";
            pic_IndCar_start.Size = new Size(48, 46);
            pic_IndCar_start.TabIndex = 16;
            pic_IndCar_start.TabStop = false;
            // 
            // pic_IndCar_window
            // 
            pic_IndCar_window.BackgroundImage = Properties.Resources.software_smashers_noText;
            pic_IndCar_window.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_window.Location = new Point(329, 174);
            pic_IndCar_window.Name = "pic_IndCar_window";
            pic_IndCar_window.Size = new Size(48, 46);
            pic_IndCar_window.TabIndex = 17;
            pic_IndCar_window.TabStop = false;
            // 
            // pic_IndCar_lock
            // 
            pic_IndCar_lock.BackgroundImage = Properties.Resources.software_smashers_noText;
            pic_IndCar_lock.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_lock.Location = new Point(513, 174);
            pic_IndCar_lock.Name = "pic_IndCar_lock";
            pic_IndCar_lock.Size = new Size(48, 46);
            pic_IndCar_lock.TabIndex = 18;
            pic_IndCar_lock.TabStop = false;
            // 
            // pic_IndCar_Arm
            // 
            pic_IndCar_Arm.BackgroundImage = Properties.Resources.software_smashers_noText;
            pic_IndCar_Arm.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_Arm.Location = new Point(708, 174);
            pic_IndCar_Arm.Name = "pic_IndCar_Arm";
            pic_IndCar_Arm.Size = new Size(48, 46);
            pic_IndCar_Arm.TabIndex = 19;
            pic_IndCar_Arm.TabStop = false;
            // 
            // grp_Fuel
            // 
            grp_Fuel.Controls.Add(label1);
            grp_Fuel.Controls.Add(lbl_IndCar_FuelBG);
            grp_Fuel.Controls.Add(lbl_IndCar_FuelNum);
            grp_Fuel.Controls.Add(lbl_IndCar_percentSymbol);
            grp_Fuel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_Fuel.ForeColor = Color.FromArgb(37, 30, 56);
            grp_Fuel.Location = new Point(92, 379);
            grp_Fuel.Name = "grp_Fuel";
            grp_Fuel.Size = new Size(703, 100);
            grp_Fuel.TabIndex = 16;
            grp_Fuel.TabStop = false;
            grp_Fuel.Text = "Fuel Percentage";
            // 
            // lbl_IndCar_percentSymbol
            // 
            lbl_IndCar_percentSymbol.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_percentSymbol.CausesValidation = false;
            lbl_IndCar_percentSymbol.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_percentSymbol.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_percentSymbol.Location = new Point(91, 22);
            lbl_IndCar_percentSymbol.Margin = new Padding(10);
            lbl_IndCar_percentSymbol.Name = "lbl_IndCar_percentSymbol";
            lbl_IndCar_percentSymbol.Padding = new Padding(10);
            lbl_IndCar_percentSymbol.Size = new Size(67, 65);
            lbl_IndCar_percentSymbol.TabIndex = 12;
            lbl_IndCar_percentSymbol.Text = "%";
            lbl_IndCar_percentSymbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_percentSymbol.UseWaitCursor = true;
            lbl_IndCar_percentSymbol.Click += label5_Click;
            // 
            // lbl_IndCar_FuelNum
            // 
            lbl_IndCar_FuelNum.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_FuelNum.CausesValidation = false;
            lbl_IndCar_FuelNum.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_FuelNum.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_FuelNum.Location = new Point(13, 22);
            lbl_IndCar_FuelNum.Margin = new Padding(10);
            lbl_IndCar_FuelNum.Name = "lbl_IndCar_FuelNum";
            lbl_IndCar_FuelNum.Padding = new Padding(10);
            lbl_IndCar_FuelNum.Size = new Size(93, 65);
            lbl_IndCar_FuelNum.TabIndex = 15;
            lbl_IndCar_FuelNum.Text = "000";
            lbl_IndCar_FuelNum.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_FuelNum.UseWaitCursor = true;
            // 
            // lbl_IndCar_FuelBG
            // 
            lbl_IndCar_FuelBG.BackColor = Color.FromArgb(235, 215, 207);
            lbl_IndCar_FuelBG.CausesValidation = false;
            lbl_IndCar_FuelBG.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_FuelBG.Location = new Point(160, 34);
            lbl_IndCar_FuelBG.Margin = new Padding(10);
            lbl_IndCar_FuelBG.Name = "lbl_IndCar_FuelBG";
            lbl_IndCar_FuelBG.Padding = new Padding(10);
            lbl_IndCar_FuelBG.Size = new Size(523, 36);
            lbl_IndCar_FuelBG.TabIndex = 20;
            lbl_IndCar_FuelBG.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_FuelBG.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(225, 166, 145);
            label1.CausesValidation = false;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 34);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(395, 36);
            label1.TabIndex = 21;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // IndividualCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(grp_Fuel);
            Controls.Add(pic_IndCar_Arm);
            Controls.Add(pic_IndCar_lock);
            Controls.Add(pic_IndCar_window);
            Controls.Add(pic_IndCar_start);
            Controls.Add(grp_Temps);
            Controls.Add(btn_IndCar_Arm);
            Controls.Add(btn_IndCar_Lock);
            Controls.Add(btn_IndCar_Windows);
            Controls.Add(btn_IndCar_Start);
            Controls.Add(lbl_IndCar_CarName);
            Controls.Add(pic_IndCar_car);
            Margin = new Padding(2, 2, 2, 2);
            Name = "IndividualCar";
            Size = new Size(885, 506);
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_car).EndInit();
            grp_Temps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_window).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_lock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_Arm).EndInit();
            grp_Fuel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pic_IndCar_car;
        private Label lbl_IndCar_CarName;
        private Button btn_IndCar_Start;
        private Button btn_IndCar_Windows;
        private Button btn_IndCar_Arm;
        private Button btn_IndCar_Lock;
        private Label lbl_IndCar_Inside;
        private Label label1;
        private Label lbl_IndCar_Degree1;
        private Label lbl_IndCar_InTemp;
        private Label lbl_IndCar_OutTemp;
        private GroupBox grp_Temps;
        private PictureBox pic_IndCar_start;
        private PictureBox pic_IndCar_window;
        private PictureBox pic_IndCar_lock;
        private PictureBox pic_IndCar_Arm;
        private GroupBox grp_Fuel;
        private Label lbl_IndCar_FuelNum;
        private Label lbl_IndCar_percentSymbol;
        private Label lbl_IndCar_FuelBG;
    }
}
