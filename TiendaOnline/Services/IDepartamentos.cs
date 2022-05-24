using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface IDepartamentos
    {
        public void AddDepartamento(Departamentos dep);
        public void UpdateDepartamento(Departamentos dep);

        public void DeleteDepartamento(Departamentos dep);

        public List<Departamentos> GetAll();

        public Departamentos loadDepartamento(Departamentos dep);
    }
}
