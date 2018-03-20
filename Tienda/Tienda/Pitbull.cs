using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Pitbull:Animal
    {
        private int cabezas;
        /// <summary>
        /// encapsulamos el atributo
        /// </summary>
        public int Cabezas
        {
            get { return cabezas; }
            set { cabezas = value; }
        }
        
        public Pitbull()
        { }
        /// <summary>
        /// utilizamos polimosfismo para los contructores
        /// </summary>
        /// <param name="nom">nombre</param>
        /// <param name="color">color </param>
        /// <param name="antenas">alas</param>
        public Pitbull(string nom, string color, int _cabezas)
        {
            base.Color = color;
            base.Nombre = nom;
            this.cabezas = _cabezas;
        }
        /// <summary>
        /// utilizamos polimosfismo para los contructores
        /// </summary>
        /// <param name="nom">nombre</param>
        /// <param name="raza">raza</param>
        /// <param name="colo">color</param>
        /// <param name="edad">edad</param>
        /// <param name="genero">generro</param>
        /// <param name="antenas">cabezas</param>
         public Pitbull(string nom, string raza, string colo, int edad, string genero, int _cabezas)
        {
            base.Nombre = nom;
            base.Raza = raza;
            base.Color = colo;
            base.Edad = edad;
            base.Genero = genero;
            this.cabezas = _cabezas;
        }
    }
}
