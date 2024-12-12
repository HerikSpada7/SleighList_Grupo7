using Microsoft.AspNetCore.Mvc;
using SleighList.Contexts;
using SleighList.Models;


namespace SleighList.Contextsus
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();

        public IActionResult Index()
        { 
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form){
            string emailInformado = form["Email"].ToString();
            string senhaInformado = form["Senha"].ToString();

            Usuario usuarioBuscado = context.Usuario.FirstOrDefault(usuario => usuario.Email == emailInformado && usuario.Senha == senhaInformado)!;

            if (usuarioBuscado == null){
                Console.WriteLine($"Dados Inválidos!");
                return LocalRedirect("~/Login");
            }else{
                Console.WriteLine($"Você entrou!");
                HttpContext.Session.SetString("UsuarioID", usuarioBuscado.UsuarioID.ToString());
                return LocalRedirect("~/Usuario");
                
            }
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}