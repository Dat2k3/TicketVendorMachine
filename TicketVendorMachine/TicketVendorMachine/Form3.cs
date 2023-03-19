using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicketVendorMachine
{
    public partial class Form3 : Form
    {
        Banking banking = new Banking();
        
        SqlConnection cn;
        SqlDataAdapter data;
        DataTable tb;

        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string name, string phone, string destination, string time, string price) : this()
        {
            text1 = name;
            text2 = phone;
            text3 = destination;
            text4 = time;
            text5 = price;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnBack.TabStop = false;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;

            btnEnter.TabStop = false;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.FlatAppearance.BorderSize = 0;

            string con = "initial catalog = bankingSystem; " +
                "data source = DESKTOP-VL7UGOA\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(con);
            cn.Open();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        public void addDatabase()
        {
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string idcard = txtID.Text;
            string pin = txtPin.Text;
            banking = new Banking(idcard, pin);

            if (idcard == "" || pin == "")
            {
                MessageBox.Show("Please, Enter the information of your credit card !");
            }

            else
            {
                string sql = "select * from banking where cardID = '" + idcard + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);

                if(tb.Rows.Count <= 0)
                {
                    MessageBox.Show("ID Card is not exist !");
                }
                
                else
                {
                    sql = "select * from banking where pin = '" + pin + "'";
                    data = new SqlDataAdapter(sql, cn);
                    tb = new DataTable();
                    data.Fill(tb);

                    if (tb.Rows.Count <= 0)
                    {
                        MessageBox.Show("PIN code is not correct !");
                    }

                    else
                    {
                        sql = "exec insert_userCustomer N'" + text1 + "', '" + text2 + "', '" + text3 + "', '" + text4 + "', '" + text5 + "'";
                        data = new SqlDataAdapter(sql, cn);
                        tb = new DataTable();
                        data.Fill(tb);

                        this.Hide();
                        Form4 form4 = new Form4(text1, text2, text3, text4, text5);
                        form4.Show();
                    }
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
