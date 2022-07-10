using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class F_GestaoAluno : UserControl
    {
        string query = "";
        string turmaAtual = "";
        string idSelecionado = "";
        int idturma = 0;
        string turma = "";
        string caminho = "";
        int linha = 0;
        int vagas = 0;
        bool isLoad = false;

        public F_GestaoAluno()
        {
            InitializeComponent();
        }

        private void F_GestaoAluno_Load(object sender, EventArgs e)
        {
            isLoad = true;
            cb_Turma.Items.Clear();
            cb_Estado.Items.Clear();
            Carregar();
            isLoad = false;
        }
        private void Carregar()
        {
            int MaxAlunos = 0;
            int sobrando = 0;

            try
            {
                query = @"
                        SELECT 
                            id AS 'ID', Nome AS 'Alunos'
                        FROM
                            aluno;";

                dgv_Alunos.DataSource = Banco.Query(query);

                string queryTurma = @"
                                 SELECT 
                                        t.id, t.descricao
                                 FROM
                                        turma t
                                    INNER JOIN
                                        professor p ON p.id = t.idprofessor
                                    INNER JOIN
                                horario h ON h.id = t.idhorario;";
                cb_Turma.DataSource = Banco.Query(queryTurma);
                cb_Turma.DisplayMember = "descricao";
                cb_Turma.ValueMember = "id";

                if (dgv_Alunos.Rows.Count > 0)
                {
                    dgv_Alunos.Columns[0].Width = 60;
                    dgv_Alunos.Columns[1].Width = 240;
                    idSelecionado = dgv_Alunos.Rows[0].Cells[0].Value.ToString();
                    tb_Nome.Text = dgv_Alunos.Rows[dgv_Alunos.SelectedRows[0].Index].Cells[1].Value.ToString();

                    // ComboBox Turmas

                    var Maxdt = Banco.Query(@"
                                    SELECT 
                                        id, Maxalunos
                                    FROM
                                        turma
                                    ORDER BY id;");
                    if (Maxdt.Rows.Count > 0)
                    {
                        int id = int.Parse(Maxdt.Rows[0].ItemArray[0].ToString());
                        var Vagdt = Banco.Query($@"
                                    SELECT 
                                       count(a.id), idturma, estado
                                    FROM
                                        aluno a
                                    WHERE
                                        a.Estado = 'A' AND a.idturma = {id};");
                        if (Vagdt.Rows.Count > 0)
                        {
                            MaxAlunos = int.Parse(Maxdt.Rows[0].ItemArray[1].ToString());
                            sobrando = int.Parse(Vagdt.Rows[0].ItemArray[0].ToString());
                            cb_Estado.SelectedValue = Vagdt.Rows[0].ItemArray[2].ToString();
                        }

                        vagas = MaxAlunos - sobrando;
                        
                    }
                }

                turma = cb_Turma.Text;
                turmaAtual = cb_Turma.Text;
                //ComboBox Estado
                Dictionary<string, string> st = new Dictionary<string, string>();
                st.Add("A", "Ativo");
                st.Add("P", "Paralisado");
                st.Add("C", "Cancelado");
                cb_Estado.DataSource = new BindingSource(st, null);
                cb_Estado.DisplayMember = "Value";
                cb_Estado.ValueMember = "Key";
                cb_Turma.SelectedValue = idturma;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Nome.Text))
            {
                g.Errar(tb_Nome, "* Campo vazio *");
            }
            if (string.IsNullOrEmpty(cb_Turma.Text))
            {
                if (MessageBox.Show("Nenhuma turma selecionada", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    cb_Turma.Focus();
                    return;
                }
            }
            else if (vagas < 1)
            {
                MessageBox.Show("Não há vaga nesta turma", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Turma.Focus();
                return;
            }
            else
            {
                string imagem = pb_foto.ImageLocation.Replace('\\', '/');
                if (System.IO.File.Exists(caminho))
                {
                    imagem = caminho.Replace('\\', '/');
                }
                if (dgv_Alunos.Rows.Count > 0)
                {
                    linha = dgv_Alunos.SelectedRows[0].Index;
                    string updateAluno = $@"UPDATE aluno 
                                        SET 
                                            Nome = '{tb_Nome.Text}',
                                            Telefone = '{mtb_telefone.Text}',
                                            proprina = '{tb_Proprina.Text}',
                                            classe = '{cb_Classe.Text}',
                                            Estado = '{cb_Estado.SelectedValue}',
                                            idturma = '{cb_Turma.SelectedValue}',
                                            idsecretario = '{Global.Id}',
                                            imagem = '{imagem}'
                                        WHERE
                                            id = '{idSelecionado}';";
                    Banco.Query(updateAluno);
                    query = @"
                        SELECT 
                            id AS 'ID', Nome AS 'Alunos'
                        FROM
                            aluno;";

                    dgv_Alunos.DataSource = Banco.Query(query);
                    dgv_Alunos.Columns[0].Width = 60;
                    dgv_Alunos.Columns[1].Width = 240;
                    MessageBox.Show("Esta alteração foi salva com sucesso", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM aluno where id = '{idSelecionado}';";
            if (MessageBox.Show("Deseja eliminar o aluno selecionado", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgv_Alunos.Rows.Count > 0)
                {
                    Banco.Query(delete);
                    dgv_Alunos.Rows.Remove(dgv_Alunos.CurrentRow);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Sem alunos para eliminar", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Limpar()
        {
            pb_foto.Image = Properties.Resources.Cadastrar;
            tb_Nome.Clear();
            cb_Turma.SelectedIndex = -1;
            cb_Estado.SelectedIndex = -1;
            tb_Proprina.Text = "";
            mtb_telefone.Clear();
            tb_Nome.Focus();
        }
        private void dgv_Alunos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.SelectedRows.Count > 0)
                {
                    idSelecionado = dgv_Alunos.Rows[dgv_Alunos.SelectedRows[0].Index].Cells[0].Value.ToString();
                    string query = $@"
                                    SELECT 
                                        id, nome, telefone, estado, idturma, imagem, proprina, classe
                                    FROM
                                        aluno
                                    WHERE
                                    id = '{idSelecionado}';";
                    DataTable dt = Banco.Query(query);
                    if (dt.Rows.Count > 0)
                    {
                        tb_Nome.Text = dt.Rows[0].ItemArray[1].ToString();
                        mtb_telefone.Text = dt.Rows[0].ItemArray[2].ToString();
                        cb_Estado.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                        cb_Turma.SelectedValue = dt.Rows[0].ItemArray[4].ToString();
                        idturma = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                        pb_foto.ImageLocation = dt.Rows[0].ItemArray[5].ToString();
                        tb_Proprina.Text = dt.Rows[0].ItemArray[6].ToString();
                        cb_Classe.Text = dt.Rows[0].ItemArray[7].ToString();
                        turmaAtual = cb_Turma.Text;
                    }
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            if (!(dgv_Alunos.Rows.Count > 0))
            {
                tb_Nome.Clear();
                tb_Proprina.Text = string.Empty;
                mtb_telefone.Clear();
                cb_Estado.Text = string.Empty;
                cb_Turma.Text = string.Empty;
                tlp_Controls.Enabled = false;
            }
            else
                tlp_Controls.Enabled = true;
        }
        Global g = new Global();
        private void pb_foto_Click(object sender, EventArgs e)
        {
           
            g.Abrir(Global.Ficheiro.Filtrar.Imagem, pb_foto);
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void F_GestaoAluno_Validating(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("Validando " + DateTime.Now.Second);
        }

        private void F_GestaoAluno_Validated(object sender, EventArgs e)
        {
            //MessageBox.Show("Validado - Ano:" + DateTime.Now.Year);
        }

        private void F_GestaoAluno_Enter(object sender, EventArgs e)
        {
            try
            {
                if (!isLoad)
                {
                    Carregar();
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            g.Errar(tb_Nome, null);
        }

        private void tb_Proprina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
