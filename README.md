# Employee Shift Scheduling System

A desktop-based **employee shift scheduling application** built with **C# and Windows Forms**. The application allows managers to assign and manage employee shifts while enforcing scheduling rules, viewing schedules, tracking attendance, and calculating weekly wages.

## Overview

Managing employee schedules manually can lead to double bookings, understaffed shifts, and uneven workloads. This application provides a simple interface for creating and managing employee schedules while automatically checking predefined scheduling constraints.

The system maintains employee and shift data in memory and provides separate interfaces for **shift management** and **attendance tracking**.

## Features

### Shift Management

* Assign employees to shifts using a date picker and shift selector
* Remove existing shifts
* Display scheduled shifts in a `DataGridView`
* Sort shifts by date and shift time
* Filter schedules by:

  * Date
  * Employee
* Prevent duplicate shift assignments

### Scheduling Rules

The application enforces several business rules when assigning shifts:

* An employee cannot be assigned to the same shift more than once.
* A maximum of **3 employees** can work the same shift.
* An employee can work a maximum of **4 shifts per week**.
* Managers can identify employees who have fewer than **2 shifts per week**.

These rules are validated before a shift is added to the schedule.

### Attendance Tracking

The application includes a separate attendance view that receives the current employee and shift data and displays:

* Employee name
* Shift date
* Shift type

Attendance data is sorted by shift date for easier review.

### Wage Calculation

The system calculates weekly wages based on the number of shifts worked.

```text
Weekly Wage = Number of Shifts × Wage Per Shift
```

The current configuration uses **£50 per shift**.

## Shift Types

The application currently supports five three-hour shift periods:

| Shift        | Time               |
| ------------ | ------------------ |
| Morning      | 7:00 AM – 10:00 AM |
| Late Morning | 10:00 AM – 1:00 PM |
| Afternoon    | 1:00 PM – 4:00 PM  |
| Evening      | 4:00 PM – 7:00 PM  |
| Night        | 7:00 PM – 10:00 PM |

Shift types are presented through a dropdown menu in the scheduling interface.

## Application Structure

```text
Shift-Scheduling-Csharp/
│
├── Form1.cs
├── Form1.Designer.cs
│
├── ShiftForm.cs
├── ShiftForm.Designer.cs
│
├── AttendanceForm.cs
├── AttendanceForm.Designer.cs
│
└── README.md
```

### `Form1.cs`

Acts as the main application window and provides navigation into the shift scheduling interface.

### `ShiftForm.cs`

Contains the core scheduling functionality, including:

* Employee data
* Shift data
* Shift assignment
* Shift validation
* Weekly shift counting
* Schedule filtering
* Schedule sorting
* Shift removal
* Minimum-shift checking
* Wage calculation
* Attendance navigation

The application represents employees and shifts using C# classes and stores them in `List<T>` collections.

### `AttendanceForm.cs`

Provides a separate view of scheduled shifts for attendance management. Employee and shift lists are passed from the scheduling form into the attendance form.

## Data Model

The application uses two primary objects:

### Employee

```csharp
Employee
├── EmployeeID
├── FirstName
├── LastName
└── FullName
```

### Shift

```csharp
Shift
├── ShiftID
├── EmployeeID
├── Date
└── ShiftType
```

Employees and shifts are connected through `EmployeeID`.

## Technologies

* **C#**
* **.NET / Windows Forms**
* **LINQ**
* **DataTable / DataView**
* **Object-Oriented Programming**
* **Event-Driven Programming**
* **Visual Studio**

## C# Concepts Demonstrated

### Object-Oriented Programming

This app defines reusable `Employee` and `Shift` classes with properties representing application data.

### Collections

Employee and shift information is maintained using generic lists:

```csharp
List<Employee>
List<Shift>
```

### LINQ

LINQ is used for operations such as sorting employees alphabetically and retrieving employee records.

```csharp
employeeList = employeeList
    .OrderBy(emp => emp.FullName)
    .ToList();
```

The attendance interface also uses LINQ to locate the employee associated with a shift.

### Event-Driven Programming

User interactions such as assigning a shift, removing a shift, filtering schedules, and calculating wages are handled through Windows Forms button events.

### Data Validation

Before creating a shift, the application checks whether the assignment violates existing scheduling rules. This prevents invalid schedules from being added to the system.

### Data Presentation

`DataTable` and `DataView` are used to transform shift information into data displayed through the application's `DataGridView`. The schedule can also be sorted and filtered dynamically.

## Example Workflow

```text
Start Application
       │
       ▼
Open Shift Scheduler
       │
       ▼
Select Employee
       │
       ▼
Select Date
       │
       ▼
Select Shift Type
       │
       ▼
Validate Scheduling Rules
       │
   ┌───┴────┐
   │        │
Invalid    Valid
   │        │
   ▼        ▼
Display   Create
Error     Shift
            │
            ▼
       Update Schedule
            │
       ┌────┴─────┐
       ▼          ▼
   Attendance   Wage
     View     Calculation
```

## Scheduling Logic

When a manager assigns a shift, the application performs several validation steps:

1. Verify that an employee has been selected.
2. Retrieve the selected employee, date, and shift type.
3. Check for duplicate assignments.
4. Count employees already assigned to the selected shift.
5. Ensure the shift does not exceed the three-employee capacity.
6. Count the employee's shifts for the current week.
7. Ensure the employee has not reached the four-shift weekly limit.
8. Create and store the new shift.
9. Refresh the schedule displayed in the interface.

## Employee Management

This application currently uses a predefined set of employees for demonstration purposes. Employees are loaded into a list when the scheduling form starts and are sorted alphabetically before being displayed in the interface.

## Future Improvements

Potential extensions include:

* Persistent database storage
* Employee login/authentication
* Employee availability and time-off requests
* Automatic schedule generation
* Conflict detection across overlapping shifts
* Export schedules to CSV or Excel
* Monthly payroll reports
* Employee-specific wage rates
* More flexible scheduling rules
* Role-based access for managers and employees
* Automated testing

## Learning Outcomes

This project provided practical experience with:

* Building a desktop application with C#
* Designing an event-driven user interface
* Applying object-oriented programming principles
* Working with collections and custom classes
* Implementing business rules in application logic
* Using LINQ for filtering and sorting
* Validating user input
* Managing data between multiple forms
* Presenting structured data using `DataGridView`
* Translating real-world scheduling requirements into program logic
