using Max.Framework.Controls.Editors;
using Max.Framework.Test;
using System;

namespace MaxFrameworkTest
{
    public class Pessoa
    {
        [MaxEditorDisplayName("Nome do vivente")]
        public string Nome { get; set; }

        [MaxEditorDisplayName("Data")]
        public DateTime Idade { get; set; }

        public bool Ativo { get; set; }
        public string Sexo { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string CPF { get; set; }
        public bool ClienteEspecial { get; set; }
    }
}
