using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class F_bt_Conta : Form
    {
        public static F_bt_Conta Conta;
        public F_bt_Conta()
        {
            InitializeComponent();
            Conta = this;
        }

        private void F_bt_Conta_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Conta_Click(object sender, EventArgs e)
        {
            S_Definicoes d = new S_Definicoes();
            if (!F_Principal.Principal.pn_Publico.Controls.ContainsKey(d.Name))
            {
                d.Dock = DockStyle.Fill;
                F_Principal.Principal.pn_Publico.Controls.Add(d);
            }
            F_Principal.Principal.pn_Publico.Controls[d.Name].BringToFront();
            this.Close();
            F_Principal.Principal.Imagem = Properties.Resources.settings;
            F_Principal.Principal.textoFlow = "Definições de Conta";
        }

        private void F_bt_Conta_Load(object sender, EventArgs e)
        {
            tT_Logado.SetToolTip(bt_Conta, Global.Nome);
            tT_Logado.SetToolTip(pb_Foto, Global.Nome);
            txt_Email.Text = Global.Email;
            txt_Nome.Text = Global.Nome;
            if (File.Exists(Global.Imagem))
            {
                pb_Foto.Image = Image.FromFile(Global.Imagem);
            }
        }
    }
}