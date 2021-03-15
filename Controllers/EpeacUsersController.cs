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
    public class EpeacUsersController : Controller
    {
        private readonly IEpeacUserRepository _repo;
        private readonly IMapper _mapper;

        public EpeacUsersController(IEpeacUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: EpeacUsers
        public ActionResult Index()
        {
            var EpeacUsers = _repo.FindAll().ToList();
            var model = _mapper.Map<List<EpeacUser>, List<EpeacUserViewModel>>(EpeacUsers);
            return View(model);
        }

        // GET: EpeacUsers/Details/5
        public ActionResult Details(int id)
        {
            if(!_repo.isExists(id))
            {
                return NotFound();
            }
            var EpeacUser = _repo.FindById(id);
            var model = _mapper.Map<EpeacUserViewModel>(EpeacUser);
            return View(model);
        }

        // GET: EpeacUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EpeacUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EpeacUserViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var EpeacUser = _mapper.Map<EpeacUser>(model);
                var isSuccess = _repo.Create(EpeacUser);
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

        // GET: EpeacUsers/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var EpeacUser = _repo.FindById(id);
            var model = _mapper.Map<EpeacUserViewModel>(EpeacUser);
            return View(model);
        }

        // POST: EpeacUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EpeacUser model) 
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var EpeacUser = _mapper.Map<EpeacUser>(model);
                var isSuccess = _repo.Update(EpeacUser);
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

        // GET: EpeacUsers/Delete/5
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            var EpeacUser = _repo.FindById(id);
            if (EpeacUser == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(EpeacUser);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: EpeacUsers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EpeacUserViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var EpeacUser = _repo.FindById(id);
                if (EpeacUser == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(EpeacUser);
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