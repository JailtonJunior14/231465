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
    public partial class FrmCategorias : Form
    {
        Categoria  cat;
        public FrmCategorias()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txtID.Clear();
            txtCate.Clear();
            txtCons.Clear();
        }
        void carregarGrid(string pesquisa)
        {

            cat = new Categoria()
            {
                categorias = pesquisa
            };
            dgvCategorias.DataSource = cat.Consultar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCate.Text == string.Empty) return;

            cat = new Categoria()
            {
                categorias = txtCate.Text
            };

            cat.Incluir();
            limpaControles();
            carregarGrid("");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            cat = new Categoria()
            {
                id = int.Parse(txtID.Text),
                categorias = txtCate.Text
            };
            cat.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a categoria?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cat = new Categoria()
                {
                    id = int.Parse(txtID.Text)
                };
                cat.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            carregarGrid(txtCons.Text);
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                txtID.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtCate.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }
    }
}
