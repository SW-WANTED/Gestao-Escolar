using System;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_CriarConta_Validar : UserControl
    {
        Global g;
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string Code { get; set; }
        public S_CriarConta_Validar()
        {
            InitializeComponent();
            g = new Global();
        }
        private void Adicionar(Control C)
        {
            S_CriarConta.pn_Publico.Controls.Clear();
            C.Dock = DockStyle.Fill;
            S_CriarConta.pn_Publico.Controls.Add(C);
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Adicionar(new S_CriarConta_Nome());
        }

        private void bt_Proximo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Nome.Text))
            {
                g.Errar(tb_Nome, "Escreva o seu Nome de Utilizador");
            }
            //else if (string.IsNullOrWhiteSpace(tb_Email.Text))
            //{
            //    g.Errar(tb_Email, "Escreva o seu Email");
            //}
            else if (string.IsNullOrWhiteSpace(tb_Code.Text))
            {
                g.Errar(tb_Code, "Você precisa de um Código de Acesso para continuar");
            }
            else
            {
                Username = tb_Nome.Text;
                Email = tb_Email.Text;
                Code = tb_Code.Text;
                Adicionar(new S_CriarConta_Senha());
            }
            
        }

        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            if (tb_Nome.Text.Length <= 0)
                g.Errar(tb_Nome, null);
        }

        private void tb_Email_Enter(object sender, EventArgs e)
        {
            if (tb_Email.Text.Length <= 0)
                g.Errar(tb_Email, null);
        }

        private void tb_Code_Enter(object sender, EventArgs e)
        {
            if (tb_Code.Text.Length <= 0)
                g.Errar(tb_Code, null);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            tb_Nome.Focus();
        }

        private void S_CriarConta_Validar_Load(object sender, EventArgs e)
        {
            tb_Nome.Text = Username;
            tb_Email.Text = Email;
            tb_Code.Text = Code;
        }
    }
}
