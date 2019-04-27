using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWP3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            

        }

        private static string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file. 
            return "Server=(local);Integrated Security=SSPI;" +
                "Initial Catalog=AdventureWorks";
        }
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder =
                                new SqlConnectionStringBuilder(GetConnectionString());

            string login = textBox1.Text;
            string password = textBox2.Text;

            while (textBox1.Text != "nauryzbai" && textBox2.Text!= "12345")
            {
                MessageBox.Show("Неверно, введите заново");
                return;
            }
            if(textBox1.Text == "nauryzbai" && textBox2.Text == "12345")
            {
                MessageBox.Show("Вы подключились усешно!");
                builder.ConnectionString = $"Data Source = ACER\\SQLEXPRESS;User ID = {textBox1.Text};" +
                $"Password = {textBox2.Text};Initial Catalog = HW3;";
            }
            
        }

        
    }
}
