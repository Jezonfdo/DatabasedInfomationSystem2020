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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainMenu ma = new MainMenu();
            ma.Show();
            this.Hide();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTeacher ad = new AddTeacher();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCourses ac = new AddCourses();
            ac.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudents ass = new AddStudents();
            ass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClubs acc = new AddClubs();
            acc.Show();
            this.Hide();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
