using System.ComponentModel;

namespace DictHash;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Neil", 1234, "Technology");
        Employee employee2 = new Employee("Mike", 2468, "Design");
        Employee employee3 = new Employee("Sara", 7777, "Sales");

        Dictionary<int, Employee> employeesById = new Dictionary<int, Employee>();
        employeesById.Add(employee1.Id, employee1);
        employeesById.Add(employee2.Id, employee2);
        employeesById.Add(employee3.Id, employee3);

        Employee? e;
        if (employeesById.TryGetValue(123, out e))
        {
            e.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Unable to find info for employee.");
        }

    }
}