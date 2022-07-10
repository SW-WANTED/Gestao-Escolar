using Design_WhiteMode_Modern.SQL;
using System;
using System.Windows.Forms;
namespace Design_WhiteMode_Modern
{
     class Global
    {
        public static string Titulo { get; set; } = "Software de Gestão Escolar";


        // Propiedades
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Apelido { get; set; }
        public static string Nome_Usuario { get; set; }
        public static string Email { get; set; }
        public static string Codigo { get; set; }
        public static string Senha { get; set; }
        public static string Telefone { get; set; }
        public static string Localidade { get; set; }
        public static string Sexo { get; set; }
        public static DateTime Nascimento { get; set; } = DateTime.Today;
        public static string Imagem { get; set; }
        // Fim Propriedades

        // Banco de dados
        public static string Server { get; set; } = "localhost";
        public static string Server_Username { get; set; } = "root";
        public static string Server_Password { get; set; } = "admin";
        public static string Server_Database { get; set; } = "escola";
        public static bool Server_Status { get; set; } = false;
        // Banco de dados

        // Caminhos fixos
        public static string Caminho { get; set; } = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string Caminho_Foto { get; set; } = Caminho + @"\fotos\";
        public static string Caminho_dados { get; set; } = Caminho + @"\dados\";

        public Global()
        {
            Erro = new ErrorProvider();
            openFileDialog = new OpenFileDialog();
        }
        public void Errar(Control objecto, String texto, Boolean RightLeft = false)
        {
            Erro.BlinkRate = 100;
            Erro.RightToLeft = RightLeft;
            if (string.IsNullOrEmpty(texto))
                this.Erro.SetError(objecto, null);
            else
                Erro.SetError(objecto, texto);
        }
        public void Abrir(Ficheiro.Filtrar Filtrar = Ficheiro.Filtrar.Tudo)
        {
            if (Filtrar == Ficheiro.Filtrar.Imagem)
            {
                openFileDialog.Filter = "Png|*.png|Jpg|*.jpg";
            }
            else if (Filtrar == Ficheiro.Filtrar.Aplicativos)
            {
                openFileDialog.Filter = "Aplicaticos|*.exe";
            }
            else if (Filtrar == Ficheiro.Filtrar.Tudo)
            {
                openFileDialog.Filter = "Todos os Ficheiros|*.*";
            }
            string caminho = "";
            string nome = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = openFileDialog.FileName;
                nome = openFileDialog.SafeFileName;
            }
            else
            {
                return;
            }
            Ficheiro.Caminho = caminho;
            Ficheiro.Nome = nome;
            
        }
        public void Abrir(string Filtrar)
        {
            string caminho = "";
            string nome = "";
            openFileDialog.Filter = Filtrar;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nome = openFileDialog.SafeFileName;
                caminho = openFileDialog.FileName;
            }
            else
            {
                return;
            }
            Ficheiro.Caminho = caminho;
            Ficheiro.Nome = nome;
            
        }
        public string Abrir(Ficheiro.Filtrar Filtrar, PictureBox Imagem)
        {
            if (Filtrar == Ficheiro.Filtrar.Imagem)
            {
                openFileDialog.Filter = "Jpg|*.jpg|Png|*.png";
            }
            else if (Filtrar == Ficheiro.Filtrar.Aplicativos)
            {
                openFileDialog.Filter = "Aplicaticos|*.exe";
            }
            else if (Filtrar == Ficheiro.Filtrar.Tudo)
            {
                openFileDialog.Filter = "Todos os Ficheiros|*.*";
            }
            string caminho = "";
            string nome = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nome = openFileDialog.SafeFileName;
                caminho = openFileDialog.FileName;
                Imagem.ImageLocation = caminho;
                return caminho;
            }
            Ficheiro.Caminho = caminho;
            Ficheiro.Nome = nome;
            return caminho;
        }
        public void Abrir(string Filtrar,PictureBox Imagem)
        {
            string caminho = "";
            string nome = "";
            openFileDialog.Filter = Filtrar;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nome = openFileDialog.SafeFileName;
                caminho = openFileDialog.FileName;
               
                Imagem.ImageLocation = caminho;
            }
            else
            {
                return;
            }
            Ficheiro.Caminho = caminho;
            Ficheiro.Nome = nome;
        }
       

        public struct Ficheiro
        {
            public enum Filtrar { Imagem,Aplicativos,Tudo};

            public static string Caminho;
            public static string Nome;
        }
        

        // Criar Objecto
        private ErrorProvider Erro;
        private OpenFileDialog openFileDialog;

        // Offline
        public static void Offline(bool c = false)
        {
            Nome = string.Empty;
            Apelido = string.Empty;
            Nome_Usuario = string.Empty;
            Email = string.Empty;
            Codigo = string.Empty;
            Senha = string.Empty;
            Telefone = string.Empty;
            Localidade = string.Empty;
            Sexo = string.Empty;
            Nascimento = DateTime.Today;
            Imagem = string.Empty;
            if (c)
            {
                S_CriarConta_Nome.Nome = "";
                S_CriarConta_Nome.Apelido = "";

                S_CriarConta_Validar.Username = "";
                S_CriarConta_Validar.Email = "";
                S_CriarConta_Validar.Code = "";

                S_CriarConta_Senha.Senha = "";
                S_CriarConta_Senha.Dicas = "";

                S_CriarConta_Perfil.Dicas = "";
            }
        }
        public static void Deletar()
        {
            Banco.Query($"delete from perfil where id = '{Id}';");
            Banco.Query($"delete from usuario where id = '{Id}';");
            Login();
        }

        public static void Login()
        {
            S_Usuario sun = new S_Usuario();
            sun.Dock = DockStyle.Fill;
            F_Principal.Principal.pn_Ferramentas.Visible = false;
            F_Principal.Principal.pn_Titulo.Visible = false;
            F_Principal.Principal.bt_Conta.Visible = false;
            F_Principal.Principal.bt_Banco.Visible = true;
            F_Principal.Principal.bt_Reiniciar.Enabled = false;
            F_Principal.Principal.bt_Reiniciar.Visible = false;
            F_Principal.Principal.pn_Publico.Controls.Clear();
            Offline(true);
            F_Principal.Principal.pn_Publico.Controls.Add(sun);
            F_Principal.Principal.pn_Publico.Controls[sun.Name].Focus();
        }

        public static void Criar()
        {
            S_CriarConta Formulario = new S_CriarConta();
            if (F_Principal.Principal.pn_Publico.Controls.Count > 0)
                F_Principal.Principal.pn_Publico.Controls.Clear();
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            F_Principal.Principal.pn_Publico.Controls.Add(Formulario);
            F_Principal.Principal.pn_Publico.Tag = Formulario;
           
            Formulario.Show();
            F_Principal.Principal.Imagem = F_Principal.ts_CriarConta.Image;
            F_Principal.Principal.textoFlow = F_Principal.ts_CriarConta.Text;
        }
    }

}
