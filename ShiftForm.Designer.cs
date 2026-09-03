namespace ComputingProject1
{
    partial class ShiftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftForm));
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.cboEmployeeID = new System.Windows.Forms.ComboBox();
            this.cboShiftType = new System.Windows.Forms.ComboBox();
            this.btnAssignShift = new System.Windows.Forms.Button();
            this.dgvShiftList = new System.Windows.Forms.DataGridView();
            this.lblChooseEmployee = new System.Windows.Forms.Label();
            this.lblChooseTime = new System.Windows.Forms.Label();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.lblShiftSchedule = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckMinimum = new System.Windows.Forms.Button();
            this.btnCalculateWages = new System.Windows.Forms.Button();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.lblAssignAShift = new System.Windows.Forms.Label();
            this.btnOpenAttendanceForm = new System.Windows.Forms.Button();
            this.cboEmployeeFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterByEmployee = new System.Windows.Forms.Button();
            this.lblScheduleFilters = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.AccessibleDescription = "select shift date";
            this.dtpShiftDate.CalendarFont = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShiftDate.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpShiftDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpShiftDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpShiftDate.Font = new System.Drawing.Font("Yet R", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpShiftDate.Location = new System.Drawing.Point(10, 83);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(244, 22);
            this.dtpShiftDate.TabIndex = 0;
            // 
            // cboEmployeeID
            // 
            this.cboEmployeeID.AccessibleDescription = "employee names";
            this.cboEmployeeID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cboEmployeeID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboEmployeeID.FormattingEnabled = true;
            this.cboEmployeeID.Location = new System.Drawing.Point(22, 174);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Size = new System.Drawing.Size(244, 21);
            this.cboEmployeeID.TabIndex = 1;
            // 
            // cboShiftType
            // 
            this.cboShiftType.AccessibleDescription = "shift types";
            this.cboShiftType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cboShiftType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboShiftType.FormattingEnabled = true;
            this.cboShiftType.Location = new System.Drawing.Point(10, 202);
            this.cboShiftType.Name = "cboShiftType";
            this.cboShiftType.Size = new System.Drawing.Size(244, 21);
            this.cboShiftType.TabIndex = 2;
            // 
            // btnAssignShift
            // 
            this.btnAssignShift.AccessibleDescription = "assign shift";
            this.btnAssignShift.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAssignShift.Font = new System.Drawing.Font("Yet R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAssignShift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAssignShift.Location = new System.Drawing.Point(28, 254);
            this.btnAssignShift.Name = "btnAssignShift";
            this.btnAssignShift.Size = new System.Drawing.Size(209, 40);
            this.btnAssignShift.TabIndex = 3;
            this.btnAssignShift.Text = "ASSIGN SHIFT";
            this.btnAssignShift.UseVisualStyleBackColor = false;
            this.btnAssignShift.Click += new System.EventHandler(this.btnAssignShift_Click);
            // 
            // dgvShiftList
            // 
            this.dgvShiftList.AccessibleDescription = "display assigned shifts";
            this.dgvShiftList.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvShiftList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShiftList.Location = new System.Drawing.Point(283, 67);
            this.dgvShiftList.Name = "dgvShiftList";
            this.dgvShiftList.Size = new System.Drawing.Size(335, 316);
            this.dgvShiftList.TabIndex = 4;
            // 
            // lblChooseEmployee
            // 
            this.lblChooseEmployee.AutoSize = true;
            this.lblChooseEmployee.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblChooseEmployee.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChooseEmployee.Location = new System.Drawing.Point(19, 154);
            this.lblChooseEmployee.Name = "lblChooseEmployee";
            this.lblChooseEmployee.Size = new System.Drawing.Size(85, 17);
            this.lblChooseEmployee.TabIndex = 6;
            this.lblChooseEmployee.Text = "Employee";
            // 
            // lblChooseTime
            // 
            this.lblChooseTime.AutoSize = true;
            this.lblChooseTime.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblChooseTime.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChooseTime.Location = new System.Drawing.Point(7, 182);
            this.lblChooseTime.Name = "lblChooseTime";
            this.lblChooseTime.Size = new System.Drawing.Size(48, 17);
            this.lblChooseTime.TabIndex = 7;
            this.lblChooseTime.Text = "Time";
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblChooseDate.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChooseDate.Location = new System.Drawing.Point(7, 63);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(47, 17);
            this.lblChooseDate.TabIndex = 8;
            this.lblChooseDate.Text = "Date";
            // 
            // lblShiftSchedule
            // 
            this.lblShiftSchedule.AutoSize = true;
            this.lblShiftSchedule.BackColor = System.Drawing.Color.Thistle;
            this.lblShiftSchedule.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShiftSchedule.Location = new System.Drawing.Point(88, 11);
            this.lblShiftSchedule.Name = "lblShiftSchedule";
            this.lblShiftSchedule.Size = new System.Drawing.Size(162, 22);
            this.lblShiftSchedule.TabIndex = 10;
            this.lblShiftSchedule.Text = "Shift Schedule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 658);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnAssignShift);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.lblChooseTime);
            this.panel1.Controls.Add(this.cboShiftType);
            this.panel1.Controls.Add(this.lblChooseDate);
            this.panel1.Controls.Add(this.dtpShiftDate);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 352);
            this.panel1.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRemove.Font = new System.Drawing.Font("Yet R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Location = new System.Drawing.Point(28, 300);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(209, 40);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "REMOVE SHIFT";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckMinimum
            // 
            this.btnCheckMinimum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheckMinimum.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckMinimum.Location = new System.Drawing.Point(22, 508);
            this.btnCheckMinimum.Name = "btnCheckMinimum";
            this.btnCheckMinimum.Size = new System.Drawing.Size(227, 39);
            this.btnCheckMinimum.TabIndex = 15;
            this.btnCheckMinimum.Text = "Check Minimum";
            this.btnCheckMinimum.UseVisualStyleBackColor = false;
            this.btnCheckMinimum.Click += new System.EventHandler(this.btnCheckMinimum_Click);
            // 
            // btnCalculateWages
            // 
            this.btnCalculateWages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalculateWages.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalculateWages.Location = new System.Drawing.Point(22, 463);
            this.btnCalculateWages.Name = "btnCalculateWages";
            this.btnCalculateWages.Size = new System.Drawing.Size(227, 39);
            this.btnCalculateWages.TabIndex = 16;
            this.btnCalculateWages.Text = "View Weekly Wages";
            this.btnCalculateWages.UseVisualStyleBackColor = false;
            this.btnCalculateWages.Click += new System.EventHandler(this.btnCalculateWages_Click);
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFilterDate.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFilterDate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFilterDate.Location = new System.Drawing.Point(169, 82);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(154, 28);
            this.btnFilterDate.TabIndex = 17;
            this.btnFilterDate.Text = "Filter by Date";
            this.btnFilterDate.UseVisualStyleBackColor = false;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.BackColor = System.Drawing.Color.Indigo;
            this.btnRemoveFilter.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemoveFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveFilter.Location = new System.Drawing.Point(92, 125);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(154, 29);
            this.btnRemoveFilter.TabIndex = 18;
            this.btnRemoveFilter.Text = "Remove Filters";
            this.btnRemoveFilter.UseVisualStyleBackColor = false;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // lblAssignAShift
            // 
            this.lblAssignAShift.AutoSize = true;
            this.lblAssignAShift.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblAssignAShift.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAssignAShift.Location = new System.Drawing.Point(62, 42);
            this.lblAssignAShift.Name = "lblAssignAShift";
            this.lblAssignAShift.Size = new System.Drawing.Size(159, 22);
            this.lblAssignAShift.TabIndex = 19;
            this.lblAssignAShift.Text = "Assign a Shift";
            // 
            // btnOpenAttendanceForm
            // 
            this.btnOpenAttendanceForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenAttendanceForm.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenAttendanceForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenAttendanceForm.Location = new System.Drawing.Point(22, 404);
            this.btnOpenAttendanceForm.Name = "btnOpenAttendanceForm";
            this.btnOpenAttendanceForm.Size = new System.Drawing.Size(237, 45);
            this.btnOpenAttendanceForm.TabIndex = 20;
            this.btnOpenAttendanceForm.Text = "MANAGE ATTENDANCE";
            this.btnOpenAttendanceForm.UseVisualStyleBackColor = false;
            this.btnOpenAttendanceForm.Click += new System.EventHandler(this.btnOpenAttendanceForm_Click);
            // 
            // cboEmployeeFilter
            // 
            this.cboEmployeeFilter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboEmployeeFilter.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboEmployeeFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cboEmployeeFilter.FormattingEnabled = true;
            this.cboEmployeeFilter.Location = new System.Drawing.Point(6, 51);
            this.cboEmployeeFilter.Name = "cboEmployeeFilter";
            this.cboEmployeeFilter.Size = new System.Drawing.Size(154, 25);
            this.cboEmployeeFilter.TabIndex = 21;
            this.cboEmployeeFilter.Text = "Select Employee";
            // 
            // btnFilterByEmployee
            // 
            this.btnFilterByEmployee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFilterByEmployee.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFilterByEmployee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilterByEmployee.Location = new System.Drawing.Point(6, 82);
            this.btnFilterByEmployee.Name = "btnFilterByEmployee";
            this.btnFilterByEmployee.Size = new System.Drawing.Size(154, 28);
            this.btnFilterByEmployee.TabIndex = 22;
            this.btnFilterByEmployee.Text = "Filter by Employee";
            this.btnFilterByEmployee.UseVisualStyleBackColor = false;
            this.btnFilterByEmployee.Click += new System.EventHandler(this.btnFilterByEmployee_Click);
            // 
            // lblScheduleFilters
            // 
            this.lblScheduleFilters.AutoSize = true;
            this.lblScheduleFilters.BackColor = System.Drawing.Color.MediumPurple;
            this.lblScheduleFilters.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScheduleFilters.Location = new System.Drawing.Point(132, 15);
            this.lblScheduleFilters.Name = "lblScheduleFilters";
            this.lblScheduleFilters.Size = new System.Drawing.Size(77, 22);
            this.lblScheduleFilters.TabIndex = 23;
            this.lblScheduleFilters.Tag = "";
            this.lblScheduleFilters.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.btnFilterByEmployee);
            this.panel2.Controls.Add(this.lblScheduleFilters);
            this.panel2.Controls.Add(this.cboEmployeeFilter);
            this.panel2.Controls.Add(this.btnFilterDate);
            this.panel2.Controls.Add(this.btnRemoveFilter);
            this.panel2.Location = new System.Drawing.Point(283, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 167);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.lblShiftSchedule);
            this.panel3.Location = new System.Drawing.Point(283, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 182);
            this.panel3.TabIndex = 25;
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 606);
            this.Controls.Add(this.btnOpenAttendanceForm);
            this.Controls.Add(this.lblAssignAShift);
            this.Controls.Add(this.btnCalculateWages);
            this.Controls.Add(this.btnCheckMinimum);
            this.Controls.Add(this.lblChooseEmployee);
            this.Controls.Add(this.dgvShiftList);
            this.Controls.Add(this.cboEmployeeID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShiftForm";
            this.Text = "ShiftForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.ComboBox cboEmployeeID;
        private System.Windows.Forms.ComboBox cboShiftType;
        private System.Windows.Forms.Button btnAssignShift;
        private System.Windows.Forms.DataGridView dgvShiftList;
        private System.Windows.Forms.Label lblChooseEmployee;
        private System.Windows.Forms.Label lblChooseTime;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.Label lblShiftSchedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckMinimum;
        private System.Windows.Forms.Button btnCalculateWages;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Label lblAssignAShift;
        private System.Windows.Forms.Button btnOpenAttendanceForm;
        private System.Windows.Forms.ComboBox cboEmployeeFilter;
        private System.Windows.Forms.Button btnFilterByEmployee;
        private System.Windows.Forms.Label lblScheduleFilters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}