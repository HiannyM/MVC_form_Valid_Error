using Microsoft.AspNetCore.Mvc;
using MVC_form_Valid_Error.Models;

namespace MVC_form_Valid_Error.Controllers;

public class ClientesController : Controller
{
    private static List<Cliente> clientes = new();

    public IActionResult Index()
    {
        return View(clientes);
    }

    public IActionResult Detalle(int id)
    {
        var cliente = clientes.FirstOrDefault(c => c.Id == id);

        if (cliente == null)
            return NotFound();

        return View(cliente);
    }

    public IActionResult Crear()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Crear(Cliente cliente)
    {
        if (!ModelState.IsValid)
            return View(cliente);

        cliente.Id = clientes.Count + 1;
        clientes.Add(cliente);

        return RedirectToAction("Index");
    }
}