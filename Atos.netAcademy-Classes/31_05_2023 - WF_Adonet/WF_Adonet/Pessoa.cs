using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Adonet
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Profissao { get; set; } = string.Empty;

        public bool GravarPessoa()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into pessoas" +
                                    //"values(" + Nome + ",'" + Profissao + "')"; - ERRADO
                                    " values(@NOME,@PROFISSAO);";

            //Criando os Parametros
            command.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@PROFISSAO", System.Data.SqlDbType.VarChar);

            //Passando os valores dos parametros
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Profissao;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    
        public bool ExcluirPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandText = "delete from pessoas where id = @id";
            command.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = Id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
                throw;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
        
        public bool AtualizarPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandText = "update from pessoas where id = @id";
            command.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            command.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@Profissao", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = Id;
            command.Parameters[1].Value = Nome;
            command.Parameters[2].Value = Profissao;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
                throw;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
        
        public Pessoa ConsultaPessoa(int id)
        {
            Banco db = new Banco();
            try
            {
                SqlConnection cn = db.AbrirConexao();
                SqlCommand command = new SqlCommand("select * from pessoas", cn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(reader.GetInt32(0) == id)
                    {
                        this.Id = reader.GetInt32(0);
                        this.Nome = reader.GetString(1);
                        this.Profissao = reader.GetString(2);

                        return this;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.FecharConexao();
            }
        }
    }
}
