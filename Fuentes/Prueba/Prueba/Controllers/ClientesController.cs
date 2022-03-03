using Prueba.Models;
using System.Linq;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ListarClientes()
        {
            using (DbJoelRojasEntities context = new DbJoelRojasEntities())
            {
                var Lstclientes = context.Cliente.ToList().Where(x => x.Estado == true);
                return Json(Lstclientes.ToList());
            }
        }

        [HttpPost]
        public JsonResult EliminarCliente(int IdCliente)
        {
            using (DbJoelRojasEntities context = new DbJoelRojasEntities())
            {
                var Cliente = context.Cliente.Where(x => x.IdCliente == IdCliente).SingleOrDefault();
                context.Cliente.Remove(Cliente);
                context.SaveChanges();
                return Json("OK");
            }
        }

        [HttpPost]
        public JsonResult AgregarCliente(ClienteViewModel objCliente)
        {
            using (DbJoelRojasEntities context = new DbJoelRojasEntities())
            {
                Cliente oEntidad = new Cliente();
                oEntidad.Nombre = objCliente.Nombre;
                oEntidad.Compania = objCliente.Compania;
                oEntidad.Tipo = objCliente.Tipo;
                oEntidad.Estado = true;
                context.Cliente.Add(oEntidad);
                context.SaveChanges();
                return Json("OK");
            }
        }
    }
}