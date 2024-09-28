using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float result = a + b;
                txtKQ.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi, vui long nhap them a hoac b", "THONG BAO");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float result = a - b;
                txtKQ.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi, vui long nhap them a hoac b", "THONG BAO");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float result = a * b;
                txtKQ.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi, vui long nhap them a hoac b", "THONG BAO");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                if (b > 0)
                {
                    float result = a / b;
                    txtKQ.Text = result.ToString();
                }
                else
                    MessageBox.Show("Khong duoc nhap b = 0", "THONG BAO");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi, vui long nhap them a hoac b", "THONG BAO");
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { 
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
