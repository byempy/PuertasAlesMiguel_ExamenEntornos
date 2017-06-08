using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertasAlesMiguel_EntornosFinal.models
{
    class Animal : IPesable
    {
        //atributos
        protected string nombre;
        protected string fechanacimiento;
        protected double peso;
        protected string comentarios;

        //Constructor
        public Animal(string nombre, string fechanacimiento, double pesos)
        {
           this.nombre = nombre;
           this.fechanacimiento = fechanacimiento;
           this.peso = pesos;
        }

        //propiedades
        public string Nombre{
            get{ return nombre; }
            set { }
         }

        public string FechaNacimiento
        {
            get { return fechanacimiento; }
            set { }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }

        //metodos
        public void Pesar(double peso)
        {
            this.peso += peso;
        }
    }
}
