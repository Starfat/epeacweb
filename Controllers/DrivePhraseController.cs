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
    public class DrivePhrasesController : Controller
    {
        private readonly IDrivePhraseRepository _repo;
        private readonly IMapper _mapper;

        public DrivePhrasesController(IDrivePhraseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: DrivePhrases
        public ActionResult Index()
        {
            var DrivePhrases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<DrivePhrase>, List<DrivePhraseViewModel>>(DrivePhrases);
            return View(model);
        }

        // GET: DrivePhrases/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var DrivePhrase = _repo.FindById(id);
            var model = _mapper.Map<DrivePhraseViewModel>(DrivePhrase);
            return View(model);
        }

        // GET: DrivePhrases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrivePhrases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DrivePhraseViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var DrivePhrase = _mapper.Map<DrivePhrase>(model);
                var isSuccess = _repo.Create(DrivePhrase);
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

        // GET: DrivePhrases/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var DrivePhrase = _repo.FindById(id);
            var model = _mapper.Map<DrivePhraseViewModel>(DrivePhrase);
            return View(model);
        }

        // POST: DrivePhrases/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DrivePhrase model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var DrivePhrase = _mapper.Map<DrivePhrase>(model);
                var isSuccess = _repo.Update(DrivePhrase);
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

        // GET: DrivePhrases/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var DrivePhrase = _repo.FindById(id);
            if (DrivePhrase == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(DrivePhrase);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: DrivePhrases/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, DrivePhraseViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var DrivePhrase = _repo.FindById(id);
                if (DrivePhrase == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(DrivePhrase);
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