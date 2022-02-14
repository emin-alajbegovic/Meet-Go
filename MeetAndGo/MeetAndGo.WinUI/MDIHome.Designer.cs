
namespace MeetAndGo.WinUI
{
    partial class MDIHome
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentedBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.officesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 602);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.officeToolStripMenuItem,
            this.buildingsToolStripMenuItem,
            this.rentedToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "Display Users";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // officeToolStripMenuItem
            // 
            this.officeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem1,
            this.addOfficeToolStripMenuItem,
            this.viewRentedToolStripMenuItem});
            this.officeToolStripMenuItem.Name = "officeToolStripMenuItem";
            this.officeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.officeToolStripMenuItem.Text = "Offices";
            // 
            // displayToolStripMenuItem1
            // 
            this.displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            this.displayToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem1.Text = "Display Offices";
            this.displayToolStripMenuItem1.Click += new System.EventHandler(this.displayToolStripMenuItem1_Click);
            // 
            // addOfficeToolStripMenuItem
            // 
            this.addOfficeToolStripMenuItem.Name = "addOfficeToolStripMenuItem";
            this.addOfficeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addOfficeToolStripMenuItem.Text = "Add Office";
            this.addOfficeToolStripMenuItem.Click += new System.EventHandler(this.addOfficeToolStripMenuItem_Click);
            // 
            // viewRentedToolStripMenuItem
            // 
            this.viewRentedToolStripMenuItem.Name = "viewRentedToolStripMenuItem";
            this.viewRentedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRentedToolStripMenuItem.Text = "Rented Offices";
            // 
            // buildingsToolStripMenuItem
            // 
            this.buildingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayBuildingsToolStripMenuItem,
            this.addBuildingToolStripMenuItem,
            this.rentedBuildingsToolStripMenuItem});
            this.buildingsToolStripMenuItem.Name = "buildingsToolStripMenuItem";
            this.buildingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.buildingsToolStripMenuItem.Text = "Buildings";
            // 
            // displayBuildingsToolStripMenuItem
            // 
            this.displayBuildingsToolStripMenuItem.Name = "displayBuildingsToolStripMenuItem";
            this.displayBuildingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.displayBuildingsToolStripMenuItem.Text = "Display Buildings";
            this.displayBuildingsToolStripMenuItem.Click += new System.EventHandler(this.displayBuildingsToolStripMenuItem_Click);
            // 
            // addBuildingToolStripMenuItem
            // 
            this.addBuildingToolStripMenuItem.Name = "addBuildingToolStripMenuItem";
            this.addBuildingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBuildingToolStripMenuItem.Text = "Add Building";
            this.addBuildingToolStripMenuItem.Click += new System.EventHandler(this.addBuildingToolStripMenuItem_Click);
            // 
            // rentedBuildingsToolStripMenuItem
            // 
            this.rentedBuildingsToolStripMenuItem.Name = "rentedBuildingsToolStripMenuItem";
            this.rentedBuildingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rentedBuildingsToolStripMenuItem.Text = "Rented Buildings";
            // 
            // rentedToolStripMenuItem
            // 
            this.rentedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildingsToolStripMenuItem1,
            this.officesToolStripMenuItem});
            this.rentedToolStripMenuItem.Name = "rentedToolStripMenuItem";
            this.rentedToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.rentedToolStripMenuItem.Text = "Rented";
            // 
            // buildingsToolStripMenuItem1
            // 
            this.buildingsToolStripMenuItem1.Name = "buildingsToolStripMenuItem1";
            this.buildingsToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.buildingsToolStripMenuItem1.Text = "Buildings";
            // 
            // officesToolStripMenuItem
            // 
            this.officesToolStripMenuItem.Name = "officesToolStripMenuItem";
            this.officesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.officesToolStripMenuItem.Text = "Offices";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MDIHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 624);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIHome";
            this.Text = "MDIHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewRentedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBuildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentedBuildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem officesToolStripMenuItem;
    }
}



