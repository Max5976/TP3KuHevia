using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_Ku_Hevia.Models;

namespace TP03_Ku_Hevia.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Discos = MusicStore.Discos;
        return View();
    }
    public IActionResult MostrarCanciones(Dictionary<int, string> canciones, string titulo) 
    {
        ViewBag.canciones = canciones.Values;
        ViewBag.titulo = titulo;
        return View();
    }
}
