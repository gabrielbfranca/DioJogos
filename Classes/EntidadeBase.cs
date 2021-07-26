using System.Collections.Generic;
//classe abstrata, preciso criar uma classe que herdar a entidade
namespace DioJogos
{
    public abstract class EntidadeBase
    {
        public int Id {get; protected set; }
        public bool Excluido { get; set; } 
    }
}