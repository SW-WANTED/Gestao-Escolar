/*Programador: Emanuel Carneiro dos Santos
 
 Nome Completo: Emanuel Carneiro dos Santos
 Escola: Instituto Politécnico Privado Elsamina
    Facebook: Emanuel Dos Santos : https://www.facebook.com/Emanuel.CDJS
    Youtube: SW Wanted : https://www.youtube.com/c/swwanted
    Instagram: @sw_wanted : https://www.instagram.com/sw_wanted
    Twitter: @SW_Wanted : https://www.twitter.com/sw_wanted
    Telefone (Unitel): +244933363523
    Telefone (Africell): +244951161450
 
 Classe: 12ª Classe
 Ano Académico: 2021/2022
 Data Atual: 22/05/2022
 Data de Nascimento: 27/03/2004
 
 */

/*Generate by Visual Studio 2019
 
 */

using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Design_WhiteMode_Modern
{
    public partial class F_Principal : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr Handle, int a, int b, int c);
        public  System.Drawing.Image Imagem { get { return Tool_Imagem.Image; } set { Tool_Imagem.Image = value; } }
        public string textoFlow { get { return Tool_Imagem.ToolTipText; } set { Tool_Imagem.ToolTipText = value; } }
        public Panel pn_Publico { get { return pn_Principal; } set { pn_Principal = value; } }
        public static F_Principal Principal;
        // S_Usuário_Nome
        public static ToolStripMenuItem ts_CriarConta { get; set; }
        public F_Principal()
        {
            InitializeComponent();
            if (BancoSave())
            {
                tT_Banco.SetToolTip(bt_Banco, "Conexão Estabelecida");
            }
            else
            {
                tT_Banco.SetToolTip(bt_Banco, "Sem Conexão");
            }

            Principal = this;
            ts_CriarConta = Menu_Sistema_CriarConta;
        }
        const int zero = 0X84;
        const int first = 1;
        const int second = 2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case zero:
                    if (m.Result == (IntPtr)first)
                    {
                        m.Result = (IntPtr)second;
                    }
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = (cp.Style | 262144);
                return cp;
            }

        }
        private void Adicionar(Control C, System.Drawing.Image imagem, string texto)
        {
            if (!pn_Principal.Controls.ContainsKey(C.Name))
            {
                C.Dock = DockStyle.Fill;
                pn_Principal.Controls.Add(C);
            }
            pn_Principal.Controls[C.Name].BringToFront();
            pn_Principal.Controls[C.Name].Focus();
            this.Imagem = imagem;
            this.textoFlow = texto;
        }
        private void Adicionar_Form(object i)
        {
            Form Formulario = i as Form;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            if (this.pn_Principal.Controls.Count > 0)
                this.pn_Principal.Controls.Clear();
            this.pn_Principal.Controls.Add(Formulario);
            this.pn_Principal.Tag = Formulario;
            Formulario.Show();
            Formulario.Focus();
        }
        private void F_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Ferramentas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Menu_Aluno_GestaoAluno_Click(object sender, EventArgs e)
        {
            Adicionar(new F_GestaoAluno(), Menu_Aluno_GestaoAluno.Image, Menu_Aluno_GestaoAluno.Text);
        }
       
        private void Tool_Inicio_Click(object sender, EventArgs e)
        {
            pn_Principal.Controls.Clear();
            Adicionar(new F_Inicio(),Tool_Inicio.Image, Tool_Inicio.Text);
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            // Resolução do aplicativo
            int largura = this.Width;
            int altura = this.Height;

            // Resolução da Tela
            int largura_tela = Screen.PrimaryScreen.Bounds.Width;
            int altura_tela = Screen.PrimaryScreen.Bounds.Height;

            if (largura > largura_tela)
            {
                int Rlargura = (largura - largura_tela) * 2;
                this.Width -= Rlargura;
                if (altura > altura_tela)
                {
                    int Raltura = (altura - altura_tela) * 2;
                    this.Height -= Raltura;
                }
            }

            Global.Login();
        }

        
        private void bt_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Aluno_NovoAluno_Click(object sender, EventArgs e)
        {
            Adicionar(new A_Novo_Aluno(), Menu_Aluno_NovoAluno.Image,Menu_Aluno_NovoAluno.Text);
        }

        private void Menu_Sistema_Usuario_Click(object sender, EventArgs e)
        {
            Adicionar(new S_Usuario(), Menu_Sistema_Usuario.Image,Menu_Sistema_Usuario.Text);
            
        }
       
        private void Menu_Sistema_CriarConta_Click(object sender, EventArgs e)
        {
            this.Imagem = Menu_Sistema_CriarConta.Image;
            this.textoFlow = Menu_Sistema_CriarConta.Text;
            Adicionar_Form(new S_CriarConta());

        }
        private void bt_Sair_MouseLeave(object sender, EventArgs e)
        {
            bt_Sair.Image = ((System.Drawing.Image)(Properties.Resources.bt_Sair_Preto_Min));
        }

        private void bt_Sair_MouseEnter(object sender, EventArgs e)
        {
            bt_Sair.Image = ((System.Drawing.Image)(Properties.Resources.bt_Sair_Branco_Min));
        }

        private void Menu_Sistema_Definicoes_Click(object sender, EventArgs e)
        { 
            Adicionar(new S_Definicoes(), Menu_Sistema_Definicoes.Image
, Menu_Sistema_Definicoes.Text
);
        }

        private void Menu_Escola_Horario_Click(object sender, EventArgs e)
        {
            Adicionar(new E_Horario(), Menu_Escola_Horario.Image,
Menu_Escola_Horario.Text
);
        }

        private void Menu_Funcionario_NovoFuncionario_Click(object sender, EventArgs e)
        {
            Adicionar(new F_Novo_Funcionario(), Menu_Funcionario_NovoFuncionario.Image
, Menu_Funcionario_NovoFuncionario.Text
);
        }

        private void F_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            pn_Principal.Controls.Clear();
        }

        private void bt_Conta_Click(object sender, EventArgs e)
        {
            F_bt_Conta c = new F_bt_Conta();
            c.Show();
        }

        private void Tool_Separador_1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Menu_Sistema_TerminarSessao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Terminar sessão no aplicativo", Global.Titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Global.Login();
            }
        }

        private void pn_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pn_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar(new E_Turma(), Menu_Escola_Turma.Image, Menu_Escola_Turma.Text);
        }

        private void Menu_Gestao_Funcionario_Click(object sender, EventArgs e)
        {
            Adicionar(new F_Gestao_Funcionario(), Menu_Gestao_Funcionario.Image, Menu_Gestao_Funcionario.Text);
        }

        private void Menu_Professor_Click(object sender, EventArgs e)
        {
            Adicionar(new P_Professor(), Menu_Professor.Image, Menu_Professor.Text);
        }

        private void Menu_Admin_Servicos_Click(object sender, EventArgs e)
        {
            Adicionar(new F_Servicos(), Menu_Admin_Servicos.Image, Menu_Admin_Servicos.Text);
        }

        private void bt_Banco_Click(object sender, EventArgs e)
        {
            Adicionar(new S_Banco(), bt_Conta.Image, "Banco de dados");
            bt_Reiniciar.Enabled = true;
            bt_Reiniciar.Visible = true;
        }

        private bool BancoSave()
        {
            string senha = Global.Server_Password;
            string banco = Global.Server_Database;
            string folders = Global.Caminho_dados + "senha.txt";
            string folderb = Global.Caminho_dados + "banco.txt";
            if (File.Exists(folders) || File.Exists(folderb))
            {
                StreamReader sr = new StreamReader(folders);
                senha = sr.ReadToEnd();
                StreamReader rs = new StreamReader(folderb);
                banco = rs.ReadToEnd();
                sr.Close();
                rs.Close();
            }
            Global.Server_Password = senha;
            Global.Server_Database = banco;
            SQL.Banco.strBanco = $"server={Global.Server};user id={Global.Server_Username};pwd={Global.Server_Password};database={Global.Server_Database};";
            SQL.Banco.conexao();
            bool status = Global.Server_Status;
            return status;
        }

        private void bt_Reiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
