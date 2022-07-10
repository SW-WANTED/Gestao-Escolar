using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design_WhiteMode_Modern.SQL
{
    class Banco
    {
        public static string strBanco = $"server={Global.Server};user id={Global.Server_Username};pwd={Global.Server_Password};database={Global.Server_Database};"; 

        public static MySqlConnection conexao()
        {
            var con = new MySqlConnection(strBanco);
            try
            {
                con.Open();
                Global.Server_Status = true;
                return con;
            }
            catch (Exception)
            {
                con.Close();
                Global.Server_Status = false;
                return con;
            }
        }

        public static DataTable CriarConta(Usuario u, Perfil p)
        {
            var dt = new DataTable();
            var banco = conexao();
            var cmd = banco.CreateCommand();

            //string usuario = "insert into usuario (username,email,telefone,senha,create_time) values (@username,@email,@telefone,@senha,@create,@update)";
            //string perfil = @"insert into perfil (nome,apelido,localidade,sexo,nascimento,imagem)
            //                      values (@nome,@apelido,@localidade,@sexo,@nascimento,@imagem)";

            string usuario = "insert into usuario (username,email,senha,code,create_time,update_time) values (@username,@email,@senha,@code,@create,@update);";
            string perfil = @"insert into perfil (nome,apelido,imagem)
                                  values (@nome,@apelido,@imagem);";

            try
            {
                if (!_verificar("username","usuario",u.username))
                {
                    cmd.CommandText = usuario;
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@email", u.email);
                    //cmd.Parameters.AddWithValue("@telefone", u.telefone);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@code", u.code);
                    cmd.Parameters.AddWithValue("@create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@update", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.CommandText = perfil;
                    cmd.Parameters.AddWithValue("@nome", p.nome);
                    cmd.Parameters.AddWithValue("@apelido", p.apelido); 
                    //cmd.Parameters.AddWithValue("@localidade", p.localidade); 
                    //cmd.Parameters.AddWithValue("@sexo", p.sexo);
                    //cmd.Parameters.AddWithValue("@nascimento", p.nascimento);
                    cmd.Parameters.AddWithValue("@imagem", p.imagem);
                    cmd.ExecuteNonQuery();

                    banco.Close();
                    MessageBox.Show("Conta criada com êxito", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"Nome de Utilizador já existente: {u.username}", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                banco.Close();
                return dt;
            }
        }

        public static DataTable Aluno(Aluno a)
        {
            var dt = new DataTable();
            var banco = conexao();
            var cmd = banco.CreateCommand();
            try
            {
                string aluno = $"INSERT INTO aluno (nome,telefone,proprina,classe,estado,idturma,idsecretario,Imagem,create_time,update_time) values (@nome,@telefone,@proprina,@classe,@estado,@idturma,@idsecretario,@foto,@create,@update)";
                cmd.CommandText = aluno;
                cmd.Parameters.AddWithValue("@nome", a.Nome);
                cmd.Parameters.AddWithValue("@telefone", a.telefone);
                cmd.Parameters.AddWithValue("@proprina", a.Proprina);
                cmd.Parameters.AddWithValue("@classe", a.Classe);
                cmd.Parameters.AddWithValue("@estado", a.Estado);
                cmd.Parameters.AddWithValue("@idturma", a.idTurma);
                cmd.Parameters.AddWithValue("@idsecretario", Global.Id);
                cmd.Parameters.AddWithValue("@foto", a.foto);
                cmd.Parameters.AddWithValue("@create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@update", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Conta criada com sucesso", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                banco.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                banco.Close();
                return dt;
            }

        }

        public static DataTable Horario(string horario, string id = null)
        {
            var dt = new DataTable();
            var banco = conexao();
            try
            {
                string h = $"INSERT INTO horario (descricao,create_time) values ('{horario}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";
                if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id)) Query(h);
                else
                {
                    h = $"UPDATE horario SET descricao = '{horario}', update_time = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE ID = '{id}';";
                    Query(h);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                banco.Close();
                return dt;
            }

        }

        public static DataTable Query(string sql, bool isM = false,string msg = "Tarefa Concluída")
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = null;
            MySqlConnection banco = conexao();
            try
            {
                var cmd = banco.CreateCommand();
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, banco);
                da.Fill(dt);
                banco.Close();
                if (isM)
                    MessageBox.Show(msg, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dt;
            }
            catch (Exception ex)
            {
                if (isM)
                    MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }
        public static bool _verificar(string campo, string table, string nome)
        {
            string verficar = $"select * from {table} where {campo}='{nome}';";
            var dt = Query(verficar);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
    }
}
