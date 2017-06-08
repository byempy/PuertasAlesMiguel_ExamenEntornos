using PuertasAlesMiguel_EntornosFinal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertasAlesMiguel_EntornosFinal
{
    class Program
    {
        static ClinicaVeterinaria clinica = new ClinicaVeterinaria();

        static void Main(string[] args)
        {
            bool seguir = true;
            string respuesta = "";

            Console.WriteLine("Bienvenido a la Clinica del Sr. Miguel Puertas Ales");

            do
            {
                Console.WriteLine();
                Console.WriteLine("1-Añadir animal");
                Console.WriteLine("2-Modificar comentarios");
                Console.WriteLine("3-Pesar animal");
                Console.WriteLine("4-Mostrar por pantalla animal");
                Console.WriteLine("5-Salir");
                Console.WriteLine();
                Console.Write("Elige lo que quieres hacer: ");
                respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    case "1":
                        MenuAnimal();
                        break;
                    case "2":
                        ModificarComentario();
                        break;
                    case "3":
                        ModificarPeso();
                        break;
                    case "4":
                        MostrarAnimal();
                        break;
                    case "5":
                        seguir = false;
                        break;

                }
            } while (seguir);
        }

        static void MenuAnimal()
        {
            string tipoAnimal = "";
            string nombre = "";
            string fechanacimiento = "";
            double peso = 0;
            string raza = "";
            string microship = "";
            bool venenosoCantador = true;

            bool centinela = true;
            string aux = "";
            bool seguir = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1-Perro");
                Console.WriteLine("2-Gato");
                Console.WriteLine("3-Pajaro");
                Console.WriteLine("4-Reptil");
                Console.WriteLine("5-Salir");
                Console.WriteLine();
                Console.Write("Elige el tipo de animal: ");
                tipoAnimal = Console.ReadLine();

                if (!tipoAnimal.Equals("5"))
                {
                    Console.Write("Nombre del bicho: ");
                    nombre = Console.ReadLine();

                    Console.Write("Fecha de nacimiento: ");
                    fechanacimiento = Console.ReadLine();

                    do
                    {
                        centinela = true;
                        Console.Write("Peso: ");
                        if (double.TryParse(Console.ReadLine(), out peso))
                        {
                            if (peso > 0)
                                centinela = false;
                            else
                                Console.WriteLine("ERROR: El peso tiene que ser mayor a 0");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: El peso no es valido.. tiene que ser un valor númerico");
                        }

                    } while (centinela);
                }
                switch (tipoAnimal)
                {
                    case "1":
                        Console.Write("Raza: ");
                        raza = Console.ReadLine();
                        Console.Write("Microship: ");
                        microship = Console.ReadLine();

                        clinica.InsertarAnimal(new Perro(nombre, raza, fechanacimiento, peso, microship));
                        break;
                    case "2":
                        Console.Write("Raza: ");
                        raza = Console.ReadLine();
                        Console.Write("Microship: ");
                        microship = Console.ReadLine();

                        clinica.InsertarAnimal(new Gato(nombre, raza, fechanacimiento, peso, microship));
                        break;
                    case "3":
                        Console.Write("Especie: ");
                        raza = Console.ReadLine();
                        Console.Write("¿Cantor?(S/N): ");
                        aux = Console.ReadLine();
                        if (aux.Equals("S"))
                        {
                            venenosoCantador = true;
                        }
                        else
                        {
                            venenosoCantador = false;
                        }

                        clinica.InsertarAnimal(new Pajaro(nombre, raza, fechanacimiento, peso, venenosoCantador));
                        break;
                    case "4":
                        Console.Write("Especie: ");
                        raza = Console.ReadLine();
                        Console.Write("¿Venenoso?(S/N): ");
                        aux = Console.ReadLine();
                        if (aux.Equals("S"))
                        {
                            venenosoCantador = true;
                        }
                        else
                        {
                            venenosoCantador = false;
                        }

                        clinica.InsertarAnimal(new Reptil(nombre, raza, fechanacimiento, peso, venenosoCantador));
                        break;
                    case "5":
                        Console.WriteLine("Esto se merece un 10 :D");
                        seguir = false;
                        break;
                }
            } while (seguir);
        }

        static void ModificarComentario()
        {
            string nombre = "", comentario = "";

            Console.Write("Nombre del animal: ");
            nombre = Console.ReadLine();
            Console.Write("Nuevo comentario: ");
            comentario = Console.ReadLine();

            try
            {
                clinica.ModificaComentarioAnimal(nombre, comentario);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ModificarPeso()
        {
            string nombre = "";
            double pesito = 0;
            bool error = true;

            Console.Write("Nombre del animal: ");
            nombre = Console.ReadLine();
            do
            {
                Console.Write("Peso: ");
                if (double.TryParse(Console.ReadLine(), out pesito))
                {
                    if (pesito > 0)
                    {
                        error = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El peso tiene que ser mayor a 0");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: El peso tiene que ser un valor númerico");
                }
            } while (error);

            try
            {
                clinica.PesarAnimal(nombre, pesito);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void MostrarAnimal()
        {
            string nombre = "";
            Animal aux;

            Console.Write("Nombre del bicho: ");
            nombre = Console.ReadLine();

            aux = clinica.BuscaAnimal(nombre);
            if(aux != null)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Ficha Animal");
                Console.WriteLine("-------------");
                Console.WriteLine(aux);
            }
            else
            {
                Console.WriteLine("ERROR: No se encontro un animal con ese nombre");
            }
        }
    }
}
