using System.ComponentModel;

namespace DictHash;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Neil", 1234, "Technology");
        Employee employee2 = new Employee("Mike", 2468, "Design");
        Employee employee3 = new Employee("Sara", 7777, "Sales");

        employee1.DisplayInfo();
        employee2.DisplayInfo();
        employee3.DisplayInfo();
    }
}

class Employee
{
    private string _name;
    private int _id;
    private string _department;
    public Employee(string name, int id, string department)
    {
        _name = name;
        _id = id;
        _department = department;
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public int Id {
        get => _id;
        set => _id = value;
    }

    public string Department {
        get => _department;
        set => _department = value;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id} Name: {Name} Department: {Department}");
    }
}


