using Api_Jogos_Isaac.Domains;

namespace Api_Jogos_Isaac.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios usuario); //Criando void de Cadastro
        void Deletar(Guid id); //Criando void de Deletar
        List<Usuarios> Listar(); //Listagem 
        void Atualizar(Guid id, Usuarios usuario); //Criando void de Atualizar
    }
}
