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
    public class CommunicationPhrasesController : Controller
    {
        private readonly ICommunicationPhraseRepository _repo;
        private readonly IMapper _mapper;

        public CommunicationPhrasesController(ICommunicationPhraseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: CommunicationPhrases
        public ActionResult Index()
        {
            var CommunicationPhrases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<CommunicationPhrase>, List<CommunicationPhraseViewModel>>(CommunicationPhrases);
            return View(model);
        }

        // GET: CommunicationPhrases/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var CommunicationPhrase = _repo.FindById(id);
            var model = _mapper.Map<CommunicationPhraseViewModel>(CommunicationPhrase);
            return View(model);
        }

        // GET: CommunicationPhrases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommunicationPhrases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CommunicationPhraseViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var CommunicationPhrase = _mapper.Map<CommunicationPhrase>(model);
                var isSuccess = _repo.Create(CommunicationPhrase);
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

        // GET: CommunicationPhrases/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var CommunicationPhrase = _repo.FindById(id);
            var model = _mapper.Map<CommunicationPhraseViewModel>(CommunicationPhrase);
            return View(model);
        }

        // POST: CommunicationPhrases/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CommunicationPhrase model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var CommunicationPhrase = _mapper.Map<CommunicationPhrase>(model);
                var isSuccess = _repo.Update(CommunicationPhrase);
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

        // GET: CommunicationPhrases/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var CommunicationPhrase = _repo.FindById(id);
            if (CommunicationPhrase == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(CommunicationPhrase);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: CommunicationPhrases/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CommunicationPhraseViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var CommunicationPhrase = _repo.FindById(id);
                if (CommunicationPhrase == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(CommunicationPhrase);
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