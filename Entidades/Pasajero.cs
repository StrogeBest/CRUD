using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private int _dni;
        public int Dni { get => this._dni; set => this._dni = value; }

        public Pasajero() { }
        public Pasajero(string nombre, string apellido, int dni) : base(nombre, apellido)
        {
            this._dni = dni;
        }
    }
}