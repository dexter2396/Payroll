using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Person person;
        public Form2(Person person)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = person.getName();
            label4.Text = person.getPosition();
            label6.Text = Convert.ToString(person.getRate());
            label8.Text = Convert.ToString((int)person.getManhour());
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
