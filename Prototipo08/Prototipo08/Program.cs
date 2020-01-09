using System;

namespace Prototipo08
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMERON=0;
            //creamos el administrador
            CAdminPrototipos admin = new CAdminPrototipos();

            //Obtenemos dos instancias
            CPersona uno = (CPersona)admin.ObtenPrototipos("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipos("Persona");

            //verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------");

            //modificamos el estado 
            uno.Nombre = "MARIANITA";
            dos.Nombre = "Dalin";

            //verificamos que cada quien tenga su estado 
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("---------");
            //HOLA

            Console.WriteLine("---------------------------------------------------------------");

            //creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            //lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //obtenemos un objeto de ese prototipo
            CAuto auto2 = (CAuto)admin.ObtenPrototipos("Auto");


            //cambiamos el estado 
            auto2.Modelo = "Honda";

            //verificamos que cada  uno tenga su estado 
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("---------");

            //obtenemos una instancia del costo
           // CValores val = (CValores)admin.ObtenPrototipos("valores");

            //Console.WriteLine(val);
        }
    }
}
