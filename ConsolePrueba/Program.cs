using ConsolePrueba.persistencia;
using System;

namespace ConsolePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Vamos a instanciar un objeto de la clase Class1
            Class1 objeto = new Class1();

            //Vamos a instanciar un objeto de otro paquete
            Class2 obj2 = new Class2();
            Console.ReadKey();
        }
    }
}
