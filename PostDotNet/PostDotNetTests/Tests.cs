using PostDotNet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostDotNetTests
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestaTransicaoLer();
        }

        private void TestaTransicaoLer()
        {
            var relacionamentos = new List<Relacionamento>();
            var partida = new ucPartida();
            var atribui = new ucAtribui("#");
            var atribui2 = new ucAtribui("X");
            var ler = new ucLer();
            var ler2 = new ucLer();

            relacionamentos.Add(new Relacionamento()
            {
                Entrada = partida,
                Saida = atribui,
                SimboloCondicao = string.Empty
            });

            relacionamentos.Add(new Relacionamento()
            {
                Entrada = atribui,
                Saida = ler,
                SimboloCondicao = ler.Simbolo
            });

            relacionamentos.Add(new Relacionamento()
            {
                Entrada = ler,
                Saida = atribui2,
                SimboloCondicao = "b"
            });

            relacionamentos.Add(new Relacionamento()
            {
                Entrada = ler,
                Saida = ler2,
                SimboloCondicao = "a"
            });

            try
            {
                textBox1.Text = Engine.Instance().ProcessarRelacionamentos(relacionamentos, textBox1.Text);
            }
            catch(MensagemPost m)
            {
                MessageBox.Show(m.Mensagem);
            }
        }
    }
}
