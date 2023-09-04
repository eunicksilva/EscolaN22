using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_POO_Base.Classes
{
    internal class Conexao
    {
        //CONEXAO REMOTA

        #region Variáveis
        //String de Conexão                     //Informações CHUMBADAS - HardCode
        private static string _strConexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EscolaN22;Integrated Security=True";
        
        //Variáveis de uso (podem ou não podem ser usadas ao decorrer do projeto)
        public SqlConnection conexao = new SqlConnection(_strConexao);
        public SqlCommand comando; //Armazenar o query
        public SqlDataAdapter da; //Adaptador para alguns componentes
        public SqlDataReader dr;  //Recebe os select's
        public DataSet ds; //Trabalha com multiplas tabelas

        #endregion

        #region Construtores
        public Conexao(string query) 
        {
            comando = new SqlCommand(query, conexao); //Comando montado
            da=new SqlDataAdapter(query, conexao); //Caso necessário, está pronto
            ds= new DataSet();// Se necessário
        }

        #endregion

        #region Métodos
        //Um métdodo para abrir uma conexão com o banco.
        public void AbrirConexao()
        {
            if (conexao.State==ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
        }

        //E um outro metodo para fechar a conexão com o banco.
        public void FecharConexao()
        {
            if (conexao.State==ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        

        #endregion
    }
}
