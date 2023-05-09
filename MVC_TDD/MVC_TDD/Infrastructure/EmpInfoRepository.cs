using MVC_TDD.Models;

namespace MVC_TDD.Infrastructure
{
    public class EmpInfoRepository : IEmpInfoRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ EmpID=1,EmpName="AAA", DeptID=1 },
                 new Employee{ EmpID=2,EmpName="BBBB", DeptID=2 },
                  new Employee{ EmpID=3,EmpName="CCCC", DeptID=1 }
            };

            return employees;
        }
    }
}
