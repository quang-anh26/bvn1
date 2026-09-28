using Microsoft.AspNetCore.Mvc;

namespace WebBaiTap.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    // Câu 1: /Home/Weekend
    public IActionResult Weekend() => View();
}
