using System.Collections.Generic;
using System.Linq;
using DogDepot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DogDepot.Models;

public class SpeciesController : Controller
{
  private readonly DogDepotContext _db;

  public SpeciesController(DogDepotContext db)
  {
    _db = db;
  }
  public ActionResult Details(int id)
  {
    Species thisSpecies = _db.Species
    .Include(species => species.Animals)
    .FirstOrDefault(species => species.SpeciesId == id);
    return View(thisSpecies);
  }

}




