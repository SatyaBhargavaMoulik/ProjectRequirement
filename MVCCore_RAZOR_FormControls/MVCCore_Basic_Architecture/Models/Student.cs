using System.Security.Principal;

namespace MVCCore_Basic_Architecture.Models
{
    public class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public decimal Marks { get; set; }
        public List<Student> StudList { get; set; }

        public Student()
        {
            StudList = new List<Student>
            {
                new Student{ Roll=1, Name="AAA", Subject="Phy", Marks=97},
                new Student{ Roll=2, Name="BBB", Subject="Phy", Marks=87},
                new Student{ Roll=3, Name="CCC", Subject="Phy", Marks=92},
                new Student{ Roll=4, Name="DDD", Subject="Phy", Marks=95}
            };
        }



        public string Add_New_Student(Student stud)
        {
            string msg = "success";
            try
            {
                StudList.Add(stud);
            }
            catch(Exception ex)
            {
                msg = "failed";
            }

            return msg;
        }
















        public List<Student> GetAllStudents()
        {
            List<Student> lstStud = new List<Student>
            {
                new Student{ Roll=1, Name="AAA", Subject="Phy", Marks=97},
                new Student{ Roll=2, Name="BBB", Subject="Phy", Marks=87},
                new Student{ Roll=3, Name="CCC", Subject="Phy", Marks=92},
                new Student{ Roll=4, Name="DDD", Subject="Phy", Marks=95}
            };



            return lstStud;
        }

        public Student GetStudentOnRoll(int roll)
        {
            Student obj = new Student();

            List<Student> lstStud = new List<Student>
            {
                new Student{ Roll=1, Name="AAA", Subject="Phy", Marks=97},
                new Student{ Roll=2, Name="BBB", Subject="Phy", Marks=87},
                new Student{ Roll=3, Name="CCC", Subject="Phy", Marks=92},
                new Student{ Roll=4, Name="DDD", Subject="Phy", Marks=95}
            };

            obj = lstStud.FirstOrDefault(x => x.Roll == roll);

            
            return obj;
        }


       

    }
}
