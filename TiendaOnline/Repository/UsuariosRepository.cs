using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Services;

namespace TiendaOnline.Repository
{
    public class UsuariosRepository: IUsuarios
    {
        private ApplicationDBContext _db;

        public UsuariosRepository(ApplicationDBContext db)
        {
            _db = db;   
        }

        public void AddUsuario(Usuarios us)
        {
            _db.Usuarios.Add(us);
            _db.SaveChanges();
        }

        public void DeleteUsuario(Usuarios us)
        {
            _db.Usuarios.Remove(us);
            _db.SaveChanges();
        }

        public IEnumerable<Usuarios> GetAll()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Usuarios> GetAll()
        //{
        //    var Join = _db.Usuarios
        //        .Include(tp => tp.TipoUsuarios)
        //        .ToList();
        //    return Join;    
        //}

        public Usuarios loadUsuario(Usuarios us)
        {
            var listarUser = _db.Usuarios.Where(x => x.UsuarioId == us.UsuarioId).FirstOrDefault(); 
            return listarUser;
        }

        public void UpdateUsuario(Usuarios us)
        {
            _db.Usuarios.Update(us);
            _db.SaveChanges();
        }
    }
}
