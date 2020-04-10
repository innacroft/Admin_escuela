using static System.Console;

namespace coreEscuela.Util
{
    public static class Printer
    {
        public static void W_Linea(int tamaño= 10)
        {
         WriteLine("".PadLeft(tamaño,'*'));
          
        }

        public static void W_Titulo(string titulo)
        {
        var tam= titulo.Length+4;
         W_Linea(tam);   
         WriteLine($"| {titulo} |");
         W_Linea(tam);
        }
    }
}