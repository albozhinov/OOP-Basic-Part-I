using System;
using System.Linq;

public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public string Name
    {
        get { return this.name; }
    }

    public decimal Salary
    {
        get { return this.salary; }
    }

    public string Position
    {
        get { return this.position; }
    }

    public string Department
    {
        get { return this.department; }
    }

    public string Email
    {
        get { return this.email; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public Employee(string information)
    {
        string[] employeeInfo = information.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

        this.name = employeeInfo[0];
        this.salary = decimal.Parse(employeeInfo[1]);
        this.position = employeeInfo[2];
        this.department = employeeInfo[3];
        this.email = "n/a";
        this.age = -1;

        if (employeeInfo.Length > 4)
        {
            try
            {
                this.age = int.Parse(employeeInfo[4]);
            }
            catch
            {

                this.email = employeeInfo[4];
            }
        }
        if (employeeInfo.Length > 5)
        {
            this.age = int.Parse(employeeInfo[5]);
        }
       
    }
}

