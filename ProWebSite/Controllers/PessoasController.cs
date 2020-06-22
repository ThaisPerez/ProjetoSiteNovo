using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProWebSite.Dao;
using ProWebSite.Models;

namespace ProWebSite.Controllers
{
    public class PessoasController : Controller
    {
        public ActionResult Index()
        {
            var pessoas = new PessoaDao().Buscar();
            return View(pessoas);
        }
        //Efetuar correções ViewBag incorreta
        public ActionResult Novo()
        {
            ViewBag.Pessoas = new SelectList(new PessoaDao().Buscar().ToDictionary(t => t.PessoaId, t => t.Nome), "Key", "Value");
            return View();
        }
        public ActionResult Editar(int id)
        {
            ViewBag.Pessoas = new SelectList(new PessoaDao().Buscar().ToDictionary(t => t.PessoaId, t => t.Nome), "Key", "Value");
            var pessoa = new PessoaDao().Buscar(id);
            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Editar(Pessoa objPessoa)
        {
            new PessoaDao().Alterar(objPessoa);
            return RedirectToAction("Index", "Pessoas");
        }
        [HttpPost]
        public ActionResult Novo(Pessoa objPessoa)
        {
            new PessoaDao().Gravar(objPessoa);
            return RedirectToAction("Index", "Pessoas");
        }
        public ActionResult Detalhar(int id)
        {
            Pessoa pessoa = new PessoaDao().Buscar(id);
            return View(pessoa);
        }
        public ActionResult Excluir(int id)
        {
            new PessoaDao().Excluir(id);
            return RedirectToAction("Index", "Pessoas");
        }
    }
}