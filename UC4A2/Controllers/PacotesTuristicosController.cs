using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UC4A2.Models;

namespace UC4A2.Controllers
{
    public class PacotesTuristicosController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(PacotesTuristicos pc)
        {
            PacotesTuristicosRepository novopc = new PacotesTuristicosRepository();
            novopc.Cadastrar(pc);
            
            ViewBag.Mensagem = "Pacote cadastrado com sucesso!";
            return View();
        }

        public IActionResult Vitrine()
        {
            PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
            List<PacotesTuristicos> pacotes = pr.Listar();
            return View(pacotes);
        }

        public IActionResult Deletar(int Id)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login", "Usuario");
            
            PacotesTuristicosRepository pacoteExcluido = new PacotesTuristicosRepository();
            PacotesTuristicos pacote = pacoteExcluido.buscarPorId(Id);

            pacoteExcluido.Excluir(pacote);

            return RedirectToAction("Vitrine");
        }

        public IActionResult Editar(int Id)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login", "Usuario");

            PacotesTuristicosRepository pacoteAlterado = new PacotesTuristicosRepository();
            PacotesTuristicos pacoteBuscado = pacoteAlterado.buscarPorId(Id);

            return View(pacoteBuscado);
        }
        [HttpPost]
        public IActionResult Editar(PacotesTuristicos pc)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login", "Usuario");

            PacotesTuristicosRepository novopc = new PacotesTuristicosRepository();
            novopc.Editar(pc);
            
            return RedirectToAction("Vitrine");
        }
    }
}