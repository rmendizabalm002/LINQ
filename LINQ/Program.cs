using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var alumnos = new List<Alumno>
            {
            new Alumno {Nombre = "victor",Nota = 5},
            new Alumno {Nombre = "oscar",Nota = 8},
            new Alumno {Nombre = "ruben",Nota = 3}
            };

            //SELECT
            Console.WriteLine("=====Select=====");
            Console.WriteLine("");

            var nombresAlumnos = alumnos.Select(x => x.Nombre).ToList();
            Console.WriteLine("Los nombres de los alumnos son: "+nombresAlumnos);

            //WHERE
            Console.WriteLine("=====where=====");
            Console.WriteLine("");

            var alumnosAprobados = alumnos.Where(x => x.Nota >= 5).ToList();
            Console.WriteLine("alumnos aprobados: "+alumnosAprobados);

            //PRIMERO Y ULTIMO
            Console.WriteLine("=====first/last=====");
            Console.WriteLine("");

            var primero = alumnos.First();
            var ultimo = alumnos.Last();

            Console.WriteLine("primer alumno: " +primero);
            Console.WriteLine("ultimo alumno: " +ultimo);


            //ORDER BY
            Console.WriteLine("=====OrderBy=====");
            Console.WriteLine("");

            var ordenadoMenorAMayor = alumnos.OrderBy(x => x.Nota).ToList();
            var ordenadoMayorAMenos = alumnos.OrderByDescending(x => x.Nota).ToList();

            Console.WriteLine("ordenar de menor a mayor: " +ordenadoMenorAMayor);
            Console.WriteLine("ordenar de mayor a menor: " +ordenadoMayorAMenos);

            var sumaNotas = alumnos.Sum(x => x.Nota);

            //MAX/MIN
            Console.WriteLine("=====max/min=====");
            Console.WriteLine("");

            var notaMaxima = alumnos.Max(x => x.Nota);
            var notaMinima = alumnos.Min(x => x.Nota);

            Console.WriteLine("nota maxima: "+notaMaxima);
            Console.WriteLine("nota minima: " + notaMinima);

            //AVERAGE
            Console.WriteLine("=====average=====");

            var media = alumnos.Average(x => x.Nota);

            Console.WriteLine("nota media: "+media);

            //ALL/ANY
            Console.WriteLine("=====all/any=====");
            Console.WriteLine("");

            var todosAprobados = alumnos.All(x => x.Nota >= 5);
            var algunAprobado = alumnos.Any(x => x.Nota >= 5);

            Console.WriteLine("estan todos aprobados? "+todosAprobados);
            Console.WriteLine("hay algun aprobado? " + algunAprobado);

        }
    }

    public class Alumno
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }



        
    }
}
