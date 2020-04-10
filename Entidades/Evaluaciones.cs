using System;
namespace coreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura{get; set;}
        public float Nota {get; set;}

        public Evaluaciones()=>UniqueId = System.Guid.NewGuid().ToString();


    }
}