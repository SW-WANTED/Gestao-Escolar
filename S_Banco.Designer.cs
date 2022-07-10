
namespace Design_WhiteMode_Modern
{
    partial class S_Banco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.tlp_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Banco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlp_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(420, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 3);
            this.panel1.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(562, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 54);
            this.label8.TabIndex = 40;
            this.label8.Text = "Banco de Dados";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Senha do servidor";
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(570, 264);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(208, 25);
            this.tb_Senha.TabIndex = 0;
            // 
            // tlp_Controls
            // 
            this.tlp_Controls.ColumnCount = 3;
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.Controls.Add(this.button1, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Salvar, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Login, 1, 0);
            this.tlp_Controls.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.tlp_Controls.Location = new System.Drawing.Point(570, 529);
            this.tlp_Controls.Name = "tlp_Controls";
            this.tlp_Controls.RowCount = 1;
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.Size = new System.Drawing.Size(400, 40);
            this.tlp_Controls.TabIndex = 2;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Salvar.Location = new System.Drawing.Point(3, 3);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(127, 34);
            this.bt_Salvar.TabIndex = 1;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Location = new System.Drawing.Point(269, 3);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(128, 34);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Iniciar Sessão";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nome do Banco de dados";
            // 
            // tb_Banco
            // 
            this.tb_Banco.Location = new System.Drawing.Point(570, 322);
            this.tb_Banco.Name = "tb_Banco";
            this.tb_Banco.Size = new System.Drawing.Size(208, 25);
            this.tb_Banco.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(136, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_Testar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Design_WhiteMode_Modern.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(645, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // S_Banco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tlp_Controls);
            this.Controls.Add(this.tb_Banco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Name = "S_Banco";
            this.Size = new System.Drawing.Size(1440, 646);
            this.Load += new System.EventHandler(this.S_Banco_Load);
            this.tlp_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.TableLayoutPanel tlp_Controls;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Banco;
        private System.Windows.Forms.Button button1;
    }
}
