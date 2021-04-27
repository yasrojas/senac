using Microsoft.AspNetCore.Mvc;
using UC8P3_yasmin.Models;

namespace UC8P3_yasmin.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Orcamento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Orcamento(Cliente novoOrcamento)
        {
            ClienteRepository cr = new ClienteRepository();
            cr.Insert(novoOrcamento);

            /* programa antigo
            Dados.OrcamentoAtual.FazerOrcamento(novoOrcamento);

            ViewBag.nome = novoOrcamento.nome;
            ViewBag.email = novoOrcamento.email;
            ViewBag.telefone = novoOrcamento.telefone;
            ViewBag.endereco = novoOrcamento.endereco;
            ViewBag.linha = novoOrcamento.linha;
            ViewBag.descricao = novoOrcamento.descricao; */

            return View("Concluido");
        }
    }
}