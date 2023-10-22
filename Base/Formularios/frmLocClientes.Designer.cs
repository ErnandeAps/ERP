namespace Erp
{
    partial class frmLocClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocClientes));
            dtGrid = new DataGridView();
            panel1 = new Panel();
            btnFiltrar = new Button();
            groupBox1 = new GroupBox();
            mskCriterio = new MaskedTextBox();
            lbTipo = new Label();
            cbTipo = new ComboBox();
            label10 = new Label();
            btnSair = new Button();
            btnVisualizar = new Button();
            btnClientes = new Button();
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
            dtGrid.Location = new Point(14, 115);
            dtGrid.Margin = new Padding(4, 3, 4, 3);
            dtGrid.Name = "dtGrid";
            dtGrid.ReadOnly = true;
            dtGrid.Size = new Size(1150, 504);
            dtGrid.TabIndex = 0;
            dtGrid.CellContentClick += dtGrid_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnFiltrar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnVisualizar);
            panel1.Controls.Add(btnClientes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 91);
            panel1.TabIndex = 23;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.White;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageAlign = ContentAlignment.TopCenter;
            btnFiltrar.Location = new Point(715, 8);
            btnFiltrar.Margin = new Padding(4, 3, 4, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(70, 74);
            btnFiltrar.TabIndex = 25;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextAlign = ContentAlignment.BottomCenter;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mskCriterio);
            groupBox1.Controls.Add(lbTipo);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(226, 8);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(481, 74);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // mskCriterio
            // 
            mskCriterio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCriterio.Location = new Point(180, 29);
            mskCriterio.Margin = new Padding(4, 3, 4, 3);
            mskCriterio.Name = "mskCriterio";
            mskCriterio.Size = new Size(286, 26);
            mskCriterio.TabIndex = 22;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Franklin Gothic Medium Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTipo.Location = new Point(176, 11);
            lbTipo.Margin = new Padding(4, 0, 4, 0);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(66, 18);
            lbTipo.TabIndex = 23;
            lbTipo.Text = "Digite aqui:";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(18, 35);
            cbTipo.Margin = new Padding(4, 3, 4, 3);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(154, 21);
            cbTipo.TabIndex = 1;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 16);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(29, 18);
            label10.TabIndex = 19;
            label10.Text = "Tipo";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(128, 3);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(70, 74);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.Transparent;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualizar.Image = (Image)resources.GetObject("btnVisualizar.Image");
            btnVisualizar.ImageAlign = ContentAlignment.TopCenter;
            btnVisualizar.Location = new Point(66, 3);
            btnVisualizar.Margin = new Padding(4, 3, 4, 3);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(70, 74);
            btnVisualizar.TabIndex = 2;
            btnVisualizar.Text = "Exibir";
            btnVisualizar.TextAlign = ContentAlignment.BottomCenter;
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.TopCenter;
            btnClientes.Location = new Point(4, 3);
            btnClientes.Margin = new Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(70, 74);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Inserir";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // frmLocClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1177, 629);
            Controls.Add(panel1);
            Controls.Add(dtGrid);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLocClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Clientes";
            Load += frmLocClientes_Load;
            KeyDown += frmLocClientes_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGrid;
        private Panel panel1;
        private Button btnVisualizar;
        private Button btnClientes;
        private Button btnSair;
        private Button btnFiltrar;
        private GroupBox groupBox1;
        private MaskedTextBox mskCriterio;
        private Label lbTipo;
        private ComboBox cbTipo;
        private Label label10;
    }
}