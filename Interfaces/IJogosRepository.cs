using Api_Jogos_Isaac.Domains;

namespace Api_Jogos_Isaac.Interfaces
{
    public interface IJogosRepository
    {
        void Cadastrar(Jogos jogos);
        void Deletar(Guid id);
        List<Jogos> Listar();
        void Atualizar(Guid id, Jogos jogos); 
    }
}
