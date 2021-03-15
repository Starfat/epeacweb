using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using epeacweb.Contracts;
using epeacweb.Data;
using epeacweb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace epeacweb.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectRepository _repo;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Projects
        public ActionResult Index()
        {
            var Projects = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Project>, List<ProjectViewModel>>(Projects);
            return View(model);
        }

        // GET: Projects/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var Project = _repo.FindById(id);
            var model = _mapper.Map<ProjectViewModel>(Project);
            return View(model);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Project = _mapper.Map<Project>(model);
                var isSuccess = _repo.Create(Project);
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

        // GET: Projects/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var Project = _repo.FindById(id);
            var model = _mapper.Map<ProjectViewModel>(Project);
            return View(model);
        }

        // POST: Projects/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Project model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Project = _mapper.Map<Project>(model);
                var isSuccess = _repo.Update(Project);
                if(!isSuccess)
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

        // GET: Projects/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var Project = _repo.FindById(id);
            if (Project == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(Project);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Projects/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProjectViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var Project = _repo.FindById(id);
                if (Project == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(Project);
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