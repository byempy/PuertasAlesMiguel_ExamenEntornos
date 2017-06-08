using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertasAlesMiguel_EntornosFinal.models
{
    class ClinicaVeterinaria
    {
        //atributos
        private IList listaAnimales;

        //constructor
        public ClinicaVeterinaria()
        {
            listaAnimales = new List<Animal>();
        }

        //metodos
        public void InsertarAnimal(Animal a)
        {
            listaAnimales.Add(a);
        }

        public Animal BuscaAnimal(string nombre)
        {
            Animal aux = null;

            foreach (Animal i in listaAnimales)
            {
                if (i.Nombre.Equals(nombre))
                {
                    aux = i;
                    break;
                }
            }

            return aux;
        }

        public void ModificaComentarioAnimal(string nombre, string nuevoComentario)
        {
            Animal aux = BuscaAnimal(nombre);
            if (aux != null)
                aux.Comentarios = nuevoComentario;
            else
                throw new Exception("ERROR: No se encontro un animal con ese nombre");
        }
        
        public void PesarAnimal(string nombre, double peso)
        {
            Animal aux = BuscaAnimal(nombre);
            if (aux != null)
                aux.Peso = peso;
            else
                throw new Exception("ERROR: No se encontro un animal con ese nombre");
        }

        public override string ToString()
        {
            string mensaje = "";

            foreach(Animal i in listaAnimales)
            {
                mensaje += i;
            }

            return mensaje;
        }
    }
}
