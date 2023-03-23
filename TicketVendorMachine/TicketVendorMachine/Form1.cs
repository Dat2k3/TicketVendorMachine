using System;
using System.Windows.Forms;

namespace TicketVendorMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPay.TabStop = false;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.FlatAppearance.BorderSize = 0;
            txtPhone.MaxLength = 10;
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            
            if(name == "" || phone == "")
            {
                MessageBox.Show("Please, Enter your information!");
            }

            else
            {
                Form2 form2 = new Form2(name, phone);
                this.Hide();
                form2.Show();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
