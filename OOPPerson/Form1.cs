using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPerson
{
    public partial class Form1 : Form
    {

        Person firstPerson, secondPerson;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSecondPerson_Click(object sender, EventArgs e)
        {
            secondPerson = new Person(tbName.Text, Convert.ToInt32(numYear.Value), cbMale.Checked);
            string gender;

            if (secondPerson.getIsMale())
            {
                gender = "Male";
            }
            else
            {
                gender = "Woman";
            }

            label2.Text = "Name: " + secondPerson.getName() + " Date of birth: " + secondPerson.getAge().ToString() + " Gender: " + gender + " Age: " + secondPerson.getAge().ToString();

            btnOlder.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            btnSecondPerson.Enabled = false;
            btnOlder.Enabled = false;
        }

        private void btnOlder_Click(object sender, EventArgs e)
        {
            if (firstPerson.getAge() < secondPerson.getAge())
            {
                label3.Text = secondPerson.getName() + " is older. Age difference is " + (secondPerson.getAge() - firstPerson.getAge() + " year");
            }
            else if (firstPerson.getAge() > secondPerson.getAge())
            {
                label3.Text = firstPerson.getName() + " is older. Age difference is " + (firstPerson.getAge() - secondPerson.getAge() + " year");
            }
            else
            {
                label3.Text = firstPerson.getName() + " & " + secondPerson.getName() + ", they are the same age, there is no age difference!";
            }
        } 

        private void btnFirstPerson_Click(object sender, EventArgs e)
        {
            firstPerson = new Person(tbName.Text, Convert.ToInt32(numYear.Value), cbMale.Checked);
            string gender;

            if (firstPerson.getIsMale())
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            label1.Text = "Name: " + firstPerson.getName() + " Date of birth: " + firstPerson.getAge().ToString() + " Gender: " + gender + " Age: " + firstPerson.getAge().ToString();

            btnSecondPerson.Enabled = true;
        }
    }
}
