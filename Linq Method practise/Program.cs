// See https://aka.ms/new-console-template for more information
using Linq_Method_practise.Models;

void Display()
{
    //Console.WriteLine("Hello, World!");
    //Group by using single property
    //var result = TestData.Employees.GroupBy(emp => emp.Department).ToList();
    //group by using composite property
    var result = TestData.Employees.GroupBy(emp => new { emp.Department,emp.Salary }).ToList();

    result.ForEach(emp_group =>
    {
        Console.WriteLine($"KEY =  {emp_group.Key}" + Environment.NewLine);
        foreach (var emp in emp_group)
        {
            Console.WriteLine($"EmployeeId = {emp.EmployeeId},  Name = {emp.Name} Salary = {emp.Salary} ");
        }
        Console.WriteLine(Environment.NewLine);
    });

}

Display();