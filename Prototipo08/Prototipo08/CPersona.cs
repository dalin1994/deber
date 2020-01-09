using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo08
{
    class CPersona:IPrototipo
    {
        //datos
        private string nombre;
        private int edad;

        //priedadad
        public string Nombre { get=>nombre; set=>nombre=value; }
        
        //datos internos (constructor)
        public CPersona(string pNombre, int pEdad)//parametros
        {
            nombre = pNombre;
            edad = pEdad;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre,edad);
        }
         //clonacion
        public object Clonar()
        {
            CPersona clon = new CPersona(nombre, edad);
            
            return clon;
        

        }
    }
}
