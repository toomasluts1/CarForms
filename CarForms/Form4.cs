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
    public partial class Form4 : Form
    {
        public List<Car> cars; //List of filtered cars
        public Form1 carsForm; //Get access to the first form

        public Form4()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.Form4_FormClosed);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Show filtered cars in the listbox
            foreach(Car c in cars)
            {
                listBox1.Items.Add(c);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Bring back the first form when this one is closed
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            carsForm.Show();
        }
    }
}
