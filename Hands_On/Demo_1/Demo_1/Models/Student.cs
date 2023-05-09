namespace Demo_1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Year { get; set; }
        public string Department { get; set; }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student(){StudentID=1,StudentName="AAAA",Year=4,Department="MECH"},
                new Student(){StudentID=2,StudentName="BBBB",Year=4,Department="CIVIL"},
                new Student(){StudentID=3,StudentName="CCCC",Year=4,Department="CSE"},
                new Student(){StudentID=4,StudentName="DDDD",Year=4,Department="EEE"}
            };
            return students;
        }
        public Student GetStudentById(int rollno)
        {
            Student student_obj = new Student();
            List<Student> students = new List<Student>
            {
                new Student(){StudentID=1,StudentName="AAAA",Year=4,Department="MECH"},
                new Student(){StudentID=2,StudentName="BBBB",Year=4,Department="CIVIL"},
                new Student(){StudentID=3,StudentName="CCCC",Year=4,Department="CSE"},
                new Student(){StudentID=4,StudentName="DDDD",Year=4,Department="EEE"}
            };
            foreach(Student student_item in students)
            {
                
                if(student_item.StudentID==rollno)
                {
                    student_obj = student_item;
                    break;
                }
            }
            return student_obj;

        }
    }
}
