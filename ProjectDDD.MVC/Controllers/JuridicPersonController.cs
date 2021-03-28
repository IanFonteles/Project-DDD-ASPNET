using AutoMapper;
using CrudDDD.MVC.ViewModels;
using ProjectDDD.Application.Interface;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDDD.MVC.Controllers {
    public class JuridicPersonController : Controller {
        private readonly IJuridicPersonAppService _juridicPersonAppService;

        public JuridicPersonController(IJuridicPersonAppService juridicPersonAppService) {
            _juridicPersonAppService = juridicPersonAppService;
        }

        // GET: Clients
        public ActionResult Index(string busca = null) {
            var clientViewModel = Mapper.Map<IEnumerable<JuridicPerson>, IEnumerable<JuridicPersonViewModel>>(_juridicPersonAppService.GetAll());
            if (busca != null) {
                clientViewModel.Where(p => p.Name.ToUpper().Contains(busca.ToUpper())).ToList();
                return View(clientViewModel.Where(p => p.Name.ToUpper().Contains(busca.ToUpper())).ToList());
            }
            return View(clientViewModel);
        }

        /*public ActionResult SearchByName(String name) {
            var clientViewModel = Mapper.Map<IEnumerable<JuridicPerson>, IEnumerable<JuridicPersonViewModel>>(_juridicPersonAppService.SearchByName(name));

            return View(clientViewModel);
        }*/

        // GET: Clients/Details/5
        public ActionResult Details(int id) {
            var client = _juridicPersonAppService.GetById(id);
            var clientViewModel = Mapper.Map<JuridicPerson, JuridicPersonViewModel>(client);

            return View(clientViewModel);
        }

        // GET: Clients/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JuridicPersonViewModel client) {
            if (ModelState.IsValid) {
                var clientDomain = Mapper.Map<JuridicPersonViewModel, JuridicPerson>(client);
                _juridicPersonAppService.Add(clientDomain);
                return RedirectToAction("Index");
            }

            return View(client);
        }


        // GET: Clients/Edit/5
        public ActionResult Edit(int id) {
            var client = _juridicPersonAppService.GetById(id);
            var clientViewModel = Mapper.Map<JuridicPerson, JuridicPersonViewModel>(client);

            return View(clientViewModel);

        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JuridicPersonViewModel client) {
            if (ModelState.IsValid) {
                var clientDomain = Mapper.Map<JuridicPersonViewModel, JuridicPerson>(client);
                _juridicPersonAppService.Update(clientDomain);

                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id) {
            var client = _juridicPersonAppService.GetById(id);
            var clientViewModel = Mapper.Map<JuridicPerson, JuridicPersonViewModel>(client);

            return View(clientViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            var client = _juridicPersonAppService.GetById(id);
            _juridicPersonAppService.Remove(client);

            return RedirectToAction("Index");
        }
    }
}

