using System;
using System.Windows.Forms;

namespace TicketVendorMachine
{
    public partial class Form4 : Form
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string name, string phone, string destination, string time, string price) : this()
        {
            text1 = name;
            text2 = phone;
            text3 = destination;
            text4 = time;
            text5 = price;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = text1;
            textBox2.Text = text2;
            textBox3.Text = text3;
            textBox4.Text = text4;
            textBox5.Text = text5;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.Close();
        }
    }
}
