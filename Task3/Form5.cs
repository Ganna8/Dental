using clinic;
using EditProfile1;
using RequestMaterial;
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
    public partial class ViewMaterialsDoctor : Form
    {
        public ViewMaterialsDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestMaterial.RequestMaterial1 Request = new RequestMaterial1();
            Request.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }
    }
}
