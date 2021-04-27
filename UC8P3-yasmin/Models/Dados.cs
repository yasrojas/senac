namespace UC8P3_yasmin.Models
{
    public class Dados
    {
        //programa antigo
        public static Orcamento OrcamentoAtual {get; set;}
        static Dados()
        {
            OrcamentoAtual = new Orcamento();
        }
    }
}