using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class F_Gestao_Funcionario : UserControl
    {
        bool isLoad = false;
        string idSelecionado = "";
        string caminho = "";
        Global g = new Global();
        public F_Gestao_Funcionario()
        {
            InitializeComponent();
        }

        private void F_Gestao_Funcionario_Load(object sender, EventArgs e)
        {
            isLoad = true;
            string queryFuncionario = $@"
                                        SELECT 
                                            Id,
                                            Nome AS 'Nome Completo',
                                            Telefone,
                                            Cargo,
                                            salario AS 'Salário'
                                        FROM
                                            funcionario;";
            dgv_Funcionarios.DataSource = Banco.Query(queryFuncionario);
            dgv_Funcionarios.Columns[0].Width = 45;
            dgv_Funcionarios.Columns[1].Width = 200;
            dgv_Funcionarios.Columns[2].Width = 150;
            dgv_Funcionarios.Columns[3].Width = 100;
            dgv_Funcionarios.Columns[4].Width = 100;

            //ComboBox Estado
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("P", "Paralisado");
            st.Add("C", "Cancelado");
            cb_Estado.Items.Clear();
            cb_Estado.DataSource = new BindingSource(st, null);
            cb_Estado.DisplayMember = "Value";
            cb_Estado.ValueMember = "Key";
            isLoad = false;
        }

        private void dgv_Funcionarios_SelectionChanged(object sender, EventArgs e)
        {
            Dictionary<char, string> sexo = new Dictionary<char, string>()
            {
                {'M',"Masculino"},
                {'F',"Feminino"}
            };
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv_Funcionarios.Rows[dgv_Funcionarios.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = $@"
                                   SELECT 
                                        Id,
                                        Nome AS 'Nome Completo',
                                        Telefone,
                                        Estado,
                                        sexo AS 'Gênero',
                                        localidade AS 'Residência',
                                        nascimento AS 'Data de Nascimento',
                                        Cargo,
                                        salario AS 'Salário',
                                        turno,
                                        Imagem
                                    FROM
                                        funcionario
                                    WHERE
                                        id = '{idSelecionado}';";
                DataTable dt = Banco.Query(query);
                tb_Nome.Text = dt.Rows[0].ItemArray[1].ToString();
                mtb_telefone.Text = dt.Rows[0].ItemArray[2].ToString();
                cb_Estado.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0].ItemArray[4].ToString())) cb_Sexo.Text = sexo[char.Parse(dt.Rows[0].ItemArray[4].ToString())];
                cb_Localidade.Text = dt.Rows[0].ItemArray[5].ToString();
                dtp_Nascimento.Value = DateTime.Parse(dt.Rows[0].ItemArray[6].ToString());
                cb_Cargo.Text = dt.Rows[0].ItemArray[7].ToString();
                tb_Salario.Text = dt.Rows[0].ItemArray[8].ToString();
                cb_Turno.Text = dt.Rows[0].ItemArray[9].ToString();
                caminho = dt.Rows[0].ItemArray[10].ToString().Replace('/','\\');
                if (File.Exists(caminho))
                {
                    pb_foto.ImageLocation = caminho;
                }
                else
                {
                    pb_foto.Image = Properties.Resources.Account_Orange_Transparent;
                }
            }
            Limpar();
        }
        private void Limpar()
        {
            if (!(dgv_Funcionarios.Rows.Count > 0))
            {
                pb_foto.Image = Properties.Resources.Account_Orange_Transparent;
                tb_Nome.Clear();
                mtb_telefone.Clear();
                cb_Estado.Text = string.Empty;
                tb_Salario.Clear();
                cb_Cargo.Text = string.Empty;
                cb_Turno.Text = string.Empty;
                cb_Sexo.Text = string.Empty;
                cb_Localidade.Text = string.Empty;
                dtp_Nascimento.Value = DateTime.Today;
                bt_Guardar.Enabled = false;
                bt_Eliminar.Enabled = false;
                bt_Imprimir.Enabled = false;
            }
            else
            {
                bt_Guardar.Enabled = true;
                bt_Eliminar.Enabled = true;
                bt_Imprimir.Enabled = true;
            }
            tb_Nome.Focus();
        }
        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM funcionario where id = '{idSelecionado}';";
            if (MessageBox.Show("Você está eliminando um funcionário, pretende continuar?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgv_Funcionarios.Rows.Count > 0)
                {
                    Banco.Query(delete);
                    dgv_Funcionarios.Rows.Remove(dgv_Funcionarios.CurrentRow);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Sem funcionários para eliminar", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            Dictionary<string, char> sexo = new Dictionary<string, char>()
            {
                {"Masculino",'M'},
                {"Feminino",'F'}
            };
            if (!string.IsNullOrEmpty(idSelecionado))
            {
                string updateFuncionario = $@"
                                        UPDATE `escola`.`funcionario` 
                                        SET 
                                            `nome` = '{tb_Nome.Text}',
                                            `telefone` = '{mtb_telefone.Text}',
                                            `cargo` = '{cb_Cargo.Text}',
                                            `salario` = '{tb_Salario.Text}',
                                            `turno` = '{cb_Turno.Text}',
                                            `localidade` = '{cb_Localidade.Text}',
                                            `sexo` = '{sexo[cb_Sexo.Text]}',
                                            `idsecretario` = '{Global.Id}',
                                            `nascimento` = '{dtp_Nascimento.Value.ToString("yyyy-MM-dd")}',
                                            `imagem` = '{caminho.Replace('\\','/')}',
                                            `update_time` = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',
                                            `Estado` = '{cb_Estado.SelectedValue.ToString()}'
                                        WHERE
                                            (`id` = '{idSelecionado}');";
                string queryFuncionario = $@"
                                        SELECT 
                                            Id,
                                            Nome AS 'Nome Completo',
                                            Telefone,
                                            Cargo,
                                            salario AS 'Salário'
                                        FROM
                                            funcionario;";
                Banco.Query(updateFuncionario);

                dgv_Funcionarios.DataSource = Banco.Query(queryFuncionario);
                dgv_Funcionarios.Columns[0].Width = 45;
                dgv_Funcionarios.Columns[1].Width = 200;
                dgv_Funcionarios.Columns[2].Width = 150;
                dgv_Funcionarios.Columns[3].Width = 100;
                dgv_Funcionarios.Columns[4].Width = 100;
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pb_foto_DoubleClick(object sender, EventArgs e)
        {
            if (Ficheiro.ShowDialog() == DialogResult.OK)
            {
                caminho = Ficheiro.FileName; 
                pb_foto.ImageLocation = caminho;
            }
            else
            {
                return;
            }
        }

        private void F_Gestao_Funcionario_Enter(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                string queryFuncionario = $@"
                                        SELECT 
                                            Id,
                                            Nome AS 'Nome Completo',
                                            Telefone,
                                            Cargo,
                                            salario AS 'Salário'
                                        FROM
                                            funcionario;";
                dgv_Funcionarios.DataSource = Banco.Query(queryFuncionario);
                dgv_Funcionarios.Columns[0].Width = 45;
                dgv_Funcionarios.Columns[1].Width = 200;
                dgv_Funcionarios.Columns[2].Width = 150;
                dgv_Funcionarios.Columns[3].Width = 100;
                dgv_Funcionarios.Columns[4].Width = 100;
            }
            Limpar();
        }
    }
}
