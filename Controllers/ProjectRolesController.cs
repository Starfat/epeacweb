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
    public class ProjectRolesController : Controller
    {
        private readonly IProjectRoleRepository _repo;
        private readonly IMapper _mapper;

        public ProjectRolesController(IProjectRoleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: ProjectRoles
        public ActionResult Index()
        {
            var ProjectRoles = _repo.FindAll().ToList();
            var model = _mapper.Map<List<ProjectRole>, List<ProjectRoleViewModel>>(ProjectRoles);
            return View(model);
        }

        // GET: ProjectRoles/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var ProjectRole = _repo.FindById(id);
            var model = _mapper.Map<ProjectRoleViewModel>(ProjectRole);
            return View(model);
        }

        // GET: ProjectRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectRoles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectRoleViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var ProjectRole = _mapper.Map<ProjectRole>(model);
                var isSuccess = _repo.Create(ProjectRole);
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

        // GET: ProjectRoles/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var ProjectRole = _repo.FindById(id);
            var model = _mapper.Map<ProjectRoleViewModel>(ProjectRole);
            return View(model);
        }

        // POST: ProjectRoles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjectRole model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var ProjectRole = _mapper.Map<ProjectRole>(model);
                var isSuccess = _repo.Update(ProjectRole);
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

        // GET: ProjectRoles/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var ProjectRole = _repo.FindById(id);
            if (ProjectRole == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(ProjectRole);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: ProjectRoles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProjectRoleViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var ProjectRole = _repo.FindById(id);
                if (ProjectRole == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(ProjectRole);
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