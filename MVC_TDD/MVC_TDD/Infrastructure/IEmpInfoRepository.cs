using MVC_TDD.Models;

namespace MVC_TDD.Infrastructure
{
    public interface IEmpInfoRepository
    {
        List<Employee> GetAllEmployees();
    }
}
