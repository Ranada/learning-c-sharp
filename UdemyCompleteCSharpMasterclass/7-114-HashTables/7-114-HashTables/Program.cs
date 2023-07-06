using System.Collections;

namespace _7_114_HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transfer of student gpa from array to hashtable: ");

            Student[] students = new Student[5];
            students[0] = new Student(1, "Jon", 4.0f);
            students[1] = new Student(2, "Dany", 2.22f);
            students[2] = new Student(6, "Tyrion", 3.2f);
            students[3] = new Student(1, "Aria", 3.7f);
            students[4] = new Student(4, "Hodor", 4.59f);

            Hashtable studentsHash = new Hashtable();

            foreach (Student student in students)
            {
                if (studentsHash.ContainsKey(student.Id))
                {
                    Console.WriteLine($"Sorry, a student with the same ID already exists. Unable to add {student.Name}.");
                }
                else
                { 
                    studentsHash.Add(student.Id, student);
                }
            }

            foreach (DictionaryEntry entry in studentsHash)
            {
                Student student = (Student)entry.Value!;
                Console.WriteLine($"{student.Id}: {student.Name} -> {student.Gpa:F2}");
            }
        }
    }
}