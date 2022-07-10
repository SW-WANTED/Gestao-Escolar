
namespace Design_WhiteMode_Modern
{
    partial class S_Usuario_Senha
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pPassword = new System.Windows.Forms.Panel();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.bt_Entrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.llblResetPassword = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.tlp_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.tlp_Controls.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPassword
            // 
            this.pPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pPassword.Controls.Add(this.tb_Senha);
            this.pPassword.Controls.Add(this.bt_Entrar);
            this.pPassword.Location = new System.Drawing.Point(92, 278);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(315, 26);
            this.pPassword.TabIndex = 0;
            // 
            // tb_Senha
            // 
            this.tb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Senha.Location = new System.Drawing.Point(58, 0);
            this.tb_Senha.MaxLength = 30;
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(200, 26);
            this.tb_Senha.TabIndex = 0;
            this.tb_Senha.UseSystemPasswordChar = true;
            this.tb_Senha.Enter += new System.EventHandler(this.tb_Senha_Enter);
            this.tb_Senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Senha_KeyUp);
            // 
            // bt_Entrar
            // 
            this.bt_Entrar.BackgroundImage = global::Design_WhiteMode_Modern.Properties.Resources.SubmitIcon;
            this.bt_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Entrar.FlatAppearance.BorderSize = 0;
            this.bt_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Entrar.Location = new System.Drawing.Point(258, 0);
            this.bt_Entrar.Name = "bt_Entrar";
            this.bt_Entrar.Size = new System.Drawing.Size(26, 26);
            this.bt_Entrar.TabIndex = 1;
            this.bt_Entrar.UseVisualStyleBackColor = true;
            this.bt_Entrar.Click += new System.EventHandler(this.bt_Entrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(3, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 94);
            this.panel1.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(200)))), ((int)(((byte)(172)))));
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(494, 94);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Emanuel Carneiro dos Santos";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblResetPassword
            // 
            this.llblResetPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(215)))), ((int)(((byte)(187)))));
            this.llblResetPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.llblResetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblResetPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(170)))), ((int)(((byte)(218)))));
            this.llblResetPassword.Location = new System.Drawing.Point(193, 0);
            this.llblResetPassword.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.llblResetPassword.Name = "llblResetPassword";
            this.llblResetPassword.Size = new System.Drawing.Size(140, 30);
            this.llblResetPassword.TabIndex = 1;
            this.llblResetPassword.TabStop = true;
            this.llblResetPassword.Text = "Esqueci a Senha";
            this.llblResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblResetPassword_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 3);
            this.panel2.TabIndex = 12;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUser.Image = global::Design_WhiteMode_Modern.Properties.Resources.Account_Blue_Transparent;
            this.pbUser.Location = new System.Drawing.Point(150, 7);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(200, 158);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 13;
            this.pbUser.TabStop = false;
            this.pbUser.WaitOnLoad = true;
            // 
            // tlp_Controls
            // 
            this.tlp_Controls.ColumnCount = 1;
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Controls.Controls.Add(this.pbUser, 0, 0);
            this.tlp_Controls.Controls.Add(this.panel1, 0, 1);
            this.tlp_Controls.Controls.Add(this.pPassword, 0, 2);
            this.tlp_Controls.Controls.Add(this.panel3, 0, 3);
            this.tlp_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Controls.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Controls.Location = new System.Drawing.Point(0, 3);
            this.tlp_Controls.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Controls.Name = "tlp_Controls";
            this.tlp_Controls.RowCount = 4;
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.Size = new System.Drawing.Size(500, 397);
            this.tlp_Controls.TabIndex = 3;
            this.tlp_Controls.Paint += new System.Windows.Forms.PaintEventHandler(this.tlp_Controls_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.llblResetPassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 81);
            this.panel3.TabIndex = 14;
            // 
            // S_Usuario_Senha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tlp_Controls);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Name = "S_Usuario_Senha";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.S_Sistema_Usuario_Senha_Load);
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.tlp_Controls.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Button bt_Entrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel llblResetPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.TableLayoutPanel tlp_Controls;
        private System.Windows.Forms.Panel panel3;
    }
}
