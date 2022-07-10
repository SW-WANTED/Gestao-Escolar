using Design_WhiteMode_Modern.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class E_Horario : UserControl
    {
        public E_Horario()
        {
            InitializeComponent();
        }

        private void E_Horario_Load(object sender, EventArgs e)
        {
            
            string horario = @"SELECT 
                                id AS 'ID', descricao AS 'Descrição'
                            FROM
                                horario
                            ORDER BY
                                descricao;";

            dgv_Horarios.DataSource = Banco.Query(horario);
            dgv_Horarios.Columns[0].Width = 80;
            dgv_Horarios.Columns[1].Width = 200;
           
        }

        private void dgv_Horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rowCount = dgv.SelectedRows.Count;
            if (rowCount > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string query = $@"SELECT 
                                    *
                                FROM
                                    horario
                                WHERE
                                    id = '{vid}';";

                dt = Banco.Query(query);
                tb_Id.Text = dt.Rows[0].ItemArray[0].ToString();
                mtb_Horario.Text = dt.Rows[0].ItemArray[1].ToString();
            }
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            tb_Id.Clear();
            mtb_Horario.Clear();
            mtb_Horario.Focus();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            string id = tb_Id.Text;
            Banco.Horario(mtb_Horario.Text, id);
            string query = $@"SELECT 
                                     id AS 'ID', descricao AS 'Descrição'
                                FROM
                                    horario
                            ORDER BY
                                descricao;";

            dgv_Horarios.DataSource = Banco.Query(query);
            dgv_Horarios.Columns[0].Width = 80;
            dgv_Horarios.Columns[1].Width = 200;
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Eliminar?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (!string.IsNullOrEmpty(tb_Id.Text))
                    {
                        string delete = $"DELETE FROM horario where id = '{tb_Id.Text}';";
                        Banco.Query(delete);
                        dgv_Horarios.Rows.Remove(dgv_Horarios.CurrentRow);
                        dgv_Horarios.Columns[0].Width = 80;
                        dgv_Horarios.Columns[1].Width = 200;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dos horários foi selecionado", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
