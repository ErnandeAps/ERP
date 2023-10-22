namespace Erp
{
    partial class FrmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            groupBox1 = new GroupBox();
            label29 = new Label();
            maskDataNasc = new MaskedTextBox();
            label28 = new Label();
            textBox1 = new TextBox();
            txtIE = new MaskedTextBox();
            label27 = new Label();
            label16 = new Label();
            maskData = new MaskedTextBox();
            txtRoteiro = new TextBox();
            label15 = new Label();
            maskCnpjCpf = new MaskedTextBox();
            txtContato = new TextBox();
            label14 = new Label();
            label13 = new Label();
            maskCelular = new MaskedTextBox();
            label12 = new Label();
            maskFone = new MaskedTextBox();
            label11 = new Label();
            txtFantasia = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            Btncnpj = new Button();
            lbTipo = new Label();
            label10 = new Label();
            cbTipo = new ComboBox();
            txtNum = new TextBox();
            label8 = new Label();
            btCep = new Button();
            txtUf = new TextBox();
            label7 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtCep = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            txtEnd = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            relaçãoGeralToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnSair = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label29);
            groupBox1.Controls.Add(maskDataNasc);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtIE);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(maskData);
            groupBox1.Controls.Add(txtRoteiro);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(maskCnpjCpf);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(maskCelular);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(maskFone);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtFantasia);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(Btncnpj);
            groupBox1.Controls.Add(lbTipo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(txtNum);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btCep);
            groupBox1.Controls.Add(txtUf);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtEnd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(8, 112);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(755, 376);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados cadastrais";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(20, 209);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(60, 15);
            label29.TabIndex = 43;
            label29.Text = "DT NASC.:";
            // 
            // maskDataNasc
            // 
            maskDataNasc.Location = new Point(20, 226);
            maskDataNasc.Margin = new Padding(4, 3, 4, 3);
            maskDataNasc.Mask = "00/00/0000";
            maskDataNasc.Name = "maskDataNasc";
            maskDataNasc.Size = new Size(96, 23);
            maskDataNasc.TabIndex = 14;
            maskDataNasc.ValidatingType = typeof(DateTime);
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(299, 164);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(61, 15);
            label28.TabIndex = 41;
            label28.Text = "CÓD. IBJE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 182);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 12;
            // 
            // txtIE
            // 
            txtIE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIE.Location = new Point(419, 37);
            txtIE.Margin = new Padding(4, 3, 4, 3);
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(119, 26);
            txtIE.TabIndex = 3;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(416, 19);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(19, 15);
            label27.TabIndex = 39;
            label27.Text = "IE:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(632, 23);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 37;
            label16.Text = "DATA";
            // 
            // maskData
            // 
            maskData.Location = new Point(637, 40);
            maskData.Margin = new Padding(4, 3, 4, 3);
            maskData.Mask = "00/00/0000";
            maskData.Name = "maskData";
            maskData.Size = new Size(96, 23);
            maskData.TabIndex = 36;
            maskData.ValidatingType = typeof(DateTime);
            // 
            // txtRoteiro
            // 
            txtRoteiro.Location = new Point(20, 278);
            txtRoteiro.Margin = new Padding(4, 3, 4, 3);
            txtRoteiro.Multiline = true;
            txtRoteiro.Name = "txtRoteiro";
            txtRoteiro.Size = new Size(713, 80);
            txtRoteiro.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 260);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 33;
            label15.Text = "ROTEIRO:\r\n";
            // 
            // maskCnpjCpf
            // 
            maskCnpjCpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskCnpjCpf.Location = new Point(176, 39);
            maskCnpjCpf.Margin = new Padding(4, 3, 4, 3);
            maskCnpjCpf.Name = "maskCnpjCpf";
            maskCnpjCpf.Size = new Size(196, 26);
            maskCnpjCpf.TabIndex = 2;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(371, 226);
            txtContato.Margin = new Padding(4, 3, 4, 3);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(362, 23);
            txtContato.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(368, 208);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 31;
            label14.Text = "CONTATO:\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(244, 209);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 29;
            label13.Text = "CELULAR:";
            // 
            // maskCelular
            // 
            maskCelular.Location = new Point(247, 226);
            maskCelular.Margin = new Padding(4, 3, 4, 3);
            maskCelular.Mask = "(99) 00000-0000";
            maskCelular.Name = "maskCelular";
            maskCelular.Size = new Size(116, 23);
            maskCelular.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(120, 209);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 27;
            label12.Text = "FONE:";
            // 
            // maskFone
            // 
            maskFone.Location = new Point(124, 226);
            maskFone.Margin = new Padding(4, 3, 4, 3);
            maskFone.Mask = "(99) 0000-0000";
            maskFone.Name = "maskFone";
            maskFone.Size = new Size(116, 23);
            maskFone.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(376, 74);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 25;
            label11.Text = "FANTASIA:";
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(376, 92);
            txtFantasia.Margin = new Padding(4, 3, 4, 3);
            txtFantasia.MaxLength = 100;
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(358, 23);
            txtFantasia.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(449, 182);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 23);
            txtEmail.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(446, 165);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 23;
            label9.Text = "EMAIL:\r\n";
            // 
            // Btncnpj
            // 
            Btncnpj.FlatAppearance.BorderSize = 0;
            Btncnpj.FlatStyle = FlatStyle.Flat;
            Btncnpj.Image = (Image)resources.GetObject("Btncnpj.Image");
            Btncnpj.Location = new Point(376, 30);
            Btncnpj.Margin = new Padding(4, 3, 4, 3);
            Btncnpj.Name = "Btncnpj";
            Btncnpj.Size = new Size(35, 35);
            Btncnpj.TabIndex = 21;
            Btncnpj.UseVisualStyleBackColor = true;
            Btncnpj.Click += Btncnpj_Click;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(173, 21);
            lbTipo.Margin = new Padding(4, 0, 4, 0);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(37, 15);
            lbTipo.TabIndex = 20;
            lbTipo.Text = "CNPJ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(89, 22);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(32, 13);
            label10.TabIndex = 18;
            label10.Text = "TIPO";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "CPF", "CNPJ" });
            cbTipo.Location = new Point(92, 40);
            cbTipo.Margin = new Padding(4, 3, 4, 3);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(76, 23);
            cbTipo.TabIndex = 1;
            cbTipo.SelectedIndexChanged += cbTipop_SelectedIndexChanged;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(469, 137);
            txtNum.Margin = new Padding(4, 3, 4, 3);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(50, 23);
            txtNum.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(465, 119);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "NUM:";
            // 
            // btCep
            // 
            btCep.FlatAppearance.BorderSize = 0;
            btCep.FlatStyle = FlatStyle.Flat;
            btCep.Image = (Image)resources.GetObject("btCep.Image");
            btCep.Location = new Point(106, 125);
            btCep.Margin = new Padding(4, 3, 4, 3);
            btCep.Name = "btCep";
            btCep.Size = new Size(35, 35);
            btCep.TabIndex = 14;
            btCep.UseVisualStyleBackColor = true;
            btCep.Click += btCep_Click;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(254, 182);
            txtUf.Margin = new Padding(4, 3, 4, 3);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(37, 23);
            txtUf.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 164);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 13;
            label7.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(20, 182);
            txtCidade.Margin = new Padding(4, 3, 4, 3);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(227, 23);
            txtCidade.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 164);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "CIDADE:";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(20, 136);
            txtCep.Margin = new Padding(4, 3, 4, 3);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(83, 23);
            txtCep.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 118);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(524, 137);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(209, 23);
            txtBairro.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "BAIRRO:";
            // 
            // txtId
            // 
            txtId.Location = new Point(20, 42);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 0;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(153, 137);
            txtEnd.Margin = new Padding(4, 3, 4, 3);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(308, 23);
            txtEnd.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 13);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "END:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "NOME/RAZÃO:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 91);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(348, 23);
            txtNome.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(776, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvarToolStripMenuItem, excluirToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.ShortcutKeys = Keys.F3;
            salvarToolStripMenuItem.Size = new Size(128, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.ShortcutKeys = Keys.F6;
            excluirToolStripMenuItem.Size = new Size(128, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(128, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relaçãoGeralToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relaçãoGeralToolStripMenuItem
            // 
            relaçãoGeralToolStripMenuItem.Name = "relaçãoGeralToolStripMenuItem";
            relaçãoGeralToolStripMenuItem.Size = new Size(205, 22);
            relaçãoGeralToolStripMenuItem.Text = "Relação geral de Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 76);
            panel1.TabIndex = 20;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(119, 3);
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
            btnExcluir.Location = new Point(68, 3);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(57, 67);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.TopCenter;
            btnSalvar.Location = new Point(14, 3);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(57, 67);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 500);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCadCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            Load += FrmCadCliente_Load;
            KeyDown += FrmCadCliente_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbTipo;
        private Label label10;
        private ComboBox cbTipo;
        private TextBox txtNum;
        private Label label8;
        private Button btCep;
        private TextBox txtUf;
        private Label label7;
        private TextBox txtCidade;
        private Label label6;
        private TextBox txtCep;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtId;
        private TextBox txtEnd;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private Button Btncnpj;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relaçãoGeralToolStripMenuItem;
        private TextBox txtEmail;
        private Label label9;
        private Label label11;
        private TextBox txtFantasia;
        private Label label12;
        private MaskedTextBox maskFone;
        private TextBox txtContato;
        private Label label14;
        private Label label13;
        private MaskedTextBox maskCelular;
        private MaskedTextBox maskCnpjCpf;
        private TextBox txtRoteiro;
        private Label label15;
        private Label label16;
        private MaskedTextBox maskData;
        private Label label29;
        private MaskedTextBox maskDataNasc;
        private Label label28;
        private TextBox textBox1;
        private MaskedTextBox txtIE;
        private Label label27;
        private Panel panel1;
        private Button btnSalvar;
        private Button btnSair;
        private Button btnExcluir;
    }
}