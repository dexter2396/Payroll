using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Person person;
        public Form1(Person person)
        {
            InitializeComponent();
            this.person = person;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.setName(textBox1.Text);
            person.setPosition(textBox2.Text);
            person.setRate(Int32.Parse(textBox3.Text));
            person.setManhour(Int32.Parse(textBox4.Text));

            MessageBox.Show("Submitted Successfully");
            Form2 form = new Form2(person);
            form.Show();
            this.Hide();

           
        }
    }
}
