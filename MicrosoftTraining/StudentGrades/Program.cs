using System.Collections;
using static Students.Grades;


var students = new Dictionary<string, Student>();

var names = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

foreach (string name in names)
{
    var student = new Student(name);
    students.Add(name, student);
}

students["Sophia"].Grades = new int[] { 90, 86, 87, 98, 100 };
students["Andrew"].Grades = new int[] { 92, 89, 81, 96, 90 };
students["Emma"].Grades = new int[] { 90, 85, 87, 98, 68 };
students["Logan"].Grades = new int[] { 90, 95, 87, 88, 96 };

void PrintAllGrades(Dictionary<string, Student> students)
{
    Console.WriteLine("\nStudent\t\tGrade");
    
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Key}:\t\t {student.Value.Average} {student.Value.LetterGrade}");     
    }
}

void PrintGrade(Student student)
{
    Console.WriteLine("\nStudent\t\tGrade");
    Console.WriteLine($"{student.Name}:\t\t {student.Average} {student.LetterGrade}");
}

void CalculateGrade(Student student)
{
    int sum = 0;

    foreach (int grade in student.Grades)
    {
        sum += grade;
    }

    decimal average = (decimal)sum / student.Grades.Length;
    
    student.Average = average;

    student.LetterGrade = GetLetterGrade(average);
}

void GetAllGrades(Dictionary<string, Student> students)
{
    foreach (var student in students)
    {
        CalculateGrade(student.Value);
    }
    PrintAllGrades(students);    
}

void GetGrade(Student student)
{
    CalculateGrade(student);
    PrintGrade(student);
}

string GetLetterGrade(decimal score)
{
    if (score >= 97.0m) return "A+";
    else if (score >= 93.0m && score < 97) return "A";
    else if (score >= 90.0m && score < 93) return "A-";
    else if (score >= 87.0m && score < 90) return "B+";
    else if (score >= 83.0m && score < 87) return "B";
    else if (score >= 80.0m && score < 83) return "B-";
    else if (score >= 77.0m && score < 80) return "C+";
    else if (score >= 73.0m && score < 77) return "C";
    else if (score >= 70.0m && score < 73) return "C-";
    else if (score >= 67.0m && score < 70) return "B+";
    else if (score >= 63.0m && score < 67) return "B";
    else if (score >= 60.0m && score < 63) return "B-";
    else return "F";
            
}

void RouteRequest(string entry)
{   
    if (entry.ToUpper() == "EXIT")
    {
        return;
    }

    if (entry.ToUpper() == "ALL")
    {
        GetAllGrades(students);
    }
    else if (students.ContainsKey(entry))
    {
        GetGrade(students[entry]);
    }
    else
    {
        Console.WriteLine("Unable to find the student record. Try again.");
    }
}

string? entry;
do
{
    Console.WriteLine("\nWho's grades would you like to get? (Enter 'first name', 'all', or 'exit' to leave the program)");
    entry = Console.ReadLine();
    
    if (entry != null)
    {
        RouteRequest(entry);
    }

} while (entry?.ToUpper() != "EXIT");



public class Student
{
    public string Name {get; set;}
    public int[] Grades {get; set;}
    public decimal Average {get; set;}
    public string? LetterGrade {get; set;}

    public Student(string name)
    {
        Name = name;
        Grades = new int[10];
        Average = 0m;
        LetterGrade = "";
    }
}



