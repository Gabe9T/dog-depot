namespace DogDepot.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public DateTime Date { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }

    public Animal(string name, string breed, DateTime date, int age, string description)
    {
      Name = name;
      Breed = breed;
      Date = date;
      Age = age;
      Description = description;
    }
  }
}
