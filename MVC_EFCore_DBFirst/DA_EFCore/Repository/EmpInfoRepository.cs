using DA_EFCore.Abstract;
using DA_EFCore.Model;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_EFCore.Repository
{
    public class EmpInfoRepository : IEmpInfoRepository
    {
        EmployeeInfoDetailsContext _context = new EmployeeInfoDetailsContext();
        public List<Employee> GetAllEmployee()
        {
            List<Employee> lstEmp = _context.Employees.ToList();
                      

            return lstEmp;

        }
    }
}
