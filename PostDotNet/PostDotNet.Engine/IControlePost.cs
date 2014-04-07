using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostDotNet.Core
{
    public enum TipoControle
    {
        Aceita = 1,
        Atribui = 2,
        Ler = 3,
        Partida = 4,
        Rejeita = 5
    }
    public interface IControlePost
    {
        string Simbolo { get; set; }
        TipoControle Tipo { get; set; }
    }
}
