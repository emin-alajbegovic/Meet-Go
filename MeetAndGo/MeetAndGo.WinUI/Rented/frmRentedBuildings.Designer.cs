
namespace MeetAndGo.WinUI.Rented
{
    partial class frmRentedBuildings
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
            this.dgvRentedBuildings = new System.Windows.Forms.DataGridView();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuildingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_Picture = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedBuildings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRentedBuildings);
            this.groupBox1.Location = new System.Drawing.Point(38, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 267);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Buildings";
            // 
            // dgvRentedBuildings
            // 
            this.dgvRentedBuildings.AllowUserToAddRows = false;
            this.dgvRentedBuildings.AllowUserToDeleteRows = false;
            this.dgvRentedBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedBuildings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentedBuildings.Location = new System.Drawing.Point(3, 16);
            this.dgvRentedBuildings.Name = "dgvRentedBuildings";
            this.dgvRentedBuildings.ReadOnly = true;
            this.dgvRentedBuildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentedBuildings.Size = new System.Drawing.Size(657, 248);
            this.dgvRentedBuildings.TabIndex = 0;
            this.dgvRentedBuildings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedBuildings_CellDoubleClick);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(41, 196);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(219, 20);
            this.txt_Price.TabIndex = 169;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 176;
            this.label9.Text = "Price";
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(41, 157);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(219, 20);
            this.txt_Adress.TabIndex = 168;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 175;
            this.label6.Text = "Adress";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(41, 79);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(219, 20);
            this.txt_LastName.TabIndex = 167;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 174;
            this.label5.Text = "Last Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(539, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 35);
            this.btnCancel.TabIndex = 170;
            this.btnCancel.Text = "Cancel reservation";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(41, 40);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(219, 20);
            this.txt_FirstName.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 173;
            this.label2.Text = "First Name";
            // 
            // txt_BuildingName
            // 
            this.txt_BuildingName.Location = new System.Drawing.Point(41, 118);
            this.txt_BuildingName.Name = "txt_BuildingName";
            this.txt_BuildingName.Size = new System.Drawing.Size(219, 20);
            this.txt_BuildingName.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 172;
            this.label1.Text = "Building Name";
            // 
            // pbx_Picture
            // 
            this.pbx_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_Picture.Location = new System.Drawing.Point(429, 24);
            this.pbx_Picture.Name = "pbx_Picture";
            this.pbx_Picture.Size = new System.Drawing.Size(269, 231);
            this.pbx_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Picture.TabIndex = 171;
            this.pbx_Picture.TabStop = false;
            // 
            // frmRentedBuildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 625);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbx_Picture);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_BuildingName);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmRentedBuildings";
            this.Text = "frmRentedBuildings";
            this.Load += new System.EventHandler(this.frmRentedBuildings_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedBuildings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRentedBuildings;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BuildingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx_Picture;
    }
}