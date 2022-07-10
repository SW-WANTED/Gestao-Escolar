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
using Design_WhiteMode_Modern.SQL;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class F_Inicio : UserControl
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr handle, int a, int b, int c);

        public static F_Inicio Inicio;
        public ContextMenuStrip CP_Publico
        { get { return Contexto_Principal; }
    set { Contexto_Principal = value; } }
        public F_Inicio()
        {
            InitializeComponent();
            Inicio = this;
        }

        bool isLoad = false;
        private void Adicionar(Control C)
        {
            if (!F_Principal.Principal.pn_Publico.Controls.ContainsKey("" + C.Name))
            {
                C.Dock = DockStyle.Fill;
                F_Principal.Principal.pn_Publico.Controls.Add(C);
            }
            F_Principal.Principal.pn_Publico.Controls["" + C.Name].BringToFront();
        }
        private void bt_Apagar_Click(object sender, EventArgs e)
        {
            bt_Apagar.Visible = false;
            tb_Procurar.Clear();
            tb_Procurar.Focus();
            
        }

        private void tb_Procurar_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_Procurar.Text.Length == 0)
                bt_Apagar.Visible = false;
            else bt_Apagar.Visible = true;
        }
        private void tb_Procurar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Procurar.Text))
            {
                tb_Procurar.Text = "Encontrar alunos";
                bt_Apagar.Visible = true;
            }
                
        }

        private void tb_Procurar_Enter(object sender, EventArgs e)
        {
            if (tb_Procurar.Text == "Encontrar alunos")
            {
                tb_Procurar.Clear();
                bt_Apagar.Visible = false;
            }
        }

        private void CP_Pesquisar_Click(object sender, EventArgs e)
        {
            //Adicionar(new F_Inicio());
            //F_Principal.Principal.Imagem = F_Principal.Principal.Tool_Inicio.Image;
            //F_Principal.Principal.textoFlow = F_Principal.Principal.Tool_Inicio.Text;
            
            Cursor.Position = new System.Drawing.Point(1303, 275);
            tb_Procurar.Focus();
        }

        private void CP_Adicionar_Novo_Aluno_Click(object sender, EventArgs e)
        {
            
            F_Principal.Principal.Imagem = CP_Adicionar_Novo_Aluno.Image;
            F_Principal.Principal.textoFlow = CP_Adicionar_Novo_Aluno.Text;
            Adicionar(new A_Novo_Aluno());
        }

        private void CP_Adicionar_Novo_Professor_Click(object sender, EventArgs e)
        {
            F_Principal.Principal.Imagem = CP_Adicionar_Novo_Professor.Image;
            F_Principal.Principal.textoFlow = CP_Adicionar_Novo_Professor.Text;
            Adicionar(new P_Novo_Professor());
        }

        private void CP_Adicionar_Novo_Funcionario_Click(object sender, EventArgs e)
        {
            F_Principal.Principal.Imagem = CP_Adicionar_Novo_Funcionario.Image;
            F_Principal.Principal.textoFlow = CP_Adicionar_Novo_Funcionario.Text;
            Adicionar(new F_Novo_Funcionario());
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            sairToolStripMenuItem.Image = Properties.Resources.bt_Sair_Preto_Min;
            sairToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void sairToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            sairToolStripMenuItem.Image = Properties.Resources.bt_Sair_Branco_Min;
            sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        private void ReiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void F_Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(F_Principal.Principal.Handle, 0x112, 0xf012, 0);
        }

   
        private void F_Inicio_Load(object sender, EventArgs e)
        {
            isLoad = true;
            Carregar();
            isLoad = false;
        }
        private void Carregar()
        {
            pb_Foto.Image = Properties.Resources.Cadastrar;
            tb_Nome.Text = "A escola não possui novos alunos";
            tb_Turma.Text = "";
            DataTable dt = new DataTable();
            string queryAluno = $@"SELECT 
                                        a.imagem, a.Nome, t.descricao
                                    FROM
                                        aluno a
                                            JOIN
                                        turma t ON a.idturma = t.id
                                    ORDER BY a.id DESC;";
            string queryAlunoUpdate = $@"
                                    SELECT 
                                        p.apelido, a.create_time, a.Nome, t.descricao
                                    FROM
                                        aluno a
                                            INNER JOIN
                                        perfil p ON a.idsecretario = p.id
                                            INNER JOIN
                                        turma t ON t.id = a.idturma
                                    ORDER BY a.create_time DESC;";
            string queryConta = $@"
                               SELECT 
                                    p.Nome, u.create_time, p.sexo
                                FROM
                                    perfil p
                                        INNER JOIN
                                    usuario u ON p.id = u.id
                                ORDER BY p.id DESC; ";
            string queryTurma = $@"
                                    SELECT 
                                        t.descricao, t.update_time, p.professor, h.descricao, t.Maxalunos
                                    FROM
                                        turma AS t
                                            INNER JOIN
                                        professor AS p ON p.id = t.idprofessor
                                            INNER JOIN
                                        horario h ON t.idhorario = h.id
                                    ORDER BY t.id desc;";
            string queryHorario = $@"
                                    SELECT 
                                        descricao, update_time
                                    FROM
                                        horario
                                     ORDER BY id desc;";
            string queryProfessor = $@"
                                    SELECT 
                                        pl.Apelido,pr.create_time, pr.professor, pl.sexo
                                    FROM
                                        professor pr
                                            INNER JOIN
                                        perfil pl ON pr.idsecretario = pl.id
                                    ORDER BY pr.id desc;";
            string queryfuncionario = $@"
                                        SELECT 
                                            pl.Apelido,f.create_time, f.Nome, f.cargo
                                        FROM
                                            funcionario f
                                                INNER JOIN
                                            perfil pl ON f.idsecretario = pl.id
                                        ORDER BY f.id desc;";
            dt = Banco.Query(queryAluno);
            if (dt.Rows.Count > 0)
            {
                string path = dt.Rows[0].ItemArray[0].ToString();
                if (File.Exists(path)) pb_Foto.ImageLocation = path;
                tb_Nome.Text = dt.Rows[0].ItemArray[1].ToString();
                tb_Turma.Text = "Entrou na Turma de " + dt.Rows[0].ItemArray[2].ToString();
            }
            dt = Banco.Query(queryAlunoUpdate);
            if (dt.Rows.Count > 0)
            {
                string apelido = dt.Rows[0].ItemArray[0].ToString();
                DateTime data = DateTime.Parse(dt.Rows[0].ItemArray[1].ToString());
                string estudante = dt.Rows[0].ItemArray[2].ToString();
                string turma = dt.Rows[0].ItemArray[2].ToString();
                string texto = $"Um(a) estudante chamado(a) {estudante}, foi matriculado pelo {apelido}";

                Texto_1.Text = texto;
                if (DateTime.Today.Date != data.Date)
                {
                    Tempo_1.Text = data.ToLongDateString() + " ás " + data.ToString("HH:mm");
                }
                else
                {
                    Tempo_1.Text = data.ToString("HH:mm:ss");
                }
            }
            dt = Banco.Query(queryConta);
            if (dt.Rows.Count > 0)
            {
                string nome = dt.Rows[0].ItemArray[0].ToString();
                DateTime data = DateTime.Parse(dt.Rows[0].ItemArray[1].ToString());
                string sexo = dt.Rows[0].ItemArray[2].ToString();
                string texto = $"Um(a) novo(a) secretário(a) chamado(a) {nome}, agora tem acesso a gestão da escola";
                if (sexo == "F")
                {
                    texto = $"A nova secretária chamada {nome}, agora tem acesso a gestão da escola";
                }
                else if(sexo == "M")
                {
                    texto = $"O novo secretário chamado {nome}, agora tem acesso a gestão da escola";
                }
                Texto_2_1.Text = texto;
                if (DateTime.Today.Date != data.Date)
                {
                    Tempo_2_1.Text = data.ToLongDateString() + " ás " + data.ToString("HH:mm");
                }
                else
                {
                    Tempo_2_1.Text = data.ToString("HH:mm:ss");
                }
            }
            dt = Banco.Query(queryTurma);
            if (dt.Rows.Count > 0)
            {
                string turma = dt.Rows[0].ItemArray[0].ToString();
                DateTime data = DateTime.Parse(dt.Rows[0].ItemArray[1].ToString());
                string professor = dt.Rows[0].ItemArray[2].ToString();
                string horario = dt.Rows[0].ItemArray[3].ToString();
                if (DateTime.Today.Date != data.Date)
                {
                    Tempo_2.Text = data.ToLongDateString() + " ás " + data.ToString("HH:mm");
                }
                else
                {
                    Tempo_2.Text = data.ToString("HH:mm:ss");
                }
                Texto_2.Text = $"Nova turma de {turma}, com o(a) professor(a) {professor} às {horario}";
            }
            dt = Banco.Query(queryHorario);
            if (dt.Rows.Count > 0)
            {
                string horario = dt.Rows[0].ItemArray[0].ToString();
                DateTime data = DateTime.Parse(dt.Rows[0].ItemArray[1].ToString());
                if (DateTime.Today.Date != data.Date)
                {
                    Tempo_3.Text = data.ToLongDateString() + " ás " + data.ToString("HH:mm");
                }
                else
                {
                    Tempo_3.Text = data.ToString("HH:mm:ss");
                }
                Texto_3.Text = $"Novo horário marcado para às {horario}";
            }
            dt = Banco.Query(queryProfessor);
            if (dt.Rows.Count > 0)
            {
                string apelido = dt.Rows[0].ItemArray[0].ToString();
                DateTime data = DateTime.Parse(dt.Rows[0].ItemArray[1].ToString());
                string professor = dt.Rows[0].ItemArray[2].ToString();
                string sexo = dt.Rows[0].ItemArray[3].ToString();
                string texto = $"Um(a) secretário(a) {apelido} cadastrou um(a) professor(a) chamado(a) {professor}";
                if (sexo == "F")
                {
                    texto = $"A secretária {apelido} cadastrou um(a) professor(a) chamado(a) {professor}";
                }
                else if (sexo == "M")
                {
                    texto = $"O secretário {apelido} cadastrou um(a) professor(a) chamado(a) {professor}";
                }
                if (DateTime.Today.Date != data.Date)
                {
                    Tempo_2_2.Text = data.ToLongDateString() + " ás " + data.ToString("HH:mm");
                }
                else
                {
                    Tempo_2_2.Text = data.ToString("HH:mm:ss");
                }
                Texto_2_2.Text = texto;
            }
            dt = Banco.Query(queryfuncionario);
            if (dt.Rows.Count > 0)
            {
                string apelido = dt.Rows[0].ItemArray[0].ToString();
                DateTime data = DateTime.Parse(dt.Rows[0].ItemArray[1].ToString());
                string funcionario = dt.Rows[0].ItemArray[2].ToString();
                string cargo = dt.Rows[0].ItemArray[3].ToString();
                if (DateTime.Today.Date != data.Date)
                {
                    Tempo_2_3.Text = data.ToLongDateString() + " ás " + data.ToString("HH:mm");
                }
                else
                {
                    Tempo_2_3.Text = data.ToString("HH:mm:ss");
                }
                Texto_2_3.Text = $"Um(a) {cargo} denominado(a) {funcionario} foi aprovado(a) para trabalhar na escola";
            }
        }

        private void F_Inicio_Enter(object sender, EventArgs e)
        { 
            if (isLoad)
            {
                Carregar();
            }
        }

    }
}
