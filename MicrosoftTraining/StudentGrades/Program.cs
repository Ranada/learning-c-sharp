using System.Collections;
using static Students.Grades;

int currentAssignments = 5;

var sophiaGrades = new int[5] { sophia1, sophia2, sophia3, sophia4, sophia5 };
var andrewGrades = new int[5] { andrew1, andrew2, andrew3, andrew4, andrew5 };
var emmaGrades = new int[5] { emma1, emma2, emma3, emma4, emma5 };
var loganGrades = new int[5] { logan1, logan2, logan3, logan4, logan5 };

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

foreach (int grade in sophiaGrades)
{
    sophiaSum += grade;
}

foreach (int grade in andrewGrades)
{
    andrewSum += grade;
}

foreach (int grade in emmaGrades)
{
    emmaSum += grade;
}

foreach (int grade in loganGrades)
{
    loganSum += grade;
}

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

string sophiaLetterGrade = GetLetterGrade(sophiaScore);
string andrewLetterGrade = GetLetterGrade(andrewScore);
string emmaLetterGrade = GetLetterGrade(emmaScore);
string loganLetterGrade = GetLetterGrade(loganScore);

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

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + " " + sophiaLetterGrade);
Console.WriteLine("Andrew:\t\t" + andrewScore + " " + andrewLetterGrade);
Console.WriteLine("Emma:\t\t" + emmaScore + " " + emmaLetterGrade);
Console.WriteLine("Logan:\t\t" + loganScore + " " + loganLetterGrade);

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();

