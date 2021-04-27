using System.Collections.Generic;
using MySqlConnector;

namespace UC4A2.Models
{
    public class PacotesTuristicosRepository
    {
        private const string enderecoConexao = "Database=destino_certo; Data Source=localhost; User Id=root; Allow User Variables=True";
        public void Cadastrar(PacotesTuristicos novoPacotesTuristicos)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlInsert =
             "INSERT INTO PacotesTuristicos(Nome, Origem, Destino, Atrativos, Saida, Retorno, Usuario)";
            sqlInsert = sqlInsert + "VALUES(@Nome, @Origem, @Destino, @Atrativos, @Saida, @Retorno, @Usuario);";
            MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

            comando.Parameters.AddWithValue("@Nome", novoPacotesTuristicos.Nome);
            comando.Parameters.AddWithValue("@Origem", novoPacotesTuristicos.Origem);
            comando.Parameters.AddWithValue("@Destino", novoPacotesTuristicos.Destino);
            comando.Parameters.AddWithValue("@Atrativos", novoPacotesTuristicos.Atrativos);
            comando.Parameters.AddWithValue("@Saida", novoPacotesTuristicos.Saida);
            comando.Parameters.AddWithValue("@Retorno", novoPacotesTuristicos.Retorno);
            comando.Parameters.AddWithValue("@Usuario", novoPacotesTuristicos.Usuario);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public void Excluir(PacotesTuristicos deletarPacote)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlDelete =
            "DELETE FROM PacotesTuristicos WHERE Id=@Id;";
            MySqlCommand comando = new MySqlCommand(sqlDelete, conexao);

            comando.Parameters.AddWithValue("@Id", deletarPacote.Id);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public void Editar(PacotesTuristicos alterarPacote)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlAlter =
            "UPDATE PacotesTuristicos SET Nome=@Nome, Origem=@Origem, Destino=@Destino,";
            sqlAlter = sqlAlter + " Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno, Usuario=@Usuario WHERE Id=@Id;";
            MySqlCommand comando = new MySqlCommand(sqlAlter, conexao);

            comando.Parameters.AddWithValue("@Id", alterarPacote.Id);
            comando.Parameters.AddWithValue("@Nome", alterarPacote.Nome);
            comando.Parameters.AddWithValue("@Origem", alterarPacote.Origem);
            comando.Parameters.AddWithValue("@Destino", alterarPacote.Destino);
            comando.Parameters.AddWithValue("@Atrativos", alterarPacote.Atrativos);
            comando.Parameters.AddWithValue("@Saida", alterarPacote.Saida);
            comando.Parameters.AddWithValue("@Retorno", alterarPacote.Retorno);
            comando.Parameters.AddWithValue("@Usuario", alterarPacote.Usuario);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public List<PacotesTuristicos> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlList = "SELECT * FROM PacotesTuristicos ORDER BY Nome;";
            MySqlCommand comandoQuery = new MySqlCommand(sqlList, conexao);
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<PacotesTuristicos> lista = new List<PacotesTuristicos>();
            
            while (reader.Read())
            {
                PacotesTuristicos pc = new PacotesTuristicos();
                pc.Id = reader.GetInt32("Id");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    pc.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Origem")))
                    pc.Origem = reader.GetString("Origem");
                if (!reader.IsDBNull(reader.GetOrdinal("Destino")))
                    pc.Destino = reader.GetString("Destino");
                if (!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                    pc.Atrativos = reader.GetString("Atrativos");
                if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                    pc.Saida = reader.GetDateTime("Saida");
                if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                    pc.Retorno = reader.GetDateTime("Retorno");
                if (!reader.IsDBNull(reader.GetOrdinal("Usuario")))
                    pc.Usuario = reader.GetInt32("Usuario");

                lista.Add(pc);
            }

            conexao.Close();
            return lista;
        }
        public PacotesTuristicos buscarPorId(int Id) 
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlSearch = "SELECT * FROM PacotesTuristicos WHERE Id=@Id;";
            MySqlCommand comando = new MySqlCommand(sqlSearch, conexao);
            comando.Parameters.AddWithValue("@Id",Id);

            MySqlDataReader reader = comando.ExecuteReader();
            PacotesTuristicos pacoteValido = new PacotesTuristicos();

            if (reader.Read())
            {
                pacoteValido.Id = reader.GetInt32("Id");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    pacoteValido.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Origem")))
                    pacoteValido.Origem = reader.GetString("Origem");
                if (!reader.IsDBNull(reader.GetOrdinal("Destino")))
                    pacoteValido.Destino = reader.GetString("Destino");
                if (!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                    pacoteValido.Atrativos = reader.GetString("Atrativos");
                if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                    pacoteValido.Saida = reader.GetDateTime("Saida");
                if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                    pacoteValido.Retorno = reader.GetDateTime("Retorno");
                if (!reader.IsDBNull(reader.GetOrdinal("Usuario")))
                    pacoteValido.Usuario = reader.GetInt32("Usuario");

            }

            conexao.Close();
            
            return pacoteValido;
        }
    }
}