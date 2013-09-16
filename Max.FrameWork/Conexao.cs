using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Windows.Forms;
using System.IO;

namespace Max.FrameWork
{
    public class Conexao
    {
        //Cria string de conexao SQL baseada em um arquivo XML
        public string StringConexaoSql()
        {
            string _usuario = null, _senha = null, _endereco = null, _banco = null;
            XmlDocument ConexaoXML = new XmlDocument();

            ConexaoXML.Load(@"Conexao.xml");

            XmlNode parConexao = ConexaoXML.SelectSingleNode("/conexao");
            _endereco = parConexao.Attributes["endereco"].Value;
            _usuario = parConexao.Attributes["usuario"].Value;
            _senha = parConexao.Attributes["senha"].Value;
            _banco = parConexao.Attributes["banco"].Value;

            string connectionString = "user id=" + _usuario + ";" +
                                    "password=" + _senha + ";" +
                                    "server=" + _endereco + ";" +
                                    "Trusted_Connection=yes;" +
                                    "database=" + _banco + "; " +
                                    "connection timeout=30";        

            return connectionString;
        }

        //Abrir e fechar conexao com banco SQL
        public string AbreConexao(SqlConnection conexaoSql)
        {
            try
            {
                conexaoSql.Open();
                return "Conexão realizada com sucesso!";
            }
            catch (Exception e)
            {
                return (e.ToString());
            }
        }
        public string FechaConexao(SqlConnection conexaoSql)
        {
            try
            {
                conexaoSql.Close();
                return "Conexão fechada com sucesso!";
            }
            catch (Exception e)
            {
                return (e.ToString());
            }
        }

        //Executa um arquivo de script SQL
        public string ExecutaArquivoSQL()
        {
            string arquivo = null;
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Title = "Escolha um arquivo de script SQL...";

            DialogResult result = abrirArquivo.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                arquivo  = abrirArquivo.FileName;
            }

            try
            {
                FileInfo file = new FileInfo(arquivo);
                string script = file.OpenText().ReadToEnd();
                SqlConnection conn = new SqlConnection(StringConexaoSql());
                Server server = new Server(new ServerConnection(conn));
                server.ConnectionContext.ExecuteNonQuery(script);
                return "Script executado com sucesso!";
            }
            catch (Exception e)
            {
                return (e.ToString());
            }
        }
    }
}
