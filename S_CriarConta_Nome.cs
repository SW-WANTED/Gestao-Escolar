using System;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_CriarConta_Nome : UserControl
    {
        Global g;
        public static string Nome { get; set; }
        public static string Apelido { get; set; }
        public S_CriarConta_Nome()
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
        private void bt_Proximo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tb_Nome.Text))
            {
                g.Errar(tb_Nome, "Escreva o seu nome próprio");
            }
            else if (string.IsNullOrWhiteSpace(tb_Apelido.Text))
            {
                g.Errar(tb_Apelido, "Escreva o seu Apelido");
            }
            else
            {
                Nome = tb_Nome.Text;
                Apelido = tb_Apelido.Text;
                Adicionar(new S_CriarConta_Validar());
            }
        }
        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            if (tb_Nome.Text.Length <= 0)
                g.Errar(tb_Nome, null);
        }

        private void tb_Apelido_Enter(object sender, EventArgs e)
        {
            if (tb_Apelido.Text.Length <= 0)
                g.Errar(tb_Apelido, null);
        }

        private void S_CriarConta_Nome_Load(object sender, EventArgs e)
        {
            tb_Nome.Focus();
            tb_Nome.Text = Nome;
            tb_Apelido.Text = Apelido;
        }

        private void pn_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Global.Login();
        }
    }
}
