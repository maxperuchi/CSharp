using AFD.Controller;
using AFD.Model;

namespace AFD
{
    class Program
    {
        static void Main(string[] args)
        {
            Automato automato = new Automato();
            automato.Palavra = "0101";

            automato.Estados.Add(new Estado() { Id = 0 });
            automato.Estados.Add(new Estado() { Id = 1 });
            automato.Estados.Add(new Estado() { Id = 2 });

            automato.EstadoInicial = automato.Estados.Find(e => e.Id == 0);
            automato.EstadosFinais.Add(automato.Estados.Find(e => e.Id == 2));

            automato.Transicoes.Add(new Transicao()
            {
                Origem = automato.Estados.Find(e => e.Id == 0),
                Destino = automato.Estados.Find(e => e.Id == 1),
                Simbolo = '0'
            });

            automato.Transicoes.Add(new Transicao()
            {
                Origem = automato.Estados.Find(e => e.Id == 1),
                Destino = automato.Estados.Find(e => e.Id == 2),
                Simbolo = '1'
            });

            automato.Transicoes.Add(new Transicao()
            {
                Origem = automato.Estados.Find(e => e.Id == 2),
                Destino = automato.Estados.Find(e => e.Id == 2),
                Simbolo = '0'
            });

            automato.Transicoes.Add(new Transicao()
            {
                Origem = automato.Estados.Find(e => e.Id == 2),
                Destino = automato.Estados.Find(e => e.Id == 2),
                Simbolo = '1'
            });

            automato.Execute();
        }
    }
}
