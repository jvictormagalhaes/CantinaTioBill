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
           
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vendaBalcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
