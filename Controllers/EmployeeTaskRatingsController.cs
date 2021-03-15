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
    public class EmployeeTaskRatingsController : Controller
    {
        private readonly IEmployeeTaskRatingRepository _repo;
        private readonly IMapper _mapper;

        public EmployeeTaskRatingsController(IEmployeeTaskRatingRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: EmployeeTaskRatings
        public ActionResult Index()
        {
            var EmployeeTaskRatings = _repo.FindAll().ToList();
            var model = _mapper.Map<List<EmployeeTaskRating>, List<EmployeeTaskRatingViewModel>>(EmployeeTaskRatings);
            return View(model);
        }

        // GET: EmployeeTaskRatings/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var EmployeeTaskRating = _repo.FindById(id);
            var model = _mapper.Map<EmployeeTaskRatingViewModel>(EmployeeTaskRating);
            return View(model);
        }

        // GET: EmployeeTaskRatings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTaskRatings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeTaskRatingViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var EmployeeTaskRating = _mapper.Map<EmployeeTaskRating>(model);
                var isSuccess = _repo.Create(EmployeeTaskRating);
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

        // GET: EmployeeTaskRatings/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var EmployeeTaskRating = _repo.FindById(id);
            var model = _mapper.Map<EmployeeTaskRatingViewModel>(EmployeeTaskRating);
            return View(model);
        }

        // POST: EmployeeTaskRatings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeTaskRating model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var EmployeeTaskRating = _mapper.Map<EmployeeTaskRating>(model);
                var isSuccess = _repo.Update(EmployeeTaskRating);
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

        // GET: EmployeeTaskRatings/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var EmployeeTaskRating = _repo.FindById(id);
            if (EmployeeTaskRating == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(EmployeeTaskRating);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: EmployeeTaskRatings/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeTaskRatingViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var EmployeeTaskRating = _repo.FindById(id);
                if (EmployeeTaskRating == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(EmployeeTaskRating);
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