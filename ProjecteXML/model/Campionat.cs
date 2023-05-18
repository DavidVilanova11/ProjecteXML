using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteXML.model
{
    public class Campionat
    {
        private int year;
        private String city;
        private String country;
        private List<DJ> Disjockeys = new List<DJ>();

        public int Year { get => year; set => year = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public List<DJ> Disjockeys1 { get => Disjockeys; set => Disjockeys = value; }

        public void addDJ(DJ dj)
        {
            Disjockeys.Add(dj);
        }

    }

}
