using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoNorte.Models;

namespace DemoNorte.Controllers
{
    public class Formularios1Controller : Controller
    {
        // GET: Formularios1
        public ActionResult Ejercicio8()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ejercicio8(FormCollection form)
        {
            Formulario1 formulario1 = new Formulario1();
            formulario1.Nombre = form.AllKeys.Contains("nombre") ? form["nombre"] : null;
            formulario1.Apellido = form.AllKeys.Contains("apellido") ? form["apellido"] : null;
            formulario1.Sexo = form.AllKeys.Contains("sexo") ? form["sexo"] : null;
            formulario1.Correo = form.AllKeys.Contains("correo") ? form["correo"] : null;
            formulario1.Ofertas = form.AllKeys.Contains("ofertas") ? true : false;
            formulario1.Condiciones = form.AllKeys.Contains("condiciones") ? true : false;
            Dominio.add(formulario1);
            return RedirectToAction("Index", "Home");
        }
    }
}