using System;

namespace Prototipo08
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el administrador
            CAdminPrototipos admin = new CAdminPrototipos();

            //Obtenemos dos instancias
            CPersona uno = (CPersona)admin.ObtenPrototipos("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipos("Persona");

            //verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------");
        }
    }
}
