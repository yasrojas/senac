using System.Collections.Generic;
using MySqlConnector;

namespace UC4A2.Models
{
    public class UsuarioRepository
    {
        private const string enderecoConexao = "Database=destino_certo; Data Source=localhost; User Id=root; Allow User Variables=True";
        public Usuario QueryLogin(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string sql = "SELECT * FROM Usuario WHERE Login = @Login AND Senha = @Senha";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@Login", u.Login);
            comandoQuery.Parameters.AddWithValue("@Senha", u.Senha);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Usuario usr = null;
            if (reader.Read())
            {
                usr = new Usuario();
                usr.Id = reader.GetInt32("Id");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    usr.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                    usr.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    usr.Senha = reader.GetString("Senha");
                if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                    usr.DataNascimento = reader.GetDateTime("DataNascimento");
            }

            conexao.Close();
            return usr;
        }
        
        public Usuario validarLogin(Usuario usuario)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlValidar = "SELECT * FROM Usuario WHERE Login=@Login and Senha = @Senha";
            MySqlCommand comando = new MySqlCommand(sqlValidar,conexao);
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@Senha", usuario.Senha);

            MySqlDataReader reader = comando.ExecuteReader();

            Usuario usuarioEncontrado = null;

            if(reader.Read())
            {
                usuarioEncontrado = new Usuario();
                usuarioEncontrado.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    usuarioEncontrado.Nome = reader.GetString("Nome");

                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                    usuarioEncontrado.Login = reader.GetString("Login");

                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    usuarioEncontrado.Senha = reader.GetString("Senha");

                usuarioEncontrado.DataNascimento = reader.GetDateTime("DataNascimento");
            }

            conexao.Close();
            return usuarioEncontrado;
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlInsert =
             "INSERT INTO Usuario (Nome, Login, Senha, DataNascimento)";
            sqlInsert = sqlInsert + " VALUES(@Nome, @Login, @Senha, @DataNascimento);";
            MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.Parameters.AddWithValue("@DataNascimento", novoUsuario.DataNascimento);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public void Excluir(Usuario deletarUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlDelete =
            "DELETE FROM Usuario WHERE Id=@Id;";
            MySqlCommand comando = new MySqlCommand(sqlDelete, conexao);

            comando.Parameters.AddWithValue("@Id", deletarUsuario.Id);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public void Editar(Usuario alterarUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlAlter =
            "UPDATE Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id;";
            MySqlCommand comando = new MySqlCommand(sqlAlter, conexao);

            comando.Parameters.AddWithValue("@Id", alterarUsuario.Id);
            comando.Parameters.AddWithValue("@Nome", alterarUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", alterarUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", alterarUsuario.Senha);
            comando.Parameters.AddWithValue("@DataNascimento", alterarUsuario.DataNascimento);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public List<Usuario> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlList = "SELECT * FROM Usuario ORDER BY Id;";
            MySqlCommand comandoQuery = new MySqlCommand(sqlList, conexao);
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            
            while (reader.Read())
            {
                Usuario u = new Usuario();
                u.Id = reader.GetInt32("Id");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    u.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                    u.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    u.Senha = reader.GetString("Senha");
                if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                    u.DataNascimento = reader.GetDateTime("DataNascimento");
                lista.Add(u);
            }

            conexao.Close();
            return lista;
        }
        public Usuario buscarPorId(int Id)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlSearch = "SELECT * FROM Usuario WHERE Id=@Id;";
            MySqlCommand comando = new MySqlCommand(sqlSearch, conexao);
            comando.Parameters.AddWithValue("@Id",Id);

            MySqlDataReader reader = comando.ExecuteReader();
            Usuario usuarioValido = new Usuario();

            if (reader.Read())
            {
                usuarioValido.Id = reader.GetInt32("Id");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    usuarioValido.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                    usuarioValido.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    usuarioValido.Senha = reader.GetString("Senha");
                if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                    usuarioValido.DataNascimento = reader.GetDateTime("DataNascimento");
            }

            conexao.Close();
            
            return usuarioValido;
        }
    }
}