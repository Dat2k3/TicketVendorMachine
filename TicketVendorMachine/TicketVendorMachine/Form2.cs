using System;
using System.Windows.Forms;

namespace TicketVendorMachine
{
    public partial class Form2 : Form
    {
        Destination destination = new Destination();
        private string text1;
        private string text2;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name, string phone) : this()
        {
            text1 = name;
            text2 = phone;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnBack.TabStop = false;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;

            btnEnter.TabStop = false;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.FlatAppearance.BorderSize = 0;

            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Start Time";
            dataGridView.Columns[1].Name = "Destination";
            dataGridView.Columns[2].Name = "Ticket Price";

            string[] row = new string[] { "6:30", "District 1", "5000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "7:30", "District 2", "25000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "8:30", "District 3", "60000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "9:30", "District 4", "6000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "10:30", "District 5", "8000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "11:30", "District 6", "14000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "13:30", "District 7", "7000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "14:30", "District 8", "18000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "15:30", "District 9", "25000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "16:30", "District 10", "10000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "17:30", "District 11", "16000VND" };
            dataGridView.Rows.Add(row);
            row = new string[] { "18:30", "District 12", "21000VND" };
            dataGridView.Rows.Add(row);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string mess = destination.toString();
            message.Text = mess;
           
            if(mess == " -  - ")
            {
                MessageBox.Show("Please, Choose the destination you want to go!");
            }

            else
            {
                Form3 form3 = new Form3(text1, text2, destination.Location, destination.Time, destination.Price);
                this.Hide();
                form3.Show();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string time = dataGridView.CurrentRow.Cells[0].Value.ToString();
            string location = dataGridView.CurrentRow.Cells[1].Value.ToString();
            string price = dataGridView.CurrentRow.Cells[2].Value.ToString();
                
            destination = new Destination(time, location, price);
            message.Text = destination.toString();
        }
    }
}
