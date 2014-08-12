using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MaxFrameworkTest
{
    public partial class Form1 : Form
    {
        private List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            InicializaPessoas();

            maxGridView1.DataSource = pessoas;
        }

        private void InicializaPessoas()
        {
            pessoas = new List<Pessoa> { 
            new Pessoa(){Nome = "Maxwel", Ativo = true, Idade = DateTime.Parse(@"21/08/1989"), ClienteEspecial = false, CPF = "123123123", QuantidadeFilhos = 3, Sexo = "Masculino"},
            new Pessoa(){Nome = "Carlos", Ativo = false, Idade = DateTime.Parse(@"21/08/1989"), ClienteEspecial = false, CPF = "123123123", QuantidadeFilhos = 3, Sexo = "Masculino"},
            new Pessoa(){Nome = "João", Ativo = false, Idade = DateTime.Parse(@"21/08/1989"), ClienteEspecial = false, CPF = "123123123", QuantidadeFilhos = 3, Sexo = "Masculino"},
            new Pessoa(){Nome = "Kim", Ativo = true, Idade = DateTime.Parse(@"21/08/1989"), ClienteEspecial = false, CPF = "123123123", QuantidadeFilhos = 3, Sexo = "Masculino"}
            };
        }

        private void maxGridView1_RowUpdated(object sender, Max.Framework.Controls.GridView.MaxGridViewRowEventArgs e)
        {

        }
    }
}
