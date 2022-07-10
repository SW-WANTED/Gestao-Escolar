
namespace Design_WhiteMode_Modern
{
    partial class S_Usuario
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
            this.pn_Principal = new System.Windows.Forms.Panel();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.pn_botoes = new System.Windows.Forms.TableLayoutPanel();
            this.pn_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Principal
            // 
            this.pn_Principal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_Principal.Location = new System.Drawing.Point(470, 60);
            this.pn_Principal.Name = "pn_Principal";
            this.pn_Principal.Size = new System.Drawing.Size(500, 452);
            this.pn_Principal.TabIndex = 4;
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
            this.bt_Proximo.Location = new System.Drawing.Point(99, 3);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(90, 28);
            this.bt_Proximo.TabIndex = 0;
            this.bt_Proximo.Text = "&Próximo";
            this.bt_Proximo.UseVisualStyleBackColor = false;
            this.bt_Proximo.Visible = false;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
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
            this.bt_Voltar.Size = new System.Drawing.Size(90, 28);
            this.bt_Voltar.TabIndex = 1;
            this.bt_Voltar.Text = "&Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = false;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // pn_botoes
            // 
            this.pn_botoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_botoes.ColumnCount = 2;
            this.pn_botoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pn_botoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pn_botoes.Controls.Add(this.bt_Voltar, 0, 0);
            this.pn_botoes.Controls.Add(this.bt_Proximo, 1, 0);
            this.pn_botoes.Location = new System.Drawing.Point(778, 518);
            this.pn_botoes.Name = "pn_botoes";
            this.pn_botoes.RowCount = 1;
            this.pn_botoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pn_botoes.Size = new System.Drawing.Size(192, 34);
            this.pn_botoes.TabIndex = 11;
            this.pn_botoes.Visible = false;
            // 
            // S_Usuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pn_botoes);
            this.Controls.Add(this.pn_Principal);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "S_Usuario";
            this.Size = new System.Drawing.Size(1440, 652);
            this.Load += new System.EventHandler(this.S_Usuario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S_Usuario_MouseDown);
            this.pn_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_Principal;
        private System.Windows.Forms.Button bt_Proximo;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.TableLayoutPanel pn_botoes;
    }
}
