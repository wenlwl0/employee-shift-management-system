using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingProject1
{

    public partial class ShiftForm : Form
    {
        private List<Shift> ShiftList = new List<Shift>();
        private List<Employee> employeeList;

        //how much each employee is paid per shift
        public decimal WagePerShift = 50;

        //company rules - maximum no. of shifts per employee per week
        private int MaxShiftsPerWeek = 4;

        //company rules - minimum no. of shifts per employee per week
        private int MinShiftsPerWeek = 2;


        public class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName => FirstName + " " + LastName;
        }

        //counts how many shifts an employee is booked for for that week
        private int CountShiftsForWeek(int pEmployeeID, DateTime pDate)
        {
            int lDayNumber = (int)pDate.DayOfWeek;
            if (lDayNumber == 0) lDayNumber = 7;
            DateTime lWeekStart = pDate.AddDays(-(lDayNumber - 1)).Date;
            DateTime lWeekEnd = lWeekStart.AddDays(6).Date;
            int lCount = 0;
            foreach (Shift lShift in ShiftList)
            {
                if (lShift.EmployeeID == pEmployeeID)
                {
                    if (lShift.Date.Date >= lWeekStart && lShift.Date.Date <= lWeekEnd)
                    {
                        lCount = lCount + 1;
                    }
                }
            }
            return lCount;
        }

        public ShiftForm()
        {
            InitializeComponent();
            this.Load += ShiftForm_Load;
        }

        //List of Employees
        private void ShiftForm_Load(object sender, EventArgs e)
        {
            employeeList = new List<Employee>
    {
        new Employee { EmployeeID = 1, FirstName = "Harry", LastName = "Potter" },
        new Employee { EmployeeID = 2, FirstName = "Hermione", LastName = "Granger" },
        new Employee { EmployeeID = 3, FirstName = "Ron", LastName = "Weasley" },
        new Employee { EmployeeID = 4, FirstName = "Draco", LastName = "Malfoy" },
        new Employee { EmployeeID = 5, FirstName = "Cedric", LastName = "Diggory" },
        new Employee { EmployeeID = 6, FirstName = "Neville", LastName = "Longbottom" },
        new Employee { EmployeeID = 7, FirstName = "Luna", LastName = "Lovegood" },
        new Employee { EmployeeID = 8, FirstName = "Pansy", LastName = "Parkinson" },
        new Employee { EmployeeID = 9, FirstName = "Ginny", LastName = "Weasley" },
        new Employee { EmployeeID = 10, FirstName = "Fred", LastName = "Weasley" },
    };
            //sets employee list in alphabetical order
            employeeList = employeeList.OrderBy(emp => emp.FullName).ToList();
            // employee list in combo box
            cboEmployeeID.DataSource = employeeList;
            cboEmployeeID.DisplayMember = "FullName";
            cboEmployeeID.ValueMember = "EmployeeID";
  
            cboEmployeeFilter.DataSource = employeeList;
            cboEmployeeFilter.DisplayMember = "FullName";
            cboEmployeeFilter.ValueMember = "EmployeeID";

            //types of shifts
            cboShiftType.Items.Clear();
            cboShiftType.Items.Add("7am - 10am");
            cboShiftType.Items.Add("10am - 1pm");
            cboShiftType.Items.Add("1pm - 4pm");
            cboShiftType.Items.Add("4pm - 7pm");
            cboShiftType.Items.Add("7pm - 10pm");
            cboShiftType.SelectedIndex = 0;
        }

        //button to assign shift
        private void btnAssignShift_Click(object sender, EventArgs e)
        {
            //if user doesnt select any employee
            if (cboEmployeeID.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            //takes selections from date picker + employee & time comboboxes
            var selectedEmployee = (Employee)cboEmployeeID.SelectedItem;
            Employee lEmployee = (Employee)cboEmployeeID.SelectedItem;
            DateTime lDate = dtpShiftDate.Value;
            string lShiftType = cboShiftType.SelectedItem.ToString();
            int lEmployeeID = lEmployee.EmployeeID;

            //same employee cannot be double booked for same shift
            foreach (Shift lShift in ShiftList)
            {
                if (lShift.EmployeeID == lEmployeeID &&
                    lShift.Date.Date == lDate.Date &&
                    lShift.ShiftType == lShiftType)
                {
                    MessageBox.Show("This employee already has this shift.");
                    return;
                }
            }

            //company rule - no more than 3 employees working the same shift
            int lWorkerCount = 0;
            foreach (Shift lShift in ShiftList)
            {
                if (lShift.Date.Date == lDate.Date &&
                    lShift.ShiftType == lShiftType)
                {
                    lWorkerCount = lWorkerCount + 1;
                }
            }

            if (lWorkerCount >= 3)
            {
                MessageBox.Show("There are already 3 employees on this shift.");
                return;
            }

            //company rule - maximum of 4 shifts per employee per week
            int lShiftsThisWeek = CountShiftsForWeek(lEmployeeID, lDate);

            if (lShiftsThisWeek >= MaxShiftsPerWeek)
            {
                MessageBox.Show("This employee already has 4 shifts this week.");
                return;
            }

            //creating the shift
            Shift lNewShift = new Shift();
            lNewShift.ShiftID = ShiftList.Count + 1;
            lNewShift.Date = lDate;
            lNewShift.ShiftType = lShiftType;
            lNewShift.EmployeeID = lEmployeeID;
            ShiftList.Add(lNewShift);
            UpdateShiftGrid();

            //company rules - maximum shifts per employee per week
            int weeklyShifts = CountShiftsForWeek(selectedEmployee.EmployeeID, lNewShift.Date);

            if (weeklyShifts >= 5)
            {
                MessageBox.Show("This employee already has 5 shifts this week.");
                return;
            }

        }

        //updating shift grid
        private void UpdateShiftGrid(DateTime? filterDate = null, int? employeeID = null)
        {
            DataTable lTable = new DataTable();

            //columns
            lTable.Columns.Add("Employee");
            lTable.Columns.Add("Date", typeof(DateTime)); 
            lTable.Columns.Add("Shift");
            lTable.Columns.Add("ShiftOrder", typeof(int)); 

            List<Employee> lEmployeeList = (List<Employee>)cboEmployeeID.DataSource;

            // shift order
            int GetShiftOrder(string shiftType)
            {
                if (shiftType == "7am - 10am") return 1;
                else if (shiftType == "10am - 1pm") return 2;
                else if (shiftType == "1pm - 4pm") return 3;
                else if (shiftType == "4pm - 7pm") return 4;
                else if (shiftType == "7pm - 10pm") return 5;
                else return 0;
            }

            //filtering
            foreach (Shift lShift in ShiftList)
            {
                if (employeeID.HasValue && lShift.EmployeeID != employeeID.Value)
                    continue;

                if (filterDate != null && lShift.Date.Date != filterDate.Value.Date)
                    continue;

                string lName = "";
                foreach (Employee emp in lEmployeeList)
                {
                    if (emp.EmployeeID == lShift.EmployeeID)
                    {
                        lName = emp.FullName;
                        break;
                    }
                }

                DataRow lRow = lTable.NewRow();
                lRow["Employee"] = lName;
                lRow["Date"] = lShift.Date.Date;  
                lRow["Shift"] = lShift.ShiftType;
                lRow["ShiftOrder"] = GetShiftOrder(lShift.ShiftType);

                lTable.Rows.Add(lRow);
            }

            // orders by date and shift 
            DataView dv = lTable.DefaultView;
            dv.Sort = "Date DESC, ShiftOrder  "; 

            dgvShiftList.DataSource = dv.ToTable();

            if (dgvShiftList.Columns.Contains("ShiftOrder"))
                dgvShiftList.Columns["ShiftOrder"].Visible = false;
        }

        //remove shifts button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvShiftList.CurrentRow == null)
            {
                MessageBox.Show("Please select a shift to remove.");
                return;
            }
            string lEmployeeName = dgvShiftList.CurrentRow.Cells[0].Value.ToString();
            string lDateString = dgvShiftList.CurrentRow.Cells[1].Value.ToString();
            string lShiftType = dgvShiftList.CurrentRow.Cells[2].Value.ToString();
            DateTime lDate = Convert.ToDateTime(lDateString);
            int lEmployeeID = 0;
            List<Employee> lEmployeeList = (List<Employee>)cboEmployeeID.DataSource;
            foreach (Employee lEmp in lEmployeeList)
            {
                if (lEmp.FullName == lEmployeeName)
                {
                    lEmployeeID = lEmp.EmployeeID;
                }
            }
            Shift lShiftToRemove = null;
            foreach (Shift lShift in ShiftList)
            {
                if (lShift.EmployeeID == lEmployeeID &&
                    lShift.Date.Date == lDate.Date &&
                    lShift.ShiftType == lShiftType)
                {
                    lShiftToRemove = lShift;
                }
            }
            if (lShiftToRemove != null)
            {
                ShiftList.Remove(lShiftToRemove);
                UpdateShiftGrid();
                MessageBox.Show("Shift removed.");
            }
        }

        //checks who has not reached minimum shifts for that week
        private void btnCheckMinimum_Click(object sender, EventArgs e)
        {
            List<Employee> lEmployeeList = (List<Employee>)cboEmployeeID.DataSource;
            DateTime lDate = dtpShiftDate.Value;

            string lMessage = "Employees with less than 2 shifts:\n\n";

            foreach (Employee lEmp in lEmployeeList)
            {
                int lCount = CountShiftsForWeek(lEmp.EmployeeID, lDate);

                if (lCount < MinShiftsPerWeek)
                {
                    lMessage += lEmp.FullName + ": " + lCount.ToString() + " shift(s)\n";
                }
            }
            MessageBox.Show(lMessage);
        }

        //calculates wages for each employee for that week
        private void btnCalculateWages_Click(object sender, EventArgs e)
        {
            List<Employee> lEmployeeList = (List<Employee>)cboEmployeeID.DataSource;
            DateTime lDate = dtpShiftDate.Value;

            string lMessage = "Weekly Wages:\n\n";

            foreach (Employee lEmp in lEmployeeList)
            {
                int lCount = CountShiftsForWeek(lEmp.EmployeeID, lDate);

                decimal lWage = lCount * 50; 

                lMessage += lEmp.FullName + ": £" + lWage.ToString() + "\n"; 
            }

            MessageBox.Show(lMessage);
        }

        //shift in dgv
        public class Shift
        {
            public int ShiftID { get; set; }
            public int EmployeeID { get; set; }
            public DateTime Date { get; set; }
            public string ShiftType { get; set; }
        }

        //filter dgv by date
        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            UpdateShiftGrid(dtpShiftDate.Value);
        }

        //remove dgv filter
        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            UpdateShiftGrid();
        }

        //button to open AttendanceForm.cs
        private void btnOpenAttendanceForm_Click(object sender, EventArgs e)
        {
            var convertedShiftList = ShiftList.Select(shift => new AttendanceForm.Shift
            {
                ShiftID = shift.ShiftID,
                EmployeeID = shift.EmployeeID,
                Date = shift.Date,
                ShiftType = shift.ShiftType
            }).ToList();

            // brings employee list to new form
            var attendanceForm = new AttendanceForm(employeeList, convertedShiftList);
            attendanceForm.Show();
        }

        //filter dgv by employee
        private void btnFilterByEmployee_Click(object sender, EventArgs e)
        {
            var selectedEmployee = (Employee)cboEmployeeFilter.SelectedItem;

            // Call the UpdateShiftGrid method with the selected employee's ID
            UpdateShiftGrid(null, selectedEmployee.EmployeeID);
        }
    }
}