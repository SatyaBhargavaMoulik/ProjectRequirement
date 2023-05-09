namespace MVCCore_EF_LazyLoad.Models
{
    public interface IEmpRepository
    {
        public List<Employee> GetAllEmployees();
    }
}
