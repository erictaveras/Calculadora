using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: /Calculadora
        public IActionResult Index()
        {
            return View(new OperacionModel());
        }

        // POST: /Calculadora
        [HttpPost]
        public IActionResult Index(OperacionModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            switch (modelo.Operacion)
            {
                case "suma":
                    modelo.Resultado = modelo.Numero1 + modelo.Numero2;
                    break;

                case "resta":
                    modelo.Resultado = modelo.Numero1 - modelo.Numero2;
                    break;

                case "multiplicacion":
                    modelo.Resultado = modelo.Numero1 * modelo.Numero2;
                    break;

                case "division":
                    if (modelo.Numero2 == 0)
                    {
                        modelo.Error = "No se puede dividir entre cero";
                        modelo.Resultado = null;
                    }
                    else
                    {
                        modelo.Resultado = modelo.Numero1 / modelo.Numero2;
                    }
                    break;

                default:
                    modelo.Error = "Operación no válida";
                    break;
            }

            return View(modelo);
        }
    }
}