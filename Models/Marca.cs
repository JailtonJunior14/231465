using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231465.Models
{
    public class Marca
    {
        public int id { get; set; }
        public string marca { get; set; }

        public void Incluir()
        {
            try
            {
                //Abre a conexao com o banco
                Banco.AbrirConexao();
                //alimenta o metodo command com a instruçao desejada e indica a conexao utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO marcas (marca) VALUES (@marca)", Banco.Conexao);
                //cria parametros utilizados na instruçaosql com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@marca", marca); //parametro string
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
                Banco.Comando = new MySqlCommand("UPDATE marcas SET marca = @marca where id =@id", Banco.Conexao);
                //cria parametros utilizados na instruçaosql com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@marca", marca); //parametro string
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
                Banco.Comando = new MySqlCommand("delete from marcas where id = @id", Banco.Conexao);
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
                Banco.Comando = new MySqlCommand("SELECT * FROM marcas where marca like @marca " + "order by marca", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@marca", marca + "%");
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
