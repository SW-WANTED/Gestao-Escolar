
namespace Design_WhiteMode_Modern
{
    partial class F_Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Servicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_Mes = new System.Windows.Forms.DateTimePicker();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.cb_Servico = new System.Windows.Forms.ComboBox();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.tb_Empresa = new System.Windows.Forms.TextBox();
            this.bt_Imprimir = new System.Windows.Forms.Button();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Servicos = new System.Windows.Forms.DataGridView();
            this.tlp_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Novo = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicos)).BeginInit();
            this.tlp_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dp_Mes);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.cb_Servico);
            this.panel1.Controls.Add(this.tb_Telefone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_Valor);
            this.panel1.Controls.Add(this.tb_Empresa);
            this.panel1.Location = new System.Drawing.Point(165, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 264);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Id";
            // 
            // dp_Mes
            // 
            this.dp_Mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dp_Mes.CustomFormat = "MM/yyyy";
            this.dp_Mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_Mes.Location = new System.Drawing.Point(164, 196);
            this.dp_Mes.Name = "dp_Mes";
            this.dp_Mes.Size = new System.Drawing.Size(141, 25);
            this.dp_Mes.TabIndex = 5;
            // 
            // tb_Id
            // 
            this.tb_Id.AutoCompleteCustomSource.AddRange(new string[] {
            "ENDE",
            "EPAL",
            "UNITEL",
            "ANGOLA TELECOM",
            "TV CABO",
            "ZAP FIBRA"});
            this.tb_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tb_Id.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.tb_Id.Location = new System.Drawing.Point(17, 47);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.ReadOnly = true;
            this.tb_Id.Size = new System.Drawing.Size(48, 25);
            this.tb_Id.TabIndex = 0;
            this.tb_Id.TabStop = false;
            // 
            // cb_Servico
            // 
            this.cb_Servico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Servico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Servico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Servico.FormattingEnabled = true;
            this.cb_Servico.Items.AddRange(new object[] {
            "Energia",
            "Água",
            "Internet"});
            this.cb_Servico.Location = new System.Drawing.Point(164, 123);
            this.cb_Servico.Name = "cb_Servico";
            this.cb_Servico.Size = new System.Drawing.Size(141, 25);
            this.cb_Servico.TabIndex = 3;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Telefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_Telefone.Location = new System.Drawing.Point(17, 123);
            this.tb_Telefone.Mask = "+(244) 000-000-000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(141, 25);
            this.tb_Telefone.TabIndex = 2;
            this.tb_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor (Akz)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // tb_Valor
            // 
            this.tb_Valor.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.tb_Valor.Location = new System.Drawing.Point(17, 196);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(141, 25);
            this.tb_Valor.TabIndex = 4;
            // 
            // tb_Empresa
            // 
            this.tb_Empresa.AutoCompleteCustomSource.AddRange(new string[] {
            "ENDE",
            "EPAL",
            "UNITEL",
            "ANGOLA TELECOM",
            "TV CABO",
            "ZAP FIBRA"});
            this.tb_Empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_Empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tb_Empresa.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.tb_Empresa.Location = new System.Drawing.Point(71, 47);
            this.tb_Empresa.Name = "tb_Empresa";
            this.tb_Empresa.Size = new System.Drawing.Size(234, 25);
            this.tb_Empresa.TabIndex = 1;
            // 
            // bt_Imprimir
            // 
            this.bt_Imprimir.Location = new System.Drawing.Point(0, 0);
            this.bt_Imprimir.Name = "bt_Imprimir";
            this.bt_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.bt_Imprimir.TabIndex = 0;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Location = new System.Drawing.Point(0, 0);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_Guardar.TabIndex = 0;
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(0, 0);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(165, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 3);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(443, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(445, 54);
            this.label6.TabIndex = 18;
            this.label6.Text = "Serviços de Pagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Servicos
            // 
            this.dgv_Servicos.AllowUserToAddRows = false;
            this.dgv_Servicos.AllowUserToDeleteRows = false;
            this.dgv_Servicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Servicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Servicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Servicos.EnableHeadersVisualStyles = false;
            this.dgv_Servicos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Servicos.Location = new System.Drawing.Point(505, 230);
            this.dgv_Servicos.MultiSelect = false;
            this.dgv_Servicos.Name = "dgv_Servicos";
            this.dgv_Servicos.ReadOnly = true;
            this.dgv_Servicos.RowHeadersVisible = false;
            this.dgv_Servicos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.dgv_Servicos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Servicos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.dgv_Servicos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Servicos.RowTemplate.ReadOnly = true;
            this.dgv_Servicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Servicos.Size = new System.Drawing.Size(660, 264);
            this.dgv_Servicos.TabIndex = 2;
            this.dgv_Servicos.SelectionChanged += new System.EventHandler(this.dgv_Servicos_SelectionChanged);
            // 
            // tlp_Controls
            // 
            this.tlp_Controls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlp_Controls.ColumnCount = 3;
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Controls.Controls.Add(this.bt_Salvar, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Novo, 0, 0);
            this.tlp_Controls.Controls.Add(this.bt_Eliminar, 1, 0);
            this.tlp_Controls.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.tlp_Controls.Location = new System.Drawing.Point(465, 544);
            this.tlp_Controls.Name = "tlp_Controls";
            this.tlp_Controls.RowCount = 1;
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Controls.Size = new System.Drawing.Size(400, 40);
            this.tlp_Controls.TabIndex = 1;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Salvar.Location = new System.Drawing.Point(136, 3);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(127, 34);
            this.bt_Salvar.TabIndex = 2;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_Novo
            // 
            this.bt_Novo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Novo.Location = new System.Drawing.Point(3, 3);
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(127, 34);
            this.bt_Novo.TabIndex = 1;
            this.bt_Novo.Text = "Novo";
            this.bt_Novo.UseVisualStyleBackColor = true;
            this.bt_Novo.Click += new System.EventHandler(this.bt_Novo_Click);
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Eliminar.Location = new System.Drawing.Point(269, 3);
            this.bt_Eliminar.Name = "bt_Eliminar";
            this.bt_Eliminar.Size = new System.Drawing.Size(128, 34);
            this.bt_Eliminar.TabIndex = 3;
            this.bt_Eliminar.Text = "Eliminar";
            this.bt_Eliminar.UseVisualStyleBackColor = true;
            this.bt_Eliminar.Click += new System.EventHandler(this.bt_Eliminar_Click);
            // 
            // F_Servicos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tlp_Controls);
            this.Controls.Add(this.dgv_Servicos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Name = "F_Servicos";
            this.Size = new System.Drawing.Size(1440, 652);
            this.Load += new System.EventHandler(this.F_Servicos_Load);
            this.Enter += new System.EventHandler(this.F_Servicos_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicos)).EndInit();
            this.tlp_Controls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Servico;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Valor;
        private System.Windows.Forms.DateTimePicker dp_Mes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.Button bt_Imprimir;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Servicos;
        private System.Windows.Forms.TableLayoutPanel tlp_Controls;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Novo;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Id;
    }
}
