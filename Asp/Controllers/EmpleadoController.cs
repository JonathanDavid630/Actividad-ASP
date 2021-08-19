﻿using Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
           using (EmpleadoEntities1 bd = new EmpleadoEntities1())
            {

                var ListadoEmpleado = bd.Empleado.ToList();

                return View(ListadoEmpleado);
            }
        }
    }
}
    
