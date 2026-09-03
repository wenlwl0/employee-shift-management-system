namespace ComputingProject1
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.dgvShiftList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblShiftSchedule = new System.Windows.Forms.Label();
            this.lblManageAttendanceTitle = new System.Windows.Forms.Label();
            this.present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Late = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Absent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShiftList
            // 
            this.dgvShiftList.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvShiftList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShiftList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.present,
            this.Late,
            this.Absent});
            this.dgvShiftList.Location = new System.Drawing.Point(-44, 30);
            this.dgvShiftList.Name = "dgvShiftList";
            this.dgvShiftList.Size = new System.Drawing.Size(543, 507);
            this.dgvShiftList.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 624);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.lblShiftSchedule);
            this.panel3.Controls.Add(this.dgvShiftList);
            this.panel3.Location = new System.Drawing.Point(63, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 463);
            this.panel3.TabIndex = 27;
            // 
            // lblShiftSchedule
            // 
            this.lblShiftSchedule.AutoSize = true;
            this.lblShiftSchedule.BackColor = System.Drawing.Color.LightCyan;
            this.lblShiftSchedule.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShiftSchedule.Location = new System.Drawing.Point(165, 5);
            this.lblShiftSchedule.Name = "lblShiftSchedule";
            this.lblShiftSchedule.Size = new System.Drawing.Size(162, 22);
            this.lblShiftSchedule.TabIndex = 10;
            this.lblShiftSchedule.Text = "Shift Schedule";
            // 
            // lblManageAttendanceTitle
            // 
            this.lblManageAttendanceTitle.AutoSize = true;
            this.lblManageAttendanceTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblManageAttendanceTitle.Font = new System.Drawing.Font("Yet R", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageAttendanceTitle.Location = new System.Drawing.Point(188, 34);
            this.lblManageAttendanceTitle.Name = "lblManageAttendanceTitle";
            this.lblManageAttendanceTitle.Size = new System.Drawing.Size(256, 28);
            this.lblManageAttendanceTitle.TabIndex = 11;
            this.lblManageAttendanceTitle.Text = "Manage Attendance";
            // 
            // present
            // 
            this.present.HeaderText = "Present";
            this.present.Name = "present";
            this.present.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.present.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.present.Width = 60;
            // 
            // Late
            // 
            this.Late.HeaderText = "Late";
            this.Late.Name = "Late";
            this.Late.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Late.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Late.Width = 60;
            // 
            // Absent
            // 
            this.Absent.HeaderText = "Absent";
            this.Absent.Name = "Absent";
            this.Absent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Absent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Absent.Width = 60;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 606);
            this.Controls.Add(this.lblManageAttendanceTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShiftList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblShiftSchedule;
        private System.Windows.Forms.Label lblManageAttendanceTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn present;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Late;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Absent;
    }
}