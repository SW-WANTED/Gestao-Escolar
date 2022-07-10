using Design_WhiteMode_Modern.SQL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class F_Servicos : UserControl
    {
        string idSelecionado;
        bool isLoad = false;

        public F_Servicos()
        {
            InitializeComponent();
        }

        private void F_Servicos_Load(object sender, EventArgs e)
        {
            isLoad = false;
            carregar();
            isLoad = true;
        }

        private void carregar()
        {
            string query = "select id, Empresa, Telefone, Servico as Serviço, Valor, mes as Mês from servicos;";
            dgv_Servicos.DataSource = Banco.Query(query);
            if (dgv_Servicos.Rows.Count > 0)
            {
                //bt_Salvar.Enabled = true;
                bt_Eliminar.Enabled = true;
            }
            else
            {
                bt_Eliminar.Enabled = false;
                //bt_Salvar.Enabled = false;
            }

        }

        private void F_Servicos_Enter(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                carregar();
            }
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar(bool v  = true)
        {
            if (v)
            {
                tb_Id.Clear();
            }
            tb_Empresa.Clear();
            tb_Telefone.Clear();
            cb_Servico.Text = string.Empty;
            tb_Valor.Clear();
            dp_Mes.Value = DateTime.Today;
            tb_Empresa.Focus();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            limpar(false);
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            string query = "";
            string msg = "";
            if (string.IsNullOrEmpty(tb_Id.Text))
            {
                query = $@"INSERT INTO `escola`.`servicos` (`empresa`, `telefone`, `servico`, `valor`, `mes`)
VALUES 
('{tb_Empresa.Text}', '{tb_Telefone.Text}', '{cb_Servico.Text}', '{tb_Valor.Text}', '{dp_Mes.Value.ToString("yyyy-MM")}');
";
                msg = $"O serviço de {cb_Servico.Text} foi pago no mês de {dp_Mes.Value.ToString("MMMM")}";
                
            }
            else
            {
                query = $@"UPDATE `escola`.`servicos` SET `empresa` = '{tb_Empresa.Text}', `telefone` = '{tb_Telefone.Text}', `servico` = '{cb_Servico.Text}', `valor` = '{tb_Valor.Text}', `mes` = '{dp_Mes.Value.ToString("yyyy-MM")}' WHERE (`id` = '{tb_Id.Text}');
";
                msg = $"Alteração salva com sucesso!";
            }
            Banco.Query(query, true, msg);
            dgv_Servicos.DataSource = Banco.Query("select id, Empresa, Telefone, Servico as Serviço, Valor, mes as Mês from servicos;");
        }

        private void dgv_Servicos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rowCount = dgv.SelectedRows.Count;
            if (rowCount > 0)
            {
                idSelecionado = dgv_Servicos.Rows[dgv_Servicos.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = $@"
                                SELECT 
                                   id, Empresa, Telefone, Servico as Serviço, Valor, mes as Mês
                                FROM
                                    servicos
                                WHERE
                                    id = '{idSelecionado}';";

                DataTable dt = Banco.Query(query);
                if (dt.Rows.Count > 0)
                {
                    tb_Id.Text = dt.Rows[0].ItemArray[0].ToString();
                    tb_Empresa.Text = dt.Rows[0].ItemArray[1].ToString();
                    tb_Telefone.Text = dt.Rows[0].ItemArray[2].ToString();
                    cb_Servico.Text = dt.Rows[0].ItemArray[3].ToString();
                    tb_Valor.Text = dt.Rows[0].ItemArray[4].ToString();
                    dp_Mes.Value = DateTime.Parse(dt.Rows[0].ItemArray[5].ToString());
                }
            }
            if (dgv_Servicos.Rows.Count > 0)
            {
                //bt_Salvar.Enabled = true;
                bt_Eliminar.Enabled = true;
            }
            else
            {
                bt_Eliminar.Enabled = false;
                //bt_Salvar.Enabled = false;
            }
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Eliminar o serviço de {cb_Servico.Text} da empresa {tb_Empresa.Text}?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string delete = $"DELETE FROM servicos where id = '{idSelecionado}';";
                    Banco.Query(delete);
                    if (!string.IsNullOrEmpty(tb_Id.Text))
                    {
                        dgv_Servicos.Rows.Remove(dgv_Servicos.CurrentRow);
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum serviço selecionado para eliminar", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else return;
        }
    }
}
