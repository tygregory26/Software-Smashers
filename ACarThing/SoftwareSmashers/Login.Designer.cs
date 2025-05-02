namespace SoftwareSmashers
{
    partial class Login
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
            lbl_Login_login = new Label();
            pic_Login_logo = new PictureBox();
            lbl_Login_email = new Label();
            lbl_Login_password = new Label();
            txt_Login_email = new TextBox();
            txt_Login_password = new TextBox();
            btn_Login_register = new Button();
            btn_Login_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Login_logo).BeginInit();
            SuspendLayout();
            // 
            // lbl_Login_login
            // 
            lbl_Login_login.AutoSize = true;
            lbl_Login_login.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            lbl_Login_login.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Login_login.Location = new Point(1076, 188);
            lbl_Login_login.Name = "lbl_Login_login";
            lbl_Login_login.Size = new Size(148, 49);
            lbl_Login_login.TabIndex = 0;
            lbl_Login_login.Text = "Login";
            // 
            // pic_Login_logo
            // 
            pic_Login_logo.Image = Properties.Resources.software_smashers_noText;
            pic_Login_logo.Location = new Point(66, 97);
            pic_Login_logo.Name = "pic_Login_logo";
            pic_Login_logo.Size = new Size(726, 630);
            pic_Login_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Login_logo.TabIndex = 1;
            pic_Login_logo.TabStop = false;
            // 
            // lbl_Login_email
            // 
            lbl_Login_email.AutoSize = true;
            lbl_Login_email.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lbl_Login_email.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Login_email.Location = new Point(983, 305);
            lbl_Login_email.Name = "lbl_Login_email";
            lbl_Login_email.Size = new Size(74, 25);
            lbl_Login_email.TabIndex = 2;
            lbl_Login_email.Text = "Email";
            // 
            // lbl_Login_password
            // 
            lbl_Login_password.AutoSize = true;
            lbl_Login_password.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lbl_Login_password.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Login_password.Location = new Point(983, 398);
            lbl_Login_password.Name = "lbl_Login_password";
            lbl_Login_password.Size = new Size(122, 25);
            lbl_Login_password.TabIndex = 3;
            lbl_Login_password.Text = "Password";
            // 
            // txt_Login_email
            // 
            txt_Login_email.Location = new Point(983, 337);
            txt_Login_email.Name = "txt_Login_email";
            txt_Login_email.Size = new Size(331, 31);
            txt_Login_email.TabIndex = 4;
            // 
            // txt_Login_password
            // 
            txt_Login_password.Location = new Point(983, 430);
            txt_Login_password.Name = "txt_Login_password";
            txt_Login_password.PasswordChar = '*';
            txt_Login_password.Size = new Size(331, 31);
            txt_Login_password.TabIndex = 5;
            // 
            // btn_Login_register
            // 
            btn_Login_register.BackColor = Color.FromArgb(229, 155, 137);
            btn_Login_register.FlatAppearance.BorderSize = 0;
            btn_Login_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 169, 200);
            btn_Login_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 136, 116);
            btn_Login_register.FlatStyle = FlatStyle.Flat;
            btn_Login_register.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Login_register.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Login_register.Location = new Point(964, 523);
            btn_Login_register.Name = "btn_Login_register";
            btn_Login_register.Size = new Size(174, 78);
            btn_Login_register.TabIndex = 6;
            btn_Login_register.Text = "Register";
            btn_Login_register.UseVisualStyleBackColor = false;
            btn_Login_register.Click += btn_Login_register_Click;
            // 
            // btn_Login_login
            // 
            btn_Login_login.BackColor = Color.FromArgb(229, 155, 137);
            btn_Login_login.FlatAppearance.BorderSize = 0;
            btn_Login_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 169, 200);
            btn_Login_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 136, 116);
            btn_Login_login.FlatStyle = FlatStyle.Flat;
            btn_Login_login.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Login_login.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Login_login.Location = new Point(1179, 523);
            btn_Login_login.Name = "btn_Login_login";
            btn_Login_login.Size = new Size(174, 78);
            btn_Login_login.TabIndex = 7;
            btn_Login_login.Text = "Login";
            btn_Login_login.UseVisualStyleBackColor = false;
            btn_Login_login.Click += btn_Login_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(btn_Login_login);
            Controls.Add(btn_Login_register);
            Controls.Add(txt_Login_password);
            Controls.Add(txt_Login_email);
            Controls.Add(lbl_Login_password);
            Controls.Add(lbl_Login_email);
            Controls.Add(pic_Login_logo);
            Controls.Add(lbl_Login_login);
            Location = new Point(0, 50);
            Name = "Login";
            Size = new Size(1531, 843);
            ((System.ComponentModel.ISupportInitialize)pic_Login_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login_login;
        private PictureBox pic_Login_logo;
        private Label lbl_Login_email;
        private Label lbl_Login_password;
        private TextBox txt_Login_email;
        private TextBox txt_Login_password;
        private Button btn_Login_register;
        private Button btn_Login_login;
    }
}
