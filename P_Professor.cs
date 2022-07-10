using Design_WhiteMode_Modern.SQL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class P_Professor : UserControl
    {
        public P_Professor()
        {
            InitializeComponent();
        }

        private void P_Professor_Load(object sender, EventArgs e)
        {
            string query = @"
                            SELECT 
                                id AS 'ID', professor AS 'Professor', telefone AS 'Telefone'
                            FROM
                                professor
                            ORDER BY id;";

            dgv_Pofessor.DataSource = Banco.Query(query);
            dgv_Pofessor.Columns[0].Width = 60;
            dgv_Pofessor.Columns[1].Width = 300;
            dgv_Pofessor.Columns[2].Width = 240;
        }

        private void dgv_Pofessor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int linha = dgv.SelectedRows.Count;
            if (linha > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string query = $@"
                                SELECT 
                                    *
                                FROM
                                    professor
                                WHERE
                                    id = '{id}';";

                dt = Banco.Query(query);
                tb_ID.Text = dt.Rows[0].ItemArray[0].ToString();
                tb_Nome.Text = dt.Rows[0].ItemArray[1].ToString();
                tb_Telefone.Text = dt.Rows[0].ItemArray[2].ToString();
            }
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            tb_ID.Clear();
            tb_Nome.Clear();
            tb_Telefone.Clear();
            tb_Nome.Focus();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            string query = string.Empty;
            if (string.IsNullOrEmpty(tb_ID.Text))
            {
                query = $@"insert into professor (professor,telefone, idsecretario,create_time)
values ('{tb_Nome.Text}','{tb_Telefone.Text}', '{Global.Id}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";
            }
            else
            {
                query = $@"
                            UPDATE professor 
                            SET 
                                professor = '{tb_Nome.Text}',
                                telefone = '{tb_Telefone.Text}',
                                idsecretario = '{Global.Id}',
                                update_time = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'
                            WHERE
                                id = '{tb_ID.Text}';";
            }
            Banco.Query(query);
                 query = @"
                            SELECT 
                                id AS 'ID', professor AS 'Professor', telefone AS 'Telefone'
                            FROM
                                professor
                            ORDER BY id;";

            dgv_Pofessor.DataSource = Banco.Query(query);
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Eliminar?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string delete = $"DELETE FROM professor where id = '{tb_ID.Text}';";
                    Banco.Query(delete);
                    if (string.IsNullOrEmpty(tb_ID.Text))
                    {
                        dgv_Pofessor.Rows.Remove(dgv_Pofessor.CurrentRow);
                        string query = @"
                            SELECT 
                                id AS 'ID', professor AS 'Professor', telefone AS 'Telefone'
                            FROM
                                professor
                            ORDER BY id;";

                        dgv_Pofessor.DataSource = Banco.Query(query);
                        tb_ID.Clear();
                        tb_Nome.Clear();
                        tb_Telefone.Clear();
                        tb_Nome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sem Professor para eliminar", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void P_Professor_Enter(object sender, EventArgs e)
        {
            string query = @"
                            SELECT 
                                id AS 'ID', professor AS 'Professor', telefone AS 'Telefone'
                            FROM
                                professor
                            ORDER BY id;";

            dgv_Pofessor.DataSource = Banco.Query(query);
            dgv_Pofessor.Columns[0].Width = 60;
            dgv_Pofessor.Columns[1].Width = 300;
            dgv_Pofessor.Columns[2].Width = 240;
        }

        private void pn_Professor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Imprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
