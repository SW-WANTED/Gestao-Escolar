using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class E_Turma : UserControl
    {
        string idSelecionado;
        bool isLoad = false;
        int modo = 0; // s ? +adrão, 1=Edilão, 2 = Inserção
        public E_Turma()
        {
            InitializeComponent();
        }

        private void E_Turma_Load(object sender, System.EventArgs e)
        {
            
            isLoad = true;
            Carregar();
            isLoad = false;
        }

        private void bt_Novo_Click(object sender, System.EventArgs e)
        {
            tb_Turma.Enabled = true;
            cb_Professor.Enabled = true;
            cb_Estado.Enabled = true;
            nud_alunos.Enabled = true;
            cb_horario.Enabled = true;
            tb_Vagas.Enabled = true;
            tb_Turma.Clear();
            cb_Professor.SelectedIndex = -1;
            nud_alunos.Value = 0;
            cb_Estado.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_Vagas.Clear();
            modo = 2;
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rowCount = dgv.SelectedRows.Count;
            if (rowCount > 0)
            {
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = $@"
                                SELECT 
                                    id, descricao, idprofessor, idhorario, Maxalunos, Estado
                                FROM
                                    turma
                                WHERE
                                    id = '{idSelecionado}';";

                DataTable dt = Banco.Query(query);
                tb_Turma.Enabled = false;
                cb_Professor.Enabled = false;
                cb_Estado.Enabled = false;
                nud_alunos.Enabled = false;
                cb_horario.Enabled = false;
                tb_Vagas.Enabled = false;

                if (dt.Rows.Count > 0)
                {
                    tb_Turma.Enabled = true;
                    cb_Professor.Enabled = true;
                    cb_Estado.Enabled = true;
                    nud_alunos.Enabled = true;
                    cb_horario.Enabled = true;
                    tb_Vagas.Enabled = true;
                    tb_Turma.Text = dt.Rows[0].ItemArray[1].ToString();
                    cb_Professor.SelectedValue = dt.Rows[0].ItemArray[2].ToString();
                    cb_horario.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                    nud_alunos.Value = Decimal.Parse(dt.Rows[0].ItemArray[4].ToString());
                    cb_Estado.SelectedValue = dt.Rows[0].ItemArray[5].ToString();
                }
                tb_Vagas.Text = Vagas();
                modo = 1;
            }
        }

        public string Vagas()
        {
            // Cálculos de Vagas
            string queryVagas = $@"
                                        SELECT 
                                            COUNT(id) AS 'countVagas'
                                        FROM
                                            aluno
                                        WHERE
                                            estado = 'A' AND idturma = '{idSelecionado}';";
            DataTable dt = Banco.Query(queryVagas);
            int vagas = Int32.Parse(Math.Round(nud_alunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].ItemArray[0].ToString());

            return vagas.ToString();
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Eliminar?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string delete = $"DELETE FROM turma where id = '{idSelecionado}';";
                    Banco.Query(delete);
                    if (dgv_turmas.Rows.Count > 0)
                    {
                        dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
                        tb_Turma.Clear();
                        cb_Professor.SelectedIndex = -1;
                        nud_alunos.Value = 0;
                        cb_Estado.SelectedIndex = -1;
                        cb_horario.SelectedIndex = -1;
                        tb_Vagas.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Sem turmas para eliminar", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            if (modo != 0)
            {
                string msg = "Nova turma adicionada.";
                string queryTurma = $@"
                        INSERT INTO turma (
descricao,idprofessor,idhorario,Maxalunos,Estado,create_time)
VALUES ('{tb_Turma.Text}','{cb_Professor.SelectedValue}','{cb_horario.SelectedValue}','{Int32.Parse(Math.Round(nud_alunos.Value, 0).ToString())}','{cb_Estado.SelectedValue}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";

                if (modo == 1 )
                {
                    queryTurma = $@"
                        UPDATE turma 
                        SET 
                            Descricao = '{tb_Turma.Text}',
                            idprofessor = '{cb_Professor.SelectedValue}',
                            idhorario = '{cb_horario.SelectedValue}',
                            Maxalunos = '{Int32.Parse(Math.Round(nud_alunos.Value, 0).ToString())}',
                            Estado = '{cb_Estado.SelectedValue}',
                            update_time = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'
                        WHERE
                            id = '{idSelecionado}';";
                    msg = $"{tb_Turma.Text} foi Atualizado.";
                }
                Banco.Query(queryTurma, true, msg);
                if (dgv_turmas.Rows.Count > 0)
                {
                    int linha = dgv_turmas.SelectedRows[0].Index;
                    if (modo == 1)
                    {
                        dgv_turmas[1, linha].Value = tb_Turma.Text;
                        dgv_turmas[2, linha].Value = cb_horario.Text;
                        tb_Vagas.Text = Vagas();
                    }
                    else
                    {
                        string sql = @"SELECT 
                                t.id AS 'ID', t.descricao AS 'Turma', h.descricao as 'Horário'
                            FROM
                                turma AS t
                                    INNER JOIN
                                horario AS h ON h.id = t.idhorario;";
                        dgv_turmas.DataSource = Banco.Query(sql);
                        dgv_turmas.Columns[0].Width = 60;
                        dgv_turmas.Columns[1].Width = 200;
                        dgv_turmas.Columns[2].Width = 140;
                    }
                }
                else
                {
                    string sql = @"SELECT 
                                t.id AS 'ID', t.descricao AS 'Turma', h.descricao as 'Horário'
                            FROM
                                turma AS t
                                    INNER JOIN
                                horario AS h ON h.id = t.idhorario;";
                    dgv_turmas.DataSource = Banco.Query(sql);
                    dgv_turmas.Columns[0].Width = 60;
                    dgv_turmas.Columns[1].Width = 200;
                    dgv_turmas.Columns[2].Width = 140;
                }
            }
        }

        private void tb_Turma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
            
        }

        private void cb_Professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void nud_alunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void Carregar()
        {
            string sql = @"SELECT 
                                t.id AS 'ID', t.descricao AS 'Turma', h.descricao as 'Horário'
                            FROM
                                turma AS t
                                    INNER JOIN
                                horario AS h ON h.id = t.idhorario;";
            dgv_turmas.DataSource = Banco.Query(sql);
            dgv_turmas.Columns[0].Width = 60;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 140;
            if (dgv_turmas.Rows.Count > 0)
            {
                tb_Turma.Enabled = true;
                cb_Professor.Enabled = true;
                cb_Estado.Enabled = true;
                nud_alunos.Enabled = true;
                cb_horario.Enabled = true;
                tb_Vagas.Enabled = true;
                }
            else
            {
                tb_Turma.Enabled = false;
                cb_Professor.Enabled = false;
                cb_Estado.Enabled = false;
                nud_alunos.Enabled = false;
                cb_horario.Enabled = false;
                tb_Vagas.Enabled = false;
            }

            // ComboBox
            string professor = @"SELECT 
                                    p.id AS 'ID', p.professor AS 'Professor'
                                FROM
                                    professor AS p
                                ORDER BY p.id;";
            cb_Professor.DataSource = Banco.Query(professor);
            cb_Professor.DisplayMember = "Professor";
            cb_Professor.ValueMember = "ID";

            // Estado (Ativo = A, Paralisada = P, Cancelada = C)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("P", "Paralisado");
            st.Add("C", "Cancelado");
            cb_Estado.DataSource = new BindingSource(st, null);
            cb_Estado.DisplayMember = "Value";
            cb_Estado.ValueMember = "Key";

            // Horarios
            string horarios = @"SELECT 
                                    *
                                FROM
                                    horario h
                                ORDER BY h.descricao;";
            cb_horario.DataSource = Banco.Query(horarios);
            cb_horario.DisplayMember = "descricao";
            cb_horario.ValueMember = "ID";
        }

        private void E_Turma_Enter(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                Carregar();
            }
        }
    }
}
