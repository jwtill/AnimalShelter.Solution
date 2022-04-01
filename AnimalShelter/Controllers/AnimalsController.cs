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
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Gets an animal based on URL parameters.
    /// </summary>
    /// <param name="name"></param> 
    /// <param name="species"></param>
    /// <param name="sex"></param>
    /// <param name="adopted"></param>
    /// <param name="minAge"></param>
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
    /// <summary>
    /// Gets a list of animals that have not been adopted.
    /// </summary>
    [HttpGet("Adoptable")]
    public async Task<ActionResult<IEnumerable<Animal>>> Adoptable()
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();
      query = query.Where(entry => entry.Adopted == false);
      return await query.ToListAsync();
    }
    /// <summary>
    /// Gets a list of all cats.
    /// </summary>
    [HttpGet("Cats")]
    public async Task<ActionResult<IEnumerable<Animal>>> Cats()
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();
      query = query.Where(entry => entry.Species == "Cat");
      return await query.ToListAsync();
    }
     /// <summary>
    /// Gets a list of all cats.
    /// </summary>
    [HttpGet("Dogs")]
    public async Task<ActionResult<IEnumerable<Animal>>> Dogs()
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();
      query = query.Where(entry => entry.Species == "Dog");
      return await query.ToListAsync();
    }
    /// <summary>
    /// Adds a new animal
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///     POST /AnimalShelter
    ///     {
    ///        "animalId": 6,
    ///        "name": "Prince",
    ///        "species": "Dog",
    ///        "age": 1,
    ///        "sex": "Male",
    ///        "adopted": false
    ///     }
    ///
    /// </remarks>
    /// <param name="animal"></param>
    /// <returns>A newly created Animal</returns>
    /// <response code="201">Returns the newly created animal</response>
    /// <response code="400">If the item is null</response> 
    
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }
    /// <summary>
    /// Gets an animal based on ID.
    /// </summary>
    /// <param name="id"></param>
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
    /// <summary>
    /// Updates an animal with a given ID.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="animal"></param>
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
    /// <summary>
    /// Deletes an animal with a given ID.
    /// </summary>
    /// <param name="id"></param>
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
    /// <summary>
    /// Gets a random animal.
    /// </summary>
    [HttpGet("Random")]
    public async Task<ActionResult<Animal>> RandomAnimal()
    {
      Random random = new Random();
      int dbCount = _db.Animals.Count();
      int id = random.Next(1, dbCount);
      var animal = await _db.Animals.FindAsync(id);
      return animal;
    }
    
    /// <summary>
    /// Changes a given animal's Adopted status.
    /// </summary>
    // <param name="id"></param>
    // <param name="adopted"></param>
    // [HttpPatch("{id}")]
    // public async Task<IActionResult> Patch(int id, bool adopted)
    //{
    //   var animal = await _db.Animals.FindAsync(id);
    //   animal.Adopted = adopted;
    //   _db.Entry(animal).State = EntityState.Modified;
    //   try
    //   {
    //     await _db.SaveChangesAsync();
    //   }
    //   catch (DbUpdateConcurrencyException)
    //   {
    //     if (!AnimalExists(id))
    //     {
    //       return NotFound();
    //     }
    //     else
    //     {
    //       throw;
    //     }
    //   }
    
    //   return NoContent();
    // }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}
