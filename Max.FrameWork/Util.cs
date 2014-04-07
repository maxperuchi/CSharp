using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.FrameWork
{
    public class Util
    {
        //Caixa de mensagem
        public void MsgBox(string Mensagem)
        {
            frmMsgBox msgbox = new frmMsgBox(Mensagem);
            msgbox.Show();
        }

        //Gerenciador de conexao
        public void GerenciadorConexao()
        {
            frmGerenciadorConexao Gerenciador = new frmGerenciadorConexao();
            Gerenciador.Show();
        }

        //Inverter uma string
        static public string Inverter(string Texto)
        {
            //Cria a partir do texto original um array de char
            char[] ArrayChar = Texto.ToCharArray();
            //Com o array criado invertemos a ordem do mesmo
            Array.Reverse(ArrayChar);
            //Agora basta criarmos uma nova String, ja com o array invertido.
            return new string(ArrayChar);
        }
    }
}
