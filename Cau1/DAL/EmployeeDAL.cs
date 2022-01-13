using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Cau1.Model;

namespace Cau1.DAL
{
    public class EmployeeDAL : DBConnection
    {
        public List<EmployeeBEL> Nhanvien()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("spEmployee", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            EmployeeDAL employee = new EmployeeDAL();
            DepartmentDAL department = new DepartmentDAL();
            List<EmployeeBEL> lstEmployee = new List<EmployeeBEL>();
            while (reader.Read())
            {
                EmployeeBEL emp = new EmployeeBEL();
                emp.IdEmployee = reader["IdEmployee"].ToString();
                emp.Name = reader["Name"].ToString();
                emp.DateBirth = DateTime.Parse(reader["DateBirth"].ToString());
                emp.Gender = reader["Gender"].ToString();
                emp.PlaceBirth = reader["PlaceBirth"].ToString();
                emp.Department = department.Danhsachkhuvuc(int.Parse(reader["IdDepartment"].ToString()));
                lstEmployee.Add(emp);
            }
            conn.Close();
            return lstEmployee;
        }
        public void Them(EmployeeBEL emp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("spInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", emp.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", emp.Department.IdDepartment));


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Sua(EmployeeBEL emp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("spUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", emp.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", emp.Department.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Xoa(EmployeeBEL emp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("spDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", emp.IdEmployee));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

