using AutoMapper;
using CrudDDD.MVC.ViewModels;
using ProjectDDD.Application.Interface;
using ProjectDDD.Domain.Entities;
using ProjectDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDDD.MVC.Controllers {
    public class FisicPersonController : Controller {
        private readonly IFisicPersonAppService _fisicPersonAppService;
        private ProjectDDDContext db = new ProjectDDDContext();

        public FisicPersonController(IFisicPersonAppService fisicPersonAppService) {
            _fisicPersonAppService = fisicPersonAppService;
        }

        public ActionResult Index(string busca=null) {
            var clientViewModel = Mapper.Map<IEnumerable<FisicPerson>, IEnumerable<FisicPersonViewModel>>(_fisicPersonAppService.GetAll());
            if (busca != null) {
                clientViewModel.Where(p => p.Name.ToUpper().Contains(busca.ToUpper())).ToList();
                return View(clientViewModel.Where(p => p.Name.ToUpper().Contains(busca.ToUpper())).ToList());
            }
            return View(clientViewModel);
        }

       /* public ActionResult SearchByName(string name) {
            var clientViewModel = Mapper.Map<IEnumerable<FisicPerson>, IEnumerable<FisicPersonViewModel>>(_fisicPersonAppService.SearchByName(name));

            return View(clientViewModel);
        }*/

        public ActionResult Details(int id) {
            var client = _fisicPersonAppService.GetById(id);
            var clientViewModel = Mapper.Map<FisicPerson, FisicPersonViewModel>(client);

            return View(clientViewModel);
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FisicPersonViewModel client) {
            if (ModelState.IsValid) {
                var clientDomain = Mapper.Map<FisicPersonViewModel, FisicPerson>(client);
                _fisicPersonAppService.Add(clientDomain);
                return RedirectToAction("Index");
            }

            return View(client);
        }


        public ActionResult Edit(int id) {
            var client = _fisicPersonAppService.GetById(id);
            var clientViewModel = Mapper.Map<FisicPerson, FisicPersonViewModel>(client);

            return View(clientViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FisicPersonViewModel client) {
            if (ModelState.IsValid) {
                var clientDomain = Mapper.Map<FisicPersonViewModel, FisicPerson>(client);
                _fisicPersonAppService.Update(clientDomain);

                return RedirectToAction("Index");
            }

            return View(client);
        }

        public ActionResult Delete(int id) {
            var client = _fisicPersonAppService.GetById(id);
            var clientViewModel = Mapper.Map<FisicPerson, FisicPersonViewModel>(client);

            return View(clientViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            var client = _fisicPersonAppService.GetById(id);
            _fisicPersonAppService.Remove(client);

            return RedirectToAction("Index");
        }
    }
}

