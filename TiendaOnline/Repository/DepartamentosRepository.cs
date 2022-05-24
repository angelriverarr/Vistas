using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Services;

namespace TiendaOnline.Repository
{
    public class DepartamentosRepository: IDepartamentos
    {
        private ApplicationDBContext _Db;

        public DepartamentosRepository(ApplicationDBContext db)
        {
            _Db = db;
        }

        public void AddDepartamento(Departamentos dep)
        {
            _Db.Departamentos.Add(dep);
            _Db.SaveChanges();
        }

        public void DeleteDepartamento(Departamentos dep)
        {
            _Db.Departamentos.Remove(dep);
            _Db.SaveChanges();
        }

        public List<Departamentos> GetAll()
        {
            return _Db.Departamentos.ToList();
        }

        public Departamentos loadDepartamento(Departamentos dep)
        {
            var listardepto = _Db.Departamentos.Where(x => x.DepartamentoId == dep.DepartamentoId).FirstOrDefault();
            return listardepto;
        }

        public void UpdateDepartamento(Departamentos dep)
        {
            _Db.Departamentos.Update(dep);
            _Db.SaveChanges();
        }
    }
}
