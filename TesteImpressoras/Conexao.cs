using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace TesteImpressoras
{
    public class Conexao
    {
        public string strConnection;
        public MySqlConnection conn;

        public Conexao(string servidor, string banco, string usuarioId, string password)
        {
            strConnection = $"Server={servidor};Database={banco};User ID={usuarioId};Password={password};";
            conn = new MySqlConnection(strConnection);
        }

        public bool conectar()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Conectado!");
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados.\n" + ex.Message);
                return false;
            }
        }

        public void desconectar()
        {
            try
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao fechar a conexão.\n" + ex);
            }
        }

        public bool inserirRegistroImpressao(string nomeTabela, string colunas, string valores)
        {
            string query = $"INSERT INTO {nomeTabela} ({colunas}) VALUES ({valores})";
            try
            {
                if(conectar() == true)
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Registro inserido com sucesso.");
                    return true;

                }
            }
            catch(MySqlException ex)
            {
               Console.WriteLine("Erro ao inserir registro: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
            return false;
        }

        public bool salvarTrabImpressao(List<InfoTrabImpressao> printJobs)
        {
            try
            {               
                    foreach(var job in printJobs)
                    {
                        string query = "INSERT IGNORE INTO PrintJobs (IDtrabalho, nomeDocumento, emissorTrabalho, status, paginasImpressas) " +
                                       "VALUES (@IDtrabalho, @nomeDocumento, @emissorTrabalho, @status, @paginasImpressas)";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@IDtrabalho", job.jobID);
                        command.Parameters.AddWithValue("@nomeDocumento", job.documentName);
                        command.Parameters.AddWithValue("@emissorTrabalho", job.submitter);
                        command.Parameters.AddWithValue("@status", job.status);
                        command.Parameters.AddWithValue("@paginasImpressas", job.pagesPrinted);
                        command.ExecuteNonQuery();
                    Console.WriteLine("Trabalho de impressão salvo com sucesso.");
                }             
                
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Erro ao armazenar trabalho de impressão.\n" + ex);
            }
            finally
            {
                desconectar();
            }

            return false;
        }
    }
}
