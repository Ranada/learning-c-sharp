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