using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoNorte.Models
{
    public class Formulario1
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _sexo;

        public string Sexo //true -> hombre
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        private Boolean _ofertas;

        public Boolean Ofertas
        {
            get { return _ofertas; }
            set { _ofertas = value; }
        }

        private Boolean _condiciones;

        public Boolean Condiciones
        {
            get { return _condiciones; }
            set { _condiciones = value; }
        }

    }
}