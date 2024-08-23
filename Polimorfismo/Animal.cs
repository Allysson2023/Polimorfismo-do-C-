using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Animal
    {
        private string tipo;
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public Animal(string tipoAnimal)
        {
            this.tipo = tipoAnimal;
        }
        public virtual void caracteristicas()
        {

        }
    }
}
