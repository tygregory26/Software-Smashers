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
            btn_MyCars_registerNew = new Button();
            btn_MyCars_selectVehicle = new Button();
            imageList4 = new ImageList(components);
            pic_MyCars_frameFord = new PictureBox();
            btn_MyCars_ford = new Button();
            btn_MyCars_chevy = new Button();
            pic_MyCars_frameChevy = new PictureBox();
            btn_MyCars_honda = new Button();
            pic_MyCars_frameHonda = new PictureBox();
            pic_MyCars_ford = new PictureBox();
            pic_MyCars_chevy = new PictureBox();
            pic_MyCars_honda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_frameFord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_frameChevy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_frameHonda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_ford).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_chevy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_honda).BeginInit();
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
            btn_MyCars_registerNew.Location = new Point(367, 417);
            btn_MyCars_registerNew.Name = "btn_MyCars_registerNew";
            btn_MyCars_registerNew.Size = new Size(158, 38);
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
            btn_MyCars_selectVehicle.Location = new Point(310, 333);
            btn_MyCars_selectVehicle.Name = "btn_MyCars_selectVehicle";
            btn_MyCars_selectVehicle.Size = new Size(273, 69);
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
            // pic_MyCars_frameFord
            // 
            pic_MyCars_frameFord.Image = Properties.Resources.Screenshot_2025_03_23_011252;
            pic_MyCars_frameFord.Location = new Point(85, 67);
            pic_MyCars_frameFord.Name = "pic_MyCars_frameFord";
            pic_MyCars_frameFord.Size = new Size(184, 129);
            pic_MyCars_frameFord.TabIndex = 6;
            pic_MyCars_frameFord.TabStop = false;
            // 
            // btn_MyCars_ford
            // 
            btn_MyCars_ford.BackColor = Color.FromArgb(229, 155, 137);
            btn_MyCars_ford.BackgroundImageLayout = ImageLayout.None;
            btn_MyCars_ford.FlatAppearance.BorderSize = 0;
            btn_MyCars_ford.FlatStyle = FlatStyle.Flat;
            btn_MyCars_ford.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_MyCars_ford.ForeColor = Color.FromArgb(37, 30, 56);
            btn_MyCars_ford.Location = new Point(85, 192);
            btn_MyCars_ford.Name = "btn_MyCars_ford";
            btn_MyCars_ford.Size = new Size(184, 38);
            btn_MyCars_ford.TabIndex = 7;
            btn_MyCars_ford.Text = "Ford";
            btn_MyCars_ford.UseVisualStyleBackColor = false;
            // 
            // btn_MyCars_chevy
            // 
            btn_MyCars_chevy.BackColor = Color.FromArgb(229, 155, 137);
            btn_MyCars_chevy.BackgroundImageLayout = ImageLayout.None;
            btn_MyCars_chevy.FlatAppearance.BorderSize = 0;
            btn_MyCars_chevy.FlatStyle = FlatStyle.Flat;
            btn_MyCars_chevy.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_MyCars_chevy.ForeColor = Color.FromArgb(37, 30, 56);
            btn_MyCars_chevy.Location = new Point(352, 192);
            btn_MyCars_chevy.Name = "btn_MyCars_chevy";
            btn_MyCars_chevy.Size = new Size(184, 38);
            btn_MyCars_chevy.TabIndex = 8;
            btn_MyCars_chevy.Text = "Chevy";
            btn_MyCars_chevy.UseVisualStyleBackColor = false;
            btn_MyCars_chevy.Click += button3_Click;
            // 
            // pic_MyCars_frameChevy
            // 
            pic_MyCars_frameChevy.Image = Properties.Resources.Screenshot_2025_03_23_011252;
            pic_MyCars_frameChevy.Location = new Point(352, 67);
            pic_MyCars_frameChevy.Name = "pic_MyCars_frameChevy";
            pic_MyCars_frameChevy.Size = new Size(184, 129);
            pic_MyCars_frameChevy.TabIndex = 9;
            pic_MyCars_frameChevy.TabStop = false;
            // 
            // btn_MyCars_honda
            // 
            btn_MyCars_honda.BackColor = Color.FromArgb(229, 155, 137);
            btn_MyCars_honda.BackgroundImageLayout = ImageLayout.None;
            btn_MyCars_honda.FlatAppearance.BorderSize = 0;
            btn_MyCars_honda.FlatStyle = FlatStyle.Flat;
            btn_MyCars_honda.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_MyCars_honda.ForeColor = Color.FromArgb(37, 30, 56);
            btn_MyCars_honda.Location = new Point(625, 192);
            btn_MyCars_honda.Name = "btn_MyCars_honda";
            btn_MyCars_honda.Size = new Size(184, 38);
            btn_MyCars_honda.TabIndex = 10;
            btn_MyCars_honda.Text = "Honda";
            btn_MyCars_honda.UseVisualStyleBackColor = false;
            // 
            // pic_MyCars_frameHonda
            // 
            pic_MyCars_frameHonda.Image = Properties.Resources.Screenshot_2025_03_23_011252;
            pic_MyCars_frameHonda.Location = new Point(625, 67);
            pic_MyCars_frameHonda.Name = "pic_MyCars_frameHonda";
            pic_MyCars_frameHonda.Size = new Size(184, 129);
            pic_MyCars_frameHonda.TabIndex = 11;
            pic_MyCars_frameHonda.TabStop = false;
            // 
            // pic_MyCars_ford
            // 
            pic_MyCars_ford.Image = Properties.Resources._9fa50573faae5ee2827b73c7e4ea9ebc_removebg_preview;
            pic_MyCars_ford.Location = new Point(96, 78);
            pic_MyCars_ford.Name = "pic_MyCars_ford";
            pic_MyCars_ford.Size = new Size(157, 108);
            pic_MyCars_ford.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_MyCars_ford.TabIndex = 12;
            pic_MyCars_ford.TabStop = false;
            // 
            // pic_MyCars_chevy
            // 
            pic_MyCars_chevy.Image = Properties.Resources._28ce8267dc297ff4432b5be6b1ebaf79_removebg_preview;
            pic_MyCars_chevy.Location = new Point(360, 78);
            pic_MyCars_chevy.Name = "pic_MyCars_chevy";
            pic_MyCars_chevy.Size = new Size(166, 108);
            pic_MyCars_chevy.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_MyCars_chevy.TabIndex = 13;
            pic_MyCars_chevy.TabStop = false;
            // 
            // pic_MyCars_honda
            // 
            pic_MyCars_honda.Image = Properties.Resources.c22df54dbb32b4d5bb6fcf2b2dcf21de_removebg_preview;
            pic_MyCars_honda.Location = new Point(638, 78);
            pic_MyCars_honda.Name = "pic_MyCars_honda";
            pic_MyCars_honda.Size = new Size(156, 108);
            pic_MyCars_honda.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_MyCars_honda.TabIndex = 14;
            pic_MyCars_honda.TabStop = false;
            // 
            // MyCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(pic_MyCars_honda);
            Controls.Add(pic_MyCars_chevy);
            Controls.Add(pic_MyCars_ford);
            Controls.Add(pic_MyCars_frameHonda);
            Controls.Add(btn_MyCars_honda);
            Controls.Add(pic_MyCars_frameChevy);
            Controls.Add(btn_MyCars_chevy);
            Controls.Add(btn_MyCars_ford);
            Controls.Add(pic_MyCars_frameFord);
            Controls.Add(btn_MyCars_selectVehicle);
            Controls.Add(btn_MyCars_registerNew);
            Margin = new Padding(2);
            Name = "MyCars";
            Size = new Size(885, 506);
            Load += MyCars_Load;
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_frameFord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_frameChevy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_frameHonda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_ford).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_chevy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_MyCars_honda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_MyCars_registerNew;
        private Button btn_MyCars_selectVehicle;
        private ImageList imageList4;
        private PictureBox pic_MyCars_frameFord;
        private Button btn_MyCars_ford;
        private Button btn_MyCars_chevy;
        private PictureBox pic_MyCars_frameChevy;
        private Button btn_MyCars_honda;
        private PictureBox pic_MyCars_frameHonda;
        private PictureBox pic_MyCars_ford;
        private PictureBox pic_MyCars_chevy;
        private PictureBox pic_MyCars_honda;
    }
}
