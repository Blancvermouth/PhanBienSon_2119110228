using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.Model
{
    public class Department
    {
        public List<EmployeeBEL> Employees { get; set; }
        public int IdDepartment { set; get; }
        public String Name { set; get; }
    }
}
