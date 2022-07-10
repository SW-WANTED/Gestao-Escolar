using System;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_CriarConta : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr Handle, int a, int b, int c);
        public static Panel pn_Publico { get; set; }
        public S_CriarConta()
        {
            InitializeComponent();
            pn_Publico = this.pn_Principal;
            Adicionar(new S_CriarConta_Nome());
        }
        private void F_Sistema_CriarConta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(F_Principal.Principal.Handle, 0x112, 0xf012, 0);
        }
        private void Adicionar(Control C)
        {

            if (!pn_Principal.Controls.ContainsKey("" + C.Name))
            {
                C.Dock = DockStyle.Fill;
                pn_Principal.Controls.Add(C);
            }
            pn_Principal.Controls["" + C.Name].BringToFront();
        }

        private void pn_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //private void bt_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (bt_MostrarSenha.Checked == true)
        //        tb_Senha.UseSystemPasswordChar = false;
        //    else tb_Senha.UseSystemPasswordChar = true;
        //}

        //private void bt_MostrarSenha_MouseEnter(object sender, EventArgs e)
        //{
        //    if (bt_MostrarSenha.Checked == true)
        //        bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.FlatAppearance.CheckedBackColor;
        //    else bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.BackColor;
        //}

        //private void bt_MostrarSenha_Click(object sender, EventArgs e)
        //{
        //    if (bt_MostrarSenha.Checked == true)
        //        bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.FlatAppearance.CheckedBackColor;
        //    else bt_MostrarSenha.FlatAppearance.MouseOverBackColor = bt_MostrarSenha.BackColor;
        //}
    }
}
