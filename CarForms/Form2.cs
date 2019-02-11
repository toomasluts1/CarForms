using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarForms
{
    public partial class Form2 : Form
    {
        public Form1 carsForm; //Get access to the first form

        public Form2()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.Form2_FormClosed);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            //Check if entered Release Year is a number
            if (short.TryParse(tbReleaseYear.Text, out short year) == false)
            {
                MessageBox.Show("Release Year incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Add a new car
            else
            {
                Car c = new Car(tbCarMark.Text, tbMaker.Text, tbType.Text, short.Parse(tbReleaseYear.Text), tbRegistrationDate.Text);
                carsForm.Insert(c);
                carsForm.MoveLast();
                this.Close();
                carsForm.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        //Bring back the first form when this one is closed
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            carsForm.Show();
        }
    }
}
