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
    public partial class UpdateTeachers : Form
    {
        public UpdateTeachers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TNS-NB-FM\SQLEXPRESS;Initial Catalog=EsoftManagementSystemProject;Integrated Security=True");
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string update_Query = "UPDATE Teachers WHERE ID='" + textBox8.Text + "', Name='" + textBox1.Text + "', DateOfBirth='" + textBox2.Text + "', Telephone='" + textBox3.Text + "', Course='" + textBox4.Text + "', Gender='" + comboBox1.Text + "', Salary='" + textBox5.Text + "',  Age='" + textBox6.Text + "',  DateJoined='" + textBox7.Text + "' WHERE ID = '" + textBoxID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(update_Query, con);
                SDA.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Wakanda!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBoxID.Clear();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string view_query = "SELECT * FROM Teachers WHERE ID=" + int.Parse(textBoxID.Text);
                SqlDataAdapter SDA = new SqlDataAdapter(view_query, con);

                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Hide();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTeachers_Load(object sender, EventArgs e)
        {

        }
    }
}
