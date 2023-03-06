using AutoMapper;
using LasPepas.Aplicacion;
using LasPepas.Entidades;
using LasPepas.Entidades.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LasPepas.Controllers
{
    public class PrendaController : Controller
    {
        private readonly IAplicacion<Prenda> _aplicacion;
        private readonly IMapper _mapper;

        public PrendaController(IAplicacion<Prenda> aplicacion, IMapper mapper)
        {
            _aplicacion = aplicacion;
            _mapper = mapper;
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


        public async Task<ActionResult<PrendaCreacionDTO>> Editar(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var prenda = await _aplicacion.GetById(id);
            var prendaDTO = _mapper.Map<PrendaCreacionDTO>(prenda);

            if (prenda == null)
            {
                return NotFound();
            }

            return View(prendaDTO);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Editar(string id, PrendaCreacionDTO prendaCreacion)
        {
            if (id != prendaCreacion.Id)
            {
                return NotFound();
            }
            Prenda prenda = _mapper.Map<Prenda>(prendaCreacion);
            if (ModelState.IsValid)
            {
                _aplicacion.Updtae(prenda);
                return RedirectToAction(nameof(Index));
            }
            return View(prenda);
        }

        public async Task<IActionResult> Detalle(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var prenda = await _aplicacion.GetById(id);
            if (prenda == null)
            {
                return NotFound();
            }

            return View(prenda);
        }

        // GET
        public async Task<IActionResult> Eliminar(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var prenda = await _aplicacion.GetById(id);

            if (prenda == null)
            {
                return NotFound();
            }

            return View(prenda);
        }


        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmar(string id)
        {
            //var lote = _loteRepository.GetFirst(p => p.Id == id, incluirPropiedades: "Barrio");
            var prenda = await _aplicacion.GetById(id);
            if (prenda == null)
            {
                return Problem("El lote solicitado no existe");
            }

            if (prenda != null)
            {
                _aplicacion.Remove(prenda);

            }
            return RedirectToAction(nameof(Index));
        }


    }
}
