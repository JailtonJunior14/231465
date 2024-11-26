using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231465.Models;

namespace _231465.Views
{
    public partial class FrmProduto : Form
    {
        Produto p;
        Categoria cat;
        Marca m;
        public FrmProduto()
        {
            InitializeComponent();
        }
        void limpacontroles()
        {
            txtID.Clear();
            txtDesc.Clear();
            cbocate.SelectedIndex = -1;
            cbomar.SelectedIndex = -1;
            txtVenda.Clear();
            picPro.ImageLocation = "";

        }
        void carregarGrid(string pesquisa)
        {
            p = new Produto()
            {
                desc = pesquisa
            };
            dgvProdutos.DataSource = p.Consultar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "") return;

            p = new Produto()
            {
                desc = txtDesc.Text,
                idCategoria = (int)cbocate.SelectedValue,
                idMarca = (int)cbomar.SelectedValue,
                venda = double.Parse(txtVenda.Text),
                estoque = double.Parse(txtEstoque.Text),
                foto = picPro.ImageLocation,

            };
            p.incluir();

            limpacontroles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            p = new Produto()
            {
                id = int.Parse(txtID.Text),
                desc = txtDesc.Text,
                idCategoria = (int)cbocate.SelectedValue,
                idMarca = (int)cbomar.SelectedValue,
                venda = double.Parse(txtVenda.Text),
                estoque = double.Parse(txtEstoque.Text),
                foto = picPro.ImageLocation


            };
            p.Alterar();

            limpacontroles();
            carregarGrid("");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir o produto?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                p = new Produto()
                {
                    id = int.Parse(txtID.Text)

                };

                p.Excluir();
                limpacontroles();
                carregarGrid("");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtCons.Text);
        }

        private void cbocate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocate.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbocate.SelectedItem;
                txtID.Text = reg["id"].ToString();
            }
        }

        private void cbomar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomar.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbomar.SelectedItem;
                txtID.Text = reg["id"].ToString();
            }
        }

        private void picPro_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:fotos/produtos/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picPro.ImageLocation = ofdArquivo.FileName;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.Rows.Count > 0)
            {
                txtID.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                txtDesc.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
                cbocate.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
                cbomar.Text = dgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                txtVenda.Text = dgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
                picPro.ImageLocation = dgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void FrmProduto_Load_1(object sender, EventArgs e)
        {
            cat = new Categoria();
            cbocate.DataSource = cat.Consultar();
            cbocate.DisplayMember = "categoria";
            cbocate.ValueMember = "id";

            m = new Marca();
            cbomar.DataSource = m.Consultar();
            cbomar.DisplayMember = "marca";
            cbomar.ValueMember = "id";

            limpacontroles();
            carregarGrid("");

            dgvProdutos.Columns["idmarca"].Visible = false;
            dgvProdutos.Columns["idcategoria"].Visible = false;
            dgvProdutos.Columns["foto"].Visible = false;
        }
    }
}
