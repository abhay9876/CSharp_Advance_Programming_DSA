/*3.Student Grade Book
Use Case: Map student roll numbers to their grade report.
OOP Concepts:
● Interface: GradeReport
● Polymorphism: Different grading strategies (CBSE, GPA).
● Encapsulation: Grade map managed inside grade service.*/


using System;

public interface GradeReport
{
    string CalculateGrade(int marks);
}

public class CBSE: GradeReport
{
    public string CalculateGrade(int marks)
    {
        if (marks > 90)
        {
            return "A";
        }
        else if (marks > 70)
        {
            return "B";
        }
        else if(marks > 50 )
        {
            return "C";
        }
        else
        {
            return "F";
        }
    }
}

public class GPA : GradeReport
{
    public string CalculateGrade(int marks)
    {
        if (marks > 90)
        {
            return "9.0";
        }
        else if (marks > 70)
        {
            return "8.0";
        }
        else if (marks > 50)
        {
            return "6.0";
        }
        else
        {
            return "F";
        }
    }
}



public class GradeService
{
    private Dictionary<int, GradeReport> grade = new Dictionary<int, GradeReport>();
    private Dictionary<int, int> marks = new Dictionary<int, int>();

    public void AddStudent(int rollNo, int mark, GradeReport gr)
    {
        marks[rollNo] = mark;
        grade[rollNo] = gr;
    }

    public void PrintGrade(int rollNo)
    {
        if (marks.ContainsKey(rollNo))
        {
            int mark = marks[rollNo];
            GradeReport gt= grade[rollNo];
            Console.WriteLine($"Roll No {rollNo} Grade: {gt.CalculateGrade(mark)}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}
