using System;
using System.Drawing.Design;
using System.Windows.Forms;

namespace buoi2wf
{
    public partial class Form1 : Form
    {
        bool check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            btn_them.Enabled = false;
            //if (tb_ma_sv.Text == string.Empty)
            //{
            //    errorProvider1.SetError(tb_ma_sv, "Bạn chưa nhập mã sinh viên");
            //}

            //if (tb_sdt.Text == string.Empty)
            //{
            //    errorProvider1.SetError(tb_sdt, "Bạn chưa nhập số điện thoại");
            //}

            //errorProvider1.Clear();
            //if (tb_ten_sv.Text == string.Empty)
            //{
            //    errorProvider1.SetError(tb_ten_sv, "Bạn chưa nhập tên sinh viên");
            //}
            rad_nam.Checked = true;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(check == true)
            //{
            //    DialogResult result = MessageBox.Show("Vui lòng nhập đủ thông tin");

            //}
 
        }

        private void tb_ma_sv_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb_ma_sv.Text != string.Empty)
            {
                btn_them.Enabled = true;
               
            }
            else
            {
                btn_them.Enabled = false;
            }

            if (tb_ma_sv.Text == string.Empty)
            {
                errorProvider1.SetError(tb_ma_sv,"Bạn chưa nhập mã sinh viên");
               
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(!IsNumber(tb_sdt.Text))
            {
                btn_them.Enabled = false;
                errorProvider1.SetError(tb_sdt, "Sai định dạng sđt");
                
            }
        }

        private bool IsNumber(string val)
        {
            foreach(char c in val)
            {
                if(!char.IsDigit(c)) return false;
            }
            return true;
        }

        private void tb_ten_sv_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(tb_ten_sv.Text == string.Empty)
            {
                errorProvider1.SetError(tb_ten_sv, "Bạn chưa nhập tên sinh viên");
               
            }
        }

        private void tb_dia_chi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb_dia_chi.Text == string.Empty)
            {
                errorProvider1.SetError(tb_dia_chi, "Bạn chưa nhập địa chỉ");
              
            }
        }

        private void rad_nam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
