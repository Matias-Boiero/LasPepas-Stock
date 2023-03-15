using AutoMapper;
using LasPepas.Aplicacion;
using LasPepas.Entidades;
using LasPepas.Entidades.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LasPepas.Controllers
{
    [Authorize(Roles = "Administrador, vendedor")]
    public class CajasController : Controller
    {
        private readonly Aplicacion.IAplicacion<Caja> _aplicacion;
        private readonly IMapper _mapper;

        public CajasController(IAplicacion<Caja> aplicacion, IMapper mapper)
        {
            _aplicacion = aplicacion;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var listaCaja = await _aplicacion.GetAll();
            return View(listaCaja);

        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            return View();
        }

        //Post
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Crear(Caja caja)
        {

            //Lote lote = _mapper.Map<Lote>(loteCreacion);
            if (ModelState.IsValid)
            {
                await _aplicacion.Add(caja);
                TempData["success"] = "Registro creado correctamente.";
                return RedirectToAction("Index");
            }

            return (View(caja));
        }


        public async Task<ActionResult<CajaCreacionDTO>> Editar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var caja = await _aplicacion.GetById(id);
            var cajaDTO = _mapper.Map<CajaCreacionDTO>(caja);

            if (caja == null)
            {
                return NotFound();
            }

            return View(cajaDTO);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Editar(int id, CajaCreacionDTO cajaCreacion)
        {
            if (id != cajaCreacion.Id)
            {
                return NotFound();
            }
            // var prenda = await _aplicacion.GetById(id);
            var caja = _mapper.Map<Caja>(cajaCreacion);
            if (ModelState.IsValid)
            {
                _aplicacion.Updtae(caja);
                return RedirectToAction(nameof(Index));
            }
            return View(cajaCreacion);
        }

        public async Task<IActionResult> Detalle(int id)
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
        public async Task<IActionResult> Eliminar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var caja = await _aplicacion.GetById(id);

            if (caja == null)
            {
                return NotFound();
            }

            return View(caja);
        }


        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmar(int id)
        {
            //var lote = _loteRepository.GetFirst(p => p.Id == id, incluirPropiedades: "Barrio");
            var caja = await _aplicacion.GetById(id);
            if (caja == null)
            {
                return Problem("La caja solicitada no existe");
            }

            if (caja != null)
            {
                _aplicacion.Remove(caja);

            }
            return RedirectToAction(nameof(Index));
        }


    }
}
