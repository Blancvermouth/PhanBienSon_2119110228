﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cau1.BAL;
using Cau1.Model;

namespace Cau1
{
    public partial class Form1 : Form
    {
        EmployeeBAL EmployBAL = new EmployeeBAL();
        DepartmentBAL DepartmentBAL = new DepartmentBAL();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmployeeBEL> lstEmploy = EmployBAL.danhsachnhanvien();
            foreach (EmployeeBEL Emp in lstEmploy)
            {
                dgvnhanvien.Rows.Add(Emp.IdEmployee, Emp.Name, Emp.DateBirth, Emp.Gender, Emp.PlaceBirth, Emp.Depart);

            }
            List<Department> lstDepart = DepartmentBAL.Danhsachkhuvuc();
            foreach (Department depart in lstDepart)
            {
                cbdonvi.Items.Add(depart);
            }
            cbdonvi.DisplayMember = "Name";
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                EmployeeBEL emp = new EmployeeBEL();
                emp.IdEmployee = tbma.Text;
                emp.Name = tbhoten.Text;
                emp.DateBirth = DateTime.Parse(dtpngaysinh.Value.Date.ToString());
                // emp.Gender = tbGender.Text;
                if (chbgioitinh.Checked)
                {
                    emp.Gender = "NAM";
                }
                else
                {
                    emp.Gender = "NU";
                }

                emp.PlaceBirth = tbnoisinh.Text;
                emp.Department = (Department)cbdonvi.SelectedItem;



                EmployBAL.Them(emp);

                dgvnhanvien.Rows.Add(emp.IdEmployee, emp.Name, emp.DateBirth, emp.Gender, emp.PlaceBirth, emp.Department.Name);
            }
        }
        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(tbma.Text))
            {
                MessageBox.Show("Mã không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbhoten.Text))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbnoisinh.Text))
            {
                MessageBox.Show("Nơi Sinh không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpngaysinh.Text))
            {
                MessageBox.Show("Ngày Sinh không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(cbdonvi.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn vị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void dgvnhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvnhanvien.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbma.Text = row.Cells[0].Value.ToString();
                tbhoten.Text = row.Cells[1].Value.ToString();
                dtpngaysinh.Text = row.Cells[2].Value.ToString();
                //   tbGender.Text = row.Cells[3].Value.ToString();
                if (row.Cells[3].Value.ToString() == "NAM")
                {
                    chbgioitinh.Checked = true;
                }
                else
                {
                    chbgioitinh.Checked = false;
                }

                tbnoisinh.Text = row.Cells[4].Value.ToString();
                cbdonvi.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
