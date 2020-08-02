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

namespace EsoftManagementSystem
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TNS-NB-FM\SQLEXPRESS;Initial Catalog=EsoftManagementSystemProject;Integrated Security=True");
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                var InsertQuery = "INSERT INTO Students(ID,Name,DateOfBirth,Telephone,Course,Gender,ParentName) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(InsertQuery, con);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Booyah!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Add ad = new Add();
            ad.Show();
            this.Hide();
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
