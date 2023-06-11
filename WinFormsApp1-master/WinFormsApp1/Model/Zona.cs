using ProjecteXML.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Zona
    {
        private double latitud;
        private double longitiud;
        private double metres_quadrats;
        private List<Animal> animals;

        public double Latitud { get => latitud; set => latitud = value; }
        public double Longitiud { get => longitiud; set => longitiud = value; }
        public double Metres_quadrats { get => metres_quadrats; set => metres_quadrats = value; }
        public List<Animal> Animals { get => animals; set => animals = value; }

        public Zona()
        {
            Animals = new List<Animal>();
        }
    }
}

