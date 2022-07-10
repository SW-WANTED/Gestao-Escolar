using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class A_Novo_Aluno : UserControl
    {
        Global g = new Global();
        string origemCompleto = "";
        string destinoCompleto = "";
        bool isLoad = false;
        public A_Novo_Aluno()
        {
            InitializeComponent();
        }

        private void F_Novo_Aluno_Load(object sender, EventArgs e)
        {
            isLoad = true;
            // Estado (Ativo = A, Paralisada = P, Cancelada = C)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("P", "Paralisado");
            st.Add("C", "Cancelada");
            cb_Aluno_Estado.Items.Clear();
            cb_Aluno_Estado.DataSource = new BindingSource(st, null);
            cb_Aluno_Estado.DisplayMember = "Value";
            cb_Aluno_Estado.ValueMember = "Key";

            // Dados Estáticos
            txt_Data.Text = DateTime.Today.ToString();
            tb_Funcionario_Nome.Text = Global.Nome;
            mtb_Funcionario_Telefone.Text = Global.Telefone;
            isLoad = false;
            Limpar();
        }

        private void pb_Foto_DoubleClick(object sender, EventArgs e)
        {
            if (Ficheiro.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = Ficheiro.FileName;
                pb_Foto.ImageLocation = origemCompleto;
            }
            else
            {
                return;
            }
        }

        private void Limpar(bool edit = true)
        {
            lblDica.Text = "Clique duplo para alterar a imagem";
            tb_Aluno_Nome.Enabled = true;
            pb_Foto.Enabled = true;
            tb_Aluno_Telefone.Enabled = true;
                tb_Proprina.Enabled = true;
            bt_Turma.Enabled = true;
            cb_Aluno_Estado.Enabled = true;
            bt_Save.Enabled = true;
            bt_Cancel.Enabled = true;
            //bt_imprimir.Enabled = false;
            pn_Aluno.Enabled = true;
            if (!edit)
            {
                
                lblDica.Text = "";
                pb_Foto.Enabled = false;
                tb_Aluno_Nome.Enabled = false;
                tb_Aluno_Telefone.Enabled = false;
                cb_Aluno_Estado.Enabled = false;
                tb_Proprina.Enabled = false;
                bt_Turma.Enabled = false;
                bt_Save.Enabled = false;
                bt_Cancel.Enabled = false;
                pn_Aluno.Enabled = false;
                //bt_imprimir.Enabled = true;
            }
            pb_Foto.Image = Properties.Resources.Cadastrar;
            tb_Aluno_Nome.Clear();
            tb_Aluno_Telefone.Clear();
            tb_Turma.Clear();
            tb_Proprina.Clear();
            tb_Proprina.Text = "";
            cb_Aluno_Estado.SelectedIndex = 0;
            tb_Aluno_Nome.Focus();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_Aluno_Nome.Text))
                {
                    MessageBox.Show("Insira o Nome do Estudante", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(cb_Classe.Text))
                {
                    MessageBox.Show("O estudante precisa de uma classe", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(cb_Aluno_Estado.Text))
                {
                    MessageBox.Show("Defina o Estado do Aluno", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(tb_Turma.Text))
                {
                    MessageBox.Show("O estudante precisa de uma turma", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Aluno a = new Aluno();
                    a.Nome = tb_Aluno_Nome.Text;
                    a.Classe = cb_Classe.Text;
                    a.telefone = tb_Aluno_Telefone.Text;
                    a.Proprina = tb_Proprina.Text;
                    a.Estado = (String)cb_Aluno_Estado.SelectedValue;
                    a.idTurma = tb_Turma.Tag.ToString();
                    if (string.IsNullOrEmpty(tb_Turma.Text))
                    {
                        MessageBox.Show("Sem turma selecionada.", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (origemCompleto == "")
                        {
                            if (MessageBox.Show("Sem foto selecionada,deseja continuar?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                return;
                            }
                        }
                        //File.Copy(Global.Ficheiro.Caminho, destinoCompleto,true);
                        if (File.Exists(origemCompleto))
                        {
                            pb_Foto.ImageLocation = origemCompleto;
                        }
                        else if (MessageBox.Show("Erro ao localizar a foto, deseja continuar?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                        a.foto = pb_Foto.ImageLocation;
                        Banco.Aluno(a);
                        Limpar(false);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"O acesso ao ficheiro {destinoCompleto} foi negado, tente acessar o aplicativo como administrador.", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Limpar(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Turma_Click(object sender, EventArgs e)
        {
            A_Novo_Aluno_Selecionar_Turma anast = new A_Novo_Aluno_Selecionar_Turma(this);
            anast.ShowDialog();
        }
        private void pb_Foto_Click(object sender, EventArgs e)
        {
            g.Abrir(Global.Ficheiro.Filtrar.Imagem);
            //destinoCompleto = Global.Caminho_Foto + Global.Ficheiro.Nome;
            destinoCompleto = Global.Ficheiro.Caminho;

            //if (File.Exists(destinoCompleto))
            //{
            //    if (MessageBox.Show("Arquivo existente,deseja substituir?",Global.Titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            //    {
            //        return;
            //    }
            //}
            pb_Foto.ImageLocation = Global.Ficheiro.Caminho;
        }

        private void A_Novo_Aluno_Enter(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                Dictionary<string, string> st = new Dictionary<string, string>();
                st.Add("A", "Ativo");
                st.Add("P", "Paralisado");
                st.Add("C", "Cancelada");
                cb_Aluno_Estado.DataSource = new BindingSource(st, null);
                cb_Aluno_Estado.DisplayMember = "Value";
                cb_Aluno_Estado.ValueMember = "Key";

                // Dados Estáticos
                txt_Data.Text = DateTime.Today.ToString();
                tb_Funcionario_Nome.Text = Global.Nome;
                mtb_Funcionario_Telefone.Text = Global.Telefone;
            }
        }
        private void cb_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> proprina = new Dictionary<string, string>();
            proprina.Add("10ª Classe", "20.000");
            proprina.Add("11ª Classe", "21.000");
            proprina.Add("12ª Classe", "22.000");
            proprina.Add("13ª Classe", "23.000");
            tb_Proprina.Text = proprina[cb_Classe.Text];
        }


        private void bt_Novo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
