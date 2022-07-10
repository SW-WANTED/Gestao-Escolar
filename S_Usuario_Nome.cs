using Design_WhiteMode_Modern.SQL;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_Usuario_Nome : UserControl
    {
        public static TextBox Nome { get; set; }
        Global g = new Global();
        public S_Usuario_Nome()
        {
            InitializeComponent();
            Nome = tb_Nome;
        }

        private void S_Sistema_Usuario_Nome_Load(object sender, EventArgs e)
        {

        }

        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            Erro.SetError(tb_Nome, null);
            if (Erro.RightToLeft)
            {
                Erro.RightToLeft = false;
            }

        }

        private void bt_Ir_Click(object sender, EventArgs e)
        {
            string nome = tb_Nome.Text;
            string sql = $@"
                            SELECT 
                                u.id,
                                u.username
                            FROM
                                usuario AS u
                            WHERE
                                u.username = '{nome}';";
            var dt = Banco.Query(sql);
            Erro.RightToLeft = true;
            if (dt.Rows.Count > 0)
            {
                Global.Id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                Global.Nome_Usuario = nome;
                Adicionar(new S_Usuario_Senha());
            }
            else
                Erro.SetError(tb_Nome, "Nome de Usuário Incorreto");
            
        }

        private void Adicionar(object o)
        {
            Control s = o as Control;
            if (!S_Usuario.pn_Publico.Controls.ContainsKey(s.Name))
            {
                s.Dock = DockStyle.Fill;
                S_Usuario.pn_Publico.Controls.Add(s);
            }

            S_Usuario.pn_Publico.Controls[s.Name].BringToFront();
            S_Usuario.pn_Buttons.Visible = true;
        }

        private void link_CriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Global.Criar();
        }

        private void tb_Nome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nome = tb_Nome.Text;
                string sql = $@"
                            SELECT 
                                u.id,
                                u.username
                            FROM
                                usuario AS u
                            WHERE
                                u.username = '{nome}';";
                var dt = Banco.Query(sql);

                if (dt.Rows.Count > 0)
                {
                    Global.Id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                    Global.Nome_Usuario = nome;
                    Adicionar(new S_Usuario_Senha());
                }
                else g.Errar(tb_Nome, "Nome de Usuário Incorreto", true);
            }
        }
    }
}
