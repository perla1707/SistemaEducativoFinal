using Microsoft.AspNetCore.Mvc;
using MVCCRUD.Models;
using System.Diagnostics;
using MVCCRUD.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MVCCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvccrudContext _dbContext;

        public HomeController(MvccrudContext _context)
        {
            _dbContext = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Imprimir(int IdTicket)
        //{

        //    ViewModelTicket modelo = _dbContext.Registros.Include(dv => dv.Nombre).Where(v => v.Id == IdTicket)
        //        .Select(v => new ViewModelTicket() {
        //            Curp = v.Curp,
        //            NombreTramite = v.NombreTramite,
        //            Nombre = v.Nombre,
        //            Paterno = v.Paterno,
        //            Materno = v.Materno, 
        //            Telefono = v.Telefono,
        //            Celular = v.Celular,
        //            Correo = v.Correo,
        //            Nivel = v.Nivel,
        //            Municipio = v.Municipio,
        //            Asunto = v.Asunto,
        //            Fecha = v.Fecha,

        //        }).ToList()

        //        }).FirstOrDefault();
     
        //    return View();
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}