
namespace Design_WhiteMode_Modern
{
    partial class F_Principal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.pn_Ferramentas = new System.Windows.Forms.Panel();
            this.Ferramentas = new System.Windows.Forms.ToolStrip();
            this.Tool_Separador_1 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tT_Conta = new System.Windows.Forms.ToolTip(this.components);
            this.pn_Titulo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlp_top = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Principal = new System.Windows.Forms.Panel();
            this.tT_Banco = new System.Windows.Forms.ToolTip(this.components);
            this.Tool_Imagem = new System.Windows.Forms.ToolStripButton();
            this.Tool_Inicio = new System.Windows.Forms.ToolStripButton();
            this.bt_Reiniciar = new System.Windows.Forms.Button();
            this.bt_Banco = new System.Windows.Forms.Button();
            this.bt_Conta = new System.Windows.Forms.Button();
            this.bt_Minimizar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.Menu_Escola = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Aluno_NovoAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Aluno_GestaoAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Professor = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Escola_Turma = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Escola_Horario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Funcionario_NovoFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Gestao_Funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Admin_Servicos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sistema_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sistema_CriarConta = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sistema_Definicoes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sistema_TerminarSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Ferramentas.SuspendLayout();
            this.Ferramentas.SuspendLayout();
            this.pn_Titulo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tlp_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Ferramentas
            // 
            this.pn_Ferramentas.BackColor = System.Drawing.Color.Transparent;
            this.pn_Ferramentas.Controls.Add(this.Ferramentas);
            this.pn_Ferramentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Ferramentas.Location = new System.Drawing.Point(0, 30);
            this.pn_Ferramentas.Name = "pn_Ferramentas";
            this.pn_Ferramentas.Size = new System.Drawing.Size(1440, 24);
            this.pn_Ferramentas.TabIndex = 12;
            // 
            // Ferramentas
            // 
            this.Ferramentas.AllowItemReorder = true;
            this.Ferramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Ferramentas.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Ferramentas.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.Ferramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Imagem,
            this.Tool_Separador_1,
            this.Tool_Inicio});
            this.Ferramentas.Location = new System.Drawing.Point(0, 0);
            this.Ferramentas.Name = "Ferramentas";
            this.Ferramentas.Padding = new System.Windows.Forms.Padding(0);
            this.Ferramentas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Ferramentas.Size = new System.Drawing.Size(1440, 25);
            this.Ferramentas.Stretch = true;
            this.Ferramentas.TabIndex = 1;
            this.Ferramentas.Text = "Ferramentas";
            this.Ferramentas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ferramentas_MouseDown);
            // 
            // Tool_Separador_1
            // 
            this.Tool_Separador_1.ForeColor = System.Drawing.Color.DimGray;
            this.Tool_Separador_1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.Tool_Separador_1.Name = "Tool_Separador_1";
            this.Tool_Separador_1.Size = new System.Drawing.Size(6, 25);
            this.Tool_Separador_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tool_Separador_1_MouseDown);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // tT_Conta
            // 
            this.tT_Conta.IsBalloon = true;
            this.tT_Conta.OwnerDraw = true;
            this.tT_Conta.ShowAlways = true;
            this.tT_Conta.ToolTipTitle = "Você Está Conectado";
            // 
            // pn_Titulo
            // 
            this.pn_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.pn_Titulo.Controls.Add(this.menuStrip1);
            this.pn_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Titulo.Location = new System.Drawing.Point(3, 3);
            this.pn_Titulo.Name = "pn_Titulo";
            this.pn_Titulo.Size = new System.Drawing.Size(1229, 24);
            this.pn_Titulo.TabIndex = 2;
            this.pn_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Titulo_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Escola,
            this.Menu_Funcionario,
            this.Menu_Sistema});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Menu_Escola;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // tlp_top
            // 
            this.tlp_top.ColumnCount = 2;
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlp_top.Controls.Add(this.panel1, 1, 0);
            this.tlp_top.Controls.Add(this.pn_Titulo, 0, 0);
            this.tlp_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_top.Location = new System.Drawing.Point(0, 0);
            this.tlp_top.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_top.Name = "tlp_top";
            this.tlp_top.RowCount = 1;
            this.tlp_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_top.Size = new System.Drawing.Size(1440, 30);
            this.tlp_top.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Reiniciar);
            this.panel1.Controls.Add(this.bt_Banco);
            this.panel1.Controls.Add(this.bt_Conta);
            this.panel1.Controls.Add(this.bt_Minimizar);
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1235, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 30);
            this.panel1.TabIndex = 0;
            // 
            // pn_Principal
            // 
            this.pn_Principal.AutoScroll = true;
            this.pn_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Principal.Location = new System.Drawing.Point(0, 54);
            this.pn_Principal.Name = "pn_Principal";
            this.pn_Principal.Size = new System.Drawing.Size(1440, 646);
            this.pn_Principal.TabIndex = 0;
            this.pn_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Principal_MouseDown);
            // 
            // tT_Banco
            // 
            this.tT_Banco.IsBalloon = true;
            this.tT_Banco.OwnerDraw = true;
            this.tT_Banco.ShowAlways = true;
            this.tT_Banco.ToolTipTitle = "Banco de dados";
            // 
            // Tool_Imagem
            // 
            this.Tool_Imagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Imagem.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Imagem.Image")));
            this.Tool_Imagem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Tool_Imagem.Name = "Tool_Imagem";
            this.Tool_Imagem.Size = new System.Drawing.Size(23, 22);
            this.Tool_Imagem.Text = "Imagem";
            this.Tool_Imagem.ToolTipText = "Início";
            // 
            // Tool_Inicio
            // 
            this.Tool_Inicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Inicio.Image")));
            this.Tool_Inicio.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Tool_Inicio.Name = "Tool_Inicio";
            this.Tool_Inicio.Size = new System.Drawing.Size(23, 22);
            this.Tool_Inicio.Text = "Início";
            this.Tool_Inicio.ToolTipText = "Início";
            this.Tool_Inicio.Click += new System.EventHandler(this.Tool_Inicio_Click);
            // 
            // bt_Reiniciar
            // 
            this.bt_Reiniciar.AccessibleName = "bt_Conta";
            this.bt_Reiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Reiniciar.BackgroundImage")));
            this.bt_Reiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Reiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Reiniciar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Reiniciar.Enabled = false;
            this.bt_Reiniciar.FlatAppearance.BorderSize = 0;
            this.bt_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reiniciar.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.bt_Reiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Reiniciar.Location = new System.Drawing.Point(0, 0);
            this.bt_Reiniciar.Name = "bt_Reiniciar";
            this.bt_Reiniciar.Size = new System.Drawing.Size(45, 30);
            this.bt_Reiniciar.TabIndex = 0;
            this.bt_Reiniciar.Tag = "database";
            this.tT_Banco.SetToolTip(this.bt_Reiniciar, "Reiniciar");
            this.bt_Reiniciar.UseVisualStyleBackColor = true;
            this.bt_Reiniciar.Visible = false;
            this.bt_Reiniciar.Click += new System.EventHandler(this.bt_Reiniciar_Click);
            // 
            // bt_Banco
            // 
            this.bt_Banco.AccessibleName = "bt_Conta";
            this.bt_Banco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Banco.BackgroundImage")));
            this.bt_Banco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Banco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Banco.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Banco.FlatAppearance.BorderSize = 0;
            this.bt_Banco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Banco.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.bt_Banco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Banco.Location = new System.Drawing.Point(45, 0);
            this.bt_Banco.Name = "bt_Banco";
            this.bt_Banco.Size = new System.Drawing.Size(45, 30);
            this.bt_Banco.TabIndex = 1;
            this.bt_Banco.Tag = "database";
            this.tT_Banco.SetToolTip(this.bt_Banco, "Conexão Estabelecida");
            this.bt_Banco.UseVisualStyleBackColor = true;
            this.bt_Banco.Click += new System.EventHandler(this.bt_Banco_Click);
            // 
            // bt_Conta
            // 
            this.bt_Conta.AccessibleName = "bt_Conta";
            this.bt_Conta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Conta.BackgroundImage")));
            this.bt_Conta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Conta.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Conta.FlatAppearance.BorderSize = 0;
            this.bt_Conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Conta.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.bt_Conta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Conta.Location = new System.Drawing.Point(90, 0);
            this.bt_Conta.Name = "bt_Conta";
            this.bt_Conta.Size = new System.Drawing.Size(45, 30);
            this.bt_Conta.TabIndex = 2;
            this.tT_Conta.SetToolTip(this.bt_Conta, "Emanuel dos Santos");
            this.bt_Conta.UseVisualStyleBackColor = true;
            this.bt_Conta.Visible = false;
            this.bt_Conta.Click += new System.EventHandler(this.bt_Conta_Click);
            // 
            // bt_Minimizar
            // 
            this.bt_Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Minimizar.FlatAppearance.BorderSize = 0;
            this.bt_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Minimizar.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.bt_Minimizar.Image = global::Design_WhiteMode_Modern.Properties.Resources.bt_Minimizar_Preto_Min;
            this.bt_Minimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Minimizar.Location = new System.Drawing.Point(135, 0);
            this.bt_Minimizar.Name = "bt_Minimizar";
            this.bt_Minimizar.Size = new System.Drawing.Size(35, 30);
            this.bt_Minimizar.TabIndex = 3;
            this.bt_Minimizar.UseVisualStyleBackColor = true;
            this.bt_Minimizar.Click += new System.EventHandler(this.bt_Minimizar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Sair.FlatAppearance.BorderSize = 0;
            this.bt_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bt_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sair.Image = global::Design_WhiteMode_Modern.Properties.Resources.bt_Sair_Preto_Min;
            this.bt_Sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Sair.Location = new System.Drawing.Point(170, 0);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(35, 30);
            this.bt_Sair.TabIndex = 4;
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            this.bt_Sair.MouseEnter += new System.EventHandler(this.bt_Sair_MouseEnter);
            this.bt_Sair.MouseLeave += new System.EventHandler(this.bt_Sair_MouseLeave);
            // 
            // Menu_Escola
            // 
            this.Menu_Escola.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Aluno_NovoAluno,
            this.Menu_Aluno_GestaoAluno,
            this.Menu_Professor,
            this.Menu_Escola_Turma,
            this.Menu_Escola_Horario});
            this.Menu_Escola.Image = global::Design_WhiteMode_Modern.Properties.Resources.I_Hospital;
            this.Menu_Escola.Name = "Menu_Escola";
            this.Menu_Escola.Size = new System.Drawing.Size(121, 20);
            this.Menu_Escola.Text = "Área Académica";
            // 
            // Menu_Aluno_NovoAluno
            // 
            this.Menu_Aluno_NovoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Menu_Aluno_NovoAluno.Image = global::Design_WhiteMode_Modern.Properties.Resources.Aluno;
            this.Menu_Aluno_NovoAluno.Name = "Menu_Aluno_NovoAluno";
            this.Menu_Aluno_NovoAluno.Size = new System.Drawing.Size(189, 22);
            this.Menu_Aluno_NovoAluno.Text = "Matrícula de Aluno";
            this.Menu_Aluno_NovoAluno.Click += new System.EventHandler(this.Menu_Aluno_NovoAluno_Click);
            // 
            // Menu_Aluno_GestaoAluno
            // 
            this.Menu_Aluno_GestaoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Menu_Aluno_GestaoAluno.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Aluno_GestaoAluno.Image")));
            this.Menu_Aluno_GestaoAluno.Name = "Menu_Aluno_GestaoAluno";
            this.Menu_Aluno_GestaoAluno.Size = new System.Drawing.Size(189, 22);
            this.Menu_Aluno_GestaoAluno.Text = "Gestão de Aluno";
            this.Menu_Aluno_GestaoAluno.Click += new System.EventHandler(this.Menu_Aluno_GestaoAluno_Click);
            // 
            // Menu_Professor
            // 
            this.Menu_Professor.Image = global::Design_WhiteMode_Modern.Properties.Resources.People;
            this.Menu_Professor.Name = "Menu_Professor";
            this.Menu_Professor.Size = new System.Drawing.Size(189, 22);
            this.Menu_Professor.Text = "Gestão de Professores";
            this.Menu_Professor.Click += new System.EventHandler(this.Menu_Professor_Click);
            // 
            // Menu_Escola_Turma
            // 
            this.Menu_Escola_Turma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Menu_Escola_Turma.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Menu_Escola_Turma.Image = global::Design_WhiteMode_Modern.Properties.Resources.Cap;
            this.Menu_Escola_Turma.Name = "Menu_Escola_Turma";
            this.Menu_Escola_Turma.Size = new System.Drawing.Size(189, 22);
            this.Menu_Escola_Turma.Text = "Turmas";
            this.Menu_Escola_Turma.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // Menu_Escola_Horario
            // 
            this.Menu_Escola_Horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Menu_Escola_Horario.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Menu_Escola_Horario.Image = global::Design_WhiteMode_Modern.Properties.Resources.Relógio_icone;
            this.Menu_Escola_Horario.Name = "Menu_Escola_Horario";
            this.Menu_Escola_Horario.Size = new System.Drawing.Size(189, 22);
            this.Menu_Escola_Horario.Text = "Horários";
            this.Menu_Escola_Horario.Click += new System.EventHandler(this.Menu_Escola_Horario_Click);
            // 
            // Menu_Funcionario
            // 
            this.Menu_Funcionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Funcionario_NovoFuncionario,
            this.Menu_Gestao_Funcionario,
            this.Menu_Admin_Servicos});
            this.Menu_Funcionario.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Funcionario.Image")));
            this.Menu_Funcionario.Name = "Menu_Funcionario";
            this.Menu_Funcionario.Size = new System.Drawing.Size(139, 20);
            this.Menu_Funcionario.Text = "Área Administrativa";
            // 
            // Menu_Funcionario_NovoFuncionario
            // 
            this.Menu_Funcionario_NovoFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Funcionario_NovoFuncionario.Image")));
            this.Menu_Funcionario_NovoFuncionario.Name = "Menu_Funcionario_NovoFuncionario";
            this.Menu_Funcionario_NovoFuncionario.Size = new System.Drawing.Size(197, 22);
            this.Menu_Funcionario_NovoFuncionario.Text = "Cadastrar Funcionários";
            this.Menu_Funcionario_NovoFuncionario.Click += new System.EventHandler(this.Menu_Funcionario_NovoFuncionario_Click);
            // 
            // Menu_Gestao_Funcionario
            // 
            this.Menu_Gestao_Funcionario.Image = global::Design_WhiteMode_Modern.Properties.Resources.Developer;
            this.Menu_Gestao_Funcionario.Name = "Menu_Gestao_Funcionario";
            this.Menu_Gestao_Funcionario.Size = new System.Drawing.Size(197, 22);
            this.Menu_Gestao_Funcionario.Text = "Gestão de Funcionários";
            this.Menu_Gestao_Funcionario.Click += new System.EventHandler(this.Menu_Gestao_Funcionario_Click);
            // 
            // Menu_Admin_Servicos
            // 
            this.Menu_Admin_Servicos.Image = global::Design_WhiteMode_Modern.Properties.Resources.atlassian_id_badge;
            this.Menu_Admin_Servicos.Name = "Menu_Admin_Servicos";
            this.Menu_Admin_Servicos.Size = new System.Drawing.Size(197, 22);
            this.Menu_Admin_Servicos.Text = "Serviços";
            this.Menu_Admin_Servicos.Click += new System.EventHandler(this.Menu_Admin_Servicos_Click);
            // 
            // Menu_Sistema
            // 
            this.Menu_Sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Sistema_Usuario,
            this.Menu_Sistema_CriarConta,
            this.Menu_Sistema_Definicoes,
            this.Menu_Sistema_TerminarSessao});
            this.Menu_Sistema.Image = global::Design_WhiteMode_Modern.Properties.Resources.services_icon;
            this.Menu_Sistema.Name = "Menu_Sistema";
            this.Menu_Sistema.Size = new System.Drawing.Size(76, 20);
            this.Menu_Sistema.Text = "Sistema";
            // 
            // Menu_Sistema_Usuario
            // 
            this.Menu_Sistema_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Sistema_Usuario.Image")));
            this.Menu_Sistema_Usuario.Name = "Menu_Sistema_Usuario";
            this.Menu_Sistema_Usuario.Size = new System.Drawing.Size(180, 22);
            this.Menu_Sistema_Usuario.Text = "Iniciar sessão";
            this.Menu_Sistema_Usuario.Click += new System.EventHandler(this.Menu_Sistema_Usuario_Click);
            // 
            // Menu_Sistema_CriarConta
            // 
            this.Menu_Sistema_CriarConta.Image = global::Design_WhiteMode_Modern.Properties.Resources.Leitor;
            this.Menu_Sistema_CriarConta.Name = "Menu_Sistema_CriarConta";
            this.Menu_Sistema_CriarConta.Size = new System.Drawing.Size(180, 22);
            this.Menu_Sistema_CriarConta.Text = "Criar conta";
            this.Menu_Sistema_CriarConta.Click += new System.EventHandler(this.Menu_Sistema_CriarConta_Click);
            // 
            // Menu_Sistema_Definicoes
            // 
            this.Menu_Sistema_Definicoes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Sistema_Definicoes.Image")));
            this.Menu_Sistema_Definicoes.Name = "Menu_Sistema_Definicoes";
            this.Menu_Sistema_Definicoes.Size = new System.Drawing.Size(180, 22);
            this.Menu_Sistema_Definicoes.Text = "Definições de Conta";
            this.Menu_Sistema_Definicoes.Click += new System.EventHandler(this.Menu_Sistema_Definicoes_Click);
            // 
            // Menu_Sistema_TerminarSessao
            // 
            this.Menu_Sistema_TerminarSessao.Image = global::Design_WhiteMode_Modern.Properties.Resources.Offline;
            this.Menu_Sistema_TerminarSessao.Name = "Menu_Sistema_TerminarSessao";
            this.Menu_Sistema_TerminarSessao.Size = new System.Drawing.Size(180, 22);
            this.Menu_Sistema_TerminarSessao.Text = "Terminar sessão";
            this.Menu_Sistema_TerminarSessao.Click += new System.EventHandler(this.Menu_Sistema_TerminarSessao_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1440, 700);
            this.Controls.Add(this.pn_Principal);
            this.Controls.Add(this.pn_Ferramentas);
            this.Controls.Add(this.tlp_top);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software de Gestão Escolar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Principal_FormClosing);
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_Principal_MouseDown);
            this.pn_Ferramentas.ResumeLayout(false);
            this.pn_Ferramentas.PerformLayout();
            this.Ferramentas.ResumeLayout(false);
            this.Ferramentas.PerformLayout();
            this.pn_Titulo.ResumeLayout(false);
            this.pn_Titulo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlp_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip Ferramentas;
        private System.Windows.Forms.ToolStripButton Tool_Imagem;
        private System.Windows.Forms.ToolStripSeparator Tool_Separador_1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Minimizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Escola;
        private System.Windows.Forms.ToolStripMenuItem Menu_Escola_Turma;
        private System.Windows.Forms.ToolStripMenuItem Menu_Escola_Horario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Funcionario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Funcionario_NovoFuncionario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sistema;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sistema_Usuario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sistema_CriarConta;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sistema_Definicoes;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sistema_TerminarSessao;
        private System.Windows.Forms.TableLayoutPanel tlp_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_Principal;
        public System.Windows.Forms.Panel pn_Ferramentas;
        public System.Windows.Forms.Panel pn_Titulo;
        public System.Windows.Forms.Button bt_Conta;
        public System.Windows.Forms.ToolTip tT_Conta;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestao_Funcionario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Aluno_GestaoAluno;
        private System.Windows.Forms.ToolStripMenuItem Menu_Aluno_NovoAluno;
        private System.Windows.Forms.ToolStripMenuItem Menu_Professor;
        private System.Windows.Forms.ToolStripMenuItem Menu_Admin_Servicos;
        public System.Windows.Forms.Button bt_Banco;
        public System.Windows.Forms.ToolTip tT_Banco;
        public System.Windows.Forms.Button bt_Reiniciar;
        public System.Windows.Forms.ToolStripButton Tool_Inicio;
    }
}

