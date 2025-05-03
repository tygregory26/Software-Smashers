namespace SoftwareSmashers
{
    partial class DeleteDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDriver));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grp_DeleteDriver_Delete = new GroupBox();
            txt_DeleteDriver_email = new TextBox();
            lbl_DeleteDriver_email = new Label();
            pic_DeleteDriver_BigImage = new PictureBox();
            btn_DeleteCar_deleteDriver = new Button();
            btn_DeleteCar_cancel = new Button();
            btn_DeleteCar_addDriver = new Button();
            dataGrid_Driver_data = new DataGridView();
            grp_DeleteDriver_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_DeleteDriver_BigImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Driver_data).BeginInit();
            SuspendLayout();
            // 
            // grp_DeleteDriver_Delete
            // 
            grp_DeleteDriver_Delete.BackColor = Color.FromArgb(229, 155, 137);
            grp_DeleteDriver_Delete.BackgroundImageLayout = ImageLayout.None;
            grp_DeleteDriver_Delete.Controls.Add(txt_DeleteDriver_email);
            grp_DeleteDriver_Delete.Controls.Add(lbl_DeleteDriver_email);
            grp_DeleteDriver_Delete.FlatStyle = FlatStyle.Flat;
            grp_DeleteDriver_Delete.Font = new Font("Verdana", 12F, FontStyle.Bold);
            grp_DeleteDriver_Delete.ForeColor = Color.FromArgb(37, 30, 56);
            grp_DeleteDriver_Delete.Location = new Point(581, 507);
            grp_DeleteDriver_Delete.Margin = new Padding(4, 5, 4, 5);
            grp_DeleteDriver_Delete.Name = "grp_DeleteDriver_Delete";
            grp_DeleteDriver_Delete.Padding = new Padding(4, 5, 4, 5);
            grp_DeleteDriver_Delete.Size = new Size(621, 149);
            grp_DeleteDriver_Delete.TabIndex = 9;
            grp_DeleteDriver_Delete.TabStop = false;
            grp_DeleteDriver_Delete.Text = "Modify Drivers";
            // 
            // txt_DeleteDriver_email
            // 
            txt_DeleteDriver_email.BackColor = Color.FromArgb(227, 225, 232);
            txt_DeleteDriver_email.BorderStyle = BorderStyle.None;
            txt_DeleteDriver_email.Font = new Font("Verdana", 16F);
            txt_DeleteDriver_email.ForeColor = Color.FromArgb(37, 30, 56);
            txt_DeleteDriver_email.ImeMode = ImeMode.NoControl;
            txt_DeleteDriver_email.Location = new Point(173, 69);
            txt_DeleteDriver_email.Margin = new Padding(4, 5, 4, 5);
            txt_DeleteDriver_email.MaxLength = 30;
            txt_DeleteDriver_email.Name = "txt_DeleteDriver_email";
            txt_DeleteDriver_email.Size = new Size(423, 39);
            txt_DeleteDriver_email.TabIndex = 21;
            txt_DeleteDriver_email.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_DeleteDriver_email
            // 
            lbl_DeleteDriver_email.CausesValidation = false;
            lbl_DeleteDriver_email.Font = new Font("Verdana", 16F, FontStyle.Bold);
            lbl_DeleteDriver_email.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_DeleteDriver_email.Location = new Point(29, 47);
            lbl_DeleteDriver_email.Margin = new Padding(14, 17, 14, 17);
            lbl_DeleteDriver_email.Name = "lbl_DeleteDriver_email";
            lbl_DeleteDriver_email.Padding = new Padding(14, 17, 14, 17);
            lbl_DeleteDriver_email.Size = new Size(161, 83);
            lbl_DeleteDriver_email.TabIndex = 20;
            lbl_DeleteDriver_email.Text = "Email:";
            lbl_DeleteDriver_email.TextAlign = ContentAlignment.MiddleLeft;
            lbl_DeleteDriver_email.UseWaitCursor = true;
            // 
            // pic_DeleteDriver_BigImage
            // 
            pic_DeleteDriver_BigImage.Image = (Image)resources.GetObject("pic_DeleteDriver_BigImage.Image");
            pic_DeleteDriver_BigImage.Location = new Point(44, 220);
            pic_DeleteDriver_BigImage.Name = "pic_DeleteDriver_BigImage";
            pic_DeleteDriver_BigImage.Size = new Size(496, 415);
            pic_DeleteDriver_BigImage.SizeMode = PictureBoxSizeMode.Zoom;
            pic_DeleteDriver_BigImage.TabIndex = 8;
            pic_DeleteDriver_BigImage.TabStop = false;
            // 
            // btn_DeleteCar_deleteDriver
            // 
            btn_DeleteCar_deleteDriver.BackColor = Color.FromArgb(229, 155, 137);
            btn_DeleteCar_deleteDriver.BackgroundImageLayout = ImageLayout.None;
            btn_DeleteCar_deleteDriver.FlatAppearance.BorderSize = 0;
            btn_DeleteCar_deleteDriver.FlatStyle = FlatStyle.Flat;
            btn_DeleteCar_deleteDriver.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btn_DeleteCar_deleteDriver.ForeColor = Color.FromArgb(37, 30, 56);
            btn_DeleteCar_deleteDriver.Location = new Point(915, 701);
            btn_DeleteCar_deleteDriver.Margin = new Padding(4, 5, 4, 5);
            btn_DeleteCar_deleteDriver.Name = "btn_DeleteCar_deleteDriver";
            btn_DeleteCar_deleteDriver.Size = new Size(287, 102);
            btn_DeleteCar_deleteDriver.TabIndex = 24;
            btn_DeleteCar_deleteDriver.Text = "Delete Driver";
            btn_DeleteCar_deleteDriver.UseVisualStyleBackColor = false;
            btn_DeleteCar_deleteDriver.Click += btn_DeleteCar_deleteDriver_Click;
            // 
            // btn_DeleteCar_cancel
            // 
            btn_DeleteCar_cancel.BackColor = Color.FromArgb(229, 155, 137);
            btn_DeleteCar_cancel.BackgroundImageLayout = ImageLayout.None;
            btn_DeleteCar_cancel.FlatAppearance.BorderSize = 0;
            btn_DeleteCar_cancel.FlatStyle = FlatStyle.Flat;
            btn_DeleteCar_cancel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_DeleteCar_cancel.ForeColor = Color.FromArgb(37, 30, 56);
            btn_DeleteCar_cancel.Location = new Point(1039, 37);
            btn_DeleteCar_cancel.Margin = new Padding(4, 5, 4, 5);
            btn_DeleteCar_cancel.Name = "btn_DeleteCar_cancel";
            btn_DeleteCar_cancel.Size = new Size(163, 63);
            btn_DeleteCar_cancel.TabIndex = 23;
            btn_DeleteCar_cancel.Text = "CANCEL";
            btn_DeleteCar_cancel.UseVisualStyleBackColor = false;
            btn_DeleteCar_cancel.Click += btn_DeleteCar_cancel_Click;
            // 
            // btn_DeleteCar_addDriver
            // 
            btn_DeleteCar_addDriver.BackColor = Color.FromArgb(229, 155, 137);
            btn_DeleteCar_addDriver.BackgroundImageLayout = ImageLayout.None;
            btn_DeleteCar_addDriver.FlatAppearance.BorderSize = 0;
            btn_DeleteCar_addDriver.FlatStyle = FlatStyle.Flat;
            btn_DeleteCar_addDriver.Font = new Font("Verdana", 18F, FontStyle.Bold);
            btn_DeleteCar_addDriver.ForeColor = Color.FromArgb(37, 30, 56);
            btn_DeleteCar_addDriver.Location = new Point(581, 701);
            btn_DeleteCar_addDriver.Margin = new Padding(4, 5, 4, 5);
            btn_DeleteCar_addDriver.Name = "btn_DeleteCar_addDriver";
            btn_DeleteCar_addDriver.Size = new Size(287, 102);
            btn_DeleteCar_addDriver.TabIndex = 22;
            btn_DeleteCar_addDriver.Text = "Add Driver";
            btn_DeleteCar_addDriver.UseVisualStyleBackColor = false;
            btn_DeleteCar_addDriver.Click += btn_DeleteCar_addDriver_Click;
            // 
            // dataGrid_Driver_data
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 225, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(37, 30, 56);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 30, 56);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(227, 225, 232);
            dataGrid_Driver_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Driver_data.BackgroundColor = Color.FromArgb(229, 155, 137);
            dataGrid_Driver_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Driver_data.Location = new Point(581, 123);
            dataGrid_Driver_data.Name = "dataGrid_Driver_data";
            dataGrid_Driver_data.RowHeadersWidth = 62;
            dataGrid_Driver_data.Size = new Size(621, 348);
            dataGrid_Driver_data.TabIndex = 25;
            // 
            // DeleteDriver
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(dataGrid_Driver_data);
            Controls.Add(btn_DeleteCar_deleteDriver);
            Controls.Add(grp_DeleteDriver_Delete);
            Controls.Add(btn_DeleteCar_cancel);
            Controls.Add(pic_DeleteDriver_BigImage);
            Controls.Add(btn_DeleteCar_addDriver);
            Location = new Point(267, 50);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DeleteDriver";
            Size = new Size(1264, 843);
            grp_DeleteDriver_Delete.ResumeLayout(false);
            grp_DeleteDriver_Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_DeleteDriver_BigImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Driver_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_DeleteDriver_Delete;
        private TextBox txt_DeleteDriver_email;
        private Label lbl_DeleteDriver_email;
        private PictureBox pic_DeleteDriver_BigImage;
        private Button btn_DeleteCar_deleteDriver;
        private Button btn_DeleteCar_cancel;
        private Button btn_DeleteCar_addDriver;
        private DataGridView dataGrid_Driver_data;
    }
}
