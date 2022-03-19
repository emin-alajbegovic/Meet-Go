
namespace MeetAndGo.WinUI.User
{
    partial class frmUserDetails
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
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisplayReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(248, 72);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(219, 79);
            this.clbRole.TabIndex = 0;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(10, 131);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(219, 20);
            this.txt_Phone.TabIndex = 34;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(10, 79);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(219, 20);
            this.txt_LastName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(10, 27);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(219, 20);
            this.txt_FirstName.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phone Number";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(248, 27);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(219, 20);
            this.txt_Email.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Email";
            // 
            // btnDisplayReservations
            // 
            this.btnDisplayReservations.Location = new System.Drawing.Point(341, 177);
            this.btnDisplayReservations.Name = "btnDisplayReservations";
            this.btnDisplayReservations.Size = new System.Drawing.Size(126, 23);
            this.btnDisplayReservations.TabIndex = 43;
            this.btnDisplayReservations.Text = "Display reservations";
            this.btnDisplayReservations.UseVisualStyleBackColor = true;
            this.btnDisplayReservations.Click += new System.EventHandler(this.btnDisplayReservations_Click);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 212);
            this.Controls.Add(this.btnDisplayReservations);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbRole);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbRole;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisplayReservations;
    }
}