using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_a_editace_položek
{
    public class University : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string state;
        public string State
        {
            get => state;
            set { state = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("State")); }
        }

        private int established;
        public int Established
        {
            get => established;
            set { established = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Established")); }
        }

        private string address;
        public string Address
        {
            get => address;
            set { address = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Address")); }
        }

        private double successRate;
        public double SuccessRate
        {
            get => successRate;
            set { successRate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SuccessRate")); }
        }

        private decimal tuition;
        public decimal Tuition
        {
            get => tuition;
            set { tuition = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tuition")); }
        }

        public static ObservableCollection<University> AllUniversities { get; set; } = new ObservableCollection<University>();

        public static void InitUniversities()
        {
            AllUniversities.Add(new University
            {
                Name = "JeVidětŽe",
                State = "JsemNestíhal",
                Established = 22091991
            });

            AllUniversities.Add(new University
            {
                Name = "Viktor",
                State = "Skála",
                Established = 02042001
            });

            AllUniversities.Add(new University
            {
                Name = "David",
                State = "Obruč",
                Established = 12121987
            });

            AllUniversities.Add(new University
            {
                Name = "Viktorie",
                State = "Navrátilová",
                Established = 07082000
            });

            AllUniversities.Add(new University
            {
                Name = "Vojta",
                State = "Kuděk",
                Established = 09121999
            });

            AllUniversities.Add(new University
            {
                Name = "Martin",
                State = "Bezruč",
                Established = 05081989
            });

            AllUniversities.Add(new University
            {
                Name = "Tereza",
                State = "Jurášková",
                Established = 20042003
            });
        }

    }
}
