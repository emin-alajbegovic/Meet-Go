
namespace MeetAndGo.WinUI.Office
{
    partial class frmAddOffice
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
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(122, 318);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(159, 35);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Grad";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(103, 247);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(219, 21);
            this.cmbGradovi.TabIndex = 26;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(103, 175);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(219, 20);
            this.txtLokacija.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lokacija";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(103, 105);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(219, 20);
            this.txtNaziv.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Naziv";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(513, 326);
            this.txtSlika.Multiline = true;
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(188, 35);
            this.txtSlika.TabIndex = 30;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(432, 326);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajSliku.TabIndex = 27;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            // 
            // pbxSlika
            // 
            this.pbxSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSlika.Location = new System.Drawing.Point(432, 89);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(269, 231);
            this.pbxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSlika.TabIndex = 29;
            this.pbxSlika.TabStop = false;
            // 
            // frmAddOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.pbxSlika);
            this.Name = "frmAddOffice";
            this.Text = "frmAddOffice";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.PictureBox pbxSlika;
    }
}