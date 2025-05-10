using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Exam.Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var conn = new SqlConnection("Data Source=ASUS;Initial Catalog=loginnapp;Integrated Security=True;TrustServerCertificate=True");
            //string query = "SELECT COUNT(*) loginapp WHERE username=@username AND password=@password";
            //var cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@username", textBox1.Text);
            //cmd.Parameters.AddWithValue("@password", textBox2.Text);
            var conn = new SqlConnection("Data Source=ASUS;Initial Catalog=loginapp;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM loginnapp WHERE username=@username AND password=@password";
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            // Burada sorğunu icra edə bilərsiniz, məsələn: var count = (int)cmd.ExecuteScalar();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
