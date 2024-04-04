using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using ListaQR.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ListaQR;
//using Microsoft.Data.SqlClient;
//using Dapper;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using System.Diagnostics;
using System.Web;
using System.Linq;
using Npgsql;
//using Swashbuckle.AspNetCore.Annotations;

namespace ListaQR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarios_controller : ControllerBase
    {
        private readonly applicationDbContext _context; // Reemplaza TuContextoDbContext con el nombre de tu clase de contexto de base de datos
        private readonly IConfiguration _configuration;
        public usuarios_controller(applicationDbContext context, IConfiguration configuration) //Constructor
        {
            this._context = context;
            this._configuration = configuration;
        }

        // GET: api/Usuarios
        [HttpGet("/usuarios")]
        public ActionResult<List<usuarios_model>> Get()
        {
            try
            {
                var result =  _context.usuarios
                 .ToList();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error " + e.Message);
            }

        }
    }
}
