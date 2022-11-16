using Microsoft.AspNetCore.Mvc;
using ProjetoFinalLP3.ViewModels;

namespace ProjetoFinaldeLP3LojadeInstrumentos.Controllers;

public class LojaController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>();

    public IActionResult Index() => View(lojas);

    public IActionResult Admin() => View(lojas);

    public IActionResult Show(int id) => View(lojas[id-1]);

    public IActionResult Cadastrar() => View();

    public IActionResult CreateCliente(string? nome, string? email, int id, string endereco, int? cpf, int? pagamento, string? tipo)
    {
        if (lojas.Any(y => y.Nome == nome))
        {
            TempData["NameError"] = "Instrumento localizado com esse nome!";
            return RedirectToAction("Admin");
        } 
        else
        {
            id = lojas.Count + 1;

            lojas.Add(new LojaViewModel(nome, email, id, endereco, cpf, pagamento, tipo));

            return RedirectToAction("Admin");
        }
    }

    public IActionResult DeleteLoja(int id)
    {
        lojas.RemoveAll(x => x.Id == id);

        return RedirectToAction("Admin");
    }
}