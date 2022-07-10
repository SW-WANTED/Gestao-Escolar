using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class F_Novo_Funcionario : UserControl
    {
        Global g = new Global(); string Caminho = "";
        public F_Novo_Funcionario()
        {
            InitializeComponent();
           
        }
        private void bt_Foto_Click(object sender, EventArgs e)
        {
            if (Ficheiro.ShowDialog() == DialogResult.OK)
            {
                Caminho = Ficheiro.FileName;
                pb_Foto.ImageLocation = Caminho;
            }
            else
            {
                return;
            }
        }


        private void bt_Foto_MouseEnter(object sender, EventArgs e)
        {
            bt_Foto.ForeColor = System.Drawing.Color.Black;
        }

        private void bt_Foto_MouseLeave(object sender, EventArgs e)
        {
            bt_Foto.ForeColor = System.Drawing.Color.White;
        }

        private void pb_Foto_MouseEnter(object sender, EventArgs e)
        {
            //if (pb_Foto.Image == Properties.Resources.Account_Orange)
                //pb_Foto.Image = Properties.Resources.Account_Orange;
            //else
            //    pb_Foto.BackColor = Color.FromArgb(253, 248, 243);
            //global::Design_WhiteMode_Modern.Properties.Resources.Account_Orange_Transparent;
        }

        private void pb_Foto_MouseLeave(object sender, EventArgs e)
        {
            //if (pb_Foto.Image == Properties.Resources.Account_Orange_Transparent)
                //pb_Foto.Image = Properties.Resources.Account_Orange_Transparent;
            //else
            //    pb_Foto.BackColor = Color.FromArgb(248, 253, 248);
        }

        private void pb_Foto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Ficheiro.ShowDialog() == DialogResult.OK)
            {
                Caminho = Ficheiro.FileName;
                pb_Foto.ImageLocation = Caminho;
            }
            else
            {
                return;
            }
        }

        private void adicionarFotoDePerfilToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            adicionarFotoDePerfilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void adicionarFotoDePerfilToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            adicionarFotoDePerfilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void removerFotoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            removerFotoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void removerFotoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            removerFotoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void adicionarFotoDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ficheiro.ShowDialog() == DialogResult.OK)
            {
                Caminho = Ficheiro.FileName;
            }
            else return;
            pb_Foto.ImageLocation = Caminho;
        }

        private void removerFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_Foto.Image = Properties.Resources.Account_Orange_Transparent;
        }

        private void Limpar(bool isOk = true)
        {
            Caminho = "";
            bt_Foto.Enabled = false;
            pb_Foto.Enabled = false;
            gb_Trabalho.Enabled = false;
            pn_Dados.Enabled = false;
            bt_Cancelar.Enabled = false;
            bt_Guardar.Enabled = false;
            tlp_Imagem.Enabled = false;
            bt_Novo.Enabled = true;
            bt_Cancelar.Cursor = Cursors.No;
            bt_Guardar.Cursor = Cursors.No;
            bt_Novo.Cursor = Cursors.Hand;
            if (isOk)
            {
                bt_Foto.Enabled = true;
                pb_Foto.Enabled = true;
                gb_Trabalho.Enabled = true;
                pn_Dados.Enabled = true;
                bt_Cancelar.Enabled = true;
                tlp_Imagem.Enabled = true;
                bt_Guardar.Enabled = true;
                bt_Novo.Enabled = false;
                bt_Cancelar.Cursor = Cursors.Hand;
                bt_Guardar.Cursor = Cursors.Hand;
                bt_Novo.Cursor = Cursors.No;
            }
            tb_Nome.Clear();
            mtb_telefone.Clear();
            cb_Localidade.Text = "";
            cb_Sexo.SelectedIndex = -1;
            cb_Cargo.Text = "";
            tb_Salario.Clear();
            cb_Turno.Text = "";
            pb_Foto.ImageLocation = Caminho;
            pb_Foto.Image = Properties.Resources.Account_Orange_Transparent;
            dtp_Nascimento.Value = DateTime.Today;
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Limpar(false);
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string imagem = "";
                if (System.IO.File.Exists(Caminho))
                {
                    imagem = Caminho.Replace('\\','/');
                }
                    Dictionary<string, char> sexo = new Dictionary<string, char>()
                {
                    {"Masculino",'M' },
                    {"Feminino", 'F' }
                };
                if (string.IsNullOrEmpty(tb_Nome.Text))
                {
                    g.Errar(tb_Nome, "* Campo vazio *");
                }
                else if (string.IsNullOrEmpty(cb_Sexo.Text))
                {
                    g.Errar(cb_Sexo, "* Campo vazio *");
                }
                else if (string.IsNullOrEmpty(cb_Cargo.Text))
                {
                    g.Errar(cb_Cargo, "* Campo vazio *");
                }
                else if (string.IsNullOrEmpty(cb_Turno.Text))
                {
                    g.Errar(cb_Turno, "* Campo vazio *");
                }
                else
                {
                    string queryFuncionario = $@"INSERT INTO funcionario (nome, telefone, cargo, salario, turno, localidade, sexo, nascimento, imagem, idsecretario, update_time, create_time) 
VALUES ('{tb_Nome.Text}', '{mtb_telefone.Text}', '{cb_Cargo.Text}', '{tb_Salario.Text}', '{cb_Turno.Text}', '{cb_Localidade.Text}', '{sexo[cb_Sexo.Text]}', '{dtp_Nascimento.Value.ToString("yyyy-MM-dd")}', '{imagem}', {Global.Id},'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";

                    Banco.Query(queryFuncionario);
                    Limpar(false);
                    MessageBox.Show("Novo Funcionário cadastrado", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            g.Errar(tb_Nome, null);
        }

        private void F_Novo_Funcionario_Load(object sender, EventArgs e)
        {
            Limpar(false);
        }
    }
}
