using LasPepas.Aplicacion;
using LasPepas.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LasPepas.Controllers
{
    public class PrendaController : Controller
    {
        private readonly IAplicacion<Prenda> _aplicacion;

        public PrendaController(IAplicacion<Prenda> aplicacion)
        {
            _aplicacion = aplicacion;
        }

        //Get
        public async Task<IActionResult> Index()
        {
            var lista = await _aplicacion.GetAll();
            return View(lista);
        }

        //Get
        public async Task<IActionResult> Crear()
        {
            return View();
        }

        //Post
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Crear(Prenda prenda)
        {

            //Lote lote = _mapper.Map<Lote>(loteCreacion);
            if (ModelState.IsValid)
            {
                await _aplicacion.Add(prenda);
                TempData["success"] = "Registro creado correctamente.";
                return RedirectToAction("Index");
            }

            return (View(prenda));
        }


    }
}
