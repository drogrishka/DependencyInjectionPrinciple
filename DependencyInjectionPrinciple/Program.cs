// See https://aka.ms/new-console-template for more information
using DependencyInjectionPrinciple;

var employeeDetailsModified = new EmployeeDetailsModified(new SalaryCalculatorModified());
employeeDetailsModified.HourlyRate = 50;
employeeDetailsModified.HoursWorked = 150;
Console.WriteLine($"The Total Pay is {employeeDetailsModified.GetSalary()}");
