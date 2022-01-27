
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
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditOfficesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentedBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buildingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.addUserToolStripMenuItem});
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
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = "Add / Edit User";
            // 
            // officeToolStripMenuItem
            // 
            this.officeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem1,
            this.addEditOfficesToolStripMenuItem,
            this.viewRentedToolStripMenuItem});
            this.officeToolStripMenuItem.Name = "officeToolStripMenuItem";
            this.officeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.officeToolStripMenuItem.Text = "Offices";
            // 
            // buildingsToolStripMenuItem
            // 
            this.buildingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayBuildingsToolStripMenuItem,
            this.addEditBuildingsToolStripMenuItem,
            this.rentedBuildingsToolStripMenuItem});
            this.buildingsToolStripMenuItem.Name = "buildingsToolStripMenuItem";
            this.buildingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.buildingsToolStripMenuItem.Text = "Buildings";
            // 
            // displayToolStripMenuItem1
            // 
            this.displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            this.displayToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem1.Text = "Display Offices";
            // 
            // addEditOfficesToolStripMenuItem
            // 
            this.addEditOfficesToolStripMenuItem.Name = "addEditOfficesToolStripMenuItem";
            this.addEditOfficesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEditOfficesToolStripMenuItem.Text = "Add/Edit Offices";
            // 
            // viewRentedToolStripMenuItem
            // 
            this.viewRentedToolStripMenuItem.Name = "viewRentedToolStripMenuItem";
            this.viewRentedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRentedToolStripMenuItem.Text = "Rented Offices";
            // 
            // displayBuildingsToolStripMenuItem
            // 
            this.displayBuildingsToolStripMenuItem.Name = "displayBuildingsToolStripMenuItem";
            this.displayBuildingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayBuildingsToolStripMenuItem.Text = "Display Buildings";
            // 
            // addEditBuildingsToolStripMenuItem
            // 
            this.addEditBuildingsToolStripMenuItem.Name = "addEditBuildingsToolStripMenuItem";
            this.addEditBuildingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEditBuildingsToolStripMenuItem.Text = "Add/Edit Buildings";
            // 
            // rentedBuildingsToolStripMenuItem
            // 
            this.rentedBuildingsToolStripMenuItem.Name = "rentedBuildingsToolStripMenuItem";
            this.rentedBuildingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rentedBuildingsToolStripMenuItem.Text = "Rented Buildings";
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
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEditOfficesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRentedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBuildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEditBuildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentedBuildingsToolStripMenuItem;
    }
}



