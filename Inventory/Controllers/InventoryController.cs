using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
  public class InventoryController : Controller
  {
    private readonly InventoryContext _db;

    public InventoryController(InventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Product> model = _db.products.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Product thisProduct = _db.products.FirstOrDefault(products => products.ProductId == id);
      return View(thisProduct);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Product product)
    {
      _db.products.Add(product);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}