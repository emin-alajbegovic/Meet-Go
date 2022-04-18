
namespace MeetAndGo.WinUI.Rented
{
    partial class frmRentedOffices
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRentedOffices = new System.Windows.Forms.DataGridView();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OfficeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_Picture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_BeginRentalDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndRentalDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Days = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRentedOffices);
            this.groupBox1.Location = new System.Drawing.Point(35, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Offices";
            // 
            // dgvRentedOffices
            // 
            this.dgvRentedOffices.AllowUserToAddRows = false;
            this.dgvRentedOffices.AllowUserToDeleteRows = false;
            this.dgvRentedOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentedOffices.Location = new System.Drawing.Point(3, 16);
            this.dgvRentedOffices.Name = "dgvRentedOffices";
            this.dgvRentedOffices.ReadOnly = true;
            this.dgvRentedOffices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentedOffices.Size = new System.Drawing.Size(657, 248);
            this.dgvRentedOffices.TabIndex = 0;
            this.dgvRentedOffices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedOffices_CellDoubleClick);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(38, 189);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(219, 20);
            this.txt_Price.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 164;
            this.label9.Text = "Price";
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(38, 150);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(219, 20);
            this.txt_Adress.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 163;
            this.label6.Text = "Adress";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(38, 72);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(219, 20);
            this.txt_LastName.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 162;
            this.label5.Text = "Last Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(536, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 35);
            this.btnCancel.TabIndex = 158;
            this.btnCancel.Text = "Cancel reservation";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(38, 33);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(219, 20);
            this.txt_FirstName.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 161;
            this.label2.Text = "First Name";
            // 
            // txt_OfficeName
            // 
            this.txt_OfficeName.Location = new System.Drawing.Point(38, 111);
            this.txt_OfficeName.Name = "txt_OfficeName";
            this.txt_OfficeName.Size = new System.Drawing.Size(219, 20);
            this.txt_OfficeName.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Office Name";
            // 
            // pbx_Picture
            // 
            this.pbx_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_Picture.Location = new System.Drawing.Point(426, 33);
            this.pbx_Picture.Name = "pbx_Picture";
            this.pbx_Picture.Size = new System.Drawing.Size(269, 231);
            this.pbx_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Picture.TabIndex = 159;
            this.pbx_Picture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 166;
            this.label3.Text = "Begin Rental Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 168;
            this.label4.Text = "End Rental Date";
            // 
            // dtp_BeginRentalDate
            // 
            this.dtp_BeginRentalDate.Location = new System.Drawing.Point(35, 269);
            this.dtp_BeginRentalDate.Name = "dtp_BeginRentalDate";
            this.dtp_BeginRentalDate.Size = new System.Drawing.Size(219, 20);
            this.dtp_BeginRentalDate.TabIndex = 169;
            // 
            // dtp_EndRentalDate
            // 
            this.dtp_EndRentalDate.Location = new System.Drawing.Point(35, 308);
            this.dtp_EndRentalDate.Name = "dtp_EndRentalDate";
            this.dtp_EndRentalDate.Size = new System.Drawing.Size(219, 20);
            this.dtp_EndRentalDate.TabIndex = 170;
            // 
            // txt_Days
            // 
            this.txt_Days.Location = new System.Drawing.Point(35, 228);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(219, 20);
            this.txt_Days.TabIndex = 171;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 172;
            this.label7.Text = "Days rented";
            // 
            // frmRentedOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 635);
            this.Controls.Add(this.txt_Days);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_EndRentalDate);
            this.Controls.Add(this.dtp_BeginRentalDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OfficeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_Picture);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRentedOffices";
            this.Text = "frmRentedOffices";
            this.Load += new System.EventHandler(this.frmRentedOffices_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRentedOffices;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OfficeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx_Picture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_BeginRentalDate;
        private System.Windows.Forms.DateTimePicker dtp_EndRentalDate;
        private System.Windows.Forms.TextBox txt_Days;
        private System.Windows.Forms.Label label7;
    }
}