
namespace Design_WhiteMode_Modern
{
    partial class S_Usuario_Nome
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
            this.components = new System.ComponentModel.Container();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.pPassword = new System.Windows.Forms.Panel();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.bt_Ir = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_CriarConta = new System.Windows.Forms.LinkLabel();
            this.Erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpControls.SuspendLayout();
            this.pPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpControls
            // 
            this.tlpControls.AutoSize = true;
            this.tlpControls.BackColor = System.Drawing.Color.Transparent;
            this.tlpControls.ColumnCount = 1;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Controls.Add(this.pPassword, 0, 2);
            this.tlpControls.Controls.Add(this.lblUsername, 0, 1);
            this.tlpControls.Controls.Add(this.pbUser, 0, 0);
            this.tlpControls.Controls.Add(this.panel1, 0, 3);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 4;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpControls.Size = new System.Drawing.Size(500, 400);
            this.tlpControls.TabIndex = 0;
            // 
            // pPassword
            // 
            this.pPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pPassword.Controls.Add(this.tb_Nome);
            this.pPassword.Controls.Add(this.bt_Ir);
            this.pPassword.Location = new System.Drawing.Point(92, 315);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(315, 30);
            this.pPassword.TabIndex = 0;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Nome.Location = new System.Drawing.Point(58, 0);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(200, 26);
            this.tb_Nome.TabIndex = 0;
            this.tb_Nome.Enter += new System.EventHandler(this.tb_Nome_Enter);
            this.tb_Nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Nome_KeyUp);
            // 
            // bt_Ir
            // 
            this.bt_Ir.BackgroundImage = global::Design_WhiteMode_Modern.Properties.Resources.SubmitIcon;
            this.bt_Ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Ir.FlatAppearance.BorderSize = 0;
            this.bt_Ir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.bt_Ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ir.Location = new System.Drawing.Point(258, 0);
            this.bt_Ir.Name = "bt_Ir";
            this.bt_Ir.Size = new System.Drawing.Size(26, 26);
            this.bt_Ir.TabIndex = 2;
            this.bt_Ir.UseVisualStyleBackColor = true;
            this.bt_Ir.Click += new System.EventHandler(this.bt_Ir_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(3, 206);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(494, 106);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nome de Usuário";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUser.Image = global::Design_WhiteMode_Modern.Properties.Resources.Untitled_11;
            this.pbUser.Location = new System.Drawing.Point(150, 3);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(200, 200);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.link_CriarConta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 46);
            this.panel1.TabIndex = 1;
            // 
            // link_CriarConta
            // 
            this.link_CriarConta.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.link_CriarConta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(170)))), ((int)(((byte)(218)))));
            this.link_CriarConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.link_CriarConta.AutoEllipsis = true;
            this.link_CriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_CriarConta.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.link_CriarConta.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_CriarConta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(215)))), ((int)(((byte)(187)))));
            this.link_CriarConta.Location = new System.Drawing.Point(202, 0);
            this.link_CriarConta.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.link_CriarConta.Name = "link_CriarConta";
            this.link_CriarConta.Size = new System.Drawing.Size(113, 30);
            this.link_CriarConta.TabIndex = 3;
            this.link_CriarConta.TabStop = true;
            this.link_CriarConta.Text = "  Criar Conta";
            this.link_CriarConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_CriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_CriarConta_LinkClicked);
            // 
            // Erro
            // 
            this.Erro.BlinkRate = 100;
            this.Erro.ContainerControl = this;
            this.Erro.RightToLeft = true;
            // 
            // S_Usuario_Nome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tlpControls);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Name = "S_Usuario_Nome";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.S_Sistema_Usuario_Nome_Load);
            this.tlpControls.ResumeLayout(false);
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button bt_Ir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider Erro;
        private System.Windows.Forms.LinkLabel link_CriarConta;
        private System.Windows.Forms.TextBox tb_Nome;
    }
}
