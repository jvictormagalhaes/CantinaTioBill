namespace CantinaDoTioBill
{
    partial class FrmCadastroUsuario
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
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuInicio = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quentinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaBalcãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbStatusAtivo = new System.Windows.Forms.RadioButton();
            this.rbStatusInativo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.MenuInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(632, 410);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 28);
            this.bntSalvar.TabIndex = 0;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(713, 410);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 28);
            this.bntSair.TabIndex = 1;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
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
            this.MenuInicio.Size = new System.Drawing.Size(800, 28);
            this.MenuInicio.TabIndex = 13;
            this.MenuInicio.Text = "MenuInicio";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.cadastroToolStripMenuItem.Text = "Usuário";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.usuáriosToolStripMenuItem.Text = "Cadastro de Usuário";
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
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // quentinhasToolStripMenuItem
            // 
            this.quentinhasToolStripMenuItem.Name = "quentinhasToolStripMenuItem";
            this.quentinhasToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.quentinhasToolStripMenuItem.Text = "Tipos de Quentinhas";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaBalcãoToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaBalcãoToolStripMenuItem
            // 
            this.vendaBalcãoToolStripMenuItem.Name = "vendaBalcãoToolStripMenuItem";
            this.vendaBalcãoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.vendaBalcãoToolStripMenuItem.Text = "Venda Balcão";
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(286, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 22);
            this.txtNome.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(286, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 22);
            this.txtUsername.TabIndex = 16;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(427, 56);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(135, 22);
            this.txtSenha.TabIndex = 18;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(427, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbStatusAtivo
            // 
            this.rbStatusAtivo.AutoSize = true;
            this.rbStatusAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusAtivo.Location = new System.Drawing.Point(577, 54);
            this.rbStatusAtivo.Name = "rbStatusAtivo";
            this.rbStatusAtivo.Size = new System.Drawing.Size(67, 24);
            this.rbStatusAtivo.TabIndex = 19;
            this.rbStatusAtivo.TabStop = true;
            this.rbStatusAtivo.Text = "Ativo";
            this.rbStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // rbStatusInativo
            // 
            this.rbStatusInativo.AutoSize = true;
            this.rbStatusInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusInativo.Location = new System.Drawing.Point(650, 54);
            this.rbStatusInativo.Name = "rbStatusInativo";
            this.rbStatusInativo.Size = new System.Drawing.Size(78, 24);
            this.rbStatusInativo.TabIndex = 20;
            this.rbStatusInativo.TabStop = true;
            this.rbStatusInativo.Text = "Inativo";
            this.rbStatusInativo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(574, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Location = new System.Drawing.Point(568, 31);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(167, 57);
            this.pnlStatus.TabIndex = 22;
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbStatusInativo);
            this.Controls.Add(this.rbStatusAtivo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.pnlStatus);
            this.Name = "FrmCadastroUsuario";
            this.Text = "Cadastro de Usuários";
            this.MenuInicio.ResumeLayout(false);
            this.MenuInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MenuInicio;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quentinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaBalcãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbStatusAtivo;
        private System.Windows.Forms.RadioButton rbStatusInativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlStatus;
    }
}