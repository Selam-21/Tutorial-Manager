using Microsoft.AspNetCore.Mvc;
using Tutorial_Manager.Models;
using Tutorial_Manager.Models.services;

namespace Tutorial_Manager.Controllers
{
    public class CommentController : Controller
    {
        private readonly ISubjectService _service;
        public CommentController(ISubjectService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
        public IActionResult Details(long id)
        {
            var data = _service.GetById(id);
            return View(data);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            _service.Add(subject);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(long id)
        {
            var data = _service.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Subject subject)
        {
            _service.Update(subject);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(long id)
        {
            var data = _service.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
