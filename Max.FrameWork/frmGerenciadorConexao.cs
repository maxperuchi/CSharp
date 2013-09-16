using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Max.FrameWork
{
    public partial class frmGerenciadorConexao : Max.FrameWork.frmVazio
    {
        Conexao Conexao = new Conexao();
        Util Util = new Util();

        string _endereco, _usuario, _senha, _banco;
        public frmGerenciadorConexao()

        {
            InitializeComponent();
            XmlDocument ConexaoXML = new XmlDocument();

            ConexaoXML.Load(@"Conexao.xml");

            XmlNode parConexao = ConexaoXML.SelectSingleNode("/conexao");
            _endereco = parConexao.Attributes["endereco"].Value;
            _usuario = parConexao.Attributes["usuario"].Value;
            _senha = parConexao.Attributes["senha"].Value;
            _banco = parConexao.Attributes["banco"].Value;

            txtEndereco.Text = _endereco;
            txtUsuario.Text = _usuario;
            txtSenha.Text = _senha;
            txtBanco.Text = _banco;
        }
        private void botaoOK1_Click(object sender, EventArgs e)
        {
            XmlDocument ConexaoXML = new XmlDocument();

            ConexaoXML.Load(@"Conexao.xml");

            XmlNode parConexao = ConexaoXML.SelectSingleNode("/conexao");
            parConexao.Attributes["endereco"].Value = txtEndereco.Text;
            parConexao.Attributes["usuario"].Value = txtUsuario.Text;
            parConexao.Attributes["senha"].Value = txtSenha.Text;
            parConexao.Attributes["banco"].Value = txtBanco.Text;

            ConexaoXML.Save(@"Conexao.xml");
            ActiveForm.Close();
        }

        private void botaoNovo1_Click(object sender, EventArgs e)
        {
            Util.MsgBox(Conexao.ExecutaArquivoSQL());
        }
    }
}
