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
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentRepository _repo;
        private readonly IMapper _mapper;

        public DepartmentsController(IDepartmentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Departments
        public ActionResult Index()
        {
            var departments = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Department>, List<DepartmentViewModel>>(departments);
            return View(model);
        }

        // GET: Departments/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var department = _repo.FindById(id);
            var model = _mapper.Map<DepartmentViewModel>(department);
            return View(model);
        }

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Department = _mapper.Map<Department>(model);
                var isSuccess = _repo.Create(Department);
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

        // GET: Departments/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var Department = _repo.FindById(id);
            var model = _mapper.Map<DepartmentViewModel>(Department);
            return View(model);
        }

        // POST: Departments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Department = _mapper.Map<Department>(model);
                var isSuccess = _repo.Update(Department);
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

        // GET: Departments/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var Department = _repo.FindById(id);
            if (Department == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(Department);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Departments/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, DepartmentViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var Department = _repo.FindById(id);
                if (Department == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(Department);
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