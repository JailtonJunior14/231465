using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.Windows.Forms;
using System.Data;

namespace _231465.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string desc { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
        public double venda { get; set; }
        public double estoque { get; set; }
        public string foto { get; set; }


        public void incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO produtos (descricao, idCategoria, idMarca, foto, valorVenda, estoque) " +
                    "VALUES (@descricao, @idCategoria, @idMarca,@foto, @valorVenda, @estoque)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", desc);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", venda);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("delete from produtos where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand
                    ("UPDATE produtos SET descricao = @descricao, idCategoria = @idCategoria, idMarca = @idMarca, " +
                    "foto= @foto, valorVenda = @valorVenda, estoque = @estoque where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", desc);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", venda);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT P.*, m.marca, c.categoria FROM " +
                                                    "Produtos p inner join Marcas m on (m.id = p.idMarca) " +
                                                    "inner join Categorias c on (c.id = p.idCategoria) " +
                                                    "where p.descricao like @descricao order by p.descricao", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", desc + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.Adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
