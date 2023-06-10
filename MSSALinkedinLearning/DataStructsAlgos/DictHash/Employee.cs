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

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Department
    {
        get => _department;
        set => _department = value;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{Id}, {Name}, {Department}");
    }
}