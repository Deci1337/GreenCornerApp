using GreenCorner.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenCorner.Services;

public class PlantService
{
    private List<Plant> _plants;

    public PlantService()
    {
        _plants = new List<Plant>
        {
            new Plant
            {
                Id = 1,
                Name = "Monstera Deliciosa",
                Description = "The Monstera Deliciosa, also known as the Swiss Cheese Plant, is a tropical plant native to southern Mexico and Panama. It is famous for its large, perforated leaves.",
                ImageUrl = "monstera.png", // Placeholder
                Price = 45.00m,
                Difficulty = "Easy",
                LightRequirement = "Medium",
                IsPopular = true,
                Tag = "Best Seller"
            },
            new Plant
            {
                Id = 2,
                Name = "Ficus Lyrata",
                Description = "Commonly known as the Fiddle-leaf Fig, it is popular for its broad, lyre-shaped leaves. It needs bright, filtered light and careful watering.",
                ImageUrl = "ficus.png", // Placeholder
                Price = 65.00m,
                Difficulty = "Hard",
                LightRequirement = "High",
                IsPopular = true,
                Tag = "Statement Piece"
            },
            new Plant
            {
                Id = 3,
                Name = "Snake Plant",
                Description = "Sansevieria trifasciata is an ideal plant for beginners. It thrives in low light and needs very little water.",
                ImageUrl = "snake.png", // Placeholder
                Price = 25.00m,
                Difficulty = "Easy",
                LightRequirement = "Low",
                IsPopular = false,
                Tag = "Indestructible"
            },
            new Plant
            {
                Id = 4,
                Name = "Pothos",
                Description = "Epipremnum aureum is a trailing vine that is very easy to care for and propagates easily in water.",
                ImageUrl = "pothos.png", // Placeholder
                Price = 15.00m,
                Difficulty = "Easy",
                LightRequirement = "Low",
                IsPopular = true,
                Tag = "Beginner Friendly"
            },
            new Plant
            {
                Id = 5,
                Name = "Calathea Orbifolia",
                Description = "Known for its large, round, striped leaves. It requires high humidity and consistent moisture.",
                ImageUrl = "calathea.png", // Placeholder
                Price = 35.00m,
                Difficulty = "Medium",
                LightRequirement = "Medium",
                IsPopular = false,
                Tag = "Pet Friendly"
            },
            new Plant
            {
                Id = 6,
                Name = "ZZ Plant",
                Description = "Zamioculcas zamiifolia is drought tolerant and accepts low-light conditions.",
                ImageUrl = "zz.png", // Placeholder
                Price = 30.00m,
                Difficulty = "Easy",
                LightRequirement = "Low",
                IsPopular = true,
                Tag = "Office Favorite"
            }
        };
    }

    public List<Plant> GetPlants()
    {
        return _plants;
    }

    public List<Plant> GetPopularPlants()
    {
        return _plants.Where(p => p.IsPopular).ToList();
    }

    public Plant GetPlantById(int id)
    {
        return _plants.FirstOrDefault(p => p.Id == id);
    }
}
