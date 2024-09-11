
using OOPHerencia.Base;
using System;

namespace OOPHerencia.Clases
{
    internal class Estudiante : Persona
    {
        public int NumeroUnico { get; set; }
        public Clase Clase { get; set; }

        public override void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------Estudiantes:" + nombre + "------------------------------------------------");
            base.ImprimirDatos();
            Console.WriteLine($"Número Único: {NumeroUnico}");
            Console.WriteLine($"Clase: {Clase.Identificador}");
        }

    }





}
    

