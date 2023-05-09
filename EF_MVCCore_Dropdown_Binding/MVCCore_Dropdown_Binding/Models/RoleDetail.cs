using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Dropdown_Binding.Models
{
    public class RoleDetail
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public List<RoleDetail> GetAllRoles()
        {
            List<RoleDetail> lstRoles = new List<RoleDetail>
            {
                new RoleDetail{ RoleID=1, RoleName="Admin"},
                new RoleDetail{ RoleID=2, RoleName="Manager"},
                new RoleDetail{ RoleID=3, RoleName="Supervisor"}
            };

            return lstRoles;
        }
    }
}
