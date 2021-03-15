using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using epeacweb.Contracts;
using epeacweb.Data;
using epeacweb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace epeacweb.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskRepository _repo;
        private readonly IMapper _mapper;

        public TasksController(ITaskRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Tasks
        public ActionResult Index()
        {
            var tasks = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Task>, List<TaskViewModel>>(tasks);
            return View(model);
        }

        // GET: Tasks/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var faq = _repo.FindById(id);
            var model = _mapper.Map<TaskViewModel>(faq);
            return View(model);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                var task = _mapper.Map<Task>(model);
                var isSuccess = _repo.Create(task);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong!");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int id)
        {
            {
                if (!_repo.isExists(id))
                {
                    return NotFound();
                }
                var faq = _repo.FindById(id);
                var model = _mapper.Map<TaskViewModel>(faq);
                return View(model);
            }
        }

        // POST: Tasks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Faq model)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var task = _mapper.Map<Task>(model);
                var isSuccess = _repo.Update(task);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong!");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something Went Wrong!");
                return View(model);
            }
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var task = _repo.FindById(id);
            if (task == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(task);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Faqs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var task = _repo.FindById(id);
                if (task == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(task);
                if (!isSuccess)
                {
                    return View(model);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}