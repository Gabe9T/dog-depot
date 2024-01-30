using System.Collections.Generic;
using System.Linq;
using DogDepot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
      List<Animal> model = _db.Animals
        .Include(animal => animal.Species)
        .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.SpeciesId = new SelectList(_db.Species, "SpeciesId", "Title");
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

    public ActionResult Edit(int id)
    {
      ViewBag.SpeciesId = new SelectList(_db.Species, "SpeciesId", "Title");
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal =>
          animal.AnimalId == id
      );
      return View(thisAnimal);
    }

    [HttpPost]
    public ActionResult Edit(Animal animal)
    {
      _db.Animals.Update(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      _db.Animals.Remove(thisAnimal);
      _db.SaveChanges();
      return View(thisAnimal);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      _db.Animals.Remove(thisAnimal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
