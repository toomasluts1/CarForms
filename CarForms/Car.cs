using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarForms
{
    [Serializable]
    public class Car
    {
        private string carMark;
        private string maker;
        private string type;
        private short releaseYear;
        private string registrationDate;

        public Car() { }
        public Car(string carMark, string maker, string type, short releaseYear, string registrationDate)
        {
            this.carMark = carMark;
            this.maker = maker;
            this.type = type;
            this.releaseYear = releaseYear;
            this.registrationDate = registrationDate;
        }

        // Property with description for listbox
        public string Description => $"{carMark} {type}, Released: {releaseYear}, Registered: {registrationDate}";

        public string CarMark { get => carMark; set => carMark = value; }
        public string Maker { get => maker; set => maker = value; }
        public string Type { get => type; set => type = value; }
        public short ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public string RegistrationDate { get => registrationDate; set => registrationDate = value; }
    }
}
