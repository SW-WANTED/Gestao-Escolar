
namespace Design_WhiteMode_Modern
{
    partial class P_Professor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Professor));
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tlp_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Imprimir = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Novo = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.dgv_Pofessor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlp_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pofessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label3.Location = new System.Drawing.Point(409, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ID.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_ID.Location = new System.Drawing.Point(413, 258);
            this.tb_ID.MaxLength = 30;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(92, 25);
            this.tb_ID.TabIndex = 0;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Telefone.Location = new System.Drawing.Point(882, 258);
            this.tb_Telefone.Mask = "+(244) 000-000-000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(146, 25);
            this.tb_Telefone.TabIndex = 2;
            this.tb_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label4.Location = new System.Drawing.Point(878, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label2.Location = new System.Drawing.Point(507, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // tb_Nome
            // 
            this.tb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nome.Location = new System.Drawing.Point(511, 258);
            this.tb_Nome.MaxLength = 30;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(365, 25);
            this.tb_Nome.TabIndex = 1;
            // 
            // tlp_Controls
            // 
            this.tlp_Controls.ColumnCount = 4;
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.Controls.Add(this.bt_Imprimir, 3, 0);
            this.tlp_Controls.Controls.Add(this.bt_Salvar, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Novo, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Eliminar, 1, 0);
            this.tlp_Controls.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Controls.Location = new System.Drawing.Point(531, 552);
            this.tlp_Controls.Name = "tlp_Controls";
            this.tlp_Controls.RowCount = 1;
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Controls.Size = new System.Drawing.Size(400, 40);
            this.tlp_Controls.TabIndex = 22;
            // 
            // bt_Imprimir
            // 
            this.bt_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.bt_Imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Imprimir.Enabled = false;
            this.bt_Imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.bt_Imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Imprimir.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Imprimir.Location = new System.Drawing.Point(303, 3);
            this.bt_Imprimir.Name = "bt_Imprimir";
            this.bt_Imprimir.Size = new System.Drawing.Size(94, 34);
            this.bt_Imprimir.TabIndex = 5;
            this.bt_Imprimir.Text = "Imprimir";
            this.bt_Imprimir.UseVisualStyleBackColor = false;
            this.bt_Imprimir.Click += new System.EventHandler(this.bt_Imprimir_Click);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.bt_Salvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.bt_Salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Salvar.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Salvar.Location = new System.Drawing.Point(103, 3);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(94, 34);
            this.bt_Salvar.TabIndex = 2;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = false;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_Novo
            // 
            this.bt_Novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.bt_Novo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Novo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.bt_Novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Novo.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Novo.Location = new System.Drawing.Point(3, 3);
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(94, 34);
            this.bt_Novo.TabIndex = 4;
            this.bt_Novo.Text = "&Novo";
            this.bt_Novo.UseVisualStyleBackColor = false;
            this.bt_Novo.Click += new System.EventHandler(this.bt_Novo_Click);
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.bt_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.bt_Eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Eliminar.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Eliminar.Location = new System.Drawing.Point(203, 3);
            this.bt_Eliminar.Name = "bt_Eliminar";
            this.bt_Eliminar.Size = new System.Drawing.Size(94, 34);
            this.bt_Eliminar.TabIndex = 0;
            this.bt_Eliminar.Text = "Eliminar";
            this.bt_Eliminar.UseVisualStyleBackColor = false;
            this.bt_Eliminar.Click += new System.EventHandler(this.bt_Eliminar_Click);
            // 
            // dgv_Pofessor
            // 
            this.dgv_Pofessor.AllowUserToAddRows = false;
            this.dgv_Pofessor.AllowUserToDeleteRows = false;
            this.dgv_Pofessor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pofessor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Pofessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pofessor.EnableHeadersVisualStyles = false;
            this.dgv_Pofessor.GridColor = System.Drawing.Color.DimGray;
            this.dgv_Pofessor.Location = new System.Drawing.Point(413, 289);
            this.dgv_Pofessor.MultiSelect = false;
            this.dgv_Pofessor.Name = "dgv_Pofessor";
            this.dgv_Pofessor.ReadOnly = true;
            this.dgv_Pofessor.RowHeadersVisible = false;
            this.dgv_Pofessor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.dgv_Pofessor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Pofessor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.dgv_Pofessor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Pofessor.RowTemplate.ReadOnly = true;
            this.dgv_Pofessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pofessor.Size = new System.Drawing.Size(615, 246);
            this.dgv_Pofessor.TabIndex = 3;
            this.dgv_Pofessor.SelectionChanged += new System.EventHandler(this.dgv_Pofessor_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(413, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 3);
            this.panel1.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(509, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 54);
            this.label8.TabIndex = 40;
            this.label8.Text = "Gestão de Professores";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // P_Professor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Pofessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tlp_Controls);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "P_Professor";
            this.Size = new System.Drawing.Size(1440, 652);
            this.Load += new System.EventHandler(this.P_Professor_Load);
            this.Enter += new System.EventHandler(this.P_Professor_Enter);
            this.tlp_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pofessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TableLayoutPanel tlp_Controls;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Novo;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.DataGridView dgv_Pofessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Imprimir;
    }
}
