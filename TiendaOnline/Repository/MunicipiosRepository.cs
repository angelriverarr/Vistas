using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Services;

namespace TiendaOnline.Repository
{
    public class MunicipiosRepository: IMunicipios
    {
        private ApplicationDBContext _db;

        public MunicipiosRepository(ApplicationDBContext db)
        {
            _db=db;
        }

        public void AddMunicipio(Municipios muni)
        {
            _db.Municipios.Add(muni);
            _db.SaveChanges();
        }

        public void DeleteMunicipio(Municipios muni)
        {
            _db.Municipios.Remove(muni);
            _db.SaveChanges();
        }

        public List<Municipios> GetAll()
        {
            return _db.Municipios.ToList();
        }

        public Municipios loadMunicipio(Municipios muni)
        {
            var listarmunicipio = _db.Municipios.Where(x => x.MunicipioId == muni.MunicipioId).FirstOrDefault();
            return listarmunicipio;
        }

        public void UpdateMunicipios(Municipios muni)
        {
            _db.Municipios.Update(muni);
        }
    }
}
