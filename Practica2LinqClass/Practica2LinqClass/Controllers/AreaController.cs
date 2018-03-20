using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica2LinqClass.Models;

namespace Practica2LinqClass.Controllers
{
    public class AreaController : Controller
    {
        // GET: Area
        areaModels models = new areaModels();

        public ActionResult Index()
        {
            return View(models.listaAreas());
        }

        public ActionResult buscarArea(int id)
        {
            var area = models.buscarArea(id);
            return View(area);
        }

        //este hace la peticion get 
        //muestra interfaz para crear cargo
        public ActionResult crear()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult crear(area a)
        {
            try
            {
                if (models.insertarArea(Convert.ToString(a)).Equals("ok"))
                {
                    return RedirectToAction("Index");
                }
                {
                    return RedirectToAction("Create");
                }
            }
            catch (Exception e)
            {
                return View();
            }

        }
        //este hace la peticion get 
        //muestra interfaz para editar cargo
        public ActionResult editarArea(int id)
        {
            var area = models.buscarArea(id);
            return View(area );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult creditarAreaear(int condArea,area a)
        {
            try
            {
                if (models.insertarArea(Convert.ToString(a)).Equals("ok"))
                {
                    return RedirectToAction("Index");
                }
                {
                    return RedirectToAction("Create");
                }
            }
            catch (Exception e)
            {
                return View();
            }

        }
    }
}