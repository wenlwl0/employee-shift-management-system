using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static ComputingProject1.ShiftForm;

namespace ComputingProject1
{
    public partial class AttendanceForm : Form
    {
        private List<Shift> ShiftList;
        private List<Employee> employeeList;

        public AttendanceForm(List<Employee> employees, List<Shift> shifts)
        {
            InitializeComponent();
            employeeList = employees;
            ShiftList = shifts;
            LoadAttendanceData();
        }

        //moves dgvShiftList from ShiftForm.cs to AttendanceForm.cs
        private void LoadAttendanceData()
        {
            DataTable dt = new DataTable();

            //columns
            dt.Columns.Add("Employee");
            dt.Columns.Add("Shift Date", typeof(DateTime));
            dt.Columns.Add("Shift Type");
            var sortedShifts = ShiftList.OrderByDescending(s => s.Date).ToList();

            foreach (var shift in sortedShifts)
            {
                var employee = employeeList.FirstOrDefault(e => e.EmployeeID == shift.EmployeeID);
                if (employee != null)
                {
                    DataRow row = dt.NewRow();
                    row["Employee"] = employee.FullName;

                    row["Shift Date"] = shift.Date.Date;  

                    row["Shift Type"] = shift.ShiftType;

                    dt.Rows.Add(row);
                }
            }
            dgvShiftList.DataSource = dt;
        }

        public class Shift
        {
            public int ShiftID { get; set; }
            public int EmployeeID { get; set; }
            public DateTime Date { get; set; }
            public string ShiftType { get; set; }
        }
    }
}
