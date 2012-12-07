using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoDemo.Models;
using TodoDemo.Models.Data;

namespace TodoDemo.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaController()
        {
            _tarefaRepository = new TarefaRepository();
        }

        //
        // GET: /Tarefa/

        public ActionResult Index()
        {
            return View(_tarefaRepository.Todas());
        }

        public ActionResult ListaTarefas()
        {
            return PartialView("_ListaTarefas", _tarefaRepository.Todas());
        }

        //
        // GET: /Tarefa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tarefa/Create

        [HttpPost]
        public ActionResult Create(Tarefa tarefa)
        {
            try
            {
                _tarefaRepository.Salvar(tarefa);

                if (Request.IsAjaxRequest())
                    return Json(tarefa);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Tarefa/Delete/5

        public ActionResult Delete(int id)
        {
            return View(_tarefaRepository.GetById(id));
        }

        //
        // POST: /Tarefa/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult RemoverTarefa(int id)
        {
            try
            {
                System.Threading.Thread.Sleep(3000);
                _tarefaRepository.Delete(id);
                if (Request.IsAjaxRequest())
                    return Json(true);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
