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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualCar));
            pic_IndCar_car = new PictureBox();
            lbl_IndCar_carName = new Label();
            btn_IndCar_start = new Button();
            btn_IndCar_windows = new Button();
            btn_IndCar_arm = new Button();
            btn_IndCar_lock = new Button();
            lbl_IndCar_outside = new Label();
            lbl_IndCar_inside = new Label();
            lbl_IndCar_degree2 = new Label();
            lbl_IndCar_degree1 = new Label();
            lbl_IndCar_inTemp = new Label();
            lbl_IndCar_outTemp = new Label();
            grp_IndCar_temps = new GroupBox();
            pic_IndCar_started = new PictureBox();
            pic_IndCar_windowUp = new PictureBox();
            pic_IndCar_unlocked = new PictureBox();
            pic_IndCar_armed = new PictureBox();
            grp_IndCar_primaryFuel = new GroupBox();
            lbl_IndCar_primaryFG = new Label();
            lbl_IndCar_primaryBG = new Label();
            lbl_IndCar_primaryFuelNum = new Label();
            lbl_IndCar_primaryPercent = new Label();
            pic_IndCar_carTypeGas = new PictureBox();
            grp_IndCar_secondaryFuel = new Panel();
            lbl_IndCar_secondaryFuelNum = new Label();
            lbl_IndCar_secondaryPercent = new Label();
            lbl_IndCar_secondaryFG = new Label();
            lbl_IndCar_secondaryBG = new Label();
            btn_IndCar_EditVehicle = new Button();
            btn_IndCar_EditDriver = new Button();
            btn_IndCar_ViewActivity = new Button();
            pic_IndCar_stopped = new PictureBox();
            pic_IndCar_windowDown = new PictureBox();
            pic_IndCar_locked = new PictureBox();
            pic_IndCar_carTypeElectric = new PictureBox();
            pic_IndCar_Unarmed = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_car).BeginInit();
            grp_IndCar_temps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_started).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_windowUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_unlocked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_armed).BeginInit();
            grp_IndCar_primaryFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_carTypeGas).BeginInit();
            grp_IndCar_secondaryFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_stopped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_windowDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_locked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_carTypeElectric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_Unarmed).BeginInit();
            SuspendLayout();
            // 
            // pic_IndCar_car
            // 
            pic_IndCar_car.BackgroundImage = (Image)resources.GetObject("pic_IndCar_car.BackgroundImage");
            pic_IndCar_car.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_car.Location = new Point(503, 30);
            pic_IndCar_car.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_car.Name = "pic_IndCar_car";
            pic_IndCar_car.Size = new Size(457, 245);
            pic_IndCar_car.TabIndex = 1;
            pic_IndCar_car.TabStop = false;
            // 
            // lbl_IndCar_carName
            // 
            lbl_IndCar_carName.BackColor = Color.FromArgb(229, 155, 137);
            lbl_IndCar_carName.CausesValidation = false;
            lbl_IndCar_carName.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_carName.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_carName.Location = new Point(76, 65);
            lbl_IndCar_carName.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_carName.Name = "lbl_IndCar_carName";
            lbl_IndCar_carName.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_carName.Size = new Size(376, 180);
            lbl_IndCar_carName.TabIndex = 2;
            lbl_IndCar_carName.Text = "Car Name";
            lbl_IndCar_carName.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_carName.UseWaitCursor = true;
            // 
            // btn_IndCar_start
            // 
            btn_IndCar_start.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_start.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_start.FlatAppearance.BorderSize = 0;
            btn_IndCar_start.FlatStyle = FlatStyle.Flat;
            btn_IndCar_start.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_start.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_start.Location = new Point(139, 353);
            btn_IndCar_start.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_start.Name = "btn_IndCar_start";
            btn_IndCar_start.Size = new Size(226, 63);
            btn_IndCar_start.TabIndex = 3;
            btn_IndCar_start.Text = "Start";
            btn_IndCar_start.UseVisualStyleBackColor = false;
            btn_IndCar_start.Click += btn_IndCar_start_Click;
            // 
            // btn_IndCar_windows
            // 
            btn_IndCar_windows.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_windows.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_windows.FlatAppearance.BorderSize = 0;
            btn_IndCar_windows.FlatStyle = FlatStyle.Flat;
            btn_IndCar_windows.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_windows.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_windows.Location = new Point(400, 353);
            btn_IndCar_windows.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_windows.Name = "btn_IndCar_windows";
            btn_IndCar_windows.Size = new Size(226, 63);
            btn_IndCar_windows.TabIndex = 4;
            btn_IndCar_windows.Text = "Windows";
            btn_IndCar_windows.UseVisualStyleBackColor = false;
            btn_IndCar_windows.Click += btn_IndCar_windows_Click;
            // 
            // btn_IndCar_arm
            // 
            btn_IndCar_arm.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_arm.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_arm.FlatAppearance.BorderSize = 0;
            btn_IndCar_arm.FlatStyle = FlatStyle.Flat;
            btn_IndCar_arm.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_arm.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_arm.Location = new Point(917, 353);
            btn_IndCar_arm.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_arm.Name = "btn_IndCar_arm";
            btn_IndCar_arm.Size = new Size(226, 63);
            btn_IndCar_arm.TabIndex = 6;
            btn_IndCar_arm.Text = "Arm";
            btn_IndCar_arm.UseVisualStyleBackColor = false;
            btn_IndCar_arm.Click += btn_IndCar_arm_Click;
            // 
            // btn_IndCar_lock
            // 
            btn_IndCar_lock.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_lock.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_lock.FlatAppearance.BorderSize = 0;
            btn_IndCar_lock.FlatStyle = FlatStyle.Flat;
            btn_IndCar_lock.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_lock.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_lock.Location = new Point(656, 353);
            btn_IndCar_lock.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_lock.Name = "btn_IndCar_lock";
            btn_IndCar_lock.Size = new Size(226, 63);
            btn_IndCar_lock.TabIndex = 5;
            btn_IndCar_lock.Text = "Lock";
            btn_IndCar_lock.UseVisualStyleBackColor = false;
            btn_IndCar_lock.Click += btn_IndCar_lock_Click;
            // 
            // lbl_IndCar_outside
            // 
            lbl_IndCar_outside.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_outside.CausesValidation = false;
            lbl_IndCar_outside.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_outside.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_outside.Location = new Point(491, 33);
            lbl_IndCar_outside.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_outside.Name = "lbl_IndCar_outside";
            lbl_IndCar_outside.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_outside.Size = new Size(217, 78);
            lbl_IndCar_outside.TabIndex = 9;
            lbl_IndCar_outside.Text = "Outside:";
            lbl_IndCar_outside.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_outside.UseWaitCursor = true;
            // 
            // lbl_IndCar_inside
            // 
            lbl_IndCar_inside.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_inside.CausesValidation = false;
            lbl_IndCar_inside.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_inside.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_inside.Location = new Point(83, 33);
            lbl_IndCar_inside.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_inside.Name = "lbl_IndCar_inside";
            lbl_IndCar_inside.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_inside.Size = new Size(166, 78);
            lbl_IndCar_inside.TabIndex = 10;
            lbl_IndCar_inside.Text = "Inside:";
            lbl_IndCar_inside.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_inside.UseWaitCursor = true;
            // 
            // lbl_IndCar_degree2
            // 
            lbl_IndCar_degree2.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_degree2.CausesValidation = false;
            lbl_IndCar_degree2.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_degree2.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_degree2.Location = new Point(826, 37);
            lbl_IndCar_degree2.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_degree2.Name = "lbl_IndCar_degree2";
            lbl_IndCar_degree2.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_degree2.Size = new Size(94, 72);
            lbl_IndCar_degree2.TabIndex = 11;
            lbl_IndCar_degree2.Text = "°F";
            lbl_IndCar_degree2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_degree2.UseWaitCursor = true;
            // 
            // lbl_IndCar_degree1
            // 
            lbl_IndCar_degree1.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_degree1.CausesValidation = false;
            lbl_IndCar_degree1.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_degree1.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_degree1.Location = new Point(344, 37);
            lbl_IndCar_degree1.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_degree1.Name = "lbl_IndCar_degree1";
            lbl_IndCar_degree1.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_degree1.Size = new Size(96, 72);
            lbl_IndCar_degree1.TabIndex = 12;
            lbl_IndCar_degree1.Text = "°F";
            lbl_IndCar_degree1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_degree1.UseWaitCursor = true;
            // 
            // lbl_IndCar_inTemp
            // 
            lbl_IndCar_inTemp.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_inTemp.CausesValidation = false;
            lbl_IndCar_inTemp.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_inTemp.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_inTemp.Location = new Point(211, 35);
            lbl_IndCar_inTemp.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_inTemp.Name = "lbl_IndCar_inTemp";
            lbl_IndCar_inTemp.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_inTemp.Size = new Size(146, 78);
            lbl_IndCar_inTemp.TabIndex = 13;
            lbl_IndCar_inTemp.Text = "000";
            lbl_IndCar_inTemp.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_inTemp.UseWaitCursor = true;
            // 
            // lbl_IndCar_outTemp
            // 
            lbl_IndCar_outTemp.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_outTemp.CausesValidation = false;
            lbl_IndCar_outTemp.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_outTemp.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_outTemp.Location = new Point(691, 33);
            lbl_IndCar_outTemp.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_outTemp.Name = "lbl_IndCar_outTemp";
            lbl_IndCar_outTemp.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_outTemp.Size = new Size(123, 82);
            lbl_IndCar_outTemp.TabIndex = 14;
            lbl_IndCar_outTemp.Text = "000";
            lbl_IndCar_outTemp.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_outTemp.UseWaitCursor = true;
            // 
            // grp_IndCar_temps
            // 
            grp_IndCar_temps.Controls.Add(lbl_IndCar_inside);
            grp_IndCar_temps.Controls.Add(lbl_IndCar_degree2);
            grp_IndCar_temps.Controls.Add(lbl_IndCar_outTemp);
            grp_IndCar_temps.Controls.Add(lbl_IndCar_inTemp);
            grp_IndCar_temps.Controls.Add(lbl_IndCar_degree1);
            grp_IndCar_temps.Controls.Add(lbl_IndCar_outside);
            grp_IndCar_temps.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_IndCar_temps.ForeColor = Color.FromArgb(37, 30, 56);
            grp_IndCar_temps.Location = new Point(139, 442);
            grp_IndCar_temps.Margin = new Padding(4, 5, 4, 5);
            grp_IndCar_temps.Name = "grp_IndCar_temps";
            grp_IndCar_temps.Padding = new Padding(4, 5, 4, 5);
            grp_IndCar_temps.Size = new Size(1004, 130);
            grp_IndCar_temps.TabIndex = 15;
            grp_IndCar_temps.TabStop = false;
            grp_IndCar_temps.Text = "Temperatures";
            // 
            // pic_IndCar_started
            // 
            pic_IndCar_started.BackgroundImage = (Image)resources.GetObject("pic_IndCar_started.BackgroundImage");
            pic_IndCar_started.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_started.Location = new Point(221, 267);
            pic_IndCar_started.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_started.Name = "pic_IndCar_started";
            pic_IndCar_started.Size = new Size(69, 77);
            pic_IndCar_started.TabIndex = 16;
            pic_IndCar_started.TabStop = false;
            // 
            // pic_IndCar_windowUp
            // 
            pic_IndCar_windowUp.BackgroundImage = (Image)resources.GetObject("pic_IndCar_windowUp.BackgroundImage");
            pic_IndCar_windowUp.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_windowUp.Location = new Point(477, 267);
            pic_IndCar_windowUp.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_windowUp.Name = "pic_IndCar_windowUp";
            pic_IndCar_windowUp.Size = new Size(69, 77);
            pic_IndCar_windowUp.TabIndex = 17;
            pic_IndCar_windowUp.TabStop = false;
            // 
            // pic_IndCar_unlocked
            // 
            pic_IndCar_unlocked.BackgroundImage = (Image)resources.GetObject("pic_IndCar_unlocked.BackgroundImage");
            pic_IndCar_unlocked.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_unlocked.Location = new Point(740, 267);
            pic_IndCar_unlocked.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_unlocked.Name = "pic_IndCar_unlocked";
            pic_IndCar_unlocked.Size = new Size(69, 77);
            pic_IndCar_unlocked.TabIndex = 18;
            pic_IndCar_unlocked.TabStop = false;
            // 
            // pic_IndCar_armed
            // 
            pic_IndCar_armed.BackgroundImage = (Image)resources.GetObject("pic_IndCar_armed.BackgroundImage");
            pic_IndCar_armed.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_armed.Location = new Point(990, 267);
            pic_IndCar_armed.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_armed.Name = "pic_IndCar_armed";
            pic_IndCar_armed.Size = new Size(69, 77);
            pic_IndCar_armed.TabIndex = 19;
            pic_IndCar_armed.TabStop = false;
            // 
            // grp_IndCar_primaryFuel
            // 
            grp_IndCar_primaryFuel.Controls.Add(lbl_IndCar_primaryFG);
            grp_IndCar_primaryFuel.Controls.Add(lbl_IndCar_primaryBG);
            grp_IndCar_primaryFuel.Controls.Add(lbl_IndCar_primaryFuelNum);
            grp_IndCar_primaryFuel.Controls.Add(lbl_IndCar_primaryPercent);
            grp_IndCar_primaryFuel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_IndCar_primaryFuel.ForeColor = Color.FromArgb(37, 30, 56);
            grp_IndCar_primaryFuel.Location = new Point(139, 582);
            grp_IndCar_primaryFuel.Margin = new Padding(4, 5, 4, 5);
            grp_IndCar_primaryFuel.Name = "grp_IndCar_primaryFuel";
            grp_IndCar_primaryFuel.Padding = new Padding(4, 5, 4, 5);
            grp_IndCar_primaryFuel.Size = new Size(1004, 172);
            grp_IndCar_primaryFuel.TabIndex = 16;
            grp_IndCar_primaryFuel.TabStop = false;
            grp_IndCar_primaryFuel.Text = "Fuel Percentage";
            // 
            // lbl_IndCar_primaryFG
            // 
            lbl_IndCar_primaryFG.BackColor = Color.FromArgb(229, 155, 137);
            lbl_IndCar_primaryFG.CausesValidation = false;
            lbl_IndCar_primaryFG.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_primaryFG.Location = new Point(229, 57);
            lbl_IndCar_primaryFG.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryFG.Name = "lbl_IndCar_primaryFG";
            lbl_IndCar_primaryFG.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryFG.Size = new Size(564, 60);
            lbl_IndCar_primaryFG.TabIndex = 21;
            lbl_IndCar_primaryFG.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_primaryFG.UseWaitCursor = true;
            // 
            // lbl_IndCar_primaryBG
            // 
            lbl_IndCar_primaryBG.BackColor = Color.FromArgb(235, 215, 207);
            lbl_IndCar_primaryBG.CausesValidation = false;
            lbl_IndCar_primaryBG.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_primaryBG.Location = new Point(229, 57);
            lbl_IndCar_primaryBG.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryBG.Name = "lbl_IndCar_primaryBG";
            lbl_IndCar_primaryBG.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryBG.Size = new Size(747, 60);
            lbl_IndCar_primaryBG.TabIndex = 20;
            lbl_IndCar_primaryBG.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_primaryBG.UseWaitCursor = true;
            // 
            // lbl_IndCar_primaryFuelNum
            // 
            lbl_IndCar_primaryFuelNum.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_primaryFuelNum.CausesValidation = false;
            lbl_IndCar_primaryFuelNum.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_primaryFuelNum.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_primaryFuelNum.Location = new Point(19, 45);
            lbl_IndCar_primaryFuelNum.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryFuelNum.Name = "lbl_IndCar_primaryFuelNum";
            lbl_IndCar_primaryFuelNum.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryFuelNum.Size = new Size(114, 90);
            lbl_IndCar_primaryFuelNum.TabIndex = 15;
            lbl_IndCar_primaryFuelNum.Text = "000";
            lbl_IndCar_primaryFuelNum.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_primaryFuelNum.UseWaitCursor = true;
            // 
            // lbl_IndCar_primaryPercent
            // 
            lbl_IndCar_primaryPercent.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_primaryPercent.CausesValidation = false;
            lbl_IndCar_primaryPercent.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_primaryPercent.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_primaryPercent.Location = new Point(116, 52);
            lbl_IndCar_primaryPercent.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryPercent.Name = "lbl_IndCar_primaryPercent";
            lbl_IndCar_primaryPercent.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_primaryPercent.Size = new Size(110, 78);
            lbl_IndCar_primaryPercent.TabIndex = 12;
            lbl_IndCar_primaryPercent.Text = "%";
            lbl_IndCar_primaryPercent.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_primaryPercent.UseWaitCursor = true;
            // 
            // pic_IndCar_carTypeGas
            // 
            pic_IndCar_carTypeGas.BackgroundImage = (Image)resources.GetObject("pic_IndCar_carTypeGas.BackgroundImage");
            pic_IndCar_carTypeGas.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_carTypeGas.Location = new Point(891, 30);
            pic_IndCar_carTypeGas.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_carTypeGas.Name = "pic_IndCar_carTypeGas";
            pic_IndCar_carTypeGas.Size = new Size(69, 77);
            pic_IndCar_carTypeGas.TabIndex = 20;
            pic_IndCar_carTypeGas.TabStop = false;
            // 
            // grp_IndCar_secondaryFuel
            // 
            grp_IndCar_secondaryFuel.Controls.Add(lbl_IndCar_secondaryFuelNum);
            grp_IndCar_secondaryFuel.Controls.Add(lbl_IndCar_secondaryPercent);
            grp_IndCar_secondaryFuel.Controls.Add(lbl_IndCar_secondaryFG);
            grp_IndCar_secondaryFuel.Controls.Add(lbl_IndCar_secondaryBG);
            grp_IndCar_secondaryFuel.Location = new Point(139, 707);
            grp_IndCar_secondaryFuel.Margin = new Padding(4, 5, 4, 5);
            grp_IndCar_secondaryFuel.Name = "grp_IndCar_secondaryFuel";
            grp_IndCar_secondaryFuel.Size = new Size(1004, 115);
            grp_IndCar_secondaryFuel.TabIndex = 21;
            // 
            // lbl_IndCar_secondaryFuelNum
            // 
            lbl_IndCar_secondaryFuelNum.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_secondaryFuelNum.CausesValidation = false;
            lbl_IndCar_secondaryFuelNum.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_secondaryFuelNum.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_secondaryFuelNum.Location = new Point(19, 13);
            lbl_IndCar_secondaryFuelNum.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryFuelNum.Name = "lbl_IndCar_secondaryFuelNum";
            lbl_IndCar_secondaryFuelNum.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryFuelNum.Size = new Size(114, 90);
            lbl_IndCar_secondaryFuelNum.TabIndex = 22;
            lbl_IndCar_secondaryFuelNum.Text = "000";
            lbl_IndCar_secondaryFuelNum.TextAlign = ContentAlignment.MiddleRight;
            lbl_IndCar_secondaryFuelNum.UseWaitCursor = true;
            // 
            // lbl_IndCar_secondaryPercent
            // 
            lbl_IndCar_secondaryPercent.BackColor = Color.FromArgb(227, 225, 232);
            lbl_IndCar_secondaryPercent.CausesValidation = false;
            lbl_IndCar_secondaryPercent.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            lbl_IndCar_secondaryPercent.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_IndCar_secondaryPercent.Location = new Point(116, 20);
            lbl_IndCar_secondaryPercent.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryPercent.Name = "lbl_IndCar_secondaryPercent";
            lbl_IndCar_secondaryPercent.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryPercent.Size = new Size(110, 78);
            lbl_IndCar_secondaryPercent.TabIndex = 22;
            lbl_IndCar_secondaryPercent.Text = "gal.";
            lbl_IndCar_secondaryPercent.TextAlign = ContentAlignment.MiddleLeft;
            lbl_IndCar_secondaryPercent.UseWaitCursor = true;
            // 
            // lbl_IndCar_secondaryFG
            // 
            lbl_IndCar_secondaryFG.BackColor = Color.FromArgb(229, 155, 137);
            lbl_IndCar_secondaryFG.CausesValidation = false;
            lbl_IndCar_secondaryFG.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_secondaryFG.Location = new Point(229, 25);
            lbl_IndCar_secondaryFG.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryFG.Name = "lbl_IndCar_secondaryFG";
            lbl_IndCar_secondaryFG.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryFG.Size = new Size(564, 60);
            lbl_IndCar_secondaryFG.TabIndex = 22;
            lbl_IndCar_secondaryFG.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_secondaryFG.UseWaitCursor = true;
            // 
            // lbl_IndCar_secondaryBG
            // 
            lbl_IndCar_secondaryBG.BackColor = Color.FromArgb(235, 215, 207);
            lbl_IndCar_secondaryBG.CausesValidation = false;
            lbl_IndCar_secondaryBG.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IndCar_secondaryBG.Location = new Point(229, 25);
            lbl_IndCar_secondaryBG.Margin = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryBG.Name = "lbl_IndCar_secondaryBG";
            lbl_IndCar_secondaryBG.Padding = new Padding(14, 17, 14, 17);
            lbl_IndCar_secondaryBG.Size = new Size(747, 60);
            lbl_IndCar_secondaryBG.TabIndex = 22;
            lbl_IndCar_secondaryBG.TextAlign = ContentAlignment.MiddleCenter;
            lbl_IndCar_secondaryBG.UseWaitCursor = true;
            // 
            // btn_IndCar_EditVehicle
            // 
            btn_IndCar_EditVehicle.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_EditVehicle.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_EditVehicle.FlatAppearance.BorderSize = 0;
            btn_IndCar_EditVehicle.FlatStyle = FlatStyle.Flat;
            btn_IndCar_EditVehicle.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_EditVehicle.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_EditVehicle.Location = new Point(990, 90);
            btn_IndCar_EditVehicle.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_EditVehicle.Name = "btn_IndCar_EditVehicle";
            btn_IndCar_EditVehicle.Size = new Size(220, 57);
            btn_IndCar_EditVehicle.TabIndex = 22;
            btn_IndCar_EditVehicle.Text = "Edit Vehicle";
            btn_IndCar_EditVehicle.UseVisualStyleBackColor = false;
            btn_IndCar_EditVehicle.Click += button1_Click;
            // 
            // btn_IndCar_EditDriver
            // 
            btn_IndCar_EditDriver.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_EditDriver.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_EditDriver.FlatAppearance.BorderSize = 0;
            btn_IndCar_EditDriver.FlatStyle = FlatStyle.Flat;
            btn_IndCar_EditDriver.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_EditDriver.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_EditDriver.Location = new Point(990, 152);
            btn_IndCar_EditDriver.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_EditDriver.Name = "btn_IndCar_EditDriver";
            btn_IndCar_EditDriver.Size = new Size(220, 67);
            btn_IndCar_EditDriver.TabIndex = 23;
            btn_IndCar_EditDriver.Text = "Update Drivers";
            btn_IndCar_EditDriver.UseVisualStyleBackColor = false;
            btn_IndCar_EditDriver.Click += btn_IndCar_EditDriver_Click;
            // 
            // btn_IndCar_ViewActivity
            // 
            btn_IndCar_ViewActivity.BackColor = Color.FromArgb(229, 155, 137);
            btn_IndCar_ViewActivity.BackgroundImageLayout = ImageLayout.None;
            btn_IndCar_ViewActivity.FlatAppearance.BorderSize = 0;
            btn_IndCar_ViewActivity.FlatStyle = FlatStyle.Flat;
            btn_IndCar_ViewActivity.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_IndCar_ViewActivity.ForeColor = Color.FromArgb(37, 30, 56);
            btn_IndCar_ViewActivity.Location = new Point(990, 30);
            btn_IndCar_ViewActivity.Margin = new Padding(4, 5, 4, 5);
            btn_IndCar_ViewActivity.Name = "btn_IndCar_ViewActivity";
            btn_IndCar_ViewActivity.Size = new Size(220, 57);
            btn_IndCar_ViewActivity.TabIndex = 24;
            btn_IndCar_ViewActivity.Text = "View Activity";
            btn_IndCar_ViewActivity.UseVisualStyleBackColor = false;
            btn_IndCar_ViewActivity.Click += btn_IndCar_ViewActivity_Click;
            // 
            // pic_IndCar_stopped
            // 
            pic_IndCar_stopped.BackgroundImage = (Image)resources.GetObject("pic_IndCar_stopped.BackgroundImage");
            pic_IndCar_stopped.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_stopped.Location = new Point(221, 267);
            pic_IndCar_stopped.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_stopped.Name = "pic_IndCar_stopped";
            pic_IndCar_stopped.Size = new Size(69, 77);
            pic_IndCar_stopped.TabIndex = 25;
            pic_IndCar_stopped.TabStop = false;
            // 
            // pic_IndCar_windowDown
            // 
            pic_IndCar_windowDown.BackgroundImage = (Image)resources.GetObject("pic_IndCar_windowDown.BackgroundImage");
            pic_IndCar_windowDown.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_windowDown.Location = new Point(477, 267);
            pic_IndCar_windowDown.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_windowDown.Name = "pic_IndCar_windowDown";
            pic_IndCar_windowDown.Size = new Size(69, 77);
            pic_IndCar_windowDown.TabIndex = 26;
            pic_IndCar_windowDown.TabStop = false;
            // 
            // pic_IndCar_locked
            // 
            pic_IndCar_locked.BackgroundImage = (Image)resources.GetObject("pic_IndCar_locked.BackgroundImage");
            pic_IndCar_locked.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_locked.Location = new Point(740, 267);
            pic_IndCar_locked.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_locked.Name = "pic_IndCar_locked";
            pic_IndCar_locked.Size = new Size(69, 77);
            pic_IndCar_locked.TabIndex = 27;
            pic_IndCar_locked.TabStop = false;
            // 
            // pic_IndCar_carTypeElectric
            // 
            pic_IndCar_carTypeElectric.BackgroundImage = (Image)resources.GetObject("pic_IndCar_carTypeElectric.BackgroundImage");
            pic_IndCar_carTypeElectric.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_carTypeElectric.Location = new Point(891, 107);
            pic_IndCar_carTypeElectric.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_carTypeElectric.Name = "pic_IndCar_carTypeElectric";
            pic_IndCar_carTypeElectric.Size = new Size(69, 77);
            pic_IndCar_carTypeElectric.TabIndex = 28;
            pic_IndCar_carTypeElectric.TabStop = false;
            // 
            // pic_IndCar_Unarmed
            // 
            pic_IndCar_Unarmed.BackgroundImage = (Image)resources.GetObject("pic_IndCar_Unarmed.BackgroundImage");
            pic_IndCar_Unarmed.BackgroundImageLayout = ImageLayout.Zoom;
            pic_IndCar_Unarmed.Location = new Point(990, 266);
            pic_IndCar_Unarmed.Margin = new Padding(4, 5, 4, 5);
            pic_IndCar_Unarmed.Name = "pic_IndCar_Unarmed";
            pic_IndCar_Unarmed.Size = new Size(69, 77);
            pic_IndCar_Unarmed.TabIndex = 29;
            pic_IndCar_Unarmed.TabStop = false;
            // 
            // IndividualCar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(pic_IndCar_Unarmed);
            Controls.Add(pic_IndCar_carTypeElectric);
            Controls.Add(pic_IndCar_locked);
            Controls.Add(pic_IndCar_windowDown);
            Controls.Add(pic_IndCar_stopped);
            Controls.Add(btn_IndCar_ViewActivity);
            Controls.Add(btn_IndCar_EditDriver);
            Controls.Add(btn_IndCar_EditVehicle);
            Controls.Add(grp_IndCar_secondaryFuel);
            Controls.Add(pic_IndCar_carTypeGas);
            Controls.Add(grp_IndCar_primaryFuel);
            Controls.Add(pic_IndCar_armed);
            Controls.Add(pic_IndCar_unlocked);
            Controls.Add(pic_IndCar_windowUp);
            Controls.Add(pic_IndCar_started);
            Controls.Add(grp_IndCar_temps);
            Controls.Add(btn_IndCar_arm);
            Controls.Add(btn_IndCar_lock);
            Controls.Add(btn_IndCar_windows);
            Controls.Add(btn_IndCar_start);
            Controls.Add(lbl_IndCar_carName);
            Controls.Add(pic_IndCar_car);
            Location = new Point(267, 50);
            Name = "IndividualCar";
            Size = new Size(1264, 843);
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_car).EndInit();
            grp_IndCar_temps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_started).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_windowUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_unlocked).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_armed).EndInit();
            grp_IndCar_primaryFuel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_carTypeGas).EndInit();
            grp_IndCar_secondaryFuel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_stopped).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_windowDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_locked).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_carTypeElectric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_IndCar_Unarmed).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pic_IndCar_car;
        private Label lbl_IndCar_carName;
        private Button btn_IndCar_start;
        private Button btn_IndCar_windows;
        private Button btn_IndCar_arm;
        private Button btn_IndCar_lock;
        private Label lbl_IndCar_outside;
        private Label lbl_IndCar_inside;
        private Label lbl_IndCar_primaryFG;
        private Label lbl_IndCar_degree1;
        private Label lbl_IndCar_degree2;
        private Label lbl_IndCar_inTemp;
        private Label lbl_IndCar_outTemp;
        private GroupBox grp_IndCar_temps;
        private PictureBox pic_IndCar_started;
        private PictureBox pic_IndCar_windowUp;
        private PictureBox pic_IndCar_unlocked;
        private PictureBox pic_IndCar_armed;
        private GroupBox grp_IndCar_primaryFuel;
        private Label lbl_IndCar_primaryFuelNum;
        private Label lbl_IndCar_primaryPercent;
        private Label lbl_IndCar_primaryBG;
        private PictureBox pic_IndCar_carTypeGas;
        private Panel grp_IndCar_secondaryFuel;
        private Label lbl_IndCar_secondaryBG;
        private Label lbl_IndCar_secondaryFG;
        private Label lbl_IndCar_secondaryPercent;
        private Label lbl_IndCar_secondaryFuelNum;
        private Button btn_IndCar_EditVehicle;
        private Button btn_IndCar_EditDriver;
        private Button btn_IndCar_ViewActivity;
        private PictureBox pic_IndCar_stopped;
        private PictureBox pic_IndCar_windowDown;
        private PictureBox pic_IndCar_locked;
        private PictureBox pic_IndCar_carTypeElectric;
        private PictureBox pic_IndCar_Unarmed;
    }
}
