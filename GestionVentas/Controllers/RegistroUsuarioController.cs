using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roler = GestionVentas.Models.Roles;
using GestionVentas.Models;
namespace GestionVentas.Controllers
{
    public class RegistroUsuarioController : Controller
    {
        //Instanciar Conexion De BD

        GestionBDVentaEntities conexion = new GestionBDVentaEntities();
        
        //metodo GET para la vista registro

        public ActionResult Registro()
        {
            if (!conexion.Roles.Any())
            {
                var roles = new List<Roles>
                {
                    new Roles {Nombre = "Administrador"},
                    new Roles {Nombre = "Usuario"}
                };
                //Agregar los Roles a la BD y Guardo los cambios
                conexion.Roles.AddRange(roles);
                conexion.SaveChanges();
            }
            var roleslist = conexion.Roles.ToList();
            //Convertir la lista de roles en un selectList (dropDowsList)
            ViewBag.Roles = new SelectList(roleslist, "rolID", "Nombre");
            return View();
        }
    }
}