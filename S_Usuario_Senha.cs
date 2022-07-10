using Design_WhiteMode_Modern.SQL;
using System; 
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_Usuario_Senha : UserControl
    {
        Global g;
        public S_Usuario_Senha()
        {
            InitializeComponent();
            g = new Global();
        }

        private void S_Sistema_Usuario_Senha_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "";
            string sql = $@"select p.nome, p.imagem from perfil p
join usuario u
on u.id = p.id
where u.username = '{Global.Nome_Usuario}';";
            var dt = Banco.Query(sql);
            if (dt.Rows.Count > 0)
            {
                Global.Imagem = dt.Rows[0].ItemArray[1].ToString();
                lblUsername.Text = dt.Rows[0].ItemArray[0].ToString();
                if (File.Exists(Global.Imagem))
                {
                    pbUser.Image = Image.FromFile(Global.Imagem);
                }

            }
            tb_Senha.Focus();
        }

        private void llblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esqueci(new S_Usuario_Esqueci());
        }

        private void Esqueci(object o)
        {
            Control s = o as Control;
            if (!S_Usuario.pn_Publico.Controls.ContainsKey(s.Name))
            {
                s.Dock = DockStyle.Fill;
                S_Usuario.pn_Publico.Controls.Add(s);
            }

            S_Usuario.pn_Publico.Controls[s.Name].BringToFront();
            S_Usuario.pn_Buttons.Visible = false;
        }

        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            var dt = Banco.Query($@"SELECT 
                                            p.Nome,
                                            p.Apelido,
                                            u.username,
                                            u.email,
                                            u.code,
                                            u.senha,
                                            u.telefone,
                                            p.localidade,
                                            p.imagem,
                                            p.sexo,
                                            p.nascimento
                                        FROM
                                            usuario u
                                                JOIN
                                            perfil p ON p.id = u.id
                                        WHERE
                                            u.username = '{Global.Nome_Usuario}' 
                                                AND 
                                            u.senha = '{tb_Senha.Text}';");
            if (dt.Rows.Count > 0)
            {
                string senha = dt.Rows[0].ItemArray[5].ToString();
                if (tb_Senha.Text == senha)
                {
                    Global.Nome = dt.Rows[0].ItemArray[0].ToString();
                    Global.Apelido = dt.Rows[0].ItemArray[1].ToString();
                    Global.Email = dt.Rows[0].ItemArray[3].ToString();
                    Global.Codigo = dt.Rows[0].ItemArray[4].ToString();
                    Global.Senha = senha;
                    Global.Telefone = dt.Rows[0].ItemArray[6].ToString();
                    Global.Localidade = dt.Rows[0].ItemArray[7].ToString();
                    Global.Imagem = dt.Rows[0].ItemArray[8].ToString();
                    Global.Sexo = dt.Rows[0].ItemArray[9].ToString();
                    if (!string.IsNullOrEmpty(dt.Rows[0].ItemArray[10].ToString()))
                    {
                        Global.Nascimento = DateTime.Parse(dt.Rows[0].ItemArray[10].ToString());
                    }
                    Adicionar(new F_Inicio());
                }
                else g.Errar(tb_Senha, "A palavra-passe está incorrreta", true);
            }
            else g.Errar(tb_Senha, "A palavra-passe está incorrreta", true);
        }
        private void Adicionar(Control C)
        {
            F_Principal.Principal.pn_Publico.Controls.Clear();
            if (!F_Principal.Principal.pn_Publico.Controls.ContainsKey(C.Name))
            {
                C.Dock = DockStyle.Fill;
                F_Principal.Principal.pn_Publico.Controls.Add(C);
                F_Principal.Principal.pn_Titulo.Visible = true;
                F_Principal.Principal.pn_Ferramentas.Visible = true;
                F_Principal.Principal.bt_Conta.Visible = true;
                F_Principal.Principal.bt_Banco.Visible = false;
                F_Principal.Principal.bt_Conta.BackgroundImage = pbUser.Image;
                F_Principal.Principal.tT_Conta.SetToolTip(F_Principal.Principal.bt_Conta, Global.Apelido); 
                F_Principal.Principal.Imagem = F_Principal.Principal.Tool_Inicio.Image;
                F_Principal.Principal.textoFlow = F_Principal.Principal.Tool_Inicio.Text;
            }
            F_Principal.Principal.pn_Publico.Controls[C.Name].BringToFront();
        }

        private void tb_Senha_Enter(object sender, EventArgs e)
        {
            g.Errar(tb_Senha, null);
        }

        private void tlp_Controls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_Senha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dt = Banco.Query($@"SELECT 
                                            p.Nome,
                                            p.Apelido,
                                            u.username,
                                            u.email,
                                            u.code,
                                            u.senha,
                                            u.telefone,
                                            p.localidade,
                                            p.imagem,
                                            p.sexo,
                                            p.nascimento
                                        FROM
                                            usuario u
                                                JOIN
                                            perfil p ON p.id = u.id
                                        WHERE
                                            u.username = '{Global.Nome_Usuario}' 
                                                AND 
                                            u.senha = '{tb_Senha.Text}';");
                if (dt.Rows.Count > 0)
                {
                    string senha = dt.Rows[0].ItemArray[5].ToString();
                    if (tb_Senha.Text == senha)
                    {
                        Global.Nome = dt.Rows[0].ItemArray[0].ToString();
                        Global.Apelido = dt.Rows[0].ItemArray[1].ToString();
                        Global.Email = dt.Rows[0].ItemArray[3].ToString();
                        Global.Codigo = dt.Rows[0].ItemArray[4].ToString();
                        Global.Senha = senha;
                        Global.Telefone = dt.Rows[0].ItemArray[6].ToString();
                        Global.Localidade = dt.Rows[0].ItemArray[7].ToString();
                        Global.Imagem = dt.Rows[0].ItemArray[8].ToString();
                        Global.Sexo = dt.Rows[0].ItemArray[9].ToString();
                        if (!string.IsNullOrEmpty(dt.Rows[0].ItemArray[10].ToString()))
                        {
                            Global.Nascimento = DateTime.Parse(dt.Rows[0].ItemArray[10].ToString());
                        }
                        Adicionar(new F_Inicio());
                    }
                    else g.Errar(tb_Senha, "A palavra-passe está incorrreta", true);
                }
                else g.Errar(tb_Senha, "A palavra-passe está incorrreta", true);
            }
        }
    }
}
