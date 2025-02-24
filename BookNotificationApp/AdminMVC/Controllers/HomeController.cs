using AdminMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminMVC.Controllers;

public class HomeController : Controller
{
    private static List<BookViewModel> Books = new List<BookViewModel>();
    public IActionResult Index()
    {
        return View(Books);
    }

    [HttpPost]
    public IActionResult AddBook(string bookName, string author)
    {

        Books.Add(new BookViewModel { Name = bookName, Author = author });
        
        return RedirectToAction(nameof(Index));
    }
}
