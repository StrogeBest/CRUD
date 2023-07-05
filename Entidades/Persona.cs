using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;

        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public string Apellido { get => this._apellido; set => this._apellido = value; }

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}