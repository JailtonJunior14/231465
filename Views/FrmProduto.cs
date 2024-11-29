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
                idCategoria = (int)cbocate.SelectedValue,  // Usando SelectedValue para pegar o ID da Categoria
                idMarca = (int)cbomar.SelectedValue,  // Usando SelectedValue para pegar o ID da Marca
                venda = double.Parse(txtVenda.Text),
                estoque = double.Parse(txtEstoque.Text),
                foto = picPro.ImageLocation
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
                idCategoria = (int)cbocate.SelectedValue,  // Pegando o ID da Categoria
                idMarca = (int)cbomar.SelectedValue,  // Pegando o ID da Marca
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
                
            }

        }

        private void cbomar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomar.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbomar.SelectedItem;
                
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
                // Atribui as informações da linha da grid para os controles do formulário
                txtID.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                txtDesc.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();

                // Aqui, ao invés de setar o texto, definimos o valor do ComboBox com o ID
                cbocate.SelectedValue = dgvProdutos.CurrentRow.Cells["idCategoria"].Value; // Atribui o ID de Categoria
                cbomar.SelectedValue = dgvProdutos.CurrentRow.Cells["idMarca"].Value; // Atribui o ID de Marca

                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                txtVenda.Text = dgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
                picPro.ImageLocation = dgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void FrmProduto_Load_1(object sender, EventArgs e)
        {
            cat = new Categoria();
            cbocate.DataSource = cat.Consultar();
            cbocate.DisplayMember = "categoria";  // Nome que aparecerá no ComboBox
            cbocate.ValueMember = "id";  // Valor que será enviado, o ID da categoria

            m = new Marca();
            cbomar.DataSource = m.Consultar();
            cbomar.DisplayMember = "marca";  // Nome que aparecerá no ComboBox
            cbomar.ValueMember = "id";  // Valor que será enviado, o ID da marca

            limpacontroles();
            carregarGrid("");

            // Esconde as colunas que não são necessárias exibir
            dgvProdutos.Columns["idMarca"].Visible = false;
            dgvProdutos.Columns["idCategoria"].Visible = false;
            dgvProdutos.Columns["foto"].Visible = false;
        }
    }
}
