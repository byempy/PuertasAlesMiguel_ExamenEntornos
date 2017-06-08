using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertasAlesMiguel_EntornosFinal.models
{
    class Pajaro:Animal
    {
        //atributos
        private string especie;
        private bool cantor;

        //Constructor
        public Pajaro(string nombre, string especie, string fechaNacimiento, double peso, bool cantor):base(nombre, fechaNacimiento, peso)
        {
            Especie = especie;
            Cantor = cantor;
        }
        
        //propiedades
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public bool Cantor
        {
            get { return cantor; }
            set { cantor = value; }
        }

        //metodos
        public override string ToString()
        {
            return this.nombre + "\n" + this.especie + "\n" + this.fechanacimiento + "\n" + this.peso + "\n" + ((this.cantor)?"Cantor":"No cantor :(") + "\n" + this.comentarios;
        }
    }
}
