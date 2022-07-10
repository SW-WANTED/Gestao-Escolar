
namespace Design_WhiteMode_Modern
{
    partial class S_CriarConta_Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_CriarConta_Perfil));
            this.pn_Principal = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Top = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Controles = new System.Windows.Forms.Panel();
            this.tlp_control = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Concluir = new System.Windows.Forms.Button();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.bt_Ignorar = new System.Windows.Forms.Button();
            this.txt_Dicas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Principal.SuspendLayout();
            this.tlp_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Controles.SuspendLayout();
            this.tlp_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Principal
            // 
            this.pn_Principal.ColumnCount = 1;
            this.pn_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pn_Principal.Controls.Add(this.tlp_Top, 0, 0);
            this.pn_Principal.Controls.Add(this.pn_Controles, 0, 3);
            this.pn_Principal.Controls.Add(this.txt_Dicas, 0, 2);
            this.pn_Principal.Controls.Add(this.label1, 0, 1);
            this.pn_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Principal.Location = new System.Drawing.Point(0, 0);
            this.pn_Principal.Name = "pn_Principal";
            this.pn_Principal.RowCount = 4;
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.pn_Principal.Size = new System.Drawing.Size(1200, 500);
            this.pn_Principal.TabIndex = 0;
            // 
            // tlp_Top
            // 
            this.tlp_Top.ColumnCount = 3;
            this.tlp_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Top.Controls.Add(this.lblTitulo, 2, 0);
            this.tlp_Top.Controls.Add(this.panel1, 1, 0);
            this.tlp_Top.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Top.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Top.Location = new System.Drawing.Point(3, 3);
            this.tlp_Top.Name = "tlp_Top";
            this.tlp_Top.RowCount = 1;
            this.tlp_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Top.Size = new System.Drawing.Size(1194, 271);
            this.tlp_Top.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Burbank Big Condensed", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(718, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(473, 271);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Aplicativo de Gestão Escolar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pb_Foto);
            this.panel1.Controls.Add(this.bt_Adicionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(480, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 265);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 24;
            // 
            // pb_Foto
            // 
            this.pb_Foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_Foto.Image")));
            this.pb_Foto.Location = new System.Drawing.Point(0, 0);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(230, 228);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Foto.TabIndex = 23;
            this.pb_Foto.TabStop = false;
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.bt_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Adicionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Adicionar.FlatAppearance.BorderSize = 0;
            this.bt_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Adicionar.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.bt_Adicionar.ForeColor = System.Drawing.Color.White;
            this.bt_Adicionar.Location = new System.Drawing.Point(0, 228);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(230, 35);
            this.bt_Adicionar.TabIndex = 9;
            this.bt_Adicionar.Text = "Adicionar Foto de Perfil";
            this.bt_Adicionar.UseVisualStyleBackColor = false;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pn_Controles
            // 
            this.pn_Controles.Controls.Add(this.tlp_control);
            this.pn_Controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Controles.Location = new System.Drawing.Point(3, 400);
            this.pn_Controles.Name = "pn_Controles";
            this.pn_Controles.Size = new System.Drawing.Size(1194, 97);
            this.pn_Controles.TabIndex = 4;
            // 
            // tlp_control
            // 
            this.tlp_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlp_control.ColumnCount = 3;
            this.tlp_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_control.Controls.Add(this.bt_Concluir, 2, 0);
            this.tlp_control.Controls.Add(this.bt_Voltar, 0, 0);
            this.tlp_control.Controls.Add(this.bt_Ignorar, 1, 0);
            this.tlp_control.Location = new System.Drawing.Point(387, 3);
            this.tlp_control.Name = "tlp_control";
            this.tlp_control.RowCount = 1;
            this.tlp_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_control.Size = new System.Drawing.Size(458, 51);
            this.tlp_control.TabIndex = 0;
            // 
            // bt_Concluir
            // 
            this.bt_Concluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.bt_Concluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Concluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Concluir.FlatAppearance.BorderSize = 0;
            this.bt_Concluir.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.bt_Concluir.Location = new System.Drawing.Point(307, 3);
            this.bt_Concluir.Name = "bt_Concluir";
            this.bt_Concluir.Size = new System.Drawing.Size(148, 45);
            this.bt_Concluir.TabIndex = 5;
            this.bt_Concluir.Text = "Concluir";
            this.bt_Concluir.UseVisualStyleBackColor = false;
            this.bt_Concluir.Click += new System.EventHandler(this.bt_Concluir_Click);
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.bt_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Voltar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Voltar.FlatAppearance.BorderSize = 0;
            this.bt_Voltar.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.bt_Voltar.Location = new System.Drawing.Point(3, 3);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(146, 45);
            this.bt_Voltar.TabIndex = 2;
            this.bt_Voltar.Text = "&Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = false;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // bt_Ignorar
            // 
            this.bt_Ignorar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.bt_Ignorar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Ignorar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Ignorar.FlatAppearance.BorderSize = 0;
            this.bt_Ignorar.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.bt_Ignorar.Location = new System.Drawing.Point(155, 3);
            this.bt_Ignorar.Name = "bt_Ignorar";
            this.bt_Ignorar.Size = new System.Drawing.Size(146, 45);
            this.bt_Ignorar.TabIndex = 1;
            this.bt_Ignorar.Text = "Ignorar";
            this.bt_Ignorar.UseVisualStyleBackColor = false;
            this.bt_Ignorar.Click += new System.EventHandler(this.bt_Ignorar_Click);
            // 
            // txt_Dicas
            // 
            this.txt_Dicas.AutoSize = true;
            this.txt_Dicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Dicas.Font = new System.Drawing.Font("Nirmala UI Semilight", 20F);
            this.txt_Dicas.Location = new System.Drawing.Point(3, 347);
            this.txt_Dicas.Name = "txt_Dicas";
            this.txt_Dicas.Size = new System.Drawing.Size(1194, 50);
            this.txt_Dicas.TabIndex = 3;
            this.txt_Dicas.Text = "Você também pode Adicionar um foto de Perfil e Personalizá-lo.";
            this.txt_Dicas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 30F);
            this.label1.Location = new System.Drawing.Point(3, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1194, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personalizar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S_CriarConta_Perfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pn_Principal);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "S_CriarConta_Perfil";
            this.Size = new System.Drawing.Size(1200, 500);
            this.Load += new System.EventHandler(this.S_CriarConta_Perfil_Load);
            this.pn_Principal.ResumeLayout(false);
            this.pn_Principal.PerformLayout();
            this.tlp_Top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Controles.ResumeLayout(false);
            this.tlp_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pn_Principal;
        private System.Windows.Forms.TableLayoutPanel tlp_Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pb_Foto;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_Controles;
        private System.Windows.Forms.TableLayoutPanel tlp_control;
        private System.Windows.Forms.Button bt_Concluir;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Button bt_Ignorar;
        private System.Windows.Forms.Label txt_Dicas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}
