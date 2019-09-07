using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbledad.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            string nacimiento = txtnacimiento.Text;

            int edad = 2019 - Convert.ToInt32(nacimiento);

            lbledad.Text = Convert.ToString(edad);
            lbledad.Visible = true;

        }
    }
}
