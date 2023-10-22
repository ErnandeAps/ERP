namespace Base.Formularios
{
    partial class FrmCadEstabelecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEstabelecimento));
            panel1 = new Panel();
            button1 = new Button();
            btnSalvar = new Button();
            tabPg = new TabControl();
            PgEmitente = new TabPage();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            label19 = new Label();
            label18 = new Label();
            txtCRT = new TextBox();
            label17 = new Label();
            txtCnae = new TextBox();
            label28 = new Label();
            textBox1 = new TextBox();
            txtIE = new MaskedTextBox();
            label27 = new Label();
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
            BtnPcnpj = new Button();
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
            pgContabil = new TabPage();
            groupBox2 = new GroupBox();
            txtCpfContador = new TextBox();
            txtCRC = new TextBox();
            label16 = new Label();
            label29 = new Label();
            maskTeleContador = new MaskedTextBox();
            txtEmailContador = new TextBox();
            label31 = new Label();
            label32 = new Label();
            label41 = new Label();
            txtNomeContador = new TextBox();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            tabPg.SuspendLayout();
            PgEmitente.SuspendLayout();
            groupBox1.SuspendLayout();
            pgContabil.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 76);
            panel1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(68, 3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(51, 67);
            button1.TabIndex = 13;
            button1.Text = "Sair";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            btnSalvar.Size = new Size(51, 67);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // tabPg
            // 
            tabPg.Controls.Add(PgEmitente);
            tabPg.Controls.Add(pgContabil);
            tabPg.Location = new Point(5, 82);
            tabPg.Name = "tabPg";
            tabPg.SelectedIndex = 0;
            tabPg.Size = new Size(785, 412);
            tabPg.TabIndex = 22;
            // 
            // PgEmitente
            // 
            PgEmitente.Controls.Add(groupBox1);
            PgEmitente.Location = new Point(4, 24);
            PgEmitente.Name = "PgEmitente";
            PgEmitente.Padding = new Padding(3);
            PgEmitente.Size = new Size(777, 384);
            PgEmitente.TabIndex = 0;
            PgEmitente.Text = "Geral";
            PgEmitente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtCRT);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(txtCnae);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtIE);
            groupBox1.Controls.Add(label27);
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
            groupBox1.Controls.Add(BtnPcnpj);
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
            groupBox1.Location = new Point(7, 6);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(752, 361);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados cadastrais";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(537, 36);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(119, 26);
            maskedTextBox1.TabIndex = 48;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(535, 18);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(30, 15);
            label19.TabIndex = 49;
            label19.Text = "MEI:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(167, 199);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(30, 15);
            label18.TabIndex = 47;
            label18.Text = "CRT:";
            // 
            // txtCRT
            // 
            txtCRT.Location = new Point(166, 217);
            txtCRT.Margin = new Padding(4, 3, 4, 3);
            txtCRT.Name = "txtCRT";
            txtCRT.Size = new Size(143, 23);
            txtCRT.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 199);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(41, 15);
            label17.TabIndex = 45;
            label17.Text = "CNAE:";
            // 
            // txtCnae
            // 
            txtCnae.Location = new Point(20, 217);
            txtCnae.Margin = new Padding(4, 3, 4, 3);
            txtCnae.MaxLength = 7;
            txtCnae.Name = "txtCnae";
            txtCnae.Size = new Size(143, 23);
            txtCnae.TabIndex = 44;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(295, 155);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(61, 15);
            label28.TabIndex = 41;
            label28.Text = "CÓD. IBJE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 173);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 12;
            // 
            // txtIE
            // 
            txtIE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIE.Location = new Point(413, 36);
            txtIE.Margin = new Padding(4, 3, 4, 3);
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(119, 26);
            txtIE.TabIndex = 3;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(411, 18);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(19, 15);
            label27.TabIndex = 39;
            label27.Text = "IE:";
            // 
            // txtRoteiro
            // 
            txtRoteiro.Location = new Point(21, 259);
            txtRoteiro.Margin = new Padding(4, 3, 4, 3);
            txtRoteiro.Multiline = true;
            txtRoteiro.Name = "txtRoteiro";
            txtRoteiro.Size = new Size(713, 80);
            txtRoteiro.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 241);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 33;
            label15.Text = "ROTEIRO:\r\n";
            // 
            // maskCnpjCpf
            // 
            maskCnpjCpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskCnpjCpf.Location = new Point(171, 38);
            maskCnpjCpf.Margin = new Padding(4, 3, 4, 3);
            maskCnpjCpf.Name = "maskCnpjCpf";
            maskCnpjCpf.Size = new Size(196, 26);
            maskCnpjCpf.TabIndex = 2;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(550, 217);
            txtContato.Margin = new Padding(4, 3, 4, 3);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(183, 23);
            txtContato.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(548, 199);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 31;
            label14.Text = "CONTATO:\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(430, 200);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 29;
            label13.Text = "CELULAR:";
            // 
            // maskCelular
            // 
            maskCelular.Location = new Point(432, 217);
            maskCelular.Margin = new Padding(4, 3, 4, 3);
            maskCelular.Mask = "(99) 00000-0000";
            maskCelular.Name = "maskCelular";
            maskCelular.Size = new Size(116, 23);
            maskCelular.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(310, 200);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 27;
            label12.Text = "FONE:";
            // 
            // maskFone
            // 
            maskFone.Location = new Point(313, 217);
            maskFone.Margin = new Padding(4, 3, 4, 3);
            maskFone.Mask = "(99) 0000-0000";
            maskFone.Name = "maskFone";
            maskFone.Size = new Size(116, 23);
            maskFone.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(373, 67);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 25;
            label11.Text = "FANTASIA:";
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(374, 84);
            txtFantasia.Margin = new Padding(4, 3, 4, 3);
            txtFantasia.MaxLength = 60;
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(358, 23);
            txtFantasia.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(442, 173);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.MaxLength = 132;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 23);
            txtEmail.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(440, 156);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 23;
            label9.Text = "EMAIL:\r\n";
            // 
            // BtnPcnpj
            // 
            BtnPcnpj.FlatAppearance.BorderSize = 0;
            BtnPcnpj.FlatStyle = FlatStyle.Flat;
            BtnPcnpj.Image = (Image)resources.GetObject("BtnPcnpj.Image");
            BtnPcnpj.Location = new Point(369, 29);
            BtnPcnpj.Margin = new Padding(4, 3, 4, 3);
            BtnPcnpj.Name = "BtnPcnpj";
            BtnPcnpj.Size = new Size(35, 35);
            BtnPcnpj.TabIndex = 21;
            BtnPcnpj.UseVisualStyleBackColor = true;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(169, 20);
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
            label10.Location = new Point(90, 22);
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
            // 
            // txtNum
            // 
            txtNum.Location = new Point(469, 130);
            txtNum.Margin = new Padding(4, 3, 4, 3);
            txtNum.MaxLength = 15;
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(52, 23);
            txtNum.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 112);
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
            btCep.Location = new Point(106, 118);
            btCep.Margin = new Padding(4, 3, 4, 3);
            btCep.Name = "btCep";
            btCep.Size = new Size(35, 35);
            btCep.TabIndex = 14;
            btCep.UseVisualStyleBackColor = true;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(252, 173);
            txtUf.Margin = new Padding(4, 3, 4, 3);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(37, 23);
            txtUf.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 155);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 13;
            label7.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(20, 173);
            txtCidade.Margin = new Padding(4, 3, 4, 3);
            txtCidade.MaxLength = 40;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(227, 23);
            txtCidade.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 155);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "MUNICÍPIO:";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(20, 129);
            txtCep.Margin = new Padding(4, 3, 4, 3);
            txtCep.MaxLength = 9;
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(83, 23);
            txtCep.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 111);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(524, 130);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.MaxLength = 20;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(209, 23);
            txtBairro.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "BAIRRO:";
            // 
            // txtId
            // 
            txtId.Location = new Point(21, 39);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 0;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(150, 130);
            txtEnd.Margin = new Padding(4, 3, 4, 3);
            txtEnd.MaxLength = 35;
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(314, 23);
            txtEnd.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 13);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "LOGRADOURO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "NOME/RAZÃO:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 84);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(351, 23);
            txtNome.TabIndex = 4;
            // 
            // pgContabil
            // 
            pgContabil.Controls.Add(groupBox2);
            pgContabil.Location = new Point(4, 24);
            pgContabil.Name = "pgContabil";
            pgContabil.Padding = new Padding(3);
            pgContabil.Size = new Size(777, 384);
            pgContabil.TabIndex = 1;
            pgContabil.Text = "Contábil";
            pgContabil.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCpfContador);
            groupBox2.Controls.Add(txtCRC);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(maskTeleContador);
            groupBox2.Controls.Add(txtEmailContador);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label41);
            groupBox2.Controls.Add(txtNomeContador);
            groupBox2.Location = new Point(7, 7);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(752, 361);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Contador";
            // 
            // txtCpfContador
            // 
            txtCpfContador.Location = new Point(21, 84);
            txtCpfContador.Margin = new Padding(4, 3, 4, 3);
            txtCpfContador.MaxLength = 11;
            txtCpfContador.Name = "txtCpfContador";
            txtCpfContador.Size = new Size(156, 23);
            txtCpfContador.TabIndex = 51;
            // 
            // txtCRC
            // 
            txtCRC.Location = new Point(21, 128);
            txtCRC.Margin = new Padding(4, 3, 4, 3);
            txtCRC.MaxLength = 9;
            txtCRC.Name = "txtCRC";
            txtCRC.Size = new Size(116, 23);
            txtCRC.TabIndex = 50;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 110);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(33, 15);
            label16.TabIndex = 49;
            label16.Text = "CRC:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(21, 155);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(40, 15);
            label29.TabIndex = 27;
            label29.Text = "FONE:";
            // 
            // maskTeleContador
            // 
            maskTeleContador.Location = new Point(21, 172);
            maskTeleContador.Margin = new Padding(4, 3, 4, 3);
            maskTeleContador.Mask = "(99) 00000-0000";
            maskTeleContador.Name = "maskTeleContador";
            maskTeleContador.Size = new Size(116, 23);
            maskTeleContador.TabIndex = 15;
            // 
            // txtEmailContador
            // 
            txtEmailContador.Location = new Point(21, 215);
            txtEmailContador.Margin = new Padding(4, 3, 4, 3);
            txtEmailContador.MaxLength = 132;
            txtEmailContador.Name = "txtEmailContador";
            txtEmailContador.Size = new Size(291, 23);
            txtEmailContador.TabIndex = 13;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(21, 198);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(44, 15);
            label31.TabIndex = 23;
            label31.Text = "EMAIL:\r\n";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(21, 66);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(31, 15);
            label32.TabIndex = 20;
            label32.Text = "CPF:";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(21, 22);
            label41.Margin = new Padding(4, 0, 4, 0);
            label41.Name = "label41";
            label41.Size = new Size(45, 15);
            label41.TabIndex = 3;
            label41.Text = "NOME:";
            // 
            // txtNomeContador
            // 
            txtNomeContador.Location = new Point(21, 40);
            txtNomeContador.Margin = new Padding(4, 3, 4, 3);
            txtNomeContador.MaxLength = 60;
            txtNomeContador.Name = "txtNomeContador";
            txtNomeContador.Size = new Size(351, 23);
            txtNomeContador.TabIndex = 4;
            // 
            // FrmCadEstabelecimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(797, 505);
            Controls.Add(tabPg);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FrmCadEstabelecimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Estabelecimento";
            KeyDown += FrmCadEstabelecimento_KeyDown;
            panel1.ResumeLayout(false);
            tabPg.ResumeLayout(false);
            PgEmitente.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pgContabil.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnSalvar;
        private TabControl tabPg;
        private TabPage PgEmitente;
        private TabPage pgContabil;
        private GroupBox groupBox1;
        private Label label28;
        private TextBox textBox1;
        private MaskedTextBox txtIE;
        private Label label27;
        private TextBox txtRoteiro;
        private Label label15;
        private MaskedTextBox maskCnpjCpf;
        private TextBox txtContato;
        private Label label14;
        private Label label13;
        private MaskedTextBox maskCelular;
        private Label label12;
        private MaskedTextBox maskFone;
        private Label label11;
        private TextBox txtFantasia;
        private TextBox txtEmail;
        private Label label9;
        private Button BtnPcnpj;
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
        private Label label17;
        private TextBox txtCnae;
        private HelpProvider helpProvider1;
        private Label label18;
        private TextBox txtCRT;
        private MaskedTextBox maskedTextBox1;
        private Label label19;
        private GroupBox groupBox2;
        private Label label16;
        private MaskedTextBox maskedTextBox4;
        private Label label29;
        private MaskedTextBox maskTeleContador;
        private TextBox txtEmailContador;
        private Label label31;
        private Label label32;
        private Label label41;
        private TextBox txtNomeContador;
        private TextBox txtCRC;
        private TextBox txtCpfContador;
    }
}