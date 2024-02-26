using System;
using System.Windows.Forms;

namespace buoi2wf
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool check = true;
            errorProvider1.Clear();
            if (tb_ma_sv.Text == string.Empty)
            {
                errorProvider1.SetError(tb_ma_sv, "Bạn chưa nhập mã sinh viên");
                check = false;
            }

            //if (!IsNumber(tb_sdt.Text))
            //{
            //    errorProvider1.SetError(tb_sdt, "Sai định dạng sđt");
            //    check = true;

            //}



            int sdt;
            if (int.TryParse(tb_sdt.Text, out sdt) == false)
            {
                errorProvider1.SetError(tb_sdt, "Sai định dạng tuổi");
                check = false;
            }


            if (tb_sdt.Text == string.Empty)
            {
                errorProvider1.SetError(tb_sdt, "Bạn chưa nhập số điện thoại");
                check = false;
            }




            if (tb_ten_sv.Text == string.Empty)
            {
                errorProvider1.SetError(tb_ten_sv, "Bạn chưa nhập tên sinh viên");
                check = false;
            }



            if (tb_dia_chi.Text == string.Empty)
            {
                errorProvider1.SetError(tb_dia_chi, "Bạn chưa nhập địa chỉ");
                check = false;
            }


            if(rad_nu.Checked == false && rad_nam.Checked == false)
            {
                errorProvider1.SetError(rad_nu, "Bạn chưa chọn giới tính");
                errorProvider1.SetError(rad_nam, "Bạn chưa chọn giới tính");
                check = false;
            }

            if (check)
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        private void tb_ma_sv_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
      
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

        }

        private void tb_dia_chi_TextChanged(object sender, EventArgs e)
        {

        }

        private void rad_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        
    }
}
