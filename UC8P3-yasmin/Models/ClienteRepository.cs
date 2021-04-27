using System.Collections.Generic;
using MySqlConnector;

namespace UC8P3_yasmin.Models
{
    public class ClienteRepository
    {
        private const string enderecoConexao = "Database=Sparcks; Data Source=localhost; User Id=root";
        public void Insert(Cliente novoCliente)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlInsert= "insert into Cliente(nome, email, telefone, endereco, linha, descricao)";
            sqlInsert = sqlInsert + "values (@nome, @email, @telefone, @endereco, @linha, @descricao);";
            
            MySqlCommand comando = new MySqlCommand(sqlInsert,conexao);
            comando.Parameters.AddWithValue("@nome", novoCliente.nome);
            comando.Parameters.AddWithValue("@email", novoCliente.email);
            comando.Parameters.AddWithValue("@telefone", novoCliente.telefone);
            comando.Parameters.AddWithValue("@endereco", novoCliente.endereco);
            comando.Parameters.AddWithValue("@linha", novoCliente.linha);
            comando.Parameters.AddWithValue("@descricao", novoCliente.descricao);
            comando.ExecuteNonQuery();
            
            conexao.Close();
        }
    }
}