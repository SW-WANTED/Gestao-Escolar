
namespace Design_WhiteMode_Modern
{
    partial class S_CriarConta_Nome
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
            this.pn_Principal = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Apelido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_Principal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Principal
            // 
            this.pn_Principal.ColumnCount = 1;
            this.pn_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pn_Principal.Controls.Add(this.label6, 0, 1);
            this.pn_Principal.Controls.Add(this.label7, 0, 0);
            this.pn_Principal.Controls.Add(this.panel1, 0, 2);
            this.pn_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Principal.Location = new System.Drawing.Point(0, 0);
            this.pn_Principal.Name = "pn_Principal";
            this.pn_Principal.RowCount = 3;
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.65823F));
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.34177F));
            this.pn_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.pn_Principal.Size = new System.Drawing.Size(1200, 451);
            this.pn_Principal.TabIndex = 0;
            this.pn_Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Principal_Paint);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 20F);
            this.label6.Location = new System.Drawing.Point(3, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1194, 67);
            this.label6.TabIndex = 9;
            this.label6.Text = "Diz-nos qual é o seu nome verdadeiro, estamos anciosos para o conhecer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 265);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Apelido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Nome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(178, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 220);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tb_Apelido
            // 
            this.tb_Apelido.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_Apelido.Location = new System.Drawing.Point(424, 44);
            this.tb_Apelido.Name = "tb_Apelido";
            this.tb_Apelido.Size = new System.Drawing.Size(299, 29);
            this.tb_Apelido.TabIndex = 1;
            this.tb_Apelido.Enter += new System.EventHandler(this.tb_Apelido_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label2.Location = new System.Drawing.Point(424, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apelido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome Próprio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tb_Nome.Location = new System.Drawing.Point(3, 44);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(299, 29);
            this.tb_Nome.TabIndex = 0;
            this.tb_Nome.Enter += new System.EventHandler(this.tb_Nome_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bt_Voltar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Proximo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(424, 174);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 43);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Voltar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Voltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Voltar.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.bt_Voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Voltar.Location = new System.Drawing.Point(3, 3);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(143, 37);
            this.bt_Voltar.TabIndex = 3;
            this.bt_Voltar.Text = "Iniciar Sessão";
            this.bt_Voltar.UseCompatibleTextRendering = true;
            this.bt_Voltar.UseVisualStyleBackColor = false;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // bt_Proximo
            // 
            this.bt_Proximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Proximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Proximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Proximo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Proximo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Proximo.Font = new System.Drawing.Font("Nirmala UI", 13F);
            this.bt_Proximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Proximo.Location = new System.Drawing.Point(152, 3);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(144, 37);
            this.bt_Proximo.TabIndex = 2;
            this.bt_Proximo.Text = "&Avançar";
            this.bt_Proximo.UseCompatibleTextRendering = true;
            this.bt_Proximo.UseVisualStyleBackColor = true;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 40F);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1194, 113);
            this.label7.TabIndex = 8;
            this.label7.Text = "Olá, como te Chamas?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S_CriarConta_Nome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pn_Principal);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Name = "S_CriarConta_Nome";
            this.Size = new System.Drawing.Size(1200, 451);
            this.Load += new System.EventHandler(this.S_CriarConta_Nome_Load);
            this.pn_Principal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pn_Principal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_Apelido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_Proximo;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Label label7;
    }
}
