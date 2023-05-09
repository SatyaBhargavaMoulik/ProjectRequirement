namespace Razor_HTML_Form_Control.Models
{
    public class Employee
    {
        public string EmployeeName { get; set;}
        public int EmployeeID { get; set; }
        public int Experience { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            { 
                new Employee(){ EmployeeName="Moulik",EmployeeID=1,Experience=0,Designation="Dotnet Developer",Salary=23000},
                new Employee(){ EmployeeName="Shyam",EmployeeID=2,Experience=0,Designation="Java Developer",Salary=23000}
            };
            return employees;
        }
    }
    
}
