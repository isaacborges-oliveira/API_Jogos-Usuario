using Api_Jogos_Isaac.Domains;

namespace Api_Jogos_Isaac.Interfaces
{
    public interface IJogosRepository
    {

        void Cadastrar(Jogos jogos); //Criando void de Cadastro
        void Deletar(Guid id); //Criando void de Deletar

        List<Jogos> Listar(); //Listagem 
        void Atualizar(Guid id, Jogos jogos); //Criando void de Atualizar

        Jogos BuscarPorId(Guid id); // criando um buscar por id de jogo
    }
}
