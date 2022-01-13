using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cau1.DAL;
using Cau1.Model;

namespace Cau1.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeBEL> danhsachnhanvien()
        {
            List<EmployeeBEL> lstEmpl = dal.Nhanvien();
            return lstEmpl;
        }
        public void Them(EmployeeBEL emp)
        {
            dal.Them(emp);
        }
        public void Sua(EmployeeBEL emp)
        {
            dal.Sua(emp);

        }
        public void Xoa(EmployeeBEL emp)
        {
            dal.Xoa(emp);
        }
    }
}
