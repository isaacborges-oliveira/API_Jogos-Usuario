using Api_Jogos_Isaac.Context;
using Api_Jogos_Isaac.Domains;
using Api_Jogos_Isaac.Interfaces;

namespace Api_Jogos_Isaac.Repository
{
    public class JogosRepository : IJogosRepository
    {
        private readonly Jogos_Context _context;
        public JogosRepository(Jogos_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Jogos jogos)
        {
            try
            {
                Jogos jogos1= _context.Jogos.Find(id)!;

                if (jogos != null)
                {
                    jogos.NomeDoJogo = jogos.NomeDoJogo;
                }

                _context.Jogos.Update(jogos!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Jogos BuscarPorId(Guid id)
        {
            try
            {
                return _context.Jogos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Jogos jogos)
        {
            try
            {
                jogos.JogosID = Guid.NewGuid();

                _context.Jogos.Add(jogos);

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
                Jogos jogos = _context.Jogos.Find(id)!;

                if (jogos != null)
                {
                    _context.Jogos.Remove(jogos);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Jogos> Listar()
        {

            try
            {
                return _context.Jogos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
