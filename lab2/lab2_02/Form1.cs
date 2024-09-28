using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_02
{
    public partial class FrmQLSV : Form
    {
        public FrmQLSV()
        {
            InitializeComponent();
        }

        private void FrmQLSV_Load(object sender, EventArgs e)
        {
         //   cmbChuyenNganh.SelectedIndex = 0;
            GenerateAndBindData();
            cmbChuyenNganh.Items.Add("CNTT");
            cmbChuyenNganh.Items.Add("NNA");
            cmbChuyenNganh.Items.Add("QTKD");

            cmbChuyenNganh.SelectedIndex = 1;

            rbNam.Checked = true;
            txtSLNam.Text = demSLNam().ToString();
            txtSLNu.Text = demSLNu().ToString();
        }
        private void GenerateAndBindData()
        {
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int id = i;
                string name = "Student " + i;
                string gender = random.Next(0, 2) == 0 ? "Nam" : "Nu";
                int dtb = random.Next(3, 10);

                string faculty = "";
                switch(random.Next(0, 3))
                {
                    case 0:
                        faculty = "CNTT";
                        break;

                    case 1:
                        faculty = "QTKD";
                        break;

                    case 2:
                        faculty = "NNA";
                        break;

                }
                dgvStudent.Rows.Add(id, name, gender, dtb, faculty);
            }
        }

  

        public void setNull()
        {
            txtMSSV.Text = null;
            txtHoTen.Text = null;
            txtDTB.Text = null;
            rbNam.Checked = true;
        }

 

        private int demSLNam()
        {
            int n = dgvStudent.Rows.Count; // Get the total number of rows
            int dem = 0; // Counter for male students

            for (int i = 0; i < n; i++)
            {
                // Check if the current row is not a new row (the last row is usually a new row if AllowUserToAddRows is true)
                if (!dgvStudent.Rows[i].IsNewRow)
                {
                    // Check if the cell for gender exists and its formatted value is "Nam"
                    if (dgvStudent.Rows[i].Cells["dgvGioitinh"].Value != null &&
                        dgvStudent.Rows[i].Cells["dgvGioitinh"].FormattedValue.ToString() == "Nam")
                    {
                        dem++; // Increment the counter
                    }
                }
            }
            return dem; // Return the count of male students
        }

        private int demSLNu()
        {
            int n = dgvStudent.Rows.Count; // Get the total number of rows
            int dem = 0; // Counter for male students

            for (int i = 0; i < n; i++)
            {
                // Check if the current row is not a new row (the last row is usually a new row if AllowUserToAddRows is true)
                if (!dgvStudent.Rows[i].IsNewRow)
                {
                    // Check if the cell for gender exists and its formatted value is "Nam"
                    if (dgvStudent.Rows[i].Cells["dgvGioitinh"].Value != null &&
                        dgvStudent.Rows[i].Cells["dgvGioitinh"].FormattedValue.ToString() != "Nam")
                    {
                        dem++; // Increment the counter
                    }
                }
            }
            return dem; // Return the count of male students
        }


        private int GetSelectedRow(string MSSV)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                // Check if the cell's value is not null before accessing it
                var cellValue = dgvStudent.Rows[i].Cells[0].Value;
                if (cellValue != null && cellValue.ToString() == MSSV)
                {
                    return i; // Return the index if a match is found
                }
            }
            return -1; // Return -1 if no match was found
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = rbNu.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtDTB.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbChuyenNganh.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            err.Clear();

            if (!IsValidMSSV(txtMSSV.Text)) // gọi hàm kiểm tra MSSV
                err.SetError(txtMSSV, "Vui long nhap MSSV khong qua 10 so,khong co chu va so am");
            else if (txtHoTen.Text.Length > 50 || !IsValidName(txtHoTen.Text))
                err.SetError(txtHoTen, "Vui long nhap Ho Ten khong qua 50 ky tu");

            else if (!double.TryParse(txtDTB.Text, out double dtb) || dtb < 0)
            {
                err.SetError(txtDTB, "Vui long nhap DTB (phai > 0)");
            }
            else
            {

                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them moi du lieu thanh cong!", "THONG BAP", MessageBoxButtons.OK);
                    setNull();

                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "THONG BAO", MessageBoxButtons.OK);
                }
            }




            bool IsValidName(string name)
            {
                // Kiểm tra ký tự đặc biệt bằng cách dùng regex
                var regex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z\s]+$");
                return regex.IsMatch(name);
            }

            bool IsValidMSSV(string mssv)
            {
                // Kiểm tra MSSV chỉ chứa số
                var regex = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
                return regex.IsMatch(mssv);
            }
            txtSLNam.Text = demSLNam().ToString();
            txtSLNu.Text =  demSLNu().ToString();
        }

 

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null )
                {
                    dgvStudent.CurrentCell.Selected = true;

                    txtMSSV.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvMSSV"].FormattedValue.ToString();
                    txtHoTen.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvHoTen"].FormattedValue.ToString();
                    txtDTB.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvDTB"].FormattedValue.ToString();

                    if (dgvStudent.Rows[e.RowIndex].Cells["dgvGioitinh"].FormattedValue.ToString() == "Nu")
                    {
                        rbNu.Checked = true;
                    }
                    else
                    {
                        rbNam.Checked = true;
                    }
                    cmbChuyenNganh.SelectedItem = dgvStudent.Rows[e.RowIndex].Cells["dgvKhoa"].FormattedValue.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Kh tim thay MSSV ");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban co muon xoa ?", "Yes/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoa SV thanh cong!", "THONG BAO", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmQLSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
