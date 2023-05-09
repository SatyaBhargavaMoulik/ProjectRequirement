using DA_EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_EFCore.Abstract
{
    public interface IEmpInfoRepository
    {
        List<Employee> GetAllEmployee();
    }
}
