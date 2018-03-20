using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> listaPerros;
            listaPerros = new List<Animal>();
            List<Animal> listaPerrosafan;
            listaPerrosafan = new List<Animal>();


            Console.WriteLine("------Bienvenidos a la tienda caninos------ ");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la obción correspondiente  ");
            Console.WriteLine("1)crear perros de afan  " + "\n" + " 2)crear perros dia normal");
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);


            switch (n)
            {
                case 1:

                    Console.WriteLine("digite la opcion " + "\n" + "1)crear Dogo " + "\n" + "2)crear Borzoi " + "\n" + "3)pitbull");
                    // se crea el nuevo perro //
                    string s2 = Console.ReadLine();
                    int n2 = int.Parse(s2);
                    switch (n2)
                    {
                            // creamos intacias y llamamos los costructores correpondientes de cada clase
                        case 1:
                            Animal nuevoPerro = new Dogo("copa", "gris", 7);
                            break;
                        case 2:
                            // creamos intacias y llamamos los costructores correpondientes de cada clase
                            Animal nuevoPerro2 = new Borzoi("el jefe", "negro ", 3);
                            break;
                        // creamos intacias y llamamos los costructores correpondientes de cada clase
                        case 3:
                            Animal nuevoPerro3 = new Pitbull("luna", "azul", 2);
                            break;
                    }




                    break;
                case 2:
                    Console.WriteLine("digite la opcion " + "\n" + "1)crear Dogo " + "\n" + "2)crear Borzoi " + "\n" + "3)pitbull");
                    // se crea el nuevo perro //
                    string s3 = Console.ReadLine();
                    int n3 = int.Parse(s3);
                    switch (n3)
                    {
                        case 1:
                            // creamos intacias y llamamos los costructores correpondientes de cada clase
                            Animal perroA = new Dogo("CAICER", "dogo", "blanco", 7, "macho", 2);
                            break;
                        case 2:
                            // creamos intacias y llamamos los costructores correpondientes de cada clase
                            Animal perroA2 = new Borzoi("LUCAS", "Borxoi", "cafe", 5, "macho", 6);
                            break;
                        case 3:
                            // creamos intacias y llamamos los costructores correpondientes de cada clase
                            Animal perroA3 = new Pitbull("el loco", "pitbull", "gris", 3, "macho", 1);
                            break;
                    }
                    break;


            }


        }

    }
}

