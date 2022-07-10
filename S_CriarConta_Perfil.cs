using Design_WhiteMode_Modern.SQL;
using System;
using System.IO;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_CriarConta_Perfil : UserControl
    {
        Global g = new Global();
        public static string Dicas { get; set; }
        public S_CriarConta_Perfil()
        {
            InitializeComponent();
            Dicas = S_CriarConta_Nome.Apelido + " Adicione uma Foto de Perfil para Personalizá-lo.";
        }

        private void pn_Colunas_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            g.Abrir(Global.Ficheiro.Filtrar.Imagem);
            pb_Foto.ImageLocation = Global.Ficheiro.Caminho;
        }

        private void bt_Ignorar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                Perfil p = new Perfil();
                S_Usuario c = new S_Usuario();

                u.username = S_CriarConta_Validar.Username;
                u.email = S_CriarConta_Validar.Email;
                u.senha = S_CriarConta_Senha.Senha;
                u.code = S_CriarConta_Validar.Code;

                p.nome = S_CriarConta_Nome.Nome;
                p.apelido = S_CriarConta_Nome.Apelido;

                Banco.CriarConta(u, p);
                Global.Offline(true);
                F_Principal.Principal.pn_Publico.Controls.Clear();
                c.Dock = DockStyle.Fill;
                F_Principal.Principal.pn_Publico.Controls.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Adicionar(new S_CriarConta_Senha());
        }
        private void Adicionar(Control C)
        {
            S_CriarConta.pn_Publico.Controls.Clear();
            C.Dock = DockStyle.Fill;
            S_CriarConta.pn_Publico.Controls.Add(C);
        }

        private void bt_Concluir_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            Perfil p = new Perfil();
            S_Usuario c = new S_Usuario();

            u.username = S_CriarConta_Validar.Username;
            u.email = S_CriarConta_Validar.Email;
            u.senha = S_CriarConta_Senha.Senha;
            u.code = S_CriarConta_Validar.Code;

            p.nome = S_CriarConta_Nome.Nome;
            p.apelido = S_CriarConta_Nome.Apelido;
            string img = Global.Ficheiro.Caminho;
            //string img_nome = Global.Ficheiro.Nome;
            try
            {
                if (!string.IsNullOrEmpty(img) && !string.IsNullOrWhiteSpace(img) && File.Exists(img))
                {
                    //string destfile = Global.Caminho_Foto + img_nome;
                    //File.Copy(img, destfile, true);
                    p.imagem = img;

                    Banco.CriarConta(u, p);
                    Global.Offline(true);
                    F_Principal.Principal.pn_Publico.Controls.Clear();
                    c.Dock = DockStyle.Fill;
                    F_Principal.Principal.pn_Publico.Controls.Add(c);
                }
                else
                {
                    MessageBox.Show("Sem foto de perfil", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Global.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }
        }

        private void S_CriarConta_Perfil_Load(object sender, EventArgs e)
        {
            txt_Dicas.Text = Dicas;
        }
    }
}
