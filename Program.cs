using System;
using System.Collections.Generic;
using coreEscuela.Entidades;
using coreEscuela.Util;
using static System.Console;
namespace coreEscuela
{
  class Program
  {
    static void Main(string[] args)
    {
      
      var engine= new EscuelaEngine();
      Printer.W_Titulo("Cursos escuela");
      engine.Inicializar();
      
      
      
      
    }




    private static void ImprimircursosEscuela(Escuela escuela)
    {
     
      if (escuela?.Cursos != null)
      {
        foreach (var curso in escuela.Cursos)
        {
          WriteLine($"Nombre: {curso.Nombre}| IdCurso: {curso.UniqueId }");
        }
      }
      else { return; }
    }

    private static void Imprimircursos(Curso[] arregloCursos)
    {
      for (int i = 0; i < arregloCursos.Length; i++)
      {
        WriteLine($"{arregloCursos[i].Nombre} , {arregloCursos[i].UniqueId }");
      }
    }
  }
}
