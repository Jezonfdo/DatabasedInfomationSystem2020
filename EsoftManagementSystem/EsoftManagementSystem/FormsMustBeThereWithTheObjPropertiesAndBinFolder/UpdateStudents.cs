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
    public partial class UpdateStudents : Form
    {
        public UpdateStudents()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TNS-NB-FM\SQLEXPRESS;Initial Catalog=EsoftManagementSystemProject;Integrated Security=True");
        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string view_query = "SELECT * FROM Students WHERE ID=" + int.Parse(textBoxID.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            textBoxID.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string update_Query ="UPDATE Students SET Name='" + textBox1.Text + "', DateOfBirth='" + textBox2.Text + "', Telephone='" + textBox4.Text + "', Course='" + textBox5.Text + "', Gender='" + comboBox1.Text + "', ParentName='" + textBox6.Text + "' WHERE ID = '" + textBoxID.Text + "' ";
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

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
