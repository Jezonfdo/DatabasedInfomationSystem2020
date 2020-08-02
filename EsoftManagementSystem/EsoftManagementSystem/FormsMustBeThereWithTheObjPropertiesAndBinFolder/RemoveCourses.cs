﻿using System;
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
    public partial class RemoveCourses : Form
    {
        public RemoveCourses()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TNS-NB-FM\SQLEXPRESS;Initial Catalog=EsoftManagementSystemProject;Integrated Security=True");

        private void RemoveCourses_Load(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string view_query = "SELECT * FROM Courses WHERE ID=" + int.Parse(textBoxID.Text);
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
            try
            {
                con.Open();

                string view_query = "SELECT * FROM Courses";
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

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string delete_query = "DELETE FROM Courses WHERE ID=" + int.Parse(textBoxID.Text);
                SqlDataAdapter SDA = new SqlDataAdapter(delete_query, con);

                DataTable dt = new DataTable();
                SDA.Fill(dt);


                MessageBox.Show("Deleted");
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
            Remove r = new Remove();
            r.Show();
            this.Hide();
        }
    }
}
