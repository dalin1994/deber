using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo08
{
    class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();
        
        public CAdminPrototipos()
        {
            //Adicionamos los objetos prototipos con los valores iniciales que nos interesen

            CPersona persona = new CPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

           // CValores valores = new CValores(1);
            //prototipos.Add("Valores", valores);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }
        public object ObtenPrototipos(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
