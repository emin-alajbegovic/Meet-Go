
namespace MeetAndGo.WinUI.Report
{
    partial class frmRentedByUserCount
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
            this.dgv_Report = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Report
            // 
            this.dgv_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Report.Location = new System.Drawing.Point(50, 44);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.Size = new System.Drawing.Size(662, 313);
            this.dgv_Report.TabIndex = 0;
            // 
            // frmRentedByUserCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 392);
            this.Controls.Add(this.dgv_Report);
            this.Name = "frmRentedByUserCount";
            this.Text = "frmRentedByUserCount";
            this.Load += new System.EventHandler(this.frmRentedByUserCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Report;
    }
}