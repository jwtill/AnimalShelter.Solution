using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }


    [HttpGet]
    public async Task<List<Animal>> Get(string name, string species, string sex, bool adopted, int minAge)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (sex != null)
      {
        query = query.Where(entry => entry.Sex == sex);
      }

      if (adopted == true || false)
      {
        query = query.Where(entry => entry.Adopted == adopted);
      }

      if (minAge > 0)
      {
        query = query.Where(entry => entry.Age >= minAge);
      }

      return await query.ToListAsync();
    }

    [HttpGet("Adoptable")]
    public async Task<ActionResult<IEnumerable<Animal>>> Adoptable()
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();
      query = query.Where(entry => entry.Adopted == false);
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    [HttpGet("Random")]
    public async Task<ActionResult<Animal>> RandomAnimal()
    {
      Random random = new Random();
      int dbCount = _db.Animals.Count();
      int id = random.Next(1, dbCount);
      var animal = await _db.Animals.FindAsync(id);
      return animal;
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}
