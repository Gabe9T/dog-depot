namespace DogDepot.Models
{
  public class Species
  {
    public int SpeciesId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public List<Animal> animals { get; set; }
  }
}
