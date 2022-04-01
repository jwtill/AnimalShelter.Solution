using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 14, Name = "Lola", Species = "Cat", Age = 21, Sex = "Female", Adopted = false },
              new Animal { AnimalId = 15, Name = "Steve", Species = "Cat", Age = 17, Sex = "Male", Adopted = true },
              new Animal { AnimalId = 3, Name = "Reggie", Species = "Dog", Age = 15, Sex = "Male", Adopted = false },
              new Animal { AnimalId = 4, Name = "Silver", Species = "Dog", Age = 13, Sex = "Male", Adopted = true },
              new Animal { AnimalId = 5, Name = "Goldie", Species = "Bird", Age = 3, Sex = "Female", Adopted = false },
              new Animal { AnimalId = 6, Name = "Prince", Species = "Dog", Age = 1, Sex = "Male", Adopted = false },
              new Animal { AnimalId = 7, Name = "Alf", Species = "Mouse", Age = 1, Sex = "Female", Adopted = true },
              new Animal { AnimalId = 8, Name = "Sam", Species = "Dog", Age = 5, Sex = "Male", Adopted = true },
              new Animal { AnimalId = 9, Name = "Teenager", Species = "Bird", Age = 4, Sex = "Male", Adopted = false },
              new Animal { AnimalId = 10, Name = "Cranston", Species = "Human", Age = 28, Sex = "TG", Adopted = true },
              new Animal { AnimalId = 11, Name = "Snoop", Species = "Turtle", Age = 77, Sex = "Female", Adopted = false },
              new Animal { AnimalId = 12, Name = "Klingon", Species = "Dog", Age = 10, Sex = "Male", Adopted = false },
              new Animal { AnimalId = 13, Name = "Trenton", Species = "Cat", Age = 999, Sex = "TG", Adopted = true }
          );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}