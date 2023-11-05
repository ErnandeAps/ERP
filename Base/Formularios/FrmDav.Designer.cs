namespace Base.Formularios
{
    partial class FrmDav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDav));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            tsmNovo = new ToolStripMenuItem();
            tsmSalvar = new ToolStripMenuItem();
            tsmFinalizar = new ToolStripMenuItem();
            tsmExcluir = new ToolStripMenuItem();
            tsmNfe = new ToolStripMenuItem();
            tsmNFCe = new ToolStripMenuItem();
            tsmSair = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            tsmDav = new ToolStripMenuItem();
            tsmRelVendas = new ToolStripMenuItem();
            tsmRelOrcamentos = new ToolStripMenuItem();
            panel1 = new Panel();
            btnNovo = new Button();
            btnNFCe = new Button();
            btnNfe = new Button();
            btnFinalizar = new Button();
            btnSair = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            textBox5 = new TextBox();
            label12 = new Label();
            cbTipo = new ComboBox();
            label16 = new Label();
            maskData = new MaskedTextBox();
            maskCnpjCpf = new MaskedTextBox();
            lbTipo = new Label();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            txtValor = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            txtQtd = new TextBox();
            label5 = new Label();
            txtValUnit = new TextBox();
            label4 = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtIdProduto = new TextBox();
            dtGrid = new DataGridView();
            label7 = new Label();
            txtSubTotal = new TextBox();
            label8 = new Label();
            txtDesconto = new TextBox();
            label9 = new Label();
            txtTotal = new TextBox();
            label10 = new Label();
            txtValPag = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(971, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmNovo, tsmSalvar, tsmFinalizar, tsmExcluir, tsmNfe, tsmNFCe, tsmSair });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsmNovo
            // 
            tsmNovo.Image = (Image)resources.GetObject("tsmNovo.Image");
            tsmNovo.Name = "tsmNovo";
            tsmNovo.ShortcutKeys = Keys.F2;
            tsmNovo.Size = new Size(180, 22);
            tsmNovo.Text = "Novo";
            tsmNovo.Click += tsmNovo_Click;
            // 
            // tsmSalvar
            // 
            tsmSalvar.Image = (Image)resources.GetObject("tsmSalvar.Image");
            tsmSalvar.Name = "tsmSalvar";
            tsmSalvar.ShortcutKeys = Keys.F3;
            tsmSalvar.Size = new Size(180, 22);
            tsmSalvar.Text = "Salvar";
            // 
            // tsmFinalizar
            // 
            tsmFinalizar.Image = (Image)resources.GetObject("tsmFinalizar.Image");
            tsmFinalizar.Name = "tsmFinalizar";
            tsmFinalizar.ShortcutKeys = Keys.F4;
            tsmFinalizar.Size = new Size(180, 22);
            tsmFinalizar.Text = "Finalizar";
            tsmFinalizar.Click += tsmFinalizar_Click;
            // 
            // tsmExcluir
            // 
            tsmExcluir.Image = (Image)resources.GetObject("tsmExcluir.Image");
            tsmExcluir.Name = "tsmExcluir";
            tsmExcluir.ShortcutKeys = Keys.F6;
            tsmExcluir.Size = new Size(180, 22);
            tsmExcluir.Text = "Excluir";
            // 
            // tsmNfe
            // 
            tsmNfe.Image = (Image)resources.GetObject("tsmNfe.Image");
            tsmNfe.Name = "tsmNfe";
            tsmNfe.ShortcutKeys = Keys.F7;
            tsmNfe.Size = new Size(180, 22);
            tsmNfe.Text = "NF-e";
            // 
            // tsmNFCe
            // 
            tsmNFCe.Image = (Image)resources.GetObject("tsmNFCe.Image");
            tsmNFCe.Name = "tsmNFCe";
            tsmNFCe.ShortcutKeys = Keys.F8;
            tsmNFCe.Size = new Size(180, 22);
            tsmNFCe.Text = "NFC-e";
            // 
            // tsmSair
            // 
            tsmSair.Name = "tsmSair";
            tsmSair.Size = new Size(180, 22);
            tsmSair.Text = "Sair";
            tsmSair.Click += tsmSair_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmDav, tsmRelVendas, tsmRelOrcamentos });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tsmDav
            // 
            tsmDav.Name = "tsmDav";
            tsmDav.Size = new Size(199, 22);
            tsmDav.Text = "Imprimir Dav";
            tsmDav.Click += relaçãoGeralToolStripMenuItem_Click;
            // 
            // tsmRelVendas
            // 
            tsmRelVendas.Name = "tsmRelVendas";
            tsmRelVendas.Size = new Size(199, 22);
            tsmRelVendas.Text = "Relação de vendas";
            // 
            // tsmRelOrcamentos
            // 
            tsmRelOrcamentos.Name = "tsmRelOrcamentos";
            tsmRelOrcamentos.Size = new Size(199, 22);
            tsmRelOrcamentos.Text = "Relação de Orçamentos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnNFCe);
            panel1.Controls.Add(btnNfe);
            panel1.Controls.Add(btnFinalizar);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 76);
            panel1.TabIndex = 21;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.White;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.TopCenter;
            btnNovo.Location = new Point(13, 3);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(57, 67);
            btnNovo.TabIndex = 17;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.BottomCenter;
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnNFCe
            // 
            btnNFCe.BackColor = Color.White;
            btnNFCe.FlatAppearance.BorderSize = 0;
            btnNFCe.FlatStyle = FlatStyle.Flat;
            btnNFCe.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNFCe.Image = (Image)resources.GetObject("btnNFCe.Image");
            btnNFCe.ImageAlign = ContentAlignment.TopCenter;
            btnNFCe.Location = new Point(266, 3);
            btnNFCe.Margin = new Padding(4, 3, 4, 3);
            btnNFCe.Name = "btnNFCe";
            btnNFCe.Size = new Size(57, 67);
            btnNFCe.TabIndex = 16;
            btnNFCe.Text = "NFC-e";
            btnNFCe.TextAlign = ContentAlignment.BottomCenter;
            btnNFCe.UseVisualStyleBackColor = false;
            // 
            // btnNfe
            // 
            btnNfe.BackColor = Color.White;
            btnNfe.FlatAppearance.BorderSize = 0;
            btnNfe.FlatStyle = FlatStyle.Flat;
            btnNfe.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNfe.Image = (Image)resources.GetObject("btnNfe.Image");
            btnNfe.ImageAlign = ContentAlignment.TopCenter;
            btnNfe.Location = new Point(215, 3);
            btnNfe.Margin = new Padding(4, 3, 4, 3);
            btnNfe.Name = "btnNfe";
            btnNfe.Size = new Size(57, 67);
            btnNfe.TabIndex = 15;
            btnNfe.Text = "NF-e";
            btnNfe.TextAlign = ContentAlignment.BottomCenter;
            btnNfe.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.White;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Image = (Image)resources.GetObject("btnFinalizar.Image");
            btnFinalizar.ImageAlign = ContentAlignment.TopCenter;
            btnFinalizar.Location = new Point(164, 3);
            btnFinalizar.Margin = new Padding(4, 3, 4, 3);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(57, 67);
            btnFinalizar.TabIndex = 14;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.TextAlign = ContentAlignment.BottomCenter;
            btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(360, 1);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(57, 67);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.Location = new Point(113, 3);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(57, 67);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.TopCenter;
            btnSalvar.Location = new Point(63, 3);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(57, 67);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(maskData);
            groupBox1.Controls.Add(maskCnpjCpf);
            groupBox1.Controls.Add(lbTipo);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 100);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(971, 79);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(764, 20);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 40;
            label13.Text = "STATUS:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(763, 36);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.MaxLength = 100;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(98, 23);
            textBox5.TabIndex = 41;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(626, 19);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 39;
            label12.Text = "MODALIDADE:";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "VENDA", "ORÇAMENTO" });
            cbTipo.Location = new Point(629, 37);
            cbTipo.Margin = new Padding(4, 3, 4, 3);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(131, 23);
            cbTipo.TabIndex = 38;
            cbTipo.Text = "VENDA";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(861, 22);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 37;
            label16.Text = "DATA";
            // 
            // maskData
            // 
            maskData.Location = new Point(865, 37);
            maskData.Margin = new Padding(4, 3, 4, 3);
            maskData.Mask = "00/00/0000";
            maskData.Name = "maskData";
            maskData.Size = new Size(96, 23);
            maskData.TabIndex = 36;
            maskData.TextAlign = HorizontalAlignment.Center;
            maskData.ValidatingType = typeof(DateTime);
            // 
            // maskCnpjCpf
            // 
            maskCnpjCpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskCnpjCpf.Location = new Point(89, 33);
            maskCnpjCpf.Margin = new Padding(4, 3, 4, 3);
            maskCnpjCpf.Name = "maskCnpjCpf";
            maskCnpjCpf.Size = new Size(153, 26);
            maskCnpjCpf.TabIndex = 2;
            maskCnpjCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(87, 17);
            lbTipo.Margin = new Padding(4, 0, 4, 0);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(64, 15);
            lbTipo.TabIndex = 20;
            lbTipo.Text = "CNP/CPFJ:";
            // 
            // txtId
            // 
            txtId.Location = new Point(20, 35);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 13);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "NOME/RAZÃO:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(246, 37);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(368, 23);
            txtNome.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtValor);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtQtd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtValUnit);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtIdProduto);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(971, 70);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(629, 19);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 16;
            label11.Text = "VALOR:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(628, 35);
            txtValor.Margin = new Padding(4, 3, 4, 3);
            txtValor.MaxLength = 100;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(106, 23);
            txtValor.TabIndex = 17;
            txtValor.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(781, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(48, 56);
            button2.TabIndex = 15;
            button2.Text = "Excluir";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(738, 12);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(48, 56);
            button1.TabIndex = 12;
            button1.Text = "Inserir";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "QUANT.:";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(544, 35);
            txtQtd.Margin = new Padding(4, 3, 4, 3);
            txtQtd.MaxLength = 100;
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(76, 23);
            txtQtd.TabIndex = 11;
            txtQtd.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 19);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "VAL. UNIT.:";
            // 
            // txtValUnit
            // 
            txtValUnit.Location = new Point(430, 35);
            txtValUnit.Margin = new Padding(4, 3, 4, 3);
            txtValUnit.MaxLength = 100;
            txtValUnit.Name = "txtValUnit";
            txtValUnit.Size = new Size(106, 23);
            txtValUnit.TabIndex = 10;
            txtValUnit.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "DESCRIÇÃO:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(75, 35);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.MaxLength = 100;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(348, 23);
            txtDescricao.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "CÓDIGO:";
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(6, 35);
            txtIdProduto.Margin = new Padding(4, 3, 4, 3);
            txtIdProduto.MaxLength = 100;
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(65, 23);
            txtIdProduto.TabIndex = 6;
            // 
            // dtGrid
            // 
            dtGrid.AllowUserToAddRows = false;
            dtGrid.AllowUserToDeleteRows = false;
            dtGrid.AllowUserToOrderColumns = true;
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Location = new Point(7, 254);
            dtGrid.Margin = new Padding(4, 3, 4, 3);
            dtGrid.Name = "dtGrid";
            dtGrid.ReadOnly = true;
            dtGrid.Size = new Size(697, 341);
            dtGrid.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(716, 299);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 29;
            label7.Text = "SUB. TOTAL: ";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(820, 296);
            txtSubTotal.Margin = new Padding(4, 3, 4, 3);
            txtSubTotal.MaxLength = 100;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(138, 32);
            txtSubTotal.TabIndex = 30;
            txtSubTotal.Text = "0,00";
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(716, 334);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 31;
            label8.Text = "DESCONTO:";
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesconto.Location = new Point(820, 331);
            txtDesconto.Margin = new Padding(4, 3, 4, 3);
            txtDesconto.MaxLength = 100;
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(138, 32);
            txtDesconto.TabIndex = 32;
            txtDesconto.Text = "0,00";
            txtDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(716, 369);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 33;
            label9.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(820, 366);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.MaxLength = 100;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(138, 32);
            txtTotal.TabIndex = 34;
            txtTotal.Text = "0,00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(716, 404);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 21);
            label10.TabIndex = 35;
            label10.Text = "VALOR PAG.:";
            // 
            // txtValPag
            // 
            txtValPag.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtValPag.Location = new Point(820, 401);
            txtValPag.Margin = new Padding(4, 3, 4, 3);
            txtValPag.MaxLength = 100;
            txtValPag.Name = "txtValPag";
            txtValPag.Size = new Size(138, 32);
            txtValPag.TabIndex = 36;
            txtValPag.Text = "0,00";
            txtValPag.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmDav
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 603);
            Controls.Add(label10);
            Controls.Add(txtValPag);
            Controls.Add(label9);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(txtDesconto);
            Controls.Add(label7);
            Controls.Add(txtSubTotal);
            Controls.Add(dtGrid);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            Name = "FrmDav";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dav (Documento antecipado de venda)";
            Load += FrmDav_Load;
            KeyDown += FrmDav_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem tsmSalvar;
        private ToolStripMenuItem tsmExcluir;
        private ToolStripMenuItem tsmSair;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem tsmDav;
        private Panel panel1;
        private Button btnSair;
        private Button btnExcluir;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private Label label16;
        private MaskedTextBox maskData;
        private MaskedTextBox maskCnpjCpf;
        private Label lbTipo;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private GroupBox groupBox2;
        private Button button1;
        private Label label6;
        private TextBox txtQtd;
        private Label label5;
        private TextBox txtValUnit;
        private Label label4;
        private TextBox txtDescricao;
        private Label label3;
        private TextBox txtIdProduto;
        private DataGridView dtGrid;
        private Label label7;
        private TextBox txtSubTotal;
        private Label label8;
        private TextBox txtDesconto;
        private Label label9;
        private TextBox txtTotal;
        private Label label10;
        private TextBox txtValPag;
        private Button button2;
        private Button btnFinalizar;
        private ToolStripMenuItem tsmFinalizar;
        private ToolStripMenuItem tsmRelVendas;
        private Label label11;
        private TextBox txtValor;
        private Button btnNfe;
        private Button btnNFCe;
        private ToolStripMenuItem tsmNfe;
        private ToolStripMenuItem tsmNFCe;
        private Label label12;
        private ComboBox cbTipo;
        private Label label13;
        private TextBox textBox5;
        private ToolStripMenuItem tsmRelOrcamentos;
        private Button btnNovo;
        private ToolStripMenuItem tsmNovo;
    }
}