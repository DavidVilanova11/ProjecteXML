using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteXML.model
{
    internal class Animal
    {
        private int pos;
        private string name;
        private string description;

        public int Pos { get => pos; set => pos = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        //Public void setPos(in pos) {
        //{
        // this.pos = pos
        //}
    }
}
