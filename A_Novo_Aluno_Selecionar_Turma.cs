using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class A_Novo_Aluno_Selecionar_Turma : Form
    {
        A_Novo_Aluno ana;
        public A_Novo_Aluno_Selecionar_Turma(A_Novo_Aluno f)
        {
            InitializeComponent();
            ana = f;
        }

        private void A_Novo_Aluno_Selecionar_Turma_Load(object sender, EventArgs e)
        {
            string query = $@"
                            SELECT 
                                t.id AS 'ID',
                                t.descricao AS 'Turmas',
                                h.descricao AS 'Horários',
                                p.professor AS 'Professores',
                                t.Maxalunos as 'Máximo de Alunos',
                                (SELECT 
                                        COUNT(id)
                                    FROM
                                        aluno a
                                    WHERE
                                        a.idturma = t.id AND Estado = 'A') AS 'Qt. Alunos'
                            FROM
                                turma t
                                    INNER JOIN
                                professor p ON p.id = t.idprofessor
                                    INNER JOIN
                                horario h ON h.id = t.idhorario;";

            dgv_turmas.DataSource = Banco.Query(query);
        }

        private void dgv_turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int MaxAlunos = 0;
            int qtdeAlunos = 0;
            string turma = "";

            if (dgv.SelectedRows.Count > 0)
            {
                MaxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
                qtdeAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
                turma = dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
            
            
            if (qtdeAlunos >= MaxAlunos)
            {
                MessageBox.Show($"Não existem vagas na turma de {turma}", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ana.tb_Turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                ana.tb_Turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
