
namespace MeetAndGo.WinUI.User
{
    partial class frmAddUser
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.Floors = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(256, 64);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(219, 20);
            this.txt_Password.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Password";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(256, 25);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(219, 20);
            this.txt_Email.TabIndex = 71;
            // 
            // Floors
            // 
            this.Floors.AutoSize = true;
            this.Floors.Location = new System.Drawing.Point(253, 9);
            this.Floors.Name = "Floors";
            this.Floors.Size = new System.Drawing.Size(32, 13);
            this.Floors.TabIndex = 73;
            this.Floors.Text = "Email";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(15, 103);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(219, 20);
            this.txt_PhoneNumber.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Role";
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(256, 103);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(219, 21);
            this.cmb_Role.TabIndex = 65;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 35);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(15, 64);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(219, 20);
            this.txt_LastName.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(15, 25);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(219, 20);
            this.txt_FirstName.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "First Name";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 193);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.Floors);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Role);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddUser";
            this.Text = "frmAddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label Floors;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label1;
    }
}