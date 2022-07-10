
namespace Design_WhiteMode_Modern
{
    partial class F_Gestao_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Gestao_Funcionario));
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlp_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Imprimir = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.gb_Trabalho = new System.Windows.Forms.GroupBox();
            this.pn_CB_Horario = new System.Windows.Forms.Panel();
            this.cb_Turno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_CB_Funcao = new System.Windows.Forms.Panel();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Salario = new System.Windows.Forms.TextBox();
            this.dtp_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.cb_Localidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_Pessoal = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.Ficheiro = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlp_Controls.SuspendLayout();
            this.gb_Trabalho.SuspendLayout();
            this.pn_CB_Horario.SuspendLayout();
            this.pn_CB_Funcao.SuspendLayout();
            this.pb_Pessoal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.mtb_telefone.Location = new System.Drawing.Point(295, 314);
            this.mtb_telefone.Mask = "+(244) 000-000-000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(129, 25);
            this.mtb_telefone.TabIndex = 2;
            this.mtb_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label1.Location = new System.Drawing.Point(291, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label2.Location = new System.Drawing.Point(291, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nome";
            // 
            // tb_Nome
            // 
            this.tb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nome.Location = new System.Drawing.Point(295, 249);
            this.tb_Nome.MaxLength = 30;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(360, 25);
            this.tb_Nome.TabIndex = 1;
            // 
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.AllowUserToAddRows = false;
            this.dgv_Funcionarios.AllowUserToDeleteRows = false;
            this.dgv_Funcionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Funcionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.EnableHeadersVisualStyles = false;
            this.dgv_Funcionarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Funcionarios.Location = new System.Drawing.Point(677, 225);
            this.dgv_Funcionarios.MultiSelect = false;
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.ReadOnly = true;
            this.dgv_Funcionarios.RowHeadersVisible = false;
            this.dgv_Funcionarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.dgv_Funcionarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Funcionarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.dgv_Funcionarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Funcionarios.RowTemplate.ReadOnly = true;
            this.dgv_Funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Funcionarios.Size = new System.Drawing.Size(600, 340);
            this.dgv_Funcionarios.TabIndex = 0;
            this.dgv_Funcionarios.SelectionChanged += new System.EventHandler(this.dgv_Funcionarios_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(498, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(444, 54);
            this.label8.TabIndex = 37;
            this.label8.Text = "Gestão de Funcionários";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_foto.ErrorImage")));
            this.pb_foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_foto.Image")));
            this.pb_foto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_foto.InitialImage")));
            this.pb_foto.Location = new System.Drawing.Point(163, 219);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(120, 120);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 35;
            this.pb_foto.TabStop = false;
            this.pb_foto.DoubleClick += new System.EventHandler(this.pb_foto_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tlp_Controls
            // 
            this.tlp_Controls.ColumnCount = 3;
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Controls.Controls.Add(this.bt_Guardar, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Imprimir, 1, 0);
            this.tlp_Controls.Controls.Add(this.bt_Eliminar, 2, 0);
            this.tlp_Controls.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Controls.Location = new System.Drawing.Point(1021, 578);
            this.tlp_Controls.Name = "tlp_Controls";
            this.tlp_Controls.RowCount = 1;
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.Size = new System.Drawing.Size(301, 40);
            this.tlp_Controls.TabIndex = 6;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Guardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.bt_Guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Guardar.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Guardar.Location = new System.Drawing.Point(3, 3);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(94, 34);
            this.bt_Guardar.TabIndex = 1;
            this.bt_Guardar.Text = "Atualizar";
            this.bt_Guardar.UseVisualStyleBackColor = false;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // bt_Imprimir
            // 
            this.bt_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Imprimir.Enabled = false;
            this.bt_Imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.bt_Imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.bt_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Imprimir.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.bt_Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Imprimir.Location = new System.Drawing.Point(103, 3);
            this.bt_Imprimir.Name = "bt_Imprimir";
            this.bt_Imprimir.Size = new System.Drawing.Size(94, 34);
            this.bt_Imprimir.TabIndex = 2;
            this.bt_Imprimir.Text = "Imprimir";
            this.bt_Imprimir.UseVisualStyleBackColor = false;
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bt_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
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
            // gb_Trabalho
            // 
            this.gb_Trabalho.Controls.Add(this.pn_CB_Horario);
            this.gb_Trabalho.Controls.Add(this.label3);
            this.gb_Trabalho.Controls.Add(this.pn_CB_Funcao);
            this.gb_Trabalho.Controls.Add(this.label4);
            this.gb_Trabalho.Controls.Add(this.label9);
            this.gb_Trabalho.Controls.Add(this.tb_Salario);
            this.gb_Trabalho.Location = new System.Drawing.Point(414, 358);
            this.gb_Trabalho.Name = "gb_Trabalho";
            this.gb_Trabalho.Size = new System.Drawing.Size(241, 207);
            this.gb_Trabalho.TabIndex = 5;
            this.gb_Trabalho.TabStop = false;
            this.gb_Trabalho.Text = "Trabalho";
            // 
            // pn_CB_Horario
            // 
            this.pn_CB_Horario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_CB_Horario.Controls.Add(this.cb_Turno);
            this.pn_CB_Horario.Location = new System.Drawing.Point(26, 173);
            this.pn_CB_Horario.Name = "pn_CB_Horario";
            this.pn_CB_Horario.Size = new System.Drawing.Size(198, 23);
            this.pn_CB_Horario.TabIndex = 2;
            // 
            // cb_Turno
            // 
            this.cb_Turno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Turno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Turno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Turno.FormattingEnabled = true;
            this.cb_Turno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Diurno",
            "Noturno",
            "Todo o dia"});
            this.cb_Turno.Location = new System.Drawing.Point(0, 0);
            this.cb_Turno.Name = "cb_Turno";
            this.cb_Turno.Size = new System.Drawing.Size(196, 25);
            this.cb_Turno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Turno";
            // 
            // pn_CB_Funcao
            // 
            this.pn_CB_Funcao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_CB_Funcao.Controls.Add(this.cb_Cargo);
            this.pn_CB_Funcao.Location = new System.Drawing.Point(26, 49);
            this.pn_CB_Funcao.Name = "pn_CB_Funcao";
            this.pn_CB_Funcao.Size = new System.Drawing.Size(200, 23);
            this.pn_CB_Funcao.TabIndex = 1;
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Cargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Items.AddRange(new object[] {
            "Director Geral",
            "Director Pedagógico",
            "Segurança",
            "Limpeza",
            "Secretário",
            "Vigilante",
            "Supervisor Técnico",
            "Gestor de Stock"});
            this.cb_Cargo.Location = new System.Drawing.Point(0, 0);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(198, 25);
            this.cb_Cargo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Salário (Akz)";
            // 
            // tb_Salario
            // 
            this.tb_Salario.Location = new System.Drawing.Point(27, 111);
            this.tb_Salario.Name = "tb_Salario";
            this.tb_Salario.Size = new System.Drawing.Size(199, 25);
            this.tb_Salario.TabIndex = 2;
            // 
            // dtp_Nascimento
            // 
            this.dtp_Nascimento.Checked = false;
            this.dtp_Nascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_Nascimento.CustomFormat = "yyyy-MM-DD";
            this.dtp_Nascimento.Location = new System.Drawing.Point(26, 173);
            this.dtp_Nascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_Nascimento.Name = "dtp_Nascimento";
            this.dtp_Nascimento.Size = new System.Drawing.Size(198, 25);
            this.dtp_Nascimento.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nascimento";
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_Sexo.Location = new System.Drawing.Point(26, 47);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(198, 25);
            this.cb_Sexo.TabIndex = 1;
            // 
            // cb_Localidade
            // 
            this.cb_Localidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Localidade.FormattingEnabled = true;
            this.cb_Localidade.Location = new System.Drawing.Point(26, 111);
            this.cb_Localidade.Name = "cb_Localidade";
            this.cb_Localidade.Size = new System.Drawing.Size(198, 25);
            this.cb_Localidade.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Residência";
            // 
            // pb_Pessoal
            // 
            this.pb_Pessoal.Controls.Add(this.label6);
            this.pb_Pessoal.Controls.Add(this.dtp_Nascimento);
            this.pb_Pessoal.Controls.Add(this.cb_Sexo);
            this.pb_Pessoal.Controls.Add(this.label7);
            this.pb_Pessoal.Controls.Add(this.label5);
            this.pb_Pessoal.Controls.Add(this.cb_Localidade);
            this.pb_Pessoal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pb_Pessoal.Location = new System.Drawing.Point(163, 358);
            this.pb_Pessoal.Name = "pb_Pessoal";
            this.pb_Pessoal.Size = new System.Drawing.Size(241, 207);
            this.pb_Pessoal.TabIndex = 4;
            this.pb_Pessoal.TabStop = false;
            this.pb_Pessoal.Text = "Pessoal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Gênero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HelvLight", 15F);
            this.label10.Location = new System.Drawing.Point(437, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(163, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 3);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_Estado);
            this.panel2.Location = new System.Drawing.Point(440, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 25);
            this.panel2.TabIndex = 3;
            // 
            // cb_Estado
            // 
            this.cb_Estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Location = new System.Drawing.Point(0, 0);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(213, 25);
            this.cb_Estado.TabIndex = 3;
            // 
            // Ficheiro
            // 
            this.Ficheiro.FileName = "openFileDialog1";
            this.Ficheiro.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // F_Gestao_Funcionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pb_Pessoal);
            this.Controls.Add(this.gb_Trabalho);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.dgv_Funcionarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tlp_Controls);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Name = "F_Gestao_Funcionario";
            this.Size = new System.Drawing.Size(1440, 652);
            this.Load += new System.EventHandler(this.F_Gestao_Funcionario_Load);
            this.Enter += new System.EventHandler(this.F_Gestao_Funcionario_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlp_Controls.ResumeLayout(false);
            this.gb_Trabalho.ResumeLayout(false);
            this.gb_Trabalho.PerformLayout();
            this.pn_CB_Horario.ResumeLayout(false);
            this.pn_CB_Funcao.ResumeLayout(false);
            this.pb_Pessoal.ResumeLayout(false);
            this.pb_Pessoal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tlp_Controls;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.Button bt_Imprimir;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.GroupBox gb_Trabalho;
        private System.Windows.Forms.Panel pn_CB_Horario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Salario;
        private System.Windows.Forms.DateTimePicker dtp_Nascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.ComboBox cb_Localidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox pb_Pessoal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.OpenFileDialog Ficheiro;
        private System.Windows.Forms.Panel pn_CB_Funcao;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.ComboBox cb_Turno;
    }
}
