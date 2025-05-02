namespace SoftwareSmashers
{
    partial class Logs
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGrid_Logs_data = new DataGridView();
            lbl_Logs_title = new Label();
            btn_Logs_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Logs_data).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Logs_data
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 225, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(37, 30, 56);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 30, 56);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(227, 225, 232);
            dataGrid_Logs_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Logs_data.BackgroundColor = Color.FromArgb(229, 155, 137);
            dataGrid_Logs_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Logs_data.Location = new Point(150, 147);
            dataGrid_Logs_data.Name = "dataGrid_Logs_data";
            dataGrid_Logs_data.RowHeadersWidth = 62;
            dataGrid_Logs_data.Size = new Size(946, 545);
            dataGrid_Logs_data.TabIndex = 0;
            // 
            // lbl_Logs_title
            // 
            lbl_Logs_title.AutoSize = true;
            lbl_Logs_title.Font = new Font("Verdana", 20F, FontStyle.Bold);
            lbl_Logs_title.ForeColor = Color.FromArgb(37, 30, 56);
            lbl_Logs_title.Location = new Point(150, 60);
            lbl_Logs_title.Name = "lbl_Logs_title";
            lbl_Logs_title.Size = new Size(485, 48);
            lbl_Logs_title.TabIndex = 1;
            lbl_Logs_title.Text = "Logs for \"CARNAME\"";
            // 
            // btn_Logs_back
            // 
            btn_Logs_back.BackColor = Color.FromArgb(229, 155, 137);
            btn_Logs_back.FlatAppearance.BorderSize = 0;
            btn_Logs_back.FlatStyle = FlatStyle.Flat;
            btn_Logs_back.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Logs_back.ForeColor = Color.FromArgb(37, 30, 56);
            btn_Logs_back.Location = new Point(937, 717);
            btn_Logs_back.Name = "btn_Logs_back";
            btn_Logs_back.Size = new Size(159, 68);
            btn_Logs_back.TabIndex = 2;
            btn_Logs_back.Text = "Back";
            btn_Logs_back.UseVisualStyleBackColor = false;
            btn_Logs_back.Click += btn_Logs_back_Click;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 225, 232);
            Controls.Add(btn_Logs_back);
            Controls.Add(lbl_Logs_title);
            Controls.Add(dataGrid_Logs_data);
            Location = new Point(267, 50);
            Name = "Logs";
            Size = new Size(1264, 843);
            ((System.ComponentModel.ISupportInitialize)dataGrid_Logs_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Logs_data;
        private Label lbl_Logs_title;
        private Button btn_Logs_back;
    }
}
