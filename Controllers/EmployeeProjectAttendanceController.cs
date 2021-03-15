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
    public class EmployeeProjectAttendancesController : Controller
    {
        private readonly IEmployeeProjectAttendanceRepository _repo;
        private readonly IMapper _mapper;

        public EmployeeProjectAttendancesController(IEmployeeProjectAttendanceRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: EmployeeProjectAttendances
        public ActionResult Index()
        {
            var EmployeeProjectAttendances = _repo.FindAll().ToList();
            var model = _mapper.Map<List<EmployeeProjectAttendance>, List<EmployeeProjectAttendanceViewModel>>(EmployeeProjectAttendances);
            return View(model);
        }

        // GET: EmployeeProjectAttendances/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var EmployeeProjectAttendance = _repo.FindById(id);
            var model = _mapper.Map<EmployeeProjectAttendanceViewModel>(EmployeeProjectAttendance);
            return View(model);
        }

        // GET: EmployeeProjectAttendances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeProjectAttendances/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeProjectAttendanceViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var EmployeeProjectAttendance = _mapper.Map<EmployeeProjectAttendance>(model);
                var isSuccess = _repo.Create(EmployeeProjectAttendance);
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

        // GET: EmployeeProjectAttendances/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var EmployeeProjectAttendance = _repo.FindById(id);
            var model = _mapper.Map<EmployeeProjectAttendanceViewModel>(EmployeeProjectAttendance);
            return View(model);
        }

        // POST: EmployeeProjectAttendances/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeProjectAttendance model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var EmployeeProjectAttendance = _mapper.Map<EmployeeProjectAttendance>(model);
                var isSuccess = _repo.Update(EmployeeProjectAttendance);
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

        // GET: EmployeeProjectAttendances/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var EmployeeProjectAttendance = _repo.FindById(id);
            if (EmployeeProjectAttendance == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(EmployeeProjectAttendance);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: EmployeeProjectAttendances/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeProjectAttendanceViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var EmployeeProjectAttendance = _repo.FindById(id);
                if (EmployeeProjectAttendance == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(EmployeeProjectAttendance);
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