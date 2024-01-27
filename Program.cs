using System;
using ConsoleStruct;
namespace ConsoleStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point(); ///or  P.X = 10.0;, resumindo inicializar o atributo funciona
            P.X = 10.0;
            Console.WriteLine(P);
        }
    }
}
