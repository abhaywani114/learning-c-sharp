using CatFood.data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CatFood.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodController : ControllerBase
{
    private readonly DataContext _dataContext;
    public FoodController(DataContext dataContext)
    {
        this._dataContext = dataContext;
    }

    [HttpGet]
    public async  Task<ActionResult<List<Food>>> GetAllFoods()
    {
        List<Food> foods = await _dataContext.Foods.ToListAsync();

        return Ok(foods);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Food>> GetFood(long id)
    {
        var food = await _dataContext.Foods.FindAsync(id);
        if (food is null)
            return NotFound("Food not found.");
        
        return Ok(food);
    }

    [HttpPost]
    public async Task<ActionResult<Food>> AddFood(Food food)
    {
        if (food.Breed.IsNullOrEmpty() || food.Name.IsNullOrEmpty() || food.Description.IsNullOrEmpty())
            return BadRequest("Please fill all the fields.");
        
        var result =  _dataContext.Foods.Add(food);
        await _dataContext.SaveChangesAsync();
        return Ok(result.Entity);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Food>> UpdateFood(long id, Food food)
    {
        var foodInDb = await _dataContext.Foods.FindAsync(id);
        if (foodInDb is null)
            return BadRequest("Food to be updated not found in db.");
        
        foodInDb.Breed = food.Breed;
        foodInDb.Description = food.Description;
      
        //_dataContext.Entry(foodInDb).CurrentValues.SetValues(food);
        await _dataContext.SaveChangesAsync();
        
        return Ok(foodInDb);
    }

    [HttpDelete]
    public async Task<ActionResult<String>> DeleteFood(long id)
    {
        
        var foodInDb = await _dataContext.Foods.FindAsync(id);
        if (foodInDb is null)
            return BadRequest("Food to be updated not found in db.");
        
        _dataContext.Foods.Remove(foodInDb);
        await _dataContext.SaveChangesAsync();
        
        return "Food was deleted";
    }
}