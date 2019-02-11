using System;
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
        string currentFile; //Name of the last saved file

        public Form1()
        {
            InitializeComponent();
            carBindingSource.DataSource = typeof(Car);
            ShowInfo();

            //Load or create a default XML file on startup
            string f = "default.xml";
            try
            {
                openXml(f);
            }
            catch(FileNotFoundException e)
            {
                saveXml(f);
            }
            currentFile = f;
        }

        //Show current and total items
        private void ShowInfo()
        {
            if (listCars.Count != 0)
            {
                lblCounter.Text = (carBindingSource.Position + 1).ToString() + " / " + carBindingSource.Count.ToString();
            }
            else lblCounter.Text = "None";
        }


        public void Insert(Car c)
        {
            if (listCars.Count == 0)
            {
                listCars.Add(c);
                carBindingSource.DataSource = listCars;
            }
            else listCars.Add(c);
            ShowInfo();
        }

        //public MoveLast method for adding a car from an other form
        public void MoveLast()
        {
            carBindingSource.MoveLast();
            ShowInfo();
        }

        //Getters and setters for interacting with other forms
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

        //Buttons for navigating through the list
        private void btnFirst_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveFirst();
            ShowInfo();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            carBindingSource.MovePrevious();
            ShowInfo();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveNext();
            ShowInfo();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            carBindingSource.MoveLast();
            ShowInfo();
        }

        //Form for adding a car
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addForm = new Form2();
            addForm.carsForm = this; //Make this form accessible from the new form
            addForm.Show();
        }

        //Form for editing a car's data
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 editForm = new Form3();
            editForm.carsForm = this; //Make this form accessible from the new form
            editForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carBindingSource.RemoveCurrent();
            if (listCars.Count == 0) carBindingSource.DataSource = typeof(Car);
            else carBindingSource.DataSource = listCars;
            ShowInfo();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carBindingSource.Clear();
            carBindingSource.DataSource = typeof(Car);
            ShowInfo();
        }

        //Generate sample data
        private void demoDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert(new Car("Toyota", "Toyota", "Highlander", 2019, "25.01.2019"));
            Insert(new Car("Ferrari", "Ferrari", "360GT", 2002, "07.11.2004"));
            Insert(new Car("BMW", "BMW", "i8", 2014, "11.12.2014"));
            Insert(new Car("Tesla", "Tesla", "Model X", 2016, "05.02.2017"));
            Insert(new Car("Nissan", "Nissan", "Micra", 2018, "06.08.2018"));
            Insert(new Car("Ford", "Ford", "EcoSport", 2019, "15.01.2019"));
            Insert(new Car("Ford", "Ford", "Fiesta", 2015, "23.11.2016"));
            Insert(new Car("Ford", "Ford", "Focus", 1998, "18.02.1999"));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Andmefail|*.xml";
            openFileDialog1.Title = "Vali andmefail avamiseks";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openXml(openFileDialog1.FileName);
            }
        }

        //Save as
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Andmefail|*.xml";
            saveFileDialog1.Title = "Vali andmefail salvestamiseks";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveXml(saveFileDialog1.FileName);
            }
        }

        //Find cars matching the criteria and send them to the listbox form
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Car> filteredCars = new List<Car>();
            foreach (Car c in listCars)
            {
                if (c.CarMark.ToUpper() == "FORD" && dateYear(c.RegistrationDate) >= 2000)
                {
                    filteredCars.Add(c);
                }
            }

            this.Hide();
            Form4 listForm = new Form4();
            listForm.cars = filteredCars;
            listForm.carsForm = this; //Make this form accessible from the new form
            listForm.Show();
        }

        //Method to apply changes from another form after editing
        public void apply() { carBindingSource.EndEdit(); }

        //Save
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveXml(currentFile);
        }

        //Read list of cars from an XML file
        private void openXml(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Car>));
                listCars = (List<Car>)xmlser.Deserialize(reader);
                if (listCars.Count == 0) carBindingSource.DataSource = typeof(Car);
                else carBindingSource.DataSource = listCars;
            }
            ShowInfo();
        }

        //Save list of cars as into XML format
        private void saveXml(string fileName)
        {
            using (FileStream writer = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Car>));
                xmlser.Serialize(writer, listCars);
            }
        }

        //Find the year from a date string by looking for the longest number
        private int? dateYear(string date)
        {
            string[] parts = date.Split('/', '.', '-');
            int j = 0;
            int length = 0;
            for (int i = 0; i<parts.Length; i++)
            {
                if (parts[i].Length > length)
                {
                    j = i;
                    length = parts[i].Length;
                }
            }

            try
            {
                int year = int.Parse(parts[j]);
                return year;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
