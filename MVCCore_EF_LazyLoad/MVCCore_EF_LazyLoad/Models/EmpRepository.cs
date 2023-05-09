namespace MVCCore_EF_LazyLoad.Models
{
   
    public class EmpRepository : IEmpRepository
    {
        EmpContext _context = new EmpContext();
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = _context.Employees.ToList();

            return employees;
        }
    }
}
