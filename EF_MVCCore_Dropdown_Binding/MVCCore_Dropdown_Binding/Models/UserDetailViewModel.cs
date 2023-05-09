using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Dropdown_Binding.Models
{
    public class UserDetailViewModel
    {
        public string Name { get; set; }
        public int RoleID { get; set; }
        public List<RoleDetail> RolesInfo { get; set; }
    }
}
