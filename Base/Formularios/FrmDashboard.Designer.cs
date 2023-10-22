
namespace Erp
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            panel1 = new Panel();
            panel6 = new Panel();
            lblFuncao = new Label();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            lblData = new Label();
            lblSuporte = new Label();
            lblEmpresa = new Label();
            panel2 = new Panel();
            btnSair = new Button();
            btnAjuda = new Button();
            btnUtilitarios = new Button();
            btnRelatorios = new Button();
            btnFinanceiro = new Button();
            btnMovimentacao = new Button();
            btnCadastros = new Button();
            button1 = new Button();
            panel3 = new Panel();
            lblLogo = new Label();
            pnlPrincipal = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(lblData);
            panel1.Controls.Add(lblSuporte);
            panel1.Controls.Add(lblEmpresa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 61);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblFuncao);
            panel6.Controls.Add(lblUsuario);
            panel6.Controls.Add(pictureBox1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1230, 0);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(155, 61);
            panel6.TabIndex = 2;
            panel6.Paint += panel6_Paint;
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.ForeColor = Color.White;
            lblFuncao.Location = new Point(18, 31);
            lblFuncao.Margin = new Padding(4, 0, 4, 0);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(46, 15);
            lblFuncao.TabIndex = 4;
            lblFuncao.Text = "Função";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(18, 16);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 61);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(356, 43);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(278, 15);
            lblData.TabIndex = 2;
            lblData.Text = "Suportek Automação F.: 84 3302-6370 / 9 9871-5995";
            lblData.Click += lblData_Click;
            // 
            // lblSuporte
            // 
            lblSuporte.AutoSize = true;
            lblSuporte.ForeColor = Color.White;
            lblSuporte.Location = new Point(4, 43);
            lblSuporte.Margin = new Padding(4, 0, 4, 0);
            lblSuporte.Name = "lblSuporte";
            lblSuporte.Size = new Size(278, 15);
            lblSuporte.TabIndex = 1;
            lblSuporte.Text = "Suportek Automação F.: 84 3302-6370 / 9 9871-5995";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.ForeColor = Color.White;
            lblEmpresa.Location = new Point(4, 10);
            lblEmpresa.Margin = new Padding(4, 0, 4, 0);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(176, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "CASA DO MATUTO DE CATENDE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnAjuda);
            panel2.Controls.Add(btnUtilitarios);
            panel2.Controls.Add(btnRelatorios);
            panel2.Controls.Add(btnFinanceiro);
            panel2.Controls.Add(btnMovimentacao);
            panel2.Controls.Add(btnCadastros);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 61);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 660);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Top;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 419);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(164, 44);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAjuda
            // 
            btnAjuda.Dock = DockStyle.Top;
            btnAjuda.FlatAppearance.BorderSize = 0;
            btnAjuda.FlatStyle = FlatStyle.Flat;
            btnAjuda.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjuda.ForeColor = Color.White;
            btnAjuda.Image = (Image)resources.GetObject("btnAjuda.Image");
            btnAjuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjuda.Location = new Point(0, 375);
            btnAjuda.Margin = new Padding(4, 3, 4, 3);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(164, 44);
            btnAjuda.TabIndex = 7;
            btnAjuda.Text = "Ajuda";
            btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnUtilitarios
            // 
            btnUtilitarios.Dock = DockStyle.Top;
            btnUtilitarios.FlatAppearance.BorderSize = 0;
            btnUtilitarios.FlatStyle = FlatStyle.Flat;
            btnUtilitarios.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUtilitarios.ForeColor = Color.White;
            btnUtilitarios.Image = (Image)resources.GetObject("btnUtilitarios.Image");
            btnUtilitarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUtilitarios.Location = new Point(0, 331);
            btnUtilitarios.Margin = new Padding(4, 3, 4, 3);
            btnUtilitarios.Name = "btnUtilitarios";
            btnUtilitarios.Size = new Size(164, 44);
            btnUtilitarios.TabIndex = 6;
            btnUtilitarios.Text = "Utilitários";
            btnUtilitarios.UseVisualStyleBackColor = true;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Dock = DockStyle.Top;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Image = (Image)resources.GetObject("btnRelatorios.Image");
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(0, 287);
            btnRelatorios.Margin = new Padding(4, 3, 4, 3);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(164, 44);
            btnRelatorios.TabIndex = 5;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.Dock = DockStyle.Top;
            btnFinanceiro.FlatAppearance.BorderSize = 0;
            btnFinanceiro.FlatStyle = FlatStyle.Flat;
            btnFinanceiro.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinanceiro.ForeColor = Color.White;
            btnFinanceiro.Image = (Image)resources.GetObject("btnFinanceiro.Image");
            btnFinanceiro.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinanceiro.Location = new Point(0, 243);
            btnFinanceiro.Margin = new Padding(4, 3, 4, 3);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(164, 44);
            btnFinanceiro.TabIndex = 4;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = true;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // btnMovimentacao
            // 
            btnMovimentacao.Dock = DockStyle.Top;
            btnMovimentacao.FlatAppearance.BorderSize = 0;
            btnMovimentacao.FlatStyle = FlatStyle.Flat;
            btnMovimentacao.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMovimentacao.ForeColor = Color.White;
            btnMovimentacao.Image = (Image)resources.GetObject("btnMovimentacao.Image");
            btnMovimentacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimentacao.Location = new Point(0, 199);
            btnMovimentacao.Margin = new Padding(4, 3, 4, 3);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(164, 44);
            btnMovimentacao.TabIndex = 3;
            btnMovimentacao.Text = "Movimentação";
            btnMovimentacao.UseVisualStyleBackColor = true;
            btnMovimentacao.Click += btnMovimentacao_Click;
            // 
            // btnCadastros
            // 
            btnCadastros.Dock = DockStyle.Top;
            btnCadastros.FlatAppearance.BorderSize = 0;
            btnCadastros.FlatStyle = FlatStyle.Flat;
            btnCadastros.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastros.ForeColor = Color.White;
            btnCadastros.Image = (Image)resources.GetObject("btnCadastros.Image");
            btnCadastros.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastros.Location = new Point(0, 155);
            btnCadastros.Margin = new Padding(4, 3, 4, 3);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(164, 44);
            btnCadastros.TabIndex = 2;
            btnCadastros.Text = "Cadastros";
            btnCadastros.UseVisualStyleBackColor = true;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 111);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 44);
            button1.TabIndex = 1;
            button1.Text = "Início";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLogo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(164, 111);
            panel3.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(24, 45);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(89, 20);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Logomarca";
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pictureBox2);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(164, 61);
            pnlPrincipal.Margin = new Padding(4, 3, 4, 3);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1221, 660);
            pnlPrincipal.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1221, 660);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 721);
            ControlBox = false;
            Controls.Add(pnlPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de gestão comercial";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button btnSair;
        private Button btnAjuda;
        private Button btnUtilitarios;
        private Button btnRelatorios;
        private Button btnFinanceiro;
        private Button btnMovimentacao;
        private Button btnCadastros;
        private Label lblEmpresa;
        private Label lblSuporte;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label lblData;
        private Label lblUsuario;
        private Label lblFuncao;
        private Label lblLogo;
        private Panel pnlPrincipal;
        private PictureBox pictureBox2;
    }
}

