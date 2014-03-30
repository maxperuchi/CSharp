using AFD.Model;
using System;
using System.Collections.Generic;

namespace AFD.Controller
{
    public class Automato
    {
        private Estado estadoAtual;
        public Estado EstadoInicial { get; set; }

        public List<Estado> Estados { get; set; }

        public List<Estado> EstadosFinais { get; set; }

        public List<Transicao> Transicoes { get; set; }

        public string Palavra { get; set; }

        public Automato()
        {
            this.Estados = new List<Estado>();
            this.EstadosFinais = new List<Estado>();
            this.Transicoes = new List<Transicao>();
        }

        public void Execute()
        {

            estadoAtual = this.EstadoInicial;
            int i = 0;
            while (i < this.Palavra.Length)
            {
                var simbolo = this.Palavra[i];

                Console.WriteLine("\n- Leu simbolo '" + simbolo + "'.");

                var transicao = this.Transicoes.Find(t => t.Simbolo == simbolo && t.Origem == estadoAtual);
                if (transicao != null)
                {
                    estadoAtual = transicao.Destino;
                    Console.WriteLine("=> Foi para o estado " + estadoAtual.Nome);
                }
                else
                {
                    Console.WriteLine("\nNao ha transicao prevista para o simbolo '" + simbolo + "' no estado " + estadoAtual.Nome);
                    Console.ReadKey();
                    return;
                }

                i++;
            }

            if (this.EstadosFinais.Contains(estadoAtual))
            {
                Console.WriteLine("\nAutomato atingiu o estado final " + estadoAtual.Nome);
            }
            Console.ReadKey();
        }
    }
}
