using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPOO2.Entities;
using WebApplicationPOO2.Models;
namespace WebApplicationPOO2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationBdContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationBdContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        _context.Choferes.Add();
            _context.SaveChanges();
        return View();
    }

     public IActionResult ChoferAdd()
    {
        return View();
    }



    public IActionResult Privacy()
    {
        Choferes chofer = new Choferes();


        List<ChoferesModel> list = new List<ChoferesModel>();
        list = _context.Choferes.Select(s => new ChoferesModel()
        {
            Id = s.Id,
            Nombre = s.Nombre, 
            Fecha = s.Fecha,
            Salario = s.Salario,
        }).Tolist(); 


        return View(list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
