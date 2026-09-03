namespace ComputingProject1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShift = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblCheckInventory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTimeOffRequests = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSalaries = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMonthlyReviews = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegisterEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.Color.Lavender;
            this.btnShift.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShift.Location = new System.Drawing.Point(89, 125);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(214, 39);
            this.btnShift.TabIndex = 1;
            this.btnShift.Text = "Shifts";
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-189, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 546);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMenu.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(120, 76);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(152, 32);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Manager Menu";
            // 
            // lblCheckInventory
            // 
            this.lblCheckInventory.AutoSize = true;
            this.lblCheckInventory.BackColor = System.Drawing.Color.Lavender;
            this.lblCheckInventory.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCheckInventory.Location = new System.Drawing.Point(16, 9);
            this.lblCheckInventory.Name = "lblCheckInventory";
            this.lblCheckInventory.Size = new System.Drawing.Size(179, 22);
            this.lblCheckInventory.TabIndex = 10;
            this.lblCheckInventory.Text = "Check Inventory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.lblCheckInventory);
            this.panel2.Location = new System.Drawing.Point(89, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 39);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.lblTimeOffRequests);
            this.panel3.Location = new System.Drawing.Point(89, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 39);
            this.panel3.TabIndex = 7;
            // 
            // lblTimeOffRequests
            // 
            this.lblTimeOffRequests.AutoSize = true;
            this.lblTimeOffRequests.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTimeOffRequests.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimeOffRequests.Location = new System.Drawing.Point(8, 9);
            this.lblTimeOffRequests.Name = "lblTimeOffRequests";
            this.lblTimeOffRequests.Size = new System.Drawing.Size(206, 22);
            this.lblTimeOffRequests.TabIndex = 12;
            this.lblTimeOffRequests.Text = "Time Off Requests";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.lblSalaries);
            this.panel4.Location = new System.Drawing.Point(89, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 39);
            this.panel4.TabIndex = 8;
            // 
            // lblSalaries
            // 
            this.lblSalaries.AutoSize = true;
            this.lblSalaries.BackColor = System.Drawing.Color.Lavender;
            this.lblSalaries.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSalaries.Location = new System.Drawing.Point(58, 9);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(94, 22);
            this.lblSalaries.TabIndex = 13;
            this.lblSalaries.Text = "Salaries";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.panel5.Controls.Add(this.lblMonthlyReviews);
            this.panel5.Location = new System.Drawing.Point(89, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 39);
            this.panel5.TabIndex = 9;
            // 
            // lblMonthlyReviews
            // 
            this.lblMonthlyReviews.AutoSize = true;
            this.lblMonthlyReviews.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMonthlyReviews.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMonthlyReviews.Location = new System.Drawing.Point(16, 9);
            this.lblMonthlyReviews.Name = "lblMonthlyReviews";
            this.lblMonthlyReviews.Size = new System.Drawing.Size(183, 22);
            this.lblMonthlyReviews.TabIndex = 14;
            this.lblMonthlyReviews.Text = "Monthly Reviews";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.lblRegisterEmployee);
            this.panel1.Location = new System.Drawing.Point(89, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 39);
            this.panel1.TabIndex = 13;
            // 
            // lblRegisterEmployee
            // 
            this.lblRegisterEmployee.AutoSize = true;
            this.lblRegisterEmployee.BackColor = System.Drawing.Color.GhostWhite;
            this.lblRegisterEmployee.Font = new System.Drawing.Font("Yet R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRegisterEmployee.Location = new System.Drawing.Point(8, 9);
            this.lblRegisterEmployee.Name = "lblRegisterEmployee";
            this.lblRegisterEmployee.Size = new System.Drawing.Size(203, 22);
            this.lblRegisterEmployee.TabIndex = 12;
            this.lblRegisterEmployee.Text = "Register Employee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCheckInventory;
        private System.Windows.Forms.Label lblTimeOffRequests;
        private System.Windows.Forms.Label lblSalaries;
        private System.Windows.Forms.Label lblMonthlyReviews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegisterEmployee;
    }
}

