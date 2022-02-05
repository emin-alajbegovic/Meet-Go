
namespace MeetAndGo.WinUI.Office
{
    partial class frmDisplayOffice
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRented = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOffices = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRented);
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbRented
            // 
            this.cmbRented.FormattingEnabled = true;
            this.cmbRented.Location = new System.Drawing.Point(217, 53);
            this.cmbRented.Name = "cmbRented";
            this.cmbRented.Size = new System.Drawing.Size(152, 21);
            this.cmbRented.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(6, 53);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(156, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(584, 50);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(122, 23);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOffices);
            this.groupBox1.Location = new System.Drawing.Point(38, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offices";
            // 
            // dgvOffices
            // 
            this.dgvOffices.AllowUserToAddRows = false;
            this.dgvOffices.AllowUserToDeleteRows = false;
            this.dgvOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOffices.Location = new System.Drawing.Point(3, 16);
            this.dgvOffices.Name = "dgvOffices";
            this.dgvOffices.ReadOnly = true;
            this.dgvOffices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffices.Size = new System.Drawing.Size(724, 299);
            this.dgvOffices.TabIndex = 0;
            this.dgvOffices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOffices_CellDoubleClick);
            // 
            // frmDisplayOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDisplayOffice";
            this.Text = "frmDisplayOffice";
            this.Load += new System.EventHandler(this.frmDisplayForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRented;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOffices;
    }
}