using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day06
{
    internal class Student
    {

        public string Name;
        public int StudentId;
        public char Grade;
        Book book;
        public Student(string name, int id, char grade)
        {
            Name = name;
            StudentId = id;
            Grade = grade;
             
        }
        public override string ToString()
        {
            
            return $"{Name} ::{StudentId} :: {Grade} \n";
        }
        public override bool Equals(object? obj)

        {
            Student s = obj as Student;
            if (s!=null)
            {
                return (s.Name == this.Name)/* && (s.StudentId == this.StudentId)*/;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public Student clone()
        {

            Student s= (Student)this.MemberwiseClone();
            s.book.Title=this.book.Title;
            s.book.Author=this.book.Author;
            s.book.ISBN=this.book.ISBN;
            return s;
        }
    }
}
