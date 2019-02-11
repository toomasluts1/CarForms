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
    public partial class Form3 : Form
    {
        public Form1 carsForm; //Get access to the first form

        public Form3()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.Form3_FormClosed);
        }

        //Fill the textboxes with previous form's data
        private void Form3_Load(object sender, EventArgs e)
        {
            tbCarMark.Text = carsForm.getCarMark();
            tbMaker.Text = carsForm.getMaker();
            tbType.Text = carsForm.getType();
            tbReleaseYear.Text = carsForm.getReleaseYear();
            tbRegistrationDate.Text = carsForm.getRegistrationDate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            //Check if entered Release Year is a number
            if (short.TryParse(tbReleaseYear.Text, out short year) == false)
            {
                MessageBox.Show("Release Year incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Change the current car's data
            else
            {
                carsForm.setCarMark(tbCarMark.Text);
                carsForm.setMaker(tbMaker.Text);
                carsForm.setType(tbType.Text);
                carsForm.setReleaseYear(tbReleaseYear.Text);
                carsForm.setRegistrationDate(tbRegistrationDate.Text);
                carsForm.apply();

                this.Close();
                carsForm.Show();
            }
        }

        //Bring back the first form when this one is closed
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            carsForm.Show();
        }
    }
}
