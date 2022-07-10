using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Design_WhiteMode_Modern
{
    public partial class S_Usuario : UserControl
    {
        public static Panel pn_Publico { get; set; }
        public static TableLayoutPanel pn_Buttons { get; set; }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr Handle, int a, int b, int c);

        public S_Usuario()
        {
            InitializeComponent();
            pn_Publico = this.pn_Principal;
            pn_Buttons = this.pn_botoes;
        }

        private void S_Usuario_Load(object sender, EventArgs e)
        {
            Adicionar(new S_Usuario_Nome()); 
        }
        private void Adicionar(Control C)
        {
            S_Usuario_Senha us = new S_Usuario_Senha();
            if (pn_Principal.Controls.ContainsKey(us.Name))
            {
                pn_Principal.Controls.RemoveByKey(us.Name);
            }
            if (!pn_Principal.Controls.ContainsKey(C.Name))
            {
                C.Dock = DockStyle.Fill;
                pn_Principal.Controls.Add(C);
            }
            pn_Principal.Controls[C.Name].BringToFront();
            pn_Principal.Controls[C.Name].Focus();
        }

        private void bt_Proximo_Click(object sender, EventArgs e)
        {

        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            pn_Buttons.Visible = false;
            Adicionar(new S_Usuario_Nome());
        }

        private void S_Usuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(F_Principal.Principal.Handle, 0x112, 0xf012, 0);
        }
    }
}
