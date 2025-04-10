namespace SoftwareSmashers
{
    partial class MyCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCars));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_MyCars_registerNew = new Button();
            btn_MyCars_selectVehicle = new Button();
            imageList4 = new ImageList(components);
            dataGrid_MyCars_CarsView = new DataGridView();
            txt_MyCar_vehicleID = new TextBox();
            lbl_MyCars_enterID = new Label();
            lbl_MyCars_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_MyCars_CarsView).BeginInit();
            SuspendLayout();
            // 
            // btn_MyCars_registerNew
            // 
            btn_MyCars_registerNew.BackColor = Color.FromArgb(229, 155, 137);
            btn_MyCars_registerNew.BackgroundImageLayout = ImageLayout.None;
            btn_MyCars_registerNew.FlatAppearance.BorderSize = 0;
            btn_MyCars_registerNew.FlatStyle = FlatStyle.Flat;
            btn_MyCars_registerNew.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_MyCars_registerNew.ForeColor = Color.FromArgb(37, 30, 56);
            btn_MyCars_registerNew.Location = new Point(696, 41);
            btn_MyCars_registerNew.Name = "btn_MyCars_registerNew";
            btn_MyCars_registerNew.Size = new Size(139, 39);
            btn_MyCars_registerNew.TabIndex = 4;
            btn_MyCars_registerNew.Text = "Register New";
            btn_MyCars_registerNew.UseVisualStyleBackColor = false;
            // 
            // btn_MyCars_selectVehicle
            // 
            btn_MyCars_selectVehicle.BackColor = Color.FromArgb(229, 155, 137);
            btn_MyCars_selectVehicle.BackgroundImageLayout = ImageLayout.None;
            btn_MyCars_selectVehicle.FlatAppearance.BorderSize = 0;
            btn_MyCars_selectVehicle.FlatStyle = FlatStyle.Flat;
            btn_MyCars_selectVehicle.Font = new Font("Verdana", 20F, FontStyle.Bold);
            btn_MyCars_selectVehicle.ForeColor = Color.FromArgb(37, 30, 56);
            btn_MyCars_selectVehicle.Location = new Point(589, 394);
            btn_MyCars_selectVehicle.Name = "btn_MyCars_selectVehicle";
            btn_MyCars_selectVehicle.Size = new Size(246, 55);
            btn_MyCars_selectVehicle.TabIndex = 5;
            btn_MyCars_selectVehicle.Text = "Select Vehicle";
            btn_MyCars_selectVehicle.UseVisualStyleBackColor = false;
            // 
            // imageList4
            // 
            imageList4.ColorDepth = ColorDepth.Depth32Bit;
            imageList4.ImageStream = (ImageListStreamer)resources.GetObject("imageList4.ImageStream");
            imageList4.TransparentColor = Color.Transparent;
            imageList4.Images.SetKeyName(0, "Screenshot 2025-03-23 011252.png");
            // 
            // dataGrid_MyCars_CarsView
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(227, 225, 232);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(37, 30, 56);
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 30, 56);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(227, 225, 232);
            dataGrid_MyCars_CarsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_MyCars_CarsView.BackgroundColor = Color.FromArgb(229, 155, 137);
            dataGrid_MyCars_CarsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_MyCars_CarsView.Location = new Point(51, 96);
            dataGrid_MyCars_CarsView.Margin = new Padding(2);
            dataGrid_MyCars_CarsView.Name = "dataGrid_MyCars_CarsView";
            dataGrid_MyCars_CarsView.RowHeadersWidth = 62;
            dataGrid_MyCars_CarsView.Size = new Size(784, 279);
            dataGrid_MyCars_CarsView.TabIndex = 7;
            // 
            // txt_MyCar_vehicleID
            // 
            txt_MyCar_vehicleID.BackColor = Color.FromArgb(227, 225, 232);
            txt_MyCar_vehicleID.BorderStyle = BorderStyle.FixedSingle;
            txt_MyCar_vehicleID.Font = new Font("Verdana", 20F);
            txt_MyCar_vehicleID.ForeColor = Color.FromArgb(37, 30, 56);
            txt_MyCar_vehicleID.ImeMode = ImeMode.NoControl;
            txt_MyCar_vehicleID.Location = new Point(327, 403);
            txt_MyCar_vehicleID.MaxLength = 30;
            txt_MyCar_vehicleID.Name = "txt_MyCar_vehicleID";
            txt_MyCar_vehicleID.Size = new Size(236, 40);
            txt_MyCar_vehicleID.TabIndex = 22;
            txt_MyCar_vehicleID.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_MyCars_enterID
            // 
            lbl_MyCars_enterID.AutoSize = true;
            lbl_MyCars_enterID.Font = new Font("Verdana", 20F, FontStyle.Bold);
            lbl_MyCars_enterID.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_MyCars_enterID.Location = new Point(51, 405);
            lbl_MyCars_enterID.Name = "lbl_MyCars_enterID";
            lbl_MyCars_enterID.Size = new Size(270, 32);
            lbl_MyCars_enterID.TabIndex = 23;
            lbl_MyCars_enterID.Text = "Enter Vehicle ID:";
            lbl_MyCars_enterID.Click += label1_Click_1;
            // 
            // lbl_MyCars_title
            // 
            lbl_MyCars_title.AutoSize = true;
            lbl_MyCars_title.Font = new Font("Verdana", 24F, FontStyle.Bold);
            lbl_MyCars_title.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_MyCars_title.Location = new Point(51, 41);
            lbl_MyCars_title.Name = "lbl_MyCars_title";
            lbl_MyCars_title.Size = new Size(158, 38);
            lbl_MyCars_title.TabIndex = 24;
            lbl_MyCars_title.Text = "My Cars";
            // 
            // MyCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(lbl_MyCars_title);
            Controls.Add(lbl_MyCars_enterID);
            Controls.Add(txt_MyCar_vehicleID);
            Controls.Add(dataGrid_MyCars_CarsView);
            Controls.Add(btn_MyCars_selectVehicle);
            Controls.Add(btn_MyCars_registerNew);
            Location = new Point(267, 0);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MyCars";
            Size = new Size(885, 506);
            Load += MyCars_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_MyCars_CarsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_MyCars_registerNew;
        private Button btn_MyCars_selectVehicle;
        private ImageList imageList4;
        private DataGridView dataGrid_MyCars_CarsView;
        private TextBox txt_MyCar_vehicleID;
        private Label lbl_MyCars_enterID;
        private Label lbl_MyCars_title;
    }
}
