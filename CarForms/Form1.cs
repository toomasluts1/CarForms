﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        public void Insert(Car c)
        {
            if (listCars.Count == 0)
            {
                listCars.Add(c);
                carBindingSource.DataSource = listCars;
            }
            else listCars.Add(c);
        }

        public void MoveLast()
        {
            carBindingSource.MoveLast();
        }

        public string getCarMark() { return tbCarMark.Text; }
        public string getMaker() { return tbMaker.Text; }
        public string getType() { return tbType.Text; }
        public string getReleaseYear() { return tbReleaseYear.Text; }
        public string getRegistrationDate() { return tbRegistrationDate.Text; }

        public void setCarMark(string x) {  tbCarMark.Text = x; }
        public void setMaker(string x) {  tbMaker.Text = x; }
        public void setType(string x) {  tbType.Text = x; }
        public void setReleaseYear(string x) {  tbReleaseYear.Text = x; }
        public void setRegistrationDate(string x) {  tbRegistrationDate.Text = x; }

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
            addForm.carsForm = this;
            addForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 editForm = new Form3();
            editForm.carsForm = this;
            editForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carBindingSource.RemoveCurrent();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carBindingSource.Clear();
            //carBindingSource.DataSource = listCars;
        }

        private void demoDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert(new Car("mark1", "maker1", "type1", 1, "date1"));
            Insert(new Car("mark2", "maker2", "type2", 2, "date2"));
            Insert(new Car("mark3", "maker3", "type3", 3, "date3"));
            Insert(new Car("mark4", "maker4", "type4", 4, "date4"));
            Insert(new Car("mark5", "maker5", "type5", 5, "date5"));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Andmefail|*.xml";
            openFileDialog1.Title = "Vali andmefail avamiseks";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialog1.FileName))
                {
                    XmlSerializer xmlser = new XmlSerializer(typeof(List<Car>));
                    listCars = (List<Car>)xmlser.Deserialize(reader);
                    carBindingSource.DataSource = listCars;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            saveFileDialog1.Filter = "Anmefail|*.xml";
            saveFileDialog1.Title = "Vali andmefail salvestamiseks";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream writer = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    XmlSerializer xmlser = new XmlSerializer(typeof(List<Car>));
                    xmlser.Serialize(writer, listCars);
                }
            }
        }
    }
}
