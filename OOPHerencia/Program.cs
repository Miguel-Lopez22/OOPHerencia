using OOPHerencia.Clases;
using System;

namespace OOPHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clase claseA = new Clase { Identificador = "A101" };
            Clase claseB = new Clase { Identificador = "A102" };


            Estudiante estudiante1 = new Estudiante { nombre = "Natalya Kintana", NumeroUnico = 5, Clase = claseA };
            Estudiante estudiante2 = new Estudiante { nombre = "Juaquin Montero", NumeroUnico = 8, Clase = claseA };
            Estudiante estudiante3 = new Estudiante { nombre = "Grabiel Garcia Marquez", NumeroUnico = 4, Clase = claseA };
            Estudiante estudiante4 = new Estudiante { nombre = "Miguel Lopez", NumeroUnico = 2, Clase = claseB };


            Profesor profesor1 = new Profesor { nombre = "William Smith" };
            Profesor profesor2 = new Profesor { nombre = "Victor Rojas" };
            Profesor profesor3 = new Profesor { nombre = "Carlos Navarro" };
            Profesor profesor4 = new Profesor { nombre = "Jessica Jones" };


            Cursos curso1 = new Cursos { Nombre = "Naturales", RecuentoClases = 25, RecuentoEjercicios = 80 };
            Cursos curso2 = new Cursos { Nombre = "Matemáticas", RecuentoClases = 40, RecuentoEjercicios = 100 };
            Cursos curso3 = new Cursos { Nombre = "Español", RecuentoClases = 20, RecuentoEjercicios = 50 };


            profesor1.AgregarCurso(curso1);
            profesor2.AgregarCurso(curso2);

            claseA.AgregarEstudiante(estudiante1);
            claseA.AgregarEstudiante(estudiante2);
            claseA.AgregarEstudiante(estudiante3);
            claseA.AgregarProfesor(profesor1);
            claseA.AgregarProfesor(profesor2);


            claseB.AgregarEstudiante(estudiante4);
            claseB.AgregarEstudiante(estudiante2);
            claseB.AgregarEstudiante(estudiante3);

            claseB.AgregarProfesor(profesor2);






            claseA.ImprimirDatos();
            claseB.ImprimirDatos();

            Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }

    }
}
        
    

