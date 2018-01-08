using AutoMapper;
using ProjetoEstoqueDDD.Domain.Entidades;
using ProjetoEstoqueDDD.Infra.Data.Repositorios;
using ProjetoEstoqueDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEstoqueDDD.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();
        private readonly EstoqueRepositorio _estoqueRepositorio = new EstoqueRepositorio();
        // GET: Produto
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepositorio.GetAll());
            foreach (var datapro in produtoViewModel)
            {
                datapro.Quantidade = _estoqueRepositorio.QuantidadeEstoque(datapro.ProdutoId);
            }

            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
