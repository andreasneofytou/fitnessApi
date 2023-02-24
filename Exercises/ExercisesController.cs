using FitnessApi.Exercises.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApi.Exercises;

[ApiController]
[Route("[controller]")]
public class ExercisesController : ControllerBase
{
    private readonly ExerciseService exerciseService;

    public ExercisesController(ExerciseService exerciseService)
    {
        this.exerciseService = exerciseService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await exerciseService.GetAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Exercise exercise)
    {
        return Ok(await exerciseService.InsertAsync(exercise));
    }

}
