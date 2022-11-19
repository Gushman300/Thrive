﻿namespace AutoEvo
{
    /// <summary>
    ///   A class for random-encounter based food sources.
    /// </summary>
    public abstract class RandomEncounterFoodSource : FoodSource
    {
        protected override float StorageScore(MicrobeSpecies species, Compound compound, Patch patch,
            SimulationCache simulationCache, WorldGenerationSettings worldSettings,
            DayNightConfiguration dayNightConfiguration)
        {
            // TODO: compute value based on encouter chance; this is a temporary solution for day/night cycle PR.
            return 1.0f;
        }
    }
}
