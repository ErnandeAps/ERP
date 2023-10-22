
namespace Erp
{
    partial class FrmMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimentacao));
            panel1 = new Panel();
            btnParametros = new Button();
            btnProdutos = new Button();
            btnSair = new Button();
            btnNfe = new Button();
            btnOrcamento = new Button();
            btnVendas = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnParametros);
            panel1.Controls.Add(btnProdutos);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnNfe);
            panel1.Controls.Add(btnOrcamento);
            panel1.Controls.Add(btnVendas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 84);
            panel1.TabIndex = 2;
            // 
            // btnParametros
            // 
            btnParametros.BackColor = Color.White;
            btnParametros.FlatAppearance.BorderSize = 0;
            btnParametros.FlatStyle = FlatStyle.Flat;
            btnParametros.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnParametros.Image = (Image)resources.GetObject("btnParametros.Image");
            btnParametros.ImageAlign = ContentAlignment.TopCenter;
            btnParametros.Location = new Point(258, 3);
            btnParametros.Margin = new Padding(4, 3, 4, 3);
            btnParametros.Name = "btnParametros";
            btnParametros.Size = new Size(70, 74);
            btnParametros.TabIndex = 5;
            btnParametros.Text = "Estoque";
            btnParametros.TextAlign = ContentAlignment.BottomCenter;
            btnParametros.UseVisualStyleBackColor = false;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.White;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.TopCenter;
            btnProdutos.Location = new Point(197, 3);
            btnProdutos.Margin = new Padding(4, 3, 4, 3);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(70, 74);
            btnProdutos.TabIndex = 4;
            btnProdutos.Text = "Compras";
            btnProdutos.TextAlign = ContentAlignment.BottomCenter;
            btnProdutos.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(319, 3);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(70, 74);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnNfe
            // 
            btnNfe.BackColor = Color.White;
            btnNfe.FlatAppearance.BorderSize = 0;
            btnNfe.FlatStyle = FlatStyle.Flat;
            btnNfe.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNfe.Image = (Image)resources.GetObject("btnNfe.Image");
            btnNfe.ImageAlign = ContentAlignment.TopCenter;
            btnNfe.Location = new Point(136, 3);
            btnNfe.Margin = new Padding(4, 3, 4, 3);
            btnNfe.Name = "btnNfe";
            btnNfe.Size = new Size(70, 74);
            btnNfe.TabIndex = 2;
            btnNfe.Text = "NF-e";
            btnNfe.TextAlign = ContentAlignment.BottomCenter;
            btnNfe.UseVisualStyleBackColor = false;
            // 
            // btnOrcamento
            // 
            btnOrcamento.BackColor = Color.Transparent;
            btnOrcamento.FlatAppearance.BorderSize = 0;
            btnOrcamento.FlatStyle = FlatStyle.Flat;
            btnOrcamento.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrcamento.Image = (Image)resources.GetObject("btnOrcamento.Image");
            btnOrcamento.ImageAlign = ContentAlignment.TopCenter;
            btnOrcamento.Location = new Point(74, 3);
            btnOrcamento.Margin = new Padding(4, 3, 4, 3);
            btnOrcamento.Name = "btnOrcamento";
            btnOrcamento.Size = new Size(70, 74);
            btnOrcamento.TabIndex = 1;
            btnOrcamento.Text = "Dav";
            btnOrcamento.TextAlign = ContentAlignment.BottomCenter;
            btnOrcamento.UseVisualStyleBackColor = false;
            btnOrcamento.Click += btnOrcamento_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.Transparent;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVendas.Image = (Image)resources.GetObject("btnVendas.Image");
            btnVendas.ImageAlign = ContentAlignment.TopCenter;
            btnVendas.Location = new Point(13, 3);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(70, 74);
            btnVendas.TabIndex = 0;
            btnVendas.Text = "Vendas";
            btnVendas.TextAlign = ContentAlignment.BottomCenter;
            btnVendas.UseVisualStyleBackColor = false;
            // 
            // FrmMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 519);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMovimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVendas";
            WindowState = FormWindowState.Maximized;
            KeyDown += FrmVendas_KeyDown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnParametros;
        private Button btnProdutos;
        private Button btnSair;
        private Button btnNfe;
        private Button btnOrcamento;
        private Button btnVendas;
    }
}