using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_Definicoes : UserControl
    {
        Global g = new Global();
        public S_Definicoes()
        {
            InitializeComponent();
        }

        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            g.Abrir(Global.Ficheiro.Filtrar.Imagem);
            pb_Foto.ImageLocation = Global.Ficheiro.Caminho;
        }
        private void bt_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (bt_MostrarSenha.Checked == true)
                tb_Senha.UseSystemPasswordChar = false;
            else tb_Senha.UseSystemPasswordChar = true;
        }
        private void bt_MostrarSenha_MouseEnter(object sender, EventArgs e)
        {
            if (bt_MostrarSenha.Checked == true)
                bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.FlatAppearance.CheckedBackColor;
            else bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.BackColor;
        }

        private void bt_MostrarSenha_Click(object sender, EventArgs e)
        {
            if (bt_MostrarSenha.Checked == true)
                bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.FlatAppearance.CheckedBackColor;
            else bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.BackColor;
        }

        private void S_Definicoes_MouseClick(object sender, MouseEventArgs e)
        {
            pn_Principal.Focus();
        }

        private void pn_Principal_MouseClick(object sender, MouseEventArgs e)
        {
            pn_Principal.Focus();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Dictionary<string, char> sexo = new Dictionary<string, char>()
            {
                {"Masculino",'M' },
                {"Feminino", 'F' }
            };

            if (sexo.ContainsKey(cb_Sexo.Text))
            {
                string sexupdate = $"UPDATE PERFIL SET `Sexo` = '{sexo[cb_Sexo.Text]}' WHERE (`id` = '{Global.Id}');";
                Banco.Query(sexupdate);
                try
                {
                    if (!string.IsNullOrEmpty(Global.Ficheiro.Caminho) && File.Exists(Global.Ficheiro.Caminho))
                    {
                        Global.Imagem = Global.Ficheiro.Caminho.Replace('\\', '/');
                        Banco.Query($"UPDATE perfil SET imagem = '{Global.Imagem}' WHERE id = '{Global.Id}';");
                    }
                    string pupdate = $"UPDATE perfil SET `Nome` = '{tb_Nome.Text}', `Apelido` = '{tb_Apelido.Text}', `Localidade` = '{tb_Localidade.Text}', `nascimento` = '{dtp_data.Value.ToString("yyyy-MM-dd")}' WHERE (`id` = '{Global.Id}');";

                    string update = $"UPDATE usuario SET `email` = '{tb_Email.Text}', `telefone` = '{maskedTextBox1.Text}', `username` = '{tb_NomeUsuario.Text}', `senha` = '{tb_Senha.Text}', update_time = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE (`id` = '{Global.Id}');";
                    Banco.Query(pupdate);
                    Banco.Query(update);

                    var dt = Banco.Query($@"SELECT 
                                            p.Nome,
                                            p.Apelido,
                                            u.username,
                                            u.email,
                                            u.code,
                                            u.senha,
                                            u.telefone,
                                            p.localidade,
                                            p.imagem,
                                            p.sexo,
                                            p.nascimento
                                        FROM
                                            usuario u
                                                JOIN
                                            perfil p ON p.id = u.id
                                        WHERE
                                            u.username = '{tb_NomeUsuario.Text}' 
                                                AND 
                                            u.senha = '{tb_Senha.Text}';");
                    if (dt.Rows.Count > 0)
                    {
                        Global.Nome = dt.Rows[0].ItemArray[0].ToString();
                        Global.Apelido = dt.Rows[0].ItemArray[1].ToString();
                        Global.Nome_Usuario = dt.Rows[0].ItemArray[2].ToString();
                        Global.Email = dt.Rows[0].ItemArray[3].ToString();
                        Global.Codigo = dt.Rows[0].ItemArray[4].ToString();
                        Global.Senha = dt.Rows[0].ItemArray[5].ToString();
                        Global.Telefone = dt.Rows[0].ItemArray[6].ToString();
                        Global.Localidade = dt.Rows[0].ItemArray[7].ToString();
                        Global.Imagem = dt.Rows[0].ItemArray[8].ToString();
                        Global.Sexo = dt.Rows[0].ItemArray[9].ToString();
                        if (!string.IsNullOrEmpty(dt.Rows[0].ItemArray[10].ToString()))
                        {
                            Global.Nascimento = DateTime.Parse(dt.Rows[0].ItemArray[10].ToString());
                        }
                        Carregar();
                        MessageBox.Show("Perfil Atualizado", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Defina um gênero.", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void S_Definicoes_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            Global.Ficheiro.Caminho = Global.Imagem;
            Dictionary<char, string> sexo = new Dictionary<char, string>()
            {
                {'M',"Masculino"},
                {'F',"Feminino"}
            };
            tb_NomeUsuario.Text = Global.Nome_Usuario;
            tb_Nome.Text = Global.Nome;
            tb_Apelido.Text = Global.Apelido;
            tb_Email.Text = Global.Email;
            maskedTextBox1.Text = Global.Telefone;
            tb_Senha.Text = Global.Senha;
            tb_Localidade.Text = Global.Localidade;
            if (!string.IsNullOrEmpty(Global.Sexo)) cb_Sexo.Text = sexo[char.Parse(Global.Sexo)];
            dtp_data.Value = Global.Nascimento;
            if (File.Exists(Global.Imagem))
            {
                pb_Foto.Image = Image.FromFile(Global.Imagem);
                F_Principal.Principal.bt_Conta.BackgroundImage = pb_Foto.Image;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cb_Sexo_Enter(object sender, EventArgs e)
        {
            g.Errar(cb_Sexo,null);
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você pretende mesmo eliminar sua conta", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Global.Deletar();
            }
        }
    }
}
