using System;
using System.Windows.Forms;
using System.IO;

namespace Design_WhiteMode_Modern
{
    public partial class S_Banco : UserControl
    {
        int change = 0;
        public S_Banco()
        {
            InitializeComponent();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                // Propriedades
                string folder = Global.Caminho_dados;
                string senha = tb_Senha.Text;
                string banco = tb_Banco.Text;
                string senhaPath = folder + "senha.txt";
                string bancoPath = folder + "banco.txt";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                StreamWriter sw = new StreamWriter(senhaPath);
                sw.Write(senha);
                sw.Close();
                StreamWriter ws = new StreamWriter(bancoPath);
                ws.Write(banco);
                ws.Close();
                MessageBox.Show("Os dados foram salvos com sucesso", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                change = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void S_Banco_Load(object sender, EventArgs e)
        {
            tb_Senha.Text = Global.Server_Password;
            tb_Banco.Text = Global.Server_Database;
            F_Principal.Principal.bt_Reiniciar.Enabled = true;
            F_Principal.Principal.bt_Reiniciar.Visible = true;
            change = 1;
        }

        private void bt_Testar_Click(object sender, EventArgs e)
        {
            try
            {
                string senha = tb_Senha.Text;
                string banco = tb_Banco.Text;
                SQL.Banco.strBanco = $"server={Global.Server};user id={Global.Server_Username};pwd={senha};database={banco};";
                SQL.Banco.conexao();
                if (Global.Server_Status)
                {

                    MessageBox.Show("A conexão foi bem sucedida", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Parece que esta configuração está incorrecta", Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQL.Banco.strBanco = $"server={Global.Server};user id={Global.Server_Username};pwd={Global.Server_Password};database={Global.Server_Database};";
                change = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (change >=2)
            {
                if (MessageBox.Show("O aplicativo precisa ser reiniciado para salvar as alterações, pretende reiniciar o aplicativo?", Global.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    Global.Login();
                }
                else
                {
                    Application.Restart();
                }
            }
            else
            {
                Global.Login();
            }
        }
    }
}
