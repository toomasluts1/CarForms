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
        public Form1 carsForm;

        public Form3()
        {
            InitializeComponent();
        }

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
            carsForm.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            carsForm.setCarMark(tbCarMark.Text);
            carsForm.setMaker(tbMaker.Text);
            carsForm.setType(tbType.Text);
            carsForm.setReleaseYear(tbReleaseYear.Text);
            carsForm.setRegistrationDate(tbRegistrationDate.Text);

            this.Close();
            carsForm.Show();
        }
    }
}
