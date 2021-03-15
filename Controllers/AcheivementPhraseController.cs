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
    public class AcheivementPhrasesController : Controller
    {
        private readonly IAcheivementPhraseRepository _repo;
        private readonly IMapper _mapper;

        public AcheivementPhrasesController(IAcheivementPhraseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: AcheivementPhrases
        public ActionResult Index()
        {
            var AcheivementPhrases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<AcheivementPhrase>, List<AcheivementPhraseViewModel>>(AcheivementPhrases);
            return View(model);
        }

        // GET: AcheivementPhrases/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var AcheivementPhrase = _repo.FindById(id);
            var model = _mapper.Map<AcheivementPhraseViewModel>(AcheivementPhrase);
            return View(model);
        }

        // GET: AcheivementPhrases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcheivementPhrases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AcheivementPhraseViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var AcheivementPhrase = _mapper.Map<AcheivementPhrase>(model);
                var isSuccess = _repo.Create(AcheivementPhrase);
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

        // GET: AcheivementPhrases/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var AcheivementPhrase = _repo.FindById(id);
            var model = _mapper.Map<AcheivementPhraseViewModel>(AcheivementPhrase);
            return View(model);
        }

        // POST: AcheivementPhrases/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AcheivementPhrase model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var AcheivementPhrase = _mapper.Map<AcheivementPhrase>(model);
                var isSuccess = _repo.Update(AcheivementPhrase);
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

        // GET: AcheivementPhrases/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var AcheivementPhrase = _repo.FindById(id);
            if (AcheivementPhrase == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(AcheivementPhrase);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: AcheivementPhrases/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AcheivementPhraseViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var AcheivementPhrase = _repo.FindById(id);
                if (AcheivementPhrase == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(AcheivementPhrase);
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