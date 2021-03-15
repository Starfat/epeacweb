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
    public class FaqsController : Controller
    {
        private readonly IFaqRepository _repo;
        private readonly IMapper _mapper;

        public FaqsController(IFaqRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: Faqs
        public ActionResult Index()
        {
            var faqs = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Faq>, List<FaqViewModel>>(faqs);
            return View(model);
        }

        // GET: Faqs/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var faq = _repo.FindById(id);
            var model = _mapper.Map<FaqViewModel>(faq);
            return View(model);
        }

        // GET: Faqs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faqs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FaqViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var faq = _mapper.Map<Faq>(model);
                var isSuccess = _repo.Create(faq);
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

        // GET: Faqs/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var faq = _repo.FindById(id);
            var model = _mapper.Map<FaqViewModel>(faq);
            return View(model);
        }

        // POST: Faqs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Faq model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var faq = _mapper.Map<Faq>(model);
                var isSuccess = _repo.Update(faq);
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

        // GET: Faqs/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var faq = _repo.FindById(id);
            if (faq == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(faq);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Faqs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FaqViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var faq = _repo.FindById(id);
                if (faq == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(faq);
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