
namespace Design_WhiteMode_Modern
{
    partial class S_Usuario_Esqueci
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
            this.pn_Cor = new System.Windows.Forms.Panel();
            this.tlp_Principal = new System.Windows.Forms.TableLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.pn_Bottom = new System.Windows.Forms.Panel();
            this.pn_botoes = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.pn_Code = new System.Windows.Forms.Panel();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.bt_Ir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.tlp_Principal.SuspendLayout();
            this.pn_Bottom.SuspendLayout();
            this.pn_botoes.SuspendLayout();
            this.pn_Code.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Cor
            // 
            this.pn_Cor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(170)))), ((int)(((byte)(218)))));
            this.pn_Cor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Cor.Location = new System.Drawing.Point(0, 0);
            this.pn_Cor.Name = "pn_Cor";
            this.pn_Cor.Size = new System.Drawing.Size(500, 3);
            this.pn_Cor.TabIndex = 0;
            // 
            // tlp_Principal
            // 
            this.tlp_Principal.ColumnCount = 1;
            this.tlp_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Principal.Controls.Add(this.lblCode, 0, 1);
            this.tlp_Principal.Controls.Add(this.pn_Bottom, 0, 3);
            this.tlp_Principal.Controls.Add(this.pn_Code, 0, 2);
            this.tlp_Principal.Controls.Add(this.panel1, 0, 0);
            this.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Principal.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Principal.Location = new System.Drawing.Point(0, 3);
            this.tlp_Principal.Name = "tlp_Principal";
            this.tlp_Principal.RowCount = 4;
            this.tlp_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tlp_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlp_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Principal.Size = new System.Drawing.Size(500, 397);
            this.tlp_Principal.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semilight", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblCode.Location = new System.Drawing.Point(3, 199);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(494, 88);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "Código de Acesso";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_Bottom
            // 
            this.pn_Bottom.Controls.Add(this.pn_botoes);
            this.pn_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Bottom.Location = new System.Drawing.Point(3, 342);
            this.pn_Bottom.Name = "pn_Bottom";
            this.pn_Bottom.Size = new System.Drawing.Size(494, 52);
            this.pn_Bottom.TabIndex = 17;
            this.pn_Bottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Bottom_Paint);
            // 
            // pn_botoes
            // 
            this.pn_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_botoes.ColumnCount = 2;
            this.pn_botoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pn_botoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pn_botoes.Controls.Add(this.bt_Voltar, 0, 0);
            this.pn_botoes.Controls.Add(this.bt_Proximo, 1, 0);
            this.pn_botoes.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.pn_botoes.Location = new System.Drawing.Point(244, 9);
            this.pn_botoes.Name = "pn_botoes";
            this.pn_botoes.RowCount = 1;
            this.pn_botoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pn_botoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pn_botoes.Size = new System.Drawing.Size(250, 40);
            this.pn_botoes.TabIndex = 16;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Voltar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Voltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Voltar.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Voltar.Location = new System.Drawing.Point(3, 3);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(119, 34);
            this.bt_Voltar.TabIndex = 1;
            this.bt_Voltar.Text = "&Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = false;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // bt_Proximo
            // 
            this.bt_Proximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Proximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Proximo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Proximo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Proximo.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Proximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Proximo.Location = new System.Drawing.Point(128, 3);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(119, 34);
            this.bt_Proximo.TabIndex = 0;
            this.bt_Proximo.Text = "&Criar uma conta";
            this.bt_Proximo.UseVisualStyleBackColor = false;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
            // 
            // pn_Code
            // 
            this.pn_Code.Controls.Add(this.tb_Code);
            this.pn_Code.Controls.Add(this.bt_Ir);
            this.pn_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Code.Location = new System.Drawing.Point(3, 290);
            this.pn_Code.Name = "pn_Code";
            this.pn_Code.Size = new System.Drawing.Size(494, 46);
            this.pn_Code.TabIndex = 18;
            // 
            // tb_Code
            // 
            this.tb_Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Code.Location = new System.Drawing.Point(137, 11);
            this.tb_Code.MaxLength = 30;
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(200, 26);
            this.tb_Code.TabIndex = 3;
            this.tb_Code.Enter += new System.EventHandler(this.tb_Code_Enter);
            // 
            // bt_Ir
            // 
            this.bt_Ir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Ir.BackgroundImage = global::Design_WhiteMode_Modern.Properties.Resources.SubmitIcon;
            this.bt_Ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Ir.FlatAppearance.BorderSize = 0;
            this.bt_Ir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.bt_Ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ir.Location = new System.Drawing.Point(337, 11);
            this.bt_Ir.Name = "bt_Ir";
            this.bt_Ir.Size = new System.Drawing.Size(26, 26);
            this.bt_Ir.TabIndex = 4;
            this.bt_Ir.UseVisualStyleBackColor = true;
            this.bt_Ir.Click += new System.EventHandler(this.bt_Ir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_Foto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 193);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pb_Foto
            // 
            this.pb_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Foto.Image = global::Design_WhiteMode_Modern.Properties.Resources.Account_Blue_Transparent;
            this.pb_Foto.Location = new System.Drawing.Point(0, 0);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(494, 193);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Foto.TabIndex = 15;
            this.pb_Foto.TabStop = false;
            this.pb_Foto.WaitOnLoad = true;
            // 
            // S_Usuario_Esqueci
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tlp_Principal);
            this.Controls.Add(this.pn_Cor);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Name = "S_Usuario_Esqueci";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.S_Usuario_Esqueci_Load);
            this.tlp_Principal.ResumeLayout(false);
            this.pn_Bottom.ResumeLayout(false);
            this.pn_botoes.ResumeLayout(false);
            this.pn_Code.ResumeLayout(false);
            this.pn_Code.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Cor;
        private System.Windows.Forms.TableLayoutPanel tlp_Principal;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TableLayoutPanel pn_botoes;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Button bt_Proximo;
        private System.Windows.Forms.Panel pn_Bottom;
        private System.Windows.Forms.Panel pn_Code;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Button bt_Ir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Foto;
    }
}
