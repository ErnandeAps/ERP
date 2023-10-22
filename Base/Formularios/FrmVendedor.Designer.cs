namespace Base.Formularios
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label29 = new Label();
            maskDataNasc = new MaskedTextBox();
            txtRg = new MaskedTextBox();
            label27 = new Label();
            label16 = new Label();
            maskData = new MaskedTextBox();
            txtRoteiro = new TextBox();
            label15 = new Label();
            maskCpf = new MaskedTextBox();
            txtContato = new TextBox();
            label14 = new Label();
            label13 = new Label();
            maskCelular = new MaskedTextBox();
            label12 = new Label();
            maskFone = new MaskedTextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            lbTipo = new Label();
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
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(776, 24);
            menuStrip1.TabIndex = 10;
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
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.ShortcutKeys = Keys.F6;
            excluirToolStripMenuItem.Size = new Size(128, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(128, 22);
            sairToolStripMenuItem.Text = "Sair";
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
            panel1.TabIndex = 21;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label29);
            groupBox1.Controls.Add(maskDataNasc);
            groupBox1.Controls.Add(txtRg);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(maskData);
            groupBox1.Controls.Add(txtRoteiro);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(maskCpf);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(maskCelular);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(maskFone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lbTipo);
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
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados cadastrais";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(361, 224);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 208);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 45;
            label10.Text = "COMISSÃO AP.:\r\n";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(638, 166);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(60, 15);
            label29.TabIndex = 43;
            label29.Text = "DT NASC.:";
            // 
            // maskDataNasc
            // 
            maskDataNasc.Location = new Point(637, 183);
            maskDataNasc.Margin = new Padding(4, 3, 4, 3);
            maskDataNasc.Mask = "00/00/0000";
            maskDataNasc.Name = "maskDataNasc";
            maskDataNasc.Size = new Size(96, 23);
            maskDataNasc.TabIndex = 10;
            maskDataNasc.ValidatingType = typeof(DateTime);
            // 
            // txtRg
            // 
            txtRg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRg.Location = new Point(570, 89);
            txtRg.Margin = new Padding(4, 3, 4, 3);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(119, 26);
            txtRg.TabIndex = 2;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(568, 71);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(25, 15);
            label27.TabIndex = 39;
            label27.Text = "RG:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(633, 23);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 37;
            label16.Text = "DATA";
            // 
            // maskData
            // 
            maskData.Location = new Point(637, 42);
            maskData.Margin = new Padding(4, 3, 4, 3);
            maskData.Mask = "00/00/0000";
            maskData.Name = "maskData";
            maskData.Size = new Size(96, 23);
            maskData.TabIndex = 36;
            maskData.ValidatingType = typeof(DateTime);
            // 
            // txtRoteiro
            // 
            txtRoteiro.Location = new Point(21, 268);
            txtRoteiro.Margin = new Padding(4, 3, 4, 3);
            txtRoteiro.Multiline = true;
            txtRoteiro.Name = "txtRoteiro";
            txtRoteiro.Size = new Size(713, 80);
            txtRoteiro.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 250);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 33;
            label15.Text = "ROTEIRO:\r\n";
            // 
            // maskCpf
            // 
            maskCpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskCpf.Location = new Point(419, 88);
            maskCpf.Margin = new Padding(4, 3, 4, 3);
            maskCpf.Name = "maskCpf";
            maskCpf.Size = new Size(149, 26);
            maskCpf.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(258, 224);
            txtContato.Margin = new Padding(4, 3, 4, 3);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(100, 23);
            txtContato.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(256, 208);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(90, 15);
            label14.TabIndex = 31;
            label14.Text = "COMISSÃO AV.:\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(137, 207);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 29;
            label13.Text = "CELULAR:";
            // 
            // maskCelular
            // 
            maskCelular.Location = new Point(139, 224);
            maskCelular.Margin = new Padding(4, 3, 4, 3);
            maskCelular.Mask = "(99) 00000-0000";
            maskCelular.Name = "maskCelular";
            maskCelular.Size = new Size(116, 23);
            maskCelular.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 207);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 27;
            label12.Text = "FONE:";
            // 
            // maskFone
            // 
            maskFone.Location = new Point(21, 224);
            maskFone.Margin = new Padding(4, 3, 4, 3);
            maskFone.Mask = "(99) 0000-0000";
            maskFone.Name = "maskFone";
            maskFone.Size = new Size(116, 23);
            maskFone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(296, 183);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 23);
            txtEmail.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(294, 166);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 23;
            label9.Text = "EMAIL:\r\n";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(417, 70);
            lbTipo.Margin = new Padding(4, 0, 4, 0);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(31, 15);
            lbTipo.TabIndex = 20;
            lbTipo.Text = "CPF:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(469, 137);
            txtNum.Margin = new Padding(4, 3, 4, 3);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(51, 23);
            txtNum.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 119);
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
            // 
            // txtUf
            // 
            txtUf.Location = new Point(254, 182);
            txtUf.Margin = new Padding(4, 3, 4, 3);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(37, 23);
            txtUf.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 164);
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
            txtCidade.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 164);
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
            txtCep.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 118);
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
            txtBairro.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 119);
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
            txtEnd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 13);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "END:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "NOME:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 91);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(396, 23);
            txtNome.TabIndex = 0;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 500);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            Name = "FrmVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Vendedores";
            KeyDown += FrmVendedor_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relaçãoGeralToolStripMenuItem;
        private Panel panel1;
        private Button btnSair;
        private Button btnExcluir;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private Label label29;
        private MaskedTextBox maskDataNasc;
        private MaskedTextBox txtRg;
        private Label label27;
        private Label label16;
        private MaskedTextBox maskData;
        private TextBox txtRoteiro;
        private Label label15;
        private MaskedTextBox maskCpf;
        private TextBox txtContato;
        private Label label14;
        private Label label13;
        private MaskedTextBox maskCelular;
        private Label label12;
        private MaskedTextBox maskFone;
        private TextBox txtEmail;
        private Label label9;
        private Label lbTipo;
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
        private TextBox textBox1;
        private Label label10;
    }
}