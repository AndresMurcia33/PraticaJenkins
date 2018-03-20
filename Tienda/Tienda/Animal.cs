using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Animal
    {
        // se declaran las variablas y se encapsulan los atributos
        private string raza;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        

    }
}
