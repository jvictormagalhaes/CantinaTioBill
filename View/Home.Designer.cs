namespace CantinaDoTioBill
{
    partial class FrmHome
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
            this.MenuInicio = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quentinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaBalcãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlFuncao = new System.Windows.Forms.Panel();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnTelaVenda = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuInicio.SuspendLayout();
            this.pnlFuncao.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuInicio
            // 
            this.MenuInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.cadastroToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.MenuInicio.Location = new System.Drawing.Point(0, 0);
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Size = new System.Drawing.Size(914, 28);
            this.MenuInicio.TabIndex = 1;
            this.MenuInicio.Text = "MenuInicio";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.cadastroToolStripMenuItem.Text = "Usuário";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.usuáriosToolStripMenuItem.Text = "Cadastro de Usuário";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.quentinhasToolStripMenuItem});
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // quentinhasToolStripMenuItem
            // 
            this.quentinhasToolStripMenuItem.Name = "quentinhasToolStripMenuItem";
            this.quentinhasToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.quentinhasToolStripMenuItem.Text = "Tipos de Quentinhas";
            this.quentinhasToolStripMenuItem.Click += new System.EventHandler(this.quentinhasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1,
            this.vendaBalcãoToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // vendaBalcãoToolStripMenuItem
            // 
            this.vendaBalcãoToolStripMenuItem.Name = "vendaBalcãoToolStripMenuItem";
            this.vendaBalcãoToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.vendaBalcãoToolStripMenuItem.Text = "Tela de Vendas";
            this.vendaBalcãoToolStripMenuItem.Click += new System.EventHandler(this.vendaBalcãoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeVendasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            this.relatórioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(806, 496);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlFuncao
            // 
            this.pnlFuncao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlFuncao.Controls.Add(this.label5);
            this.pnlFuncao.Controls.Add(this.label4);
            this.pnlFuncao.Controls.Add(this.label3);
            this.pnlFuncao.Controls.Add(this.label2);
            this.pnlFuncao.Controls.Add(this.label1);
            this.pnlFuncao.Controls.Add(this.btnVendas);
            this.pnlFuncao.Controls.Add(this.btnProdutos);
            this.pnlFuncao.Controls.Add(this.btnTelaVenda);
            this.pnlFuncao.Controls.Add(this.btnCliente);
            this.pnlFuncao.Controls.Add(this.btnUsuario);
            this.pnlFuncao.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFuncao.Location = new System.Drawing.Point(0, 28);
            this.pnlFuncao.Name = "pnlFuncao";
            this.pnlFuncao.Size = new System.Drawing.Size(120, 510);
            this.pnlFuncao.TabIndex = 0;
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundImage = global::CantinaDoTioBill.Properties.Resources.Vendas;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.Location = new System.Drawing.Point(20, 272);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(63, 56);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackgroundImage = global::CantinaDoTioBill.Properties.Resources.botaoProduto;
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.Location = new System.Drawing.Point(20, 188);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(63, 54);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTelaVenda
            // 
            this.btnTelaVenda.BackgroundImage = global::CantinaDoTioBill.Properties.Resources.vb;
            this.btnTelaVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTelaVenda.Location = new System.Drawing.Point(20, 359);
            this.btnTelaVenda.Name = "btnTelaVenda";
            this.btnTelaVenda.Size = new System.Drawing.Size(63, 53);
            this.btnTelaVenda.TabIndex = 2;
            this.btnTelaVenda.UseVisualStyleBackColor = true;
            this.btnTelaVenda.Click += new System.EventHandler(this.btnTelaVenda_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::CantinaDoTioBill.Properties.Resources.botaoCliente;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.Location = new System.Drawing.Point(20, 105);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(63, 53);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImage = global::CantinaDoTioBill.Properties.Resources.botãoUser;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.Location = new System.Drawing.Point(20, 24);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(63, 53);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogo.BackgroundImage = global::CantinaDoTioBill.Properties.Resources.teste;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(12, 31);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(871, 495);
            this.pnlLogo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vendas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tela de Venda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produtos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(914, 538);
            this.Controls.Add(this.pnlFuncao);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.MenuInicio);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuInicio;
            this.Name = "FrmHome";
            this.Text = "Tela de Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.MenuInicio.ResumeLayout(false);
            this.MenuInicio.PerformLayout();
            this.pnlFuncao.ResumeLayout(false);
            this.pnlFuncao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuInicio;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quentinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaBalcãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlFuncao;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnTelaVenda;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}