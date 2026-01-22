using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab01_part02
{
    internal class Student
    {
        private int studentId;
        private string firstName;
        private string lastName;
        private char Grade;
        private double attendancePercentage;


        public void SetStudentId(int id)
        {
            if (id > 0)
                studentId = id;
            else
                Console.WriteLine("entert correct id\n");
        }
        public void SetFirstName(string name)
        {
            if (name != null) { firstName = name; }

            else { Console.WriteLine("enter the  Name\n"); }

        }
        public void SetLastName(string name) {
            if (name != null) { lastName = name; }
            else { Console.WriteLine("enter  the  Name\n"); }
        }
        public void setGrade(char grade)
        {
            if (grade == 'A' || grade == 'B' || grade == 'C' || grade == 'D' || grade == 'F')
                Grade = grade;
            else

            { Console.WriteLine("the grade is not true\n"); }
        }
        public void SetAttendance(double pct)
        {
            if (pct >= 0 && pct <= 100)
            {
                attendancePercentage = pct;
            }
            else { Console.WriteLine("the percentage not true\n"); }
        }
        public string GetFullName()
        {
            return firstName + lastName;
        }

        public string IsPassing() {
            if (Grade == 'F')
                return "failling";
            else
                return "passing"; }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($" Student ID:{studentId}\n FullName: {firstName} {lastName}\n current Grade: {Grade}\n Attendance: {attendancePercentage}%\n Academic Status: {IsPassing()}\n");

        }

    }
}
