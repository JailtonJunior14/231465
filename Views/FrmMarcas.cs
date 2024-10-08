using _231465.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231465.Views
{
    public partial class FrmMarcas : Form
    {
        Marca m;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtMarca.Clear();
            txtPesquisa.Clear();
        }
        void carregarGrid(string pesquisa)
        {

            m = new Marca()
            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = m.Consultar();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnadd_Click(object sender, EventArgs e) //botao incluir
        {
            if (txtMarca.Text == string.Empty) return;

            m = new Marca()
            {
                marca = txtMarca.Text
            };

            m.Incluir();
            limpaControles();
            carregarGrid("");
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMarcas.RowCount > 0)
            {
                txtMarca.Text = dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
                txttID.Text = dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            m = new Marca()
            {
                id = int.Parse(txtID.Text),
                marca = txtMarca.Text
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a Marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    id = int.Parse(txtID.Text)
                };
                m.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }
    }
}
