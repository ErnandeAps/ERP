
namespace Erp
{
    partial class FrmTelaCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaCadastros));
            btnClientes = new Button();
            panel1 = new Panel();
            btnEstabelecimento = new Button();
            btnProdutos = new Button();
            btnSair = new Button();
            btnUsuario = new Button();
            btnVendedor = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.TopCenter;
            btnClientes.Location = new Point(12, 3);
            btnClientes.Margin = new Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(70, 74);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEstabelecimento);
            panel1.Controls.Add(btnProdutos);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnUsuario);
            panel1.Controls.Add(btnVendedor);
            panel1.Controls.Add(btnClientes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 84);
            panel1.TabIndex = 1;
            // 
            // btnEstabelecimento
            // 
            btnEstabelecimento.BackColor = Color.Transparent;
            btnEstabelecimento.FlatAppearance.BorderSize = 0;
            btnEstabelecimento.FlatStyle = FlatStyle.Flat;
            btnEstabelecimento.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstabelecimento.Image = (Image)resources.GetObject("btnEstabelecimento.Image");
            btnEstabelecimento.ImageAlign = ContentAlignment.TopCenter;
            btnEstabelecimento.Location = new Point(262, 4);
            btnEstabelecimento.Margin = new Padding(4, 3, 4, 3);
            btnEstabelecimento.Name = "btnEstabelecimento";
            btnEstabelecimento.Size = new Size(70, 74);
            btnEstabelecimento.TabIndex = 6;
            btnEstabelecimento.Text = "Loja";
            btnEstabelecimento.TextAlign = ContentAlignment.BottomCenter;
            btnEstabelecimento.UseVisualStyleBackColor = false;
            btnEstabelecimento.Click += btnEstabelecimento_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.Transparent;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.TopCenter;
            btnProdutos.Location = new Point(200, 3);
            btnProdutos.Margin = new Padding(4, 3, 4, 3);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(70, 74);
            btnProdutos.TabIndex = 4;
            btnProdutos.Text = "Produtos";
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
            btnSair.Location = new Point(324, 4);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(70, 74);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.Transparent;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = ContentAlignment.TopCenter;
            btnUsuario.Location = new Point(137, 3);
            btnUsuario.Margin = new Padding(4, 3, 4, 3);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(70, 74);
            btnUsuario.TabIndex = 2;
            btnUsuario.Text = "Usuários";
            btnUsuario.TextAlign = ContentAlignment.BottomCenter;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = Color.Transparent;
            btnVendedor.FlatAppearance.BorderSize = 0;
            btnVendedor.FlatStyle = FlatStyle.Flat;
            btnVendedor.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVendedor.Image = (Image)resources.GetObject("btnVendedor.Image");
            btnVendedor.ImageAlign = ContentAlignment.TopCenter;
            btnVendedor.Location = new Point(74, 3);
            btnVendedor.Margin = new Padding(4, 3, 4, 3);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(70, 74);
            btnVendedor.TabIndex = 1;
            btnVendedor.Text = "Vendedor";
            btnVendedor.TextAlign = ContentAlignment.BottomCenter;
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnFornecedores_Click;
            // 
            // FrmTelaCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 623);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmTelaCadastros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTelaCadastros";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Panel panel1;
        private Button btnSair;
        private Button btnUsuario;
        private Button btnVendedor;
        private Button btnProdutos;
        private Button btnEstabelecimento;
    }
}