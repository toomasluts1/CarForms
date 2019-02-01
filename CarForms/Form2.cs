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
        public Form1 carsForm;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Car c = new Car(tbCarMark.Text, tbMaker.Text, tbType.Text, short.Parse(tbReleaseYear.Text), tbRegistrationDate.Text);
            carsForm.Insert(c);
            carsForm.MoveLast();
            this.Close();
            carsForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            carsForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
