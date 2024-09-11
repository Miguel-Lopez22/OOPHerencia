
using System;

namespace OOPHerencia.Clases
{
    internal class Cursos
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Curso: {Nombre}");
            Console.WriteLine($"Recuento de Clases: {RecuentoClases}");
            Console.WriteLine($"Recuento de Ejercicios: {RecuentoEjercicios}");
        }

    }
}
    

