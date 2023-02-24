using FitnessApi.Common.Models;

namespace FitnessApi.Exercises.Models;

public enum Category
{
    Barbell,
    Dumbbell,
    Bodyweight,
    AssistedBodyweight,
    Cardio,
    Cable,
    Machine,
    Kettlebell,
    Reps,
    Ball,
    Rope,
}

public enum MuscleGroup
{
    Arms,
    Back,
    Chest,
    Core,
    Legs,
    Shoulders,
    Olympic,
    FullBody,
    Cardio,
}

public class Exercise : BaseModel
{
    public string? Title { get; set; }

    public Category Category { get; set; }

    public MuscleGroup MuscleGroup { get; set; }
}