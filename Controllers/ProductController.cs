using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBaiTap.Data;

namespace WebBaiTap.Controllers;

public class ProductController : Controller
{
    private readonly AppDbContext _db;

    public ProductController(AppDbContext db)
    {
        _db = db;
    }

    // /Product : lấy dữ liệu từ SQL Server rồi đưa ra View
    public async Task<IActionResult> Index()
    {
        var products = await _db.Products.AsNoTracking().OrderBy(p => p.Id).ToListAsync();
        return View(products);
    }
}
