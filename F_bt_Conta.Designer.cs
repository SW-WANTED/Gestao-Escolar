
namespace Design_WhiteMode_Modern
{
    partial class F_bt_Conta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_bt_Conta));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Email = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.Label();
            this.bt_Conta = new System.Windows.Forms.Button();
            this.tT_Logado = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Conta, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 97);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.13043F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.86957F));
            this.tableLayoutPanel2.Controls.Add(this.pb_Foto, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 56);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pb_Foto
            // 
            this.pb_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_Foto.Image")));
            this.pb_Foto.Location = new System.Drawing.Point(3, 3);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(70, 50);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Foto.TabIndex = 0;
            this.pb_Foto.TabStop = false;
            this.tT_Logado.SetToolTip(this.pb_Foto, "Emanuel dos Santos");
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txt_Email, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_Nome, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(79, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 50);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.AutoSize = true;
            this.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_Email.Location = new System.Drawing.Point(3, 23);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(174, 27);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.Text = "ernelemanuel10@hotmail.com";
            this.txt_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Nome
            // 
            this.txt_Nome.AutoSize = true;
            this.txt_Nome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Nome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_Nome.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.txt_Nome.Location = new System.Drawing.Point(3, 8);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(174, 15);
            this.txt_Nome.TabIndex = 2;
            this.txt_Nome.Text = "Emanuel dos Santos";
            this.txt_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_Conta
            // 
            this.bt_Conta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Conta.FlatAppearance.BorderSize = 0;
            this.bt_Conta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.bt_Conta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.bt_Conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Conta.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.bt_Conta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
            this.bt_Conta.Location = new System.Drawing.Point(4, 67);
            this.bt_Conta.Name = "bt_Conta";
            this.bt_Conta.Size = new System.Drawing.Size(262, 26);
            this.bt_Conta.TabIndex = 2;
            this.bt_Conta.Text = "Configurações de Conta";
            this.bt_Conta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tT_Logado.SetToolTip(this.bt_Conta, "Emanuel dos Santos");
            this.bt_Conta.UseVisualStyleBackColor = false;
            this.bt_Conta.Click += new System.EventHandler(this.bt_Conta_Click);
            // 
            // tT_Logado
            // 
            this.tT_Logado.AutomaticDelay = 1000;
            this.tT_Logado.AutoPopDelay = 10000;
            this.tT_Logado.InitialDelay = 100;
            this.tT_Logado.ReshowDelay = 50;
            this.tT_Logado.ToolTipTitle = "Está conectado";
            // 
            // F_bt_Conta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(270, 97);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_bt_Conta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartão do Usuário";
            this.Deactivate += new System.EventHandler(this.F_bt_Conta_Deactivate);
            this.Load += new System.EventHandler(this.F_bt_Conta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label txt_Email;
        private System.Windows.Forms.Label txt_Nome;
        private System.Windows.Forms.Button bt_Conta;
        private System.Windows.Forms.ToolTip tT_Logado;
        public System.Windows.Forms.PictureBox pb_Foto;
    }
}