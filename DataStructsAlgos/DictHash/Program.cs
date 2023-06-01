using System.ComponentModel;

namespace DictHash;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Neil", 1234, "Technology");
        Employee employee2 = new Employee("Mike", 2468, "Design");
        Employee employee3 = new Employee("Sara", 7777, "Sales");

        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        employees.Add(employee1.Id, employee1);
        employees.Add(employee2.Id, employee2);
        employees.Add(employee3.Id, employee3);

        Console.WriteLine("----Print employee by ID----");
        Employee? e;
        if (employees.TryGetValue(123, out e))
        {
            e.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Unable to find info for employee.");
        }


        Console.WriteLine("----Print all employees in dictionary----");
        foreach (var pair in employees)
        {
            pair.Value.DisplayInfo();
        }

        HashSet<string> productCodes = new HashSet<string>();

        productCodes.Add("P1234");
        productCodes.Add("P3456");
        productCodes.Add("P7890");

        Console.WriteLine("----Print all product codes in hash----");
        foreach (string code in productCodes)
        {
            Console.WriteLine(code);
        }

    }
}