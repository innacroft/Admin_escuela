using System.Collections.Generic;

namespace coreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set; }= System.Guid.NewGuid().ToString();
        string nombre;
        public string Nombre 
        { 
          get{return "Copia "+ nombre; }
          set{nombre= value.ToUpper();}
        }
        public int Añodecreacion { get; set; }
        public string Pais { get; set; }
        public string ciudad { get; set; }
        public TiposEscuela TipoEscuela{ get; set; }
        
        //public Curso[] Cursos { get; set; } //declaracion arreglo
        public List<Curso> Cursos { get; set; } //declaracion lista
        // public Escuela(string nombre,int año)
        // {
        //   this.nombre=nombre;
        //   this.Añodecreacion=año;
        // }
         public Escuela(string nombre, int año) =>(Nombre, Añodecreacion)=(nombre,año);
        // // public Escuela(string nombre, int año,TiposEscuela tipos,
        // //                  string pais="", string ciudad=" ") =>(Nombre, Añodecreacion,TipoEscuela)=(nombre,año,tipos);
         public Escuela(string nombre, int año,TiposEscuela tipos,
                          string pais="", string ciudad=" ")
                 {
                   (Nombre,Añodecreacion)=(nombre,año);
                   Pais=pais;
                   this.ciudad=ciudad;
                 
                 }
        public override string ToString(){
          return $"Nombre: {Nombre},Tipo: {TipoEscuela},\n Pais: {Pais}, Ciudad: {ciudad}";
         }
    }
  
}

