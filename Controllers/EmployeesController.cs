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
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Employees
        public ActionResult Index()
        {
            var Employees = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Employee>, List<EmployeeViewModel>>(Employees);
            return View(model);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var Employee = _repo.FindById(id);
            var model = _mapper.Map<EmployeeViewModel>(Employee);
            return View(model);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Employee = _mapper.Map<Employee>(model);
                var isSuccess = _repo.Create(Employee);
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

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var Employee = _repo.FindById(id);
            var model = _mapper.Map<EmployeeViewModel>(Employee);
            return View(model);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Employee = _mapper.Map<Employee>(model);
                var isSuccess = _repo.Update(Employee);
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

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var Employee = _repo.FindById(id);
            if (Employee == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(Employee);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var Employee = _repo.FindById(id);
                if (Employee == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(Employee);
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