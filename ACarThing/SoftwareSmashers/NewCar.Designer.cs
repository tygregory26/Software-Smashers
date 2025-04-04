namespace SoftwareSmashers
{
    partial class NewCar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCar));
            pic_NewCar_BigImage = new PictureBox();
            grp_NewCar_VehicleInfo = new GroupBox();
            txt_NewCar_vehicleName = new TextBox();
            lbl_NewCar_vehicleName = new Label();
            panel1 = new Panel();
            radiobtn_NewCar_Hybrid = new RadioButton();
            radiobtn_NewCar_Gas = new RadioButton();
            radiobtn_NewCar_Electric = new RadioButton();
            lbl_NewCar_Type = new Label();
            lbl_NewCar_VIN = new Label();
            lbl_NewCar_Year = new Label();
            lbl_NewCar_Model = new Label();
            lbl_NewCar_Make = new Label();
            txt_NewCar_VIN = new TextBox();
            txt_NewCar_Year = new TextBox();
            txt_NewCar_Model = new TextBox();
            txt_NewCar_Make = new TextBox();
            toolTip = new ToolTip(components);
            btn_NewCar_Save = new Button();
            btn_NewCar_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_NewCar_BigImage).BeginInit();
            grp_NewCar_VehicleInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pic_NewCar_BigImage
            // 
            pic_NewCar_BigImage.Image = (Image)resources.GetObject("pic_NewCar_BigImage.Image");
            pic_NewCar_BigImage.Location = new Point(56, 60);
            pic_NewCar_BigImage.Name = "pic_NewCar_BigImage";
            pic_NewCar_BigImage.Size = new Size(496, 415);
            pic_NewCar_BigImage.SizeMode = PictureBoxSizeMode.Zoom;
            pic_NewCar_BigImage.TabIndex = 6;
            pic_NewCar_BigImage.TabStop = false;
            // 
            // grp_NewCar_VehicleInfo
            // 
            grp_NewCar_VehicleInfo.BackColor = Color.FromArgb(229, 155, 137);
            grp_NewCar_VehicleInfo.BackgroundImageLayout = ImageLayout.None;
            grp_NewCar_VehicleInfo.Controls.Add(txt_NewCar_vehicleName);
            grp_NewCar_VehicleInfo.Controls.Add(lbl_NewCar_vehicleName);
            grp_NewCar_VehicleInfo.Controls.Add(panel1);
            grp_NewCar_VehicleInfo.Controls.Add(lbl_NewCar_VIN);
            grp_NewCar_VehicleInfo.Controls.Add(lbl_NewCar_Year);
            grp_NewCar_VehicleInfo.Controls.Add(lbl_NewCar_Model);
            grp_NewCar_VehicleInfo.Controls.Add(lbl_NewCar_Make);
            grp_NewCar_VehicleInfo.Controls.Add(txt_NewCar_VIN);
            grp_NewCar_VehicleInfo.Controls.Add(txt_NewCar_Year);
            grp_NewCar_VehicleInfo.Controls.Add(txt_NewCar_Model);
            grp_NewCar_VehicleInfo.Controls.Add(txt_NewCar_Make);
            grp_NewCar_VehicleInfo.FlatStyle = FlatStyle.Flat;
            grp_NewCar_VehicleInfo.Font = new Font("Verdana", 12F, FontStyle.Bold);
            grp_NewCar_VehicleInfo.ForeColor = Color.FromArgb(37, 30, 56);
            grp_NewCar_VehicleInfo.Location = new Point(580, 52);
            grp_NewCar_VehicleInfo.Margin = new Padding(4, 5, 4, 5);
            grp_NewCar_VehicleInfo.Name = "grp_NewCar_VehicleInfo";
            grp_NewCar_VehicleInfo.Padding = new Padding(4, 5, 4, 5);
            grp_NewCar_VehicleInfo.Size = new Size(621, 735);
            grp_NewCar_VehicleInfo.TabIndex = 7;
            grp_NewCar_VehicleInfo.TabStop = false;
            grp_NewCar_VehicleInfo.Text = "Vehicle Information";
            // 
            // txt_NewCar_vehicleName
            // 
            txt_NewCar_vehicleName.BackColor = Color.FromArgb(227, 225, 232);
            txt_NewCar_vehicleName.BorderStyle = BorderStyle.None;
            txt_NewCar_vehicleName.Font = new Font("Verdana", 16F);
            txt_NewCar_vehicleName.ForeColor = Color.FromArgb(37, 30, 56);
            txt_NewCar_vehicleName.ImeMode = ImeMode.NoControl;
            txt_NewCar_vehicleName.Location = new Point(333, 77);
            txt_NewCar_vehicleName.Margin = new Padding(4, 5, 4, 5);
            txt_NewCar_vehicleName.MaxLength = 30;
            txt_NewCar_vehicleName.Name = "txt_NewCar_vehicleName";
            txt_NewCar_vehicleName.Size = new Size(253, 39);
            txt_NewCar_vehicleName.TabIndex = 21;
            txt_NewCar_vehicleName.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_NewCar_vehicleName
            // 
            lbl_NewCar_vehicleName.CausesValidation = false;
            lbl_NewCar_vehicleName.Font = new Font("Verdana", 16F, FontStyle.Bold);
            lbl_NewCar_vehicleName.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_NewCar_vehicleName.Location = new Point(19, 55);
            lbl_NewCar_vehicleName.Margin = new Padding(14, 17, 14, 17);
            lbl_NewCar_vehicleName.Name = "lbl_NewCar_vehicleName";
            lbl_NewCar_vehicleName.Padding = new Padding(14, 17, 14, 17);
            lbl_NewCar_vehicleName.Size = new Size(314, 83);
            lbl_NewCar_vehicleName.TabIndex = 20;
            lbl_NewCar_vehicleName.Text = "Vehicle Name:";
            lbl_NewCar_vehicleName.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lbl_NewCar_vehicleName, "The brand that made the vehicle.");
            lbl_NewCar_vehicleName.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radiobtn_NewCar_Hybrid);
            panel1.Controls.Add(radiobtn_NewCar_Gas);
            panel1.Controls.Add(radiobtn_NewCar_Electric);
            panel1.Controls.Add(lbl_NewCar_Type);
            panel1.Location = new Point(77, 478);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 222);
            panel1.TabIndex = 19;
            // 
            // radiobtn_NewCar_Hybrid
            // 
            radiobtn_NewCar_Hybrid.AutoSize = true;
            radiobtn_NewCar_Hybrid.FlatStyle = FlatStyle.Flat;
            radiobtn_NewCar_Hybrid.Location = new Point(313, 155);
            radiobtn_NewCar_Hybrid.Margin = new Padding(4, 5, 4, 5);
            radiobtn_NewCar_Hybrid.Name = "radiobtn_NewCar_Hybrid";
            radiobtn_NewCar_Hybrid.Size = new Size(126, 33);
            radiobtn_NewCar_Hybrid.TabIndex = 18;
            radiobtn_NewCar_Hybrid.Text = "Hybrid";
            radiobtn_NewCar_Hybrid.UseVisualStyleBackColor = true;
            radiobtn_NewCar_Hybrid.CheckedChanged += radiobtn_NewCar_Hybrid_CheckedChanged;
            // 
            // radiobtn_NewCar_Gas
            // 
            radiobtn_NewCar_Gas.AutoSize = true;
            radiobtn_NewCar_Gas.FlatStyle = FlatStyle.Flat;
            radiobtn_NewCar_Gas.Location = new Point(313, 87);
            radiobtn_NewCar_Gas.Margin = new Padding(4, 5, 4, 5);
            radiobtn_NewCar_Gas.Name = "radiobtn_NewCar_Gas";
            radiobtn_NewCar_Gas.Size = new Size(85, 33);
            radiobtn_NewCar_Gas.TabIndex = 16;
            radiobtn_NewCar_Gas.Text = "Gas";
            radiobtn_NewCar_Gas.UseVisualStyleBackColor = true;
            radiobtn_NewCar_Gas.CheckedChanged += radiobtn_NewCar_Gas_CheckedChanged;
            // 
            // radiobtn_NewCar_Electric
            // 
            radiobtn_NewCar_Electric.AutoSize = true;
            radiobtn_NewCar_Electric.FlatStyle = FlatStyle.Flat;
            radiobtn_NewCar_Electric.Location = new Point(313, 23);
            radiobtn_NewCar_Electric.Margin = new Padding(4, 5, 4, 5);
            radiobtn_NewCar_Electric.Name = "radiobtn_NewCar_Electric";
            radiobtn_NewCar_Electric.Size = new Size(135, 33);
            radiobtn_NewCar_Electric.TabIndex = 17;
            radiobtn_NewCar_Electric.Text = "Electric";
            radiobtn_NewCar_Electric.UseVisualStyleBackColor = true;
            radiobtn_NewCar_Electric.CheckedChanged += radiobtn_NewCar_Electric_CheckedChanged;
            // 
            // lbl_NewCar_Type
            // 
            lbl_NewCar_Type.CausesValidation = false;
            lbl_NewCar_Type.Font = new Font("Verdana", 15F, FontStyle.Bold);
            lbl_NewCar_Type.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_NewCar_Type.Location = new Point(14, 47);
            lbl_NewCar_Type.Margin = new Padding(14, 17, 14, 17);
            lbl_NewCar_Type.Name = "lbl_NewCar_Type";
            lbl_NewCar_Type.Padding = new Padding(14, 17, 14, 17);
            lbl_NewCar_Type.Size = new Size(279, 108);
            lbl_NewCar_Type.TabIndex = 15;
            lbl_NewCar_Type.Text = "Engine Type:";
            lbl_NewCar_Type.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lbl_NewCar_Type, "Vehicle Identification Number");
            lbl_NewCar_Type.UseWaitCursor = true;
            // 
            // lbl_NewCar_VIN
            // 
            lbl_NewCar_VIN.CausesValidation = false;
            lbl_NewCar_VIN.Font = new Font("Verdana", 14F, FontStyle.Bold);
            lbl_NewCar_VIN.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_NewCar_VIN.Location = new Point(39, 348);
            lbl_NewCar_VIN.Margin = new Padding(14, 17, 14, 17);
            lbl_NewCar_VIN.Name = "lbl_NewCar_VIN";
            lbl_NewCar_VIN.Padding = new Padding(14, 17, 14, 17);
            lbl_NewCar_VIN.Size = new Size(141, 108);
            lbl_NewCar_VIN.TabIndex = 14;
            lbl_NewCar_VIN.Text = "VIN:";
            lbl_NewCar_VIN.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lbl_NewCar_VIN, "Vehicle Identification Number");
            lbl_NewCar_VIN.UseWaitCursor = true;
            // 
            // lbl_NewCar_Year
            // 
            lbl_NewCar_Year.CausesValidation = false;
            lbl_NewCar_Year.Font = new Font("Verdana", 14F, FontStyle.Bold);
            lbl_NewCar_Year.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_NewCar_Year.Location = new Point(39, 273);
            lbl_NewCar_Year.Margin = new Padding(14, 17, 14, 17);
            lbl_NewCar_Year.Name = "lbl_NewCar_Year";
            lbl_NewCar_Year.Padding = new Padding(14, 17, 14, 17);
            lbl_NewCar_Year.Size = new Size(154, 108);
            lbl_NewCar_Year.TabIndex = 13;
            lbl_NewCar_Year.Text = "Year:";
            lbl_NewCar_Year.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lbl_NewCar_Year, "Year the vehicle was made.");
            lbl_NewCar_Year.UseWaitCursor = true;
            // 
            // lbl_NewCar_Model
            // 
            lbl_NewCar_Model.CausesValidation = false;
            lbl_NewCar_Model.Font = new Font("Verdana", 14F, FontStyle.Bold);
            lbl_NewCar_Model.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_NewCar_Model.Location = new Point(39, 197);
            lbl_NewCar_Model.Margin = new Padding(14, 17, 14, 17);
            lbl_NewCar_Model.Name = "lbl_NewCar_Model";
            lbl_NewCar_Model.Padding = new Padding(14, 17, 14, 17);
            lbl_NewCar_Model.Size = new Size(154, 108);
            lbl_NewCar_Model.TabIndex = 12;
            lbl_NewCar_Model.Text = "Model:";
            lbl_NewCar_Model.TextAlign = ContentAlignment.MiddleLeft;
            lbl_NewCar_Model.UseWaitCursor = true;
            // 
            // lbl_NewCar_Make
            // 
            lbl_NewCar_Make.CausesValidation = false;
            lbl_NewCar_Make.Font = new Font("Verdana", 14F, FontStyle.Bold);
            lbl_NewCar_Make.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_NewCar_Make.Location = new Point(39, 122);
            lbl_NewCar_Make.Margin = new Padding(14, 17, 14, 17);
            lbl_NewCar_Make.Name = "lbl_NewCar_Make";
            lbl_NewCar_Make.Padding = new Padding(14, 17, 14, 17);
            lbl_NewCar_Make.Size = new Size(141, 108);
            lbl_NewCar_Make.TabIndex = 11;
            lbl_NewCar_Make.Text = "Make:";
            lbl_NewCar_Make.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lbl_NewCar_Make, "The brand that made the vehicle.");
            lbl_NewCar_Make.UseWaitCursor = true;
            lbl_NewCar_Make.Click += lbl_IndCar_inside_Click;
            // 
            // txt_NewCar_VIN
            // 
            txt_NewCar_VIN.BackColor = Color.FromArgb(227, 225, 232);
            txt_NewCar_VIN.BorderStyle = BorderStyle.None;
            txt_NewCar_VIN.Font = new Font("Verdana", 12F);
            txt_NewCar_VIN.ForeColor = Color.FromArgb(37, 30, 56);
            txt_NewCar_VIN.Location = new Point(247, 390);
            txt_NewCar_VIN.Margin = new Padding(4, 5, 4, 5);
            txt_NewCar_VIN.MaxLength = 17;
            txt_NewCar_VIN.Name = "txt_NewCar_VIN";
            txt_NewCar_VIN.Size = new Size(339, 30);
            txt_NewCar_VIN.TabIndex = 3;
            txt_NewCar_VIN.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_NewCar_Year
            // 
            txt_NewCar_Year.BackColor = Color.FromArgb(227, 225, 232);
            txt_NewCar_Year.BorderStyle = BorderStyle.None;
            txt_NewCar_Year.Font = new Font("Verdana", 12F);
            txt_NewCar_Year.ForeColor = Color.FromArgb(37, 30, 56);
            txt_NewCar_Year.Location = new Point(247, 315);
            txt_NewCar_Year.Margin = new Padding(4, 5, 4, 5);
            txt_NewCar_Year.MaxLength = 4;
            txt_NewCar_Year.Name = "txt_NewCar_Year";
            txt_NewCar_Year.Size = new Size(339, 30);
            txt_NewCar_Year.TabIndex = 2;
            txt_NewCar_Year.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_NewCar_Model
            // 
            txt_NewCar_Model.BackColor = Color.FromArgb(227, 225, 232);
            txt_NewCar_Model.BorderStyle = BorderStyle.None;
            txt_NewCar_Model.Font = new Font("Verdana", 12F);
            txt_NewCar_Model.ForeColor = Color.FromArgb(37, 30, 56);
            txt_NewCar_Model.Location = new Point(247, 238);
            txt_NewCar_Model.Margin = new Padding(4, 5, 4, 5);
            txt_NewCar_Model.MaxLength = 30;
            txt_NewCar_Model.Name = "txt_NewCar_Model";
            txt_NewCar_Model.Size = new Size(339, 30);
            txt_NewCar_Model.TabIndex = 1;
            txt_NewCar_Model.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_NewCar_Make
            // 
            txt_NewCar_Make.BackColor = Color.FromArgb(227, 225, 232);
            txt_NewCar_Make.BorderStyle = BorderStyle.None;
            txt_NewCar_Make.Font = new Font("Verdana", 12F);
            txt_NewCar_Make.ForeColor = Color.FromArgb(37, 30, 56);
            txt_NewCar_Make.ImeMode = ImeMode.NoControl;
            txt_NewCar_Make.Location = new Point(247, 163);
            txt_NewCar_Make.Margin = new Padding(4, 5, 4, 5);
            txt_NewCar_Make.MaxLength = 30;
            txt_NewCar_Make.Name = "txt_NewCar_Make";
            txt_NewCar_Make.Size = new Size(339, 30);
            txt_NewCar_Make.TabIndex = 0;
            txt_NewCar_Make.TextAlign = HorizontalAlignment.Right;
            // 
            // toolTip
            // 
            toolTip.BackColor = Color.FromArgb(227, 225, 232);
            toolTip.ForeColor = Color.FromArgb(37, 30, 56);
            // 
            // btn_NewCar_Save
            // 
            btn_NewCar_Save.BackColor = Color.FromArgb(229, 155, 137);
            btn_NewCar_Save.BackgroundImageLayout = ImageLayout.None;
            btn_NewCar_Save.FlatAppearance.BorderSize = 0;
            btn_NewCar_Save.FlatStyle = FlatStyle.Flat;
            btn_NewCar_Save.Font = new Font("Verdana", 26F, FontStyle.Bold);
            btn_NewCar_Save.ForeColor = Color.FromArgb(37, 30, 56);
            btn_NewCar_Save.Location = new Point(136, 532);
            btn_NewCar_Save.Margin = new Padding(4, 5, 4, 5);
            btn_NewCar_Save.Name = "btn_NewCar_Save";
            btn_NewCar_Save.Size = new Size(344, 122);
            btn_NewCar_Save.TabIndex = 19;
            btn_NewCar_Save.Text = "SAVE";
            btn_NewCar_Save.UseVisualStyleBackColor = false;
            btn_NewCar_Save.Click += btn_IndCar_windows_Click;
            // 
            // btn_NewCar_Cancel
            // 
            btn_NewCar_Cancel.BackColor = Color.FromArgb(229, 155, 137);
            btn_NewCar_Cancel.BackgroundImageLayout = ImageLayout.None;
            btn_NewCar_Cancel.FlatAppearance.BorderSize = 0;
            btn_NewCar_Cancel.FlatStyle = FlatStyle.Flat;
            btn_NewCar_Cancel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_NewCar_Cancel.ForeColor = Color.FromArgb(37, 30, 56);
            btn_NewCar_Cancel.Location = new Point(200, 690);
            btn_NewCar_Cancel.Margin = new Padding(4, 5, 4, 5);
            btn_NewCar_Cancel.Name = "btn_NewCar_Cancel";
            btn_NewCar_Cancel.Size = new Size(226, 63);
            btn_NewCar_Cancel.TabIndex = 20;
            btn_NewCar_Cancel.Text = "CANCEL";
            btn_NewCar_Cancel.UseVisualStyleBackColor = false;
            btn_NewCar_Cancel.Click += button1_Click;
            // 
            // NewCar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(btn_NewCar_Cancel);
            Controls.Add(btn_NewCar_Save);
            Controls.Add(grp_NewCar_VehicleInfo);
            Controls.Add(pic_NewCar_BigImage);
            Location = new Point(267, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NewCar";
            Size = new Size(1264, 843);
            ((System.ComponentModel.ISupportInitialize)pic_NewCar_BigImage).EndInit();
            grp_NewCar_VehicleInfo.ResumeLayout(false);
            grp_NewCar_VehicleInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_NewCar_BigImage;
        private GroupBox grp_NewCar_VehicleInfo;
        private TextBox txt_NewCar_VIN;
        private TextBox txt_NewCar_Year;
        private TextBox txt_NewCar_Model;
        private TextBox txt_NewCar_Make;
        private Label lbl_NewCar_Make;
        private Label lbl_NewCar_Model;
        private Label lbl_NewCar_VIN;
        private Label lbl_NewCar_Year;
        private ToolTip toolTip;
        private Label lbl_NewCar_Type;
        private RadioButton radiobtn_NewCar_Gas;
        private RadioButton radiobtn_NewCar_Electric;
        private RadioButton radiobtn_NewCar_Hybrid;
        private Button btn_NewCar_Save;
        private Button btn_NewCar_Cancel;
        private Panel panel1;
        private Label lbl_NewCar_vehicleName;
        private TextBox txt_NewCar_vehicleName;
    }
}
