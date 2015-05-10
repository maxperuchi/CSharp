using SimuladorEscalonamento.Controles;

namespace SimuladorEscalonamento
{
    public interface IFila
    {
        void AdicionarProcesso(ucProcesso processo);
        ucProcesso RetirarProximoProcesso();
        void Limpar();
        void RemoverProcesso(ucProcesso processo);
    }
}
