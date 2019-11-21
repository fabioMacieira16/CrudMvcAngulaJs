using CRUD_MVC5_AngulaJS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CRUD_MVC5_AngulaJS.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET:Retonar a lista de Funcionario
        public JsonResult GetFuncionario()
        {
            using (var db = new FuncionariosEntities())
            {
                List<Funcionario> listaFuncionarios = db.Funcionarios.ToList();

                return Json(listaFuncionarios, JsonRequestBehavior.AllowGet);
            }
        }
    }
}