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
    public partial class AddClubs : Form
    {
        public AddClubs()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TNS-NB-FM\SQLEXPRESS;Initial Catalog=EsoftManagementSystemProject;Integrated Security=True");
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
                try
            {
                con.Open();

                var InsertQuery = "INSERT INTO Clubs(ID,Name,DateOfPractice,TimeOfPractice,TeacherInCharge,Gender,Fees,PlaceHeld) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.Show();
            this.Hide();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddClubs_Load(object sender, EventArgs e)
        {

        }
    }
}
