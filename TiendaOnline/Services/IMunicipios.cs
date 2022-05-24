using TiendaOnline.Models;

namespace TiendaOnline.Services
{
    public interface IMunicipios
    {
        public void AddMunicipio(Municipios muni);
        public void UpdateMunicipios(Municipios muni);

        public void DeleteMunicipio(Municipios muni);

        public List<Municipios> GetAll();

        public Municipios loadMunicipio(Municipios muni);
    }
}
