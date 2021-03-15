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
    public class PunctualityPhrasesController : Controller
    {
        private readonly IPunctualityPhraseRepository _repo;
        private readonly IMapper _mapper;

        public PunctualityPhrasesController(IPunctualityPhraseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: PunctualityPhrases
        public ActionResult Index()
        {
            var PunctualityPhrases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<PunctualityPhrase>, List<PunctualityPhraseViewModel>>(PunctualityPhrases);
            return View(model);
        }

        // GET: PunctualityPhrases/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var PunctualityPhrase = _repo.FindById(id);
            var model = _mapper.Map<PunctualityPhraseViewModel>(PunctualityPhrase);
            return View(model);
        }

        // GET: PunctualityPhrases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PunctualityPhrases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PunctualityPhraseViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var PunctualityPhrase = _mapper.Map<PunctualityPhrase>(model);
                var isSuccess = _repo.Create(PunctualityPhrase);
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

        // GET: PunctualityPhrases/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var PunctualityPhrase = _repo.FindById(id);
            var model = _mapper.Map<PunctualityPhraseViewModel>(PunctualityPhrase);
            return View(model);
        }

        // POST: PunctualityPhrases/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PunctualityPhrase model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var PunctualityPhrase = _mapper.Map<PunctualityPhrase>(model);
                var isSuccess = _repo.Update(PunctualityPhrase);
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

        // GET: PunctualityPhrases/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var PunctualityPhrase = _repo.FindById(id);
            if (PunctualityPhrase == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(PunctualityPhrase);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: PunctualityPhrases/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PunctualityPhraseViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var PunctualityPhrase = _repo.FindById(id);
                if (PunctualityPhrase == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(PunctualityPhrase);
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