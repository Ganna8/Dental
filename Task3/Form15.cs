using clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class PatientHomePage : Form
    {
        public PatientHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookAppointment Book = new BookAppointment();
            Book.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpcomingAppointments App = new UpcomingAppointments();
            App.Show();
            this.Hide();
        }
    }
}
