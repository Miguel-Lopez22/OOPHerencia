
using System;

namespace OOPHerencia.Base
{
    internal class Persona
    {
        public string nombre;

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
        }
    }
}
