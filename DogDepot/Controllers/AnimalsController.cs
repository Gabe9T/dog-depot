using Microsoft.AspNetCore.Mvc;
using DogDepot.Models;
using System.Collections.Generic;
using System.Linq;

namespace DogDepot.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly DogDepotContext _db;
    public AnimalsController(DogDepotContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal animal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(animal);
    }
  }
}
