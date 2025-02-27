using AdminMVC.Models;
using Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AdminMVC.Controllers;

public class HomeController : Controller
{
    private static List<BookViewModel> Books = new List<BookViewModel>();
    private readonly IHubContext<NotificationHub> _hubContext;
    public HomeController(IHubContext<NotificationHub> hubContext)
    {
        _hubContext = hubContext;
    }
    public IActionResult Index()
    {
        return View(Books);
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(string bookName, string author)
    {

        Books.Add(new BookViewModel { Name = bookName, Author = author });

        string notificationMessage = $"New book added: {bookName} by {author}";

        try
        {
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", notificationMessage);
            Console.WriteLine($"Bildirim baþarýyla gönderildia: {notificationMessage}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Bildirim gönderilirken hata oluþtu: {ex.Message}");
            // Hata durumunda kullanýcýya bilgi verebilir veya loglayabilirsiniz.
        }

        return RedirectToAction(nameof(Index));
    }
}
