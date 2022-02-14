
namespace MeetAndGo.WinUI.Building
{
    partial class frmBuildingDetails
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
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(16, 142);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(219, 20);
            this.txt_Phone.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Phone";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(15, 25);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(219, 20);
            this.txt_LastName.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Last Name";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(16, 103);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(219, 20);
            this.txt_Email.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(16, 64);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(219, 20);
            this.txt_FirstName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "First Name";
            // 
            // frmBuildingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmBuildingDetails";
            this.Text = "frmBuildingDetails";
            this.Load += new System.EventHandler(this.frmBuildingDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label1;
    }
}