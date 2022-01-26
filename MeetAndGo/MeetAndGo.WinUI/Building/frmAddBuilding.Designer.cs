
namespace MeetAndGo.WinUI.Building
{
    partial class frmAddBuilding
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Countries = new System.Windows.Forms.ComboBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.pbx_Picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Cities = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(122, 326);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(159, 35);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Country";
            // 
            // cmb_Countries
            // 
            this.cmb_Countries.FormattingEnabled = true;
            this.cmb_Countries.Location = new System.Drawing.Point(103, 228);
            this.cmb_Countries.Name = "cmb_Countries";
            this.cmb_Countries.Size = new System.Drawing.Size(219, 21);
            this.cmb_Countries.TabIndex = 26;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(103, 167);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(219, 20);
            this.txt_Location.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Location";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(103, 105);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(219, 20);
            this.txt_Name.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(513, 326);
            this.txtSlika.Multiline = true;
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(188, 35);
            this.txtSlika.TabIndex = 30;
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(432, 326);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadImage.TabIndex = 27;
            this.btn_LoadImage.Text = "...";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            // 
            // pbx_Picture
            // 
            this.pbx_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_Picture.Location = new System.Drawing.Point(432, 89);
            this.pbx_Picture.Name = "pbx_Picture";
            this.pbx_Picture.Size = new System.Drawing.Size(269, 231);
            this.pbx_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Picture.TabIndex = 29;
            this.pbx_Picture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "City";
            // 
            // cmb_Cities
            // 
            this.cmb_Cities.FormattingEnabled = true;
            this.cmb_Cities.Location = new System.Drawing.Point(103, 282);
            this.cmb_Cities.Name = "cmb_Cities";
            this.cmb_Cities.Size = new System.Drawing.Size(219, 21);
            this.cmb_Cities.TabIndex = 34;
            // 
            // frmAddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Cities);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Countries);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.btn_LoadImage);
            this.Controls.Add(this.pbx_Picture);
            this.Name = "frmAddBuilding";
            this.Text = "frmAddBuilding";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Countries;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.PictureBox pbx_Picture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Cities;
    }
}