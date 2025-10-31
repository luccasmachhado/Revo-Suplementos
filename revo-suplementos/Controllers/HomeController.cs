using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using revo_suplementos.Models;

namespace revo_suplementos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var produtos = new List<Produto>
            {
                new Produto( { 
                    )
                    Id = 1, 
                    Nome = "Whey Protein Isolado", 
                    Descricao = "Prote�na pura e de r�pida absor��o.", 
                    Preco = 159.90m, ImagemUrl = "/imagens/whey.jpeg" 
                },
                
                new Produto() { 
                    Id = 2, Nome = "Creatina Monohidratada", Descricao = "Energia e for�a explosiva.", 
                    Preco = 99.90m, ImagemUrl = "/imagens/creatina.jpeg" 
                },
                
                new Produto() { Id = 3, 
                    Nome = "Pr�-Treino NitroBlast", 
                    Descricao = "Foco e energia m�xima.", 
                    Preco = 129.90m, 
                    ImagemUrl = "/imagens/pretreino.jpeg" 
                }
            };

        return View(produtos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
