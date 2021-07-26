using System.Collections.Generic;

namespace DioJogos 
{
    //repositório armazena os dados do objeto
    public class SystemRepositorio : Arepositorio<SystemRequirements>
    {
        //instancia as listas
        private List<SystemRequirements> listaSystem = new List<SystemRequirements>();

        // o comando ao invés de adicionar, ele troca o objeto atua pelo anterior no mesmo id
        public void AtualizaS(int id, SystemRequirements objeto)
        {
            listaSystem[id] = objeto;
        }


        // muda o bool do atributo exclui para true chamando o método da classe SystemRequirements
        // listaSystem[id] seleciona o objeto que precisda alterar
        public void ExcluiS(int id)
        {
            listaSystem[id].Excluir();
        }

        // retorna as listas dos objetos
        public List<SystemRequirements> ListaS()
        {
            return listaSystem;
        }

        // O método add adiciona o objeto no repositório
        public void InsereS(SystemRequirements objeto)
        {
            listaSystem.Add(objeto);
        }


        public int ProximoIdS()
        {
            throw new System.NotImplementedException();
        }

        public SystemRequirements RetornaPorIdS(int id)
        {
            return listaSystem[id];
        }
    }
}