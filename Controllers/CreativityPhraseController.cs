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
    public class CreativityPhrasesController : Controller
    {
        private readonly ICreativityPhraseRepository _repo;
        private readonly IMapper _mapper;

        public CreativityPhrasesController(ICreativityPhraseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: CreativityPhrases
        public ActionResult Index()
        {
            var CreativityPhrases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<CreativityPhrase>, List<CreativityPhraseViewModel>>(CreativityPhrases);
            return View(model);
        }

        // GET: CreativityPhrases/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var CreativityPhrase = _repo.FindById(id);
            var model = _mapper.Map<CreativityPhraseViewModel>(CreativityPhrase);
            return View(model);
        }

        // GET: CreativityPhrases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreativityPhrases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreativityPhraseViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var CreativityPhrase = _mapper.Map<CreativityPhrase>(model);
                var isSuccess = _repo.Create(CreativityPhrase);
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

        // GET: CreativityPhrases/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var CreativityPhrase = _repo.FindById(id);
            var model = _mapper.Map<CreativityPhraseViewModel>(CreativityPhrase);
            return View(model);
        }

        // POST: CreativityPhrases/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreativityPhrase model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var CreativityPhrase = _mapper.Map<CreativityPhrase>(model);
                var isSuccess = _repo.Update(CreativityPhrase);
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

        // GET: CreativityPhrases/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var CreativityPhrase = _repo.FindById(id);
            if (CreativityPhrase == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(CreativityPhrase);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: CreativityPhrases/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CreativityPhraseViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var CreativityPhrase = _repo.FindById(id);
                if (CreativityPhrase == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(CreativityPhrase);
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