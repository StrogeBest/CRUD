using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private string[] _elementos;
        private string[] _dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
        private int _dni;
        public int Dni { get => this._dni; set => this._dni = value; }

        public Pasajero() { }
        public Pasajero(string nombre, string apellido, int dni) : base(nombre, apellido)
        {
            this._dni = dni;
            this._elementos = new string[10];
        }

        public string this[int indice]
        {
            get => this._dias[indice];
            set => this._dias[indice] = value;
        }
    }
}