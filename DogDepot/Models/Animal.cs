namespace DogDepot.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    public int SpeciesId { get; set; }

    public Species Species { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public int Age { get; set; }
    public string Description { get; set; }

  }
}
