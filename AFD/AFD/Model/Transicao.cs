namespace AFD.Model
{
    public class Transicao
    {
        public Estado Origem { get; set; }

        public Estado Destino { get; set; }

        public char Simbolo { get; set; }
    }
}
