using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertasAlesMiguel_EntornosFinal.models
{
    class Reptil:Animal
    {
        //atributos
        private string especie;
        private bool venenoso;

        //Constructor
        public Reptil(string nombre, string especie, string fechaNacimiento, double peso, bool venenoso):base(nombre, fechaNacimiento, peso)
        {
            Especie = especie;
            Venenoso = venenoso;
        }

        //propiedades
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public bool Venenoso
        {
            get { return venenoso; }
            set { venenoso = value; }
        }

        //metodos
        public override string ToString()
        {
            return this.nombre + "\n" + this.especie + "\n" + this.fechanacimiento + "\n" + this.peso + "\n" + ((this.venenoso)?"Venenoso":"No venenoso") + "\n" + this.comentarios;
        }
    }
}
