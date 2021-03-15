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
    public class ProjectManagersController : Controller
    {
        private readonly IProjectManagerRepository _repo;
        private readonly IMapper _mapper;

        public ProjectManagersController(IProjectManagerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: ProjectManagers
        public ActionResult Index()
        {
            var ProjectManagers = _repo.FindAll().ToList();
            var model = _mapper.Map<List<ProjectManager>, List<ProjectManagerViewModel>>(ProjectManagers);
            return View(model);
        }

        // GET: ProjectManagers/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var ProjectManager = _repo.FindById(id);
            var model = _mapper.Map<ProjectManagerViewModel>(ProjectManager);
            return View(model);
        }

        // GET: ProjectManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectManagers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectManagerViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var ProjectManager = _mapper.Map<ProjectManager>(model);
                var isSuccess = _repo.Create(ProjectManager);
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

        // GET: ProjectManagers/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var ProjectManager = _repo.FindById(id);
            var model = _mapper.Map<ProjectManagerViewModel>(ProjectManager);
            return View(model);
        }

        // POST: ProjectManagers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjectManager model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var ProjectManager = _mapper.Map<ProjectManager>(model);
                var isSuccess = _repo.Update(ProjectManager);
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

        // GET: ProjectManagers/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var ProjectManager = _repo.FindById(id);
            if (ProjectManager == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(ProjectManager);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: ProjectManagers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProjectManagerViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var ProjectManager = _repo.FindById(id);
                if (ProjectManager == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(ProjectManager);
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