using CantinaDoTioBill.View;
using System;
using System.Windows.Forms;

namespace CantinaDoTioBill
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quentinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTpQuentinha tpQuentinha = new FrmTpQuentinha();
            tpQuentinha.ShowDialog();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja realmente sair ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { };
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos= new FrmProdutos();
            produtos.ShowDialog();
        }

        private void vendaBalcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaVenda vb = new FrmTelaVenda();
            vb.ShowDialog();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.ShowDialog();
        }

        private void btnTelaVenda_Click(object sender, EventArgs e)
        {
            FrmTelaVenda telavendas = new FrmTelaVenda();
            telavendas.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
