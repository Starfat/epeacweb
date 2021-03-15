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
    public class DepartmentManagersController : Controller
    {
        private readonly IDepartmentManagerRepository _repo;
        private readonly IMapper _mapper;

        public DepartmentManagersController(IDepartmentManagerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: DepartmentManagers
        public ActionResult Index()
        {
            var DepartmentManagers = _repo.FindAll().ToList();
            var model = _mapper.Map<List<DepartmentManager>, List<DepartmentManagerViewModel>>(DepartmentManagers);
            return View(model);
        }

        // GET: DepartmentManagers/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var DepartmentManager = _repo.FindById(id);
            var model = _mapper.Map<DepartmentManagerViewModel>(DepartmentManager);
            return View(model);
        }

        // GET: DepartmentManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentManagers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentManagerViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var DepartmentManager = _mapper.Map<DepartmentManager>(model);
                var isSuccess = _repo.Create(DepartmentManager);
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

        // GET: DepartmentManagers/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var DepartmentManager = _repo.FindById(id);
            var model = _mapper.Map<DepartmentManagerViewModel>(DepartmentManager);
            return View(model);
        }

        // POST: DepartmentManagers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentManager model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var DepartmentManager = _mapper.Map<DepartmentManager>(model);
                var isSuccess = _repo.Update(DepartmentManager);
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

        // GET: DepartmentManagers/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var DepartmentManager = _repo.FindById(id);
            if (DepartmentManager == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(DepartmentManager);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: DepartmentManagers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, DepartmentManagerViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var DepartmentManager = _repo.FindById(id);
                if (DepartmentManager == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(DepartmentManager);
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