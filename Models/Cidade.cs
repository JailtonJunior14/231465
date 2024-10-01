using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _231465.Models
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }

        public string uf { get; set; }

        public void Incluir()
        {
            try
            {
                //Abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a instruçao desejada e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);
                //cria parametros utilizados na instruçaosql com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); //parametro string
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                //executa o comando no mysql, tem a funcao do raio do workbench
                Banco.Comando.ExecuteNonQuery();
                //fecha a conexao
                Banco.FecharConexao();

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
                //abre conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a instruçao desejada e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("Update cidades set nome = @nome, uf = @uf, where id =@id", Banco.Conexao);
                //cria parametros utilizados na instruçaosql com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); //parametro string
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                //executa o comando no mysql, tem a funcao do raio do workbench
                Banco.Comando.ExecuteNonQuery();
                //fecha a conexao
                Banco.FecharConexao();

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
                Banco.Comando = new MySqlCommand("delete from cidades where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
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
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like @Nome " + "order by nome", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
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
