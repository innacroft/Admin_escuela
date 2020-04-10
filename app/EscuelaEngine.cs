using System;
using System.Collections.Generic;
using System.Linq;
using coreEscuela.Entidades;
using static System.Console;
using coreEscuela.Util;


namespace coreEscuela
{
  public class EscuelaEngine
  {


    public Escuela Escuela { get; set; }

    public EscuelaEngine()
    {
      Escuela = new Escuela("Platzi academy", 2012, TiposEscuela.Preescolar, pais: "Colombia", ciudad: "Bogota");
    }
    public void Inicializar()
    {
      CargarCursos();
      CargarAsignaturas();
      CargarEvaluaciones();

    }

    private void CargarEvaluaciones()
    {
      int counter = 0;
      int counter_alumn = 0;

      List<Evaluaciones> evaluaciones = new List<Evaluaciones>();
      foreach (var curso in Escuela.Cursos)
      {
        foreach (var alumno in curso.Alumnos)
        {
          counter_alumn++;
          foreach (var Asignatura in curso.Asignaturas)
          {
            for (int i = 0; i < 5; i++)
            {
              Random rand = new Random();
              double numb = rand.NextDouble();
              double averagesDoubles = Math.Round(numb, 1);
              float nota = Convert.ToSingle(Math.Round((averagesDoubles * 5.0 / 0.9), 1));
              counter++;
              var evas = new Evaluaciones();
              evas.Nombre = "Evaluacion No. " + counter.ToString();
              evas.Asignatura = Asignatura;
              evas.Alumno = alumno;
              evas.Nota = nota;
              evaluaciones.Add(evas);
              WriteLine($"{evas.Nombre}\n Asignatura: {evas.Asignatura.Nombre}| Alumno: {evas.Alumno.Nombre}| Nota: {nota}");
            }
          }
        }
      }
      WriteLine($"Total evaluaciones: {evaluaciones.Count()} | Total alumnos: {counter_alumn}  ");
    }

    public double GetRandomNumber(double minimum, double maximum)
    {
      Random random = new Random();
      return random.NextDouble() * (maximum - minimum) + minimum;
    }

    private void CargarAsignaturas()
    {
      foreach (var curso in Escuela.Cursos)
      {
        List<Asignatura> listaAsignaturas = new List<Asignatura>{
          new Asignatura{Nombre="Matemáticas"},
          new Asignatura{Nombre="Ed Fisica"},
          new Asignatura{Nombre="Castellano"},
          new Asignatura{Nombre="Ciencias Naturales"}
        };
        curso.Asignaturas = listaAsignaturas;
      }
    }

    private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
    {
      string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
      string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

      var listaAlumnos = from n1 in nombre1
                         from n2 in nombre2
                         from a1 in apellido1
                         select new Alumno { Nombre = $"{n1} {n2} {a1}" };

      return listaAlumnos.OrderBy(al => al.UniqueId).Take(cantidad).ToList();
    }

    public void CargarCursos()
    {
      Escuela.Cursos = new List<Curso>(){
         new Curso(){Nombre="101",Jornada=TiposJornada.Mañana},
         new Curso(){Nombre="201",Jornada=TiposJornada.Mañana},
         new Curso(){Nombre="301",Jornada=TiposJornada.Mañana},
         new Curso(){Nombre="401",Jornada=TiposJornada.Mañana},
         new Curso(){Nombre="501",Jornada=TiposJornada.Mañana},
    };
      Random random = new Random();


      foreach (var curso in Escuela.Cursos)
      {
        int cantrandom = random.Next(5, 20);
        curso.Alumnos = GenerarAlumnosAlAzar(cantrandom);
      }
    }

  }


}