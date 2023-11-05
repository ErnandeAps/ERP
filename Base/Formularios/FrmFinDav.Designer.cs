namespace Base.Formularios
{
    partial class FrmFinDav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinDav));
            dtGrid = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            btnSair = new Button();
            groupBox1 = new GroupBox();
            mskCriterio = new MaskedTextBox();
            lbTipo = new Label();
            cbTipo = new ComboBox();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtGrid
            // 
            dtGrid.AllowUserToAddRows = false;
            dtGrid.AllowUserToDeleteRows = false;
            dtGrid.AllowUserToOrderColumns = true;
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Location = new Point(2, 162);
            dtGrid.Margin = new Padding(4, 3, 4, 3);
            dtGrid.Name = "dtGrid";
            dtGrid.ReadOnly = true;
            dtGrid.Size = new Size(232, 153);
            dtGrid.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnSair);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 76);
            panel1.TabIndex = 30;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(18, 3);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(57, 67);
            button3.TabIndex = 14;
            button3.Text = "Finalizar";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(83, 3);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(57, 67);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(mskCriterio);
            groupBox1.Controls.Add(lbTipo);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 82);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(511, 74);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // mskCriterio
            // 
            mskCriterio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCriterio.Location = new Point(180, 29);
            mskCriterio.Margin = new Padding(4, 3, 4, 3);
            mskCriterio.Name = "mskCriterio";
            mskCriterio.Size = new Size(104, 26);
            mskCriterio.TabIndex = 1;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Franklin Gothic Medium Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTipo.Location = new Point(178, 11);
            lbTipo.Margin = new Padding(4, 0, 4, 0);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(66, 18);
            lbTipo.TabIndex = 23;
            lbTipo.Text = "Digite aqui:";
            lbTipo.Click += lbTipo_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(18, 35);
            cbTipo.Margin = new Padding(4, 3, 4, 3);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(154, 21);
            cbTipo.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 16);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 18);
            label10.TabIndex = 19;
            label10.Text = "Forma de Pag.:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(342, 11);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(48, 56);
            button2.TabIndex = 25;
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
            button1.Location = new Point(299, 11);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(48, 56);
            button1.TabIndex = 2;
            button1.Text = "Inserir";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(242, 241);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 41;
            label9.Text = "TOTAL PG.";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(364, 238);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.MaxLength = 100;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(122, 32);
            textBox7.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(242, 206);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 39;
            label8.Text = "DESCONTO";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(364, 203);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.MaxLength = 100;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 32);
            textBox6.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(242, 171);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 37;
            label7.Text = "TOTAL";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(364, 168);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.MaxLength = 100;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 32);
            textBox5.TabIndex = 38;
            // 
            // FrmFinDav
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 321);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dtGrid);
            Name = "FrmFinDav";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finalizar pagamento";
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGrid;
        private Panel panel1;
        private Button button3;
        private Button btnSair;
        private GroupBox groupBox1;
        private MaskedTextBox mskCriterio;
        private Label lbTipo;
        private ComboBox cbTipo;
        private Label label10;
        private Button button2;
        private Button button1;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
    }
}