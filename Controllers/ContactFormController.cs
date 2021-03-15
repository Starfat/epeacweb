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
    public class ContactFormsController : Controller
    {
        private readonly IContactFormRepository _repo;
        private readonly IMapper _mapper;

        public ContactFormsController(IContactFormRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: ContactForms
        public ActionResult Index()
        {
            var ContactForms = _repo.FindAll().ToList();
            var model = _mapper.Map<List<ContactForm>, List<ContactFormViewModel>>(ContactForms);
            return View(model);
        }

        // GET: ContactForms/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var ContactForm = _repo.FindById(id);
            var model = _mapper.Map<ContactFormViewModel>(ContactForm);
            return View(model);
        }

        // GET: ContactForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactForms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactFormViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var ContactForm = _mapper.Map<ContactForm>(model);
                var isSuccess = _repo.Create(ContactForm);
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

        // GET: ContactForms/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var ContactForm = _repo.FindById(id);
            var model = _mapper.Map<ContactFormViewModel>(ContactForm);
            return View(model);
        }

        // POST: ContactForms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContactForm model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var ContactForm = _mapper.Map<ContactForm>(model);
                var isSuccess = _repo.Update(ContactForm);
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

        // GET: ContactForms/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var ContactForm = _repo.FindById(id);
            if (ContactForm == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(ContactForm);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: ContactForms/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ContactFormViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var ContactForm = _repo.FindById(id);
                if (ContactForm == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(ContactForm);
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