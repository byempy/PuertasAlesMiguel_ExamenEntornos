using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertasAlesMiguel_EntornosFinal.models
{
    class Perro:Animal
    {
        //atributos
        private string raza;
        private string microship;

        //Constructor
        public Perro(string nombre, string raza, string fechaNacimiento, double peso, string microship):base(nombre, fechaNacimiento, peso)
        {
            Raza = raza;
            Microship = microship;
        }

        //propiedades
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public string Microship
        {
            get { return microship; }
            set { microship = value; }
        }

        //metodos
        public override string ToString()
        {
            return this.nombre + "\n" + this.raza + "\n" + this.fechanacimiento + "\n" + this.peso + "\n" + this.microship + "\n" + this.comentarios;
        }
    }
}
