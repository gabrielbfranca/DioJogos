using System.Collections.Generic;
namespace DioJogos
{
    public interface Arepositorio<T>
    {
         List<T> ListaS();
        T RetornaPorIdS(int id);        
        void InsereS(T entidade);        
        void ExcluiS(int id);        
        void AtualizaS(int id, T entidade);
        int ProximoIdS();
    }
}