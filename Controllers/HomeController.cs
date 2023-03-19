using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetoWebLhPetsMVC.Models;

namespace projetoWebLhPetsMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instâncias do tipo cliente
        Cliente cl1 = new Cliente(1, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cl2 = new Cliente(2, "Willian Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cl3 = new Cliente(3, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cl4 = new Cliente(4, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cl5 = new Cliente(5, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        //lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cl1);
        listaClientes.Add(cl2);
        listaClientes.Add(cl3);
        listaClientes.Add(cl4);
        listaClientes.Add(cl5);

        //leva os dados para a View
        ViewBag.listaClientes = listaClientes;

        //instâncias do tipo fornecedor
        Fornecedor fo1 = new Fornecedor(1, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fo2 = new Fornecedor(2, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fo3 = new Fornecedor(3, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fo4 = new Fornecedor(4, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fo5 = new Fornecedor(5, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fo1);
        listaFornecedores.Add(fo2);
        listaFornecedores.Add(fo3);
        listaFornecedores.Add(fo4);
        listaFornecedores.Add(fo5);

        //leva os dados para a View
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
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
