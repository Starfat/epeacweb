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
    public class CooperationPhrasesController : Controller
    {
        private readonly ICooperationPhraseRepository _repo;
        private readonly IMapper _mapper;

        public CooperationPhrasesController(ICooperationPhraseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: CooperationPhrases
        public ActionResult Index()
        {
            var CooperationPhrases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<CooperationPhrase>, List<CooperationPhraseViewModel>>(CooperationPhrases);
            return View(model);
        }

        // GET: CooperationPhrases/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var CooperationPhrase = _repo.FindById(id);
            var model = _mapper.Map<CooperationPhraseViewModel>(CooperationPhrase);
            return View(model);
        }

        // GET: CooperationPhrases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CooperationPhrases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CooperationPhraseViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var CooperationPhrase = _mapper.Map<CooperationPhrase>(model);
                var isSuccess = _repo.Create(CooperationPhrase);
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

        // GET: CooperationPhrases/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var CooperationPhrase = _repo.FindById(id);
            var model = _mapper.Map<CooperationPhraseViewModel>(CooperationPhrase);
            return View(model);
        }

        // POST: CooperationPhrases/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CooperationPhrase model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var CooperationPhrase = _mapper.Map<CooperationPhrase>(model);
                var isSuccess = _repo.Update(CooperationPhrase);
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

        // GET: CooperationPhrases/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var CooperationPhrase = _repo.FindById(id);
            if (CooperationPhrase == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(CooperationPhrase);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: CooperationPhrases/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CooperationPhraseViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var CooperationPhrase = _repo.FindById(id);
                if (CooperationPhrase == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(CooperationPhrase);
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