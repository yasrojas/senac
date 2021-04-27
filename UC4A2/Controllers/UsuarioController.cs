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
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.validarLogin(u);

            if(usuario != null)
            {
                ViewBag.Mensagem = "Você está logado";
               
               //registo na sessao os dados q foram retornados na validaçao
                HttpContext.Session.SetInt32("IdUsuario",usuario.Id);
                HttpContext.Session.SetString("NomeUsuario",usuario.Nome);

                return RedirectToAction("Cadastro");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
        }
        
        public IActionResult Logout()
        {
            //limpa todos os dados de uma sessao
            HttpContext.Session.Clear();
            
            return RedirectToAction("Login");
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            UsuarioRepository novoU = new UsuarioRepository();
            novoU.Cadastrar(u);
            
            ViewBag.Mensagem = "Usuario cadastrado com sucesso!";
            return View();
        }

        public IActionResult Listar()
        {
            UsuarioRepository listaU = new UsuarioRepository();
            List<Usuario> usuarios = listaU.Listar();
            return View(usuarios);
        }

        public IActionResult Deletar(int Id)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");
            
            UsuarioRepository usuarioExcluido = new UsuarioRepository();
            Usuario usr = usuarioExcluido.buscarPorId(Id);

            usuarioExcluido.Excluir(usr);

            return RedirectToAction("Listar");
        }

        public IActionResult Editar(int Id)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            UsuarioRepository usuarioAlterado = new UsuarioRepository();
            Usuario usuarioBuscado = usuarioAlterado.buscarPorId(Id);

            return View(usuarioBuscado);
        }
        [HttpPost]
        public IActionResult Editar(Usuario usr)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login");

            UsuarioRepository novoUsr = new UsuarioRepository();
            novoUsr.Editar(usr);
            
            return RedirectToAction("Listar");
        }
    } 
}