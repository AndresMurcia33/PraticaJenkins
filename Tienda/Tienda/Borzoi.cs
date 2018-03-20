using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Borzoi:Animal
    {
         private int alas;
         /// <summary>
         /// encapsulamos el atributo
         /// </summary>
        public int Alas
        {
            get { return alas; }
            set { alas = value; }
        }
        public Borzoi()/// <summary>
        /// utilizamos polimosfismo para los contructores
        /// </summary>
        /// <param name="nom">nombre</param>
        /// <param name="color">color </param>
        /// <param name="antenas">alas</param>
        { }
        
         public Borzoi(string nom,string color,int alas)
        {
            base.Nombre = nom;
            base.Color = color;
            this.alas = alas;
        }
         /// <summary>
         /// utilizamos polimosfismo para los contructores
         /// </summary>
         /// <param name="nom">nombre</param>
         /// <param name="raza">raza</param>
         /// <param name="colo">color</param>
         /// <param name="edad">edad</param>
         /// <param name="genero">generro</param>
         /// <param name="antenas">alas</param>
         public Borzoi(string nom, string raza, string colo, int edad, string genero, int alas)
        {
            base.Nombre = nom;
            base.Raza = raza;
            base.Color = colo;
            base.Edad = edad;
            base.Genero = genero;
            this.alas = alas;

        }
        
    }
}
