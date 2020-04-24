using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoNorte.Models
{
    public class Dominio
    {
        private static List<Formulario1> formulario1s = new List<Formulario1>();

        public static void add(Formulario1 f1)
        {
            formulario1s.Add(f1);
        }

        public static List<Formulario1> Get()
        {
            return formulario1s;
        }
    }
}