using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface ITipoUsuarios
    {
        public void AddTipoUsuario(TipoUsuarios TpUsuario);
        public void UpdateTipoUsuario(TipoUsuarios TpUsuario);

        public void DeleteTipoUsuario(TipoUsuarios TpUsuario);

        public List<TipoUsuarios> GetAll();

        public TipoUsuarios loadTipoUsuario(TipoUsuarios TpUsuario);
    }
}
