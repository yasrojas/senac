using System.Collections.Generic;

namespace UC8P3_yasmin.Models
{
    public class Orcamento
    {
        private static List<Cliente> novoCliente = new List<Cliente>();

        public void FazerOrcamento(Cliente orcamento)
        {
            novoCliente.Add(orcamento);
        }
    }
}