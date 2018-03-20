using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Dogo:Animal
    {
         private int antenas;
        /// <summary>
        /// encapsulamos el atributo
        /// </summary>
        public int Antenas
        {
            get { return antenas; }
            set { antenas = value; }
        }
        /// <summary>
        /// contructor vacio
        /// </summary>
        public Dogo()
        { }
        /// <summary>
        /// utilizamos polimosfismo para los contructores
        /// </summary>
        /// <param name="nom">nombre</param>
        /// <param name="color">color </param>
        /// <param name="antenas">antenas</param>
        public Dogo(string nom,string color,int antenas)
        {
            base.Color = color;
            base.Nombre = nom;
            this.antenas = antenas;

        }
        /// <summary>
        /// utilizamos polimosfismo para los contructores
        /// </summary>
        /// <param name="nom">nombre</param>
        /// <param name="raza">raza</param>
        /// <param name="colo">color</param>
        /// <param name="edad">edad</param>
        /// <param name="genero">generro</param>
        /// <param name="antenas">antenas</param>
        public Dogo(string nom, string raza, string colo, int edad, string genero, int antenas)
        {
            base.Nombre = nom;
            base.Raza = raza;
            base.Color = colo;
            base.Edad = edad;
            base.Genero = genero;
            this.antenas = antenas;

        }
    }
}
