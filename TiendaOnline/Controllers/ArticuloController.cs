using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Services;
using Microsoft.AspNetCore.Mvc;

namespace TiendaOnline.Controllers
{
    public class ArticuloController : Controller
    {
        private IArticulos _articulos;
        private IClientes _cl;
        private readonly ILogger<ClienteController> _logger;
        private ApplicationDBContext _db;

        public ArticuloController(ILogger<ClienteController> logger, IArticulos articulos, IClientes cl, ApplicationDBContext db)
        {
            _articulos = articulos;
            _cl = cl;
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult>  Guardar(Articulos art)
        {
            
            _articulos.AddArticulo(art);

            return RedirectToAction("Articulo");
        }
        public async Task<IActionResult> Articulo()
        {
            //var getInnerJoin = from Categorias in _db.Categorias
            //                   from Articulos in _db.Articulos
            //                   where Categorias.CategoriaId == Articulos.CategoriaID
            //                   select new
            //                   {
            //                       catgoria = Categorias.Tipo,
            //                       id = Articulos.ArticuloId,
            //                       cantida = Articulos.Cantidad,
            //                       nombre = Articulos.Nombre,
            //                       descripcion = Articulos.Descripcion,
            //                       precio = Articulos.Precio

            //                   };
            //ViewBag.articulo = getInnerJoin;

            //var getJoinCat = from Categorias in _db.Categorias
            //                 from Articulos in _db.Articulos
            //                 where Categorias.CategoriaId == Categorias.CategoriaId
            //                 select new
            //                 {
            //                     id = Categorias.CategoriaId,
            //                     categoria = Categorias.Tipo

            //                 };
            //ViewBag.Categoria = getJoinCat;
            IEnumerable<Articulos> articulos = await _db.Articulos.Include(x => x.Categoria).ToListAsync();

            Articulos articulo = new Articulos();
            ViewBag.articulo = articulos;
            ViewBag.Categoria = await _db.Categorias.ToListAsync();
            return View(articulo);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Articulos art = new Articulos();
            art.ArticuloId = id;
            var listArticulo = _articulos.LoadArticulo(art);

            var getJoinCat = from Categorias in _db.Categorias
                             from Articulos in _db.Articulos
                             where Articulos.CategoriaID == Categorias.CategoriaId
                             select new
                             {
                                 id = Categorias.CategoriaId,
                                 categoria = Categorias.Tipo

                             };
            ViewBag.Categoria = getJoinCat;

            ViewBag.Categoria = await _db.Categorias.ToListAsync();
            return View(listArticulo);
        }

        public IActionResult Delete (int id)
        {
            Articulos art =new Articulos();
            art.ArticuloId=id;
            _articulos.DeleteArticulo(art);
           return RedirectToAction("Articulo");
        }
        public IActionResult Actualizar( Articulos art)
        {
            _articulos.UpdateAticulo(art);
            return RedirectToAction("Articulo");
        }
    }
}
