using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftManagementSystem
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStudents m = new UpdateStudents();
            m.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UpdateTeachers m = new UpdateTeachers();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCourse m = new UpdateCourse();
            m.Show();
            this.Hide();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateClubs uc = new UpdateClubs();
            uc.Show();
            this.Hide();

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
