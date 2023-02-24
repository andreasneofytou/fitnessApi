using FitnessApi.Exercises.Models;
using MongoDB.Driver;

namespace FitnessApi.Exercises;

public class ExerciseService
{
    private readonly Repository<Exercise> exerciseRepository;

    public ExerciseService(Repository<Exercise> exerciseRepository)
    {
        this.exerciseRepository = exerciseRepository;
    }

    public async Task<IEnumerable<Exercise>> GetAsync()
    {
        var filter = Builders<Exercise>.Filter.Empty;
        return await exerciseRepository.FindAsync(filter);
    }

    public async Task<Exercise> InsertAsync(Exercise exercise)
    {
        return await exerciseRepository.InsertAsync(exercise);
    }
}