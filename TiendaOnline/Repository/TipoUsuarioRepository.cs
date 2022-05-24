using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Services;

namespace TiendaOnline.Repository
{
    public class TipoUsuarioRepository: ITipoUsuarios
    {
        private ApplicationDBContext _db;
        public TipoUsuarioRepository(ApplicationDBContext db)
        {
            _db = db;
        }

        public void AddTipoUsuario(TipoUsuarios TpUsuario)
        {
            _db.TipoUsuarios.Add(TpUsuario);
            _db.SaveChanges();
        }

        public void DeleteTipoUsuario(TipoUsuarios TpUsuario)
        {
            _db.TipoUsuarios.Remove(TpUsuario);
            _db.SaveChanges();
        }

        public List<TipoUsuarios> GetAll()
        {
            return _db.TipoUsuarios.ToList();
        }

        public TipoUsuarios loadTipoUsuario(TipoUsuarios TpUsuario)
        {
            var listartUser = _db.TipoUsuarios.Where(x => x.TipoUsuarioId == TpUsuario.TipoUsuarioId).FirstOrDefault();
            return listartUser;
        }

        public void UpdateTipoUsuario(TipoUsuarios TpUsuario)
        {
            _db.TipoUsuarios.Update(TpUsuario);
            _db.SaveChanges();
        }
    }
}
