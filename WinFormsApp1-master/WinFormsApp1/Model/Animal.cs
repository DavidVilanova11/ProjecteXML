using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteXML.model
{
    public class Animal
    {
        private string especie;
        private string nom;
        private int edat;
        private string color;

        public string Especie { get => especie; set => especie = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Edat { get => edat; set => edat = value; }
        public string Color { get => color; set => color = value; }
    }
}