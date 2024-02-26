using System;
using System.Drawing.Design;
using System.Threading;
using System.Windows.Forms;

namespace buoi2wf
{
    public partial class Form1 : Form
    {
        bool isRunning = true;
        public void CheckBtnAdd()
        {
            
            if(tb_ma_sv.Text == string.Empty || tb_ten_sv.Text == string.Empty || tb_sdt.Text == string.Empty
                || tb_dia_chi.Text == string.Empty)
            {
                btn_them.Enabled = false;
            }
            else
            {
                btn_them.Enabled = true;
            }
        }
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
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show("Thêm thành công");

        }

        private void tb_ma_sv_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            CheckBtnAdd();
            if (tb_ma_sv.Text == string.Empty)
            {
                errorProvider1.SetError(tb_ma_sv,"Bạn chưa nhập mã sinh viên");
                check = true;
            }
            else
            {
                check = false;
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            CheckBtnAdd();
            if (!IsNumber(tb_sdt.Text))
            {
                btn_them.Enabled = false;
                errorProvider1.SetError(tb_sdt, "Sai định dạng sđt");
                check=true;

            }
            else
            {
                check = false;
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
            CheckBtnAdd();
            if (tb_ten_sv.Text == string.Empty)
            {
                errorProvider1.SetError(tb_ten_sv, "Bạn chưa nhập tên sinh viên");
                check = true;
            }
            else
            {
                check = false;
            }
        }

        private void tb_dia_chi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            CheckBtnAdd();
            if (tb_dia_chi.Text == string.Empty)
            {
                errorProvider1.SetError(tb_dia_chi, "Bạn chưa nhập địa chỉ");
                check = true;
            }
            else
            {
                check = false;
            }
        }

        private void rad_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
        }

        

        private void Form1_Activated(object sender, EventArgs e)
        {
            CheckBtnAdd();
            Console.WriteLine("Hello");
        }

        
    }
}
