namespace oop_lab01_part02
{
    internal class Program
    {
        static void Main(string[] args)
        {

    Student st1 = new Student();
            st1.SetStudentId(1);
            st1.SetFirstName("Manar");
            st1.SetLastName("AbdelHak");
            st1.SetAttendance(95.3);
            st1.setGrade('B');
            st1.GetFullName();
            //st1.IsPassing();
            st1.DisplayStudentInfo();



            Student st2 = new Student();
            st2.SetStudentId(1);
            st2.SetFirstName("Manar");
            st2.SetLastName("AbdelHak");
            st2.SetAttendance(-95.3);
            st2.setGrade('s');
            st2.GetFullName();
           // st2.IsPassing();
            st2.DisplayStudentInfo();
              
        }     
    }
}
