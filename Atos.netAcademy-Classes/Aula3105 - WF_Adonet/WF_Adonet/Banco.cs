using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WF_Adonet
{
    internal class Banco
    {
        private string stringConexao = "Data Source=localhost;" +
                                       "Initial Catalog=ADONET; User ID=USUARIO;" +
                                       "password=NEILSANTOS;language=Portuguese;"+
                                       "trusted_connection=true;encrypt=false;";

        private SqlConnection Cn;
        private void Conexao()
        {
            Cn = new SqlConnection(stringConexao);
        }
        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                Cn.Open();
                return Cn;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public void FecharConexao()
        {
            try
            {
                Cn.Open();
               
            }
            catch (Exception ex)
            {
                return;
            }
        }
        
        public DataTable ExecutarConsultaGenerica(string sql) 
        {
            try
            {
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, Cn);//Cria o comando
                command.ExecuteNonQuery();//Executa o comando

                SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter que manuseia ...

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
