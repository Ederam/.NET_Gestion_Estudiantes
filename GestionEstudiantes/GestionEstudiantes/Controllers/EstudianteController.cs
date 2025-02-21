using GestionEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEstudiantes.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.ESTUDIANTES.ToList());
            }
            
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.ESTUDIANTES.Where(x => x.ID_ESTUDIANTE == id ));
            }
            
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        public ActionResult Create(ESTUDIANTES estudaintes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.ESTUDIANTES.Add(estudaintes);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.ESTUDIANTES.Where(x => x.ID_ESTUDIANTE == id).FirstOrDefault());
            }
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ESTUDIANTES estudiantes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(estudiantes).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.ESTUDIANTES.Where(x => x.ID_ESTUDIANTE == id).FirstOrDefault());
            }
        }

        // POST: Estudiante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    ESTUDIANTES estudiante = context.ESTUDIANTES.Where(x=>x.ID_ESTUDIANTE==id).FirstOrDefault();
                    context.ESTUDIANTES.Remove(estudiante);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
