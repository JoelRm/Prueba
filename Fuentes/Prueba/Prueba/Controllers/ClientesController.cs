using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba.Data;
using Prueba.Models;
using System.Collections.Generic;
using System.Linq;

namespace Prueba.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notfy;

        public ClientesController(ILogger<ClientesController> logger, ApplicationDbContext db, INotyfService notfy)
        {
            _logger = logger;
            _db = db;
            _notfy = notfy;    
        }
        public IActionResult Index()
        {
            IEnumerable<Cliente> clientes = _db.Clientes.Select(s => s).ToList();
            return View(clientes);
        }

        [HttpPost]
        public JsonResult ListarClientes()
        {
            IEnumerable<Cliente> clientes = _db.Clientes.Select(s => s).ToList();
            return Json(clientes.ToList());
        }

        [HttpPost]
        public JsonResult EliminarCliente(int idCliente)
        {
            var Cliente = _db.Clientes.Where(x => x.IdCliente == idCliente).SingleOrDefault();
            _db.Clientes.Remove(Cliente);
            _db.SaveChanges();
            return Json("OK");
            
        }

        [HttpPost]
        public JsonResult AgregarCliente(ClienteViewModel objCliente)
        {
            Cliente oEntidad = new Cliente();
            oEntidad.Nombre = objCliente.Nombre;
            oEntidad.Compania = objCliente.Compania;
            oEntidad.Tipo = objCliente.Tipo;
            oEntidad.Estado = true;
            _db.Clientes.Add(oEntidad);
            _db.SaveChanges();
            return Json("OK");
        }

    }
}
