using Api_Jogos_Isaac.Context;
using Api_Jogos_Isaac.Domains;
using Api_Jogos_Isaac.Interfaces;

namespace Api_Jogos_Isaac.Repository
{

    public class UsuarioRepository : IUsuarioRepository

    {
        private readonly Jogos_Context _context;
        public UsuarioRepository(Jogos_Context context)
        {
            _context = context;
        }
       /// <summary>
       /// _Context serve para puxar as informacoes do Context do BD
       /// </summary>
       /// <param name="id"></param>
       /// <param name="usuario"></param>
        public void Atualizar(Guid id, Usuarios usuario)
        {
            try
            {
                Usuarios usuarios = _context.Usuarios.Find(id)!;

                if (usuarios != null)
                {
                    usuarios.Nome = usuario.Nome;
                }

                _context.Usuarios.Update(usuarios!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                return _context.Usuarios.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuarios usuario)
        {
            try
            {
                usuario.UsuarioID = Guid.NewGuid();

                _context.Usuarios.Add(usuario);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Usuarios usuarios = _context.Usuarios.Find(id)!;
                if (usuarios != null)
                {
                    _context.Usuarios.Remove(usuarios);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuarios> Listar()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        List<Usuarios> IUsuarioRepository.Listar()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
