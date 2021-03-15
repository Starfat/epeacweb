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
    public class MilestonesController : Controller
    {
        private readonly IMilestoneRepository _repo;
        private readonly IMapper _mapper;

        public MilestonesController(IMilestoneRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Milestones
        public ActionResult Index()
        {
            var Milestones = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Milestone>, List<MilestoneViewModel>>(Milestones);
            return View(model);
        }

        // GET: Milestones/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var Milestone = _repo.FindById(id);
            var model = _mapper.Map<MilestoneViewModel>(Milestone);
            return View(model);
        }

        // GET: Milestones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Milestones/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MilestoneViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Milestone = _mapper.Map<Milestone>(model);
                var isSuccess = _repo.Create(Milestone);
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

        // GET: Milestones/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var Milestone = _repo.FindById(id);
            var model = _mapper.Map<MilestoneViewModel>(Milestone);
            return View(model);
        }

        // POST: Milestones/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Milestone model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Milestone = _mapper.Map<Milestone>(model);
                var isSuccess = _repo.Update(Milestone);
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

        // GET: Milestones/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var Milestone = _repo.FindById(id);
            if (Milestone == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(Milestone);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Milestones/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MilestoneViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var Milestone = _repo.FindById(id);
                if (Milestone == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(Milestone);
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