
namespace Design_WhiteMode_Modern
{
    partial class E_Turma
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Novo = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Professor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_alunos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Vagas = new System.Windows.Forms.TextBox();
            this.tb_Turma = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.bt_Salvar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Novo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Eliminar, 1, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(913, 582);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 40);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Salvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
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
            this.bt_Novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Novo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Novo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bt_Novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Novo.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Novo.Location = new System.Drawing.Point(3, 3);
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(94, 34);
            this.bt_Novo.TabIndex = 1;
            this.bt_Novo.Text = "&Novo";
            this.bt_Novo.UseVisualStyleBackColor = false;
            this.bt_Novo.Click += new System.EventHandler(this.bt_Novo_Click);
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.bt_Eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Eliminar.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Eliminar.Location = new System.Drawing.Point(203, 3);
            this.bt_Eliminar.Name = "bt_Eliminar";
            this.bt_Eliminar.Size = new System.Drawing.Size(95, 34);
            this.bt_Eliminar.TabIndex = 3;
            this.bt_Eliminar.Text = "Eliminar";
            this.bt_Eliminar.UseVisualStyleBackColor = false;
            this.bt_Eliminar.Click += new System.EventHandler(this.bt_Eliminar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(214, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 3);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(548, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Turmas da Escola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Design_WhiteMode_Modern.Properties.Resources.Cap;
            this.pictureBox1.Location = new System.Drawing.Point(645, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label2.Location = new System.Drawing.Point(210, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Professor";
            // 
            // cb_Professor
            // 
            this.cb_Professor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Professor.Enabled = false;
            this.cb_Professor.FormattingEnabled = true;
            this.cb_Professor.Location = new System.Drawing.Point(211, 338);
            this.cb_Professor.Name = "cb_Professor";
            this.cb_Professor.Size = new System.Drawing.Size(301, 25);
            this.cb_Professor.TabIndex = 2;
            this.cb_Professor.SelectedIndexChanged += new System.EventHandler(this.cb_Professor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label3.Location = new System.Drawing.Point(210, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Máximo alunos";
            // 
            // nud_alunos
            // 
            this.nud_alunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_alunos.Enabled = false;
            this.nud_alunos.Location = new System.Drawing.Point(214, 407);
            this.nud_alunos.Name = "nud_alunos";
            this.nud_alunos.Size = new System.Drawing.Size(140, 25);
            this.nud_alunos.TabIndex = 3;
            this.nud_alunos.ValueChanged += new System.EventHandler(this.nud_alunos_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label4.Location = new System.Drawing.Point(368, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // cb_Estado
            // 
            this.cb_Estado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Estado.Enabled = false;
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Location = new System.Drawing.Point(369, 407);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(143, 25);
            this.cb_Estado.TabIndex = 4;
            this.cb_Estado.SelectedIndexChanged += new System.EventHandler(this.cb_Estado_SelectedIndexChanged);
            // 
            // cb_horario
            // 
            this.cb_horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_horario.Enabled = false;
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(214, 474);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(301, 25);
            this.cb_horario.TabIndex = 5;
            this.cb_horario.SelectedIndexChanged += new System.EventHandler(this.cb_horario_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label5.Location = new System.Drawing.Point(210, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Horário";
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            this.dgv_turmas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_turmas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_turmas.Location = new System.Drawing.Point(579, 234);
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.dgv_turmas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_turmas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.dgv_turmas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_turmas.RowTemplate.ReadOnly = true;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(635, 327);
            this.dgv_turmas.TabIndex = 0;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label6.Location = new System.Drawing.Point(210, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome da Turma";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label7.Location = new System.Drawing.Point(213, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vagas";
            // 
            // tb_Vagas
            // 
            this.tb_Vagas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Vagas.Enabled = false;
            this.tb_Vagas.Location = new System.Drawing.Point(217, 536);
            this.tb_Vagas.Name = "tb_Vagas";
            this.tb_Vagas.ReadOnly = true;
            this.tb_Vagas.Size = new System.Drawing.Size(298, 25);
            this.tb_Vagas.TabIndex = 6;
            // 
            // tb_Turma
            // 
            this.tb_Turma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Turma.Location = new System.Drawing.Point(214, 270);
            this.tb_Turma.Name = "tb_Turma";
            this.tb_Turma.Size = new System.Drawing.Size(298, 25);
            this.tb_Turma.TabIndex = 1;
            this.tb_Turma.TextChanged += new System.EventHandler(this.tb_Turma_TextChanged);
            // 
            // E_Turma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tb_Turma);
            this.Controls.Add(this.tb_Vagas);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nud_alunos);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Professor);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Name = "E_Turma";
            this.Size = new System.Drawing.Size(1440, 652);
            this.Load += new System.EventHandler(this.E_Turma_Load);
            this.Enter += new System.EventHandler(this.E_Turma_Enter);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Novo;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_alunos;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.ComboBox cb_Professor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Vagas;
        private System.Windows.Forms.TextBox tb_Turma;
    }
}
