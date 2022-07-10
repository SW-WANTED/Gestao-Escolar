using System;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_CriarConta_Senha : UserControl
    {
        Global g = new Global();
        public static string Senha { get; set; }
        public static string Dicas { get; set; }
        public S_CriarConta_Senha()
        {
            InitializeComponent();
            Dicas = "Agora já tens uma Validação " + S_CriarConta_Nome.Apelido + ", para a sua melhor proteção, crie uma Senha";
        }
        private void Adicionar(Control C)
        {
            S_CriarConta.pn_Publico.Controls.Clear();
            C.Dock = DockStyle.Fill;
            S_CriarConta.pn_Publico.Controls.Add(C);
        }
        private void bt_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (bt_MostrarSenha.Checked == true)
                tb_Senha_R.UseSystemPasswordChar = false;
            else tb_Senha_R.UseSystemPasswordChar = true;
        }
        private void bt_MostrarSenha_MouseEnter(object sender, EventArgs e)
        {
            if (bt_MostrarSenha.Checked == true)
                bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.FlatAppearance.CheckedBackColor;
            else bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.BackColor;
        }

        private void bt_MostrarSenha_Click(object sender, EventArgs e)
        {
            if (bt_MostrarSenha.Checked == true)
                bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.FlatAppearance.CheckedBackColor;
            else bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.BackColor;
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Adicionar(new S_CriarConta_Validar());
        }

        private void bt_Proximo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Senha.Text))
            {
                g.Errar(tb_Senha, "Introduza uma Senha de Segurança");
            }
            else if (string.IsNullOrWhiteSpace(tb_Senha_R.Text))
            {
                g.Errar(tb_Senha_R, "Escreva Novamente a Senha introduzida Anteriormente");
            }
            else
            {
                if(tb_Senha.Text!=tb_Senha_R.Text)
                {
                    g.Errar(tb_Senha_R, "As senhas não coincidem");
                }
                else
                {
                    Senha = tb_Senha.Text;
                    Adicionar(new S_CriarConta_Perfil());
                }
                
            }
        }

        private void tb_Senha_Enter(object sender, EventArgs e)
        {
            if (tb_Senha.Text.Length <= 0)
                g.Errar(tb_Senha, null);
        }

        private void tb_Senha_R_Enter(object sender, EventArgs e)
        {
            if (tb_Senha_R.Text.Length <= 0)
                g.Errar(tb_Senha_R, null);
        }

        private void S_CriarConta_Senha_Load(object sender, EventArgs e)
        {
            tb_Senha.Focus();
            tb_Senha.Text = Senha;
            txt_Dicas.Text = Dicas;
        }
    }
}
