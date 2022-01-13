using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cau1.Model;

namespace Cau1.DAL
{
    public class DepartmentDAL : DBConnection
    {
        public List<Department> Danhsachkhuvuc()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("spDepartment", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.CommandType = CommandType.StoredProcedure;
            List<Department> lstDepartment = new List<Department>();
            while (reader.Read())
            {
                Department Depart = new Department();
                Depart.IdDepartment = int.Parse(reader["IdDepartment"].ToString());
                Depart.Name = reader["name"].ToString();
                lstDepartment.Add(Depart);
            }
            conn.Close();
            return lstDepartment;


        }
        public Department Danhsachkhuvuc(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Department_2119110228 where IdDepartment=" + id.ToString(), conn);
            Department Department = new Department();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows && reader.Read())
            {
                Department.IdDepartment = int.Parse(reader["IdDepartment"].ToString());
                Department.Name = reader["name"].ToString();
            }
            conn.Close();
            return Department;
        }
    }
}
