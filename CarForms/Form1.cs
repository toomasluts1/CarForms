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
    public partial class Form1 : Form
    {
        List<Car> listCars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            carBindingSource.DataSource = typeof(Car);
        }

        private void Insert(Car c)
        {
            if (listCars.Count == 0)
            {
                listCars.Add(c);
                carBindingSource.DataSource = listCars;
            }
            else listCars.Add(c);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            carBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveLast();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addForm = new Form2();
            addForm.Show();
        }
    }
}
