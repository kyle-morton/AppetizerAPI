using Microsoft.AspNetCore.Mvc;
using AppetizersAPI.Models;

namespace AppetizersAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class AppetizersController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var appetizers = new List<Appetizer>();
            var id = 1;
            
            // deep clone 3x for more results
            for (int i = 0; i < 3; i++)
            {
                appetizers.AddRange(_appetizers.Select(a => new Appetizer
                {
                    Id = id++, 
                    Name = a.Name,
                    Description = a.Description,
                    Price = a.Price,
                    Protein = a.Protein,
                    Calories = a.Calories,
                    Carbs = a.Carbs,   
                    ImageURL = a.ImageURL
                }));
            }
            
            return Ok(new
            {
                request = appetizers
            });
        }


        private const string _baseImagesUrl = "https://appetizers.azurewebsites.net/images";
        private List<Appetizer> _appetizers = new List<Appetizer>
        {
                new Appetizer {
                    Name = "Asian Flank Steak",
                    Description = "This perfectly thin cut just melts in your mouth.",
                    Protein = 14,
                    Calories = 300,
                    Price = 8.99,
                    Carbs = 0,
                    ImageURL = $"{_baseImagesUrl}/asian-flank-steak.jpg" 
                },
                new Appetizer {
                    Name = "Blackened Shrimp",
                    Description = "Seasoned shrimp from the depths of the Atlantic Ocean.",
                    Protein = 4,
                    Calories = 450,
                    Price = 6.99,
                    Carbs = 3,
                    ImageURL = $"{_baseImagesUrl}/blackened-shrimp.jpg" 
                },
                new Appetizer{
                    Name = "Buffalo Chicken Bites",
                    Description = "The tasty bites of chicken have just the right amount of kick to them.",
                    Protein = 5,
                    Calories = 800,
                    Price = 7.49,
                    Carbs = 22,
                    ImageURL = $"{_baseImagesUrl}/buffalo-chicken-bites.jpg" 
                },
                new Appetizer{
                    Name = "Chicken Avocado Spring Roll",
                    Description = "These won't last 10 seconds once they hit the table.",
                    Protein = 7,
                    Calories = 480,
                    Price = 12.99,
                    Carbs = 19,
                    ImageURL = $"{_baseImagesUrl}/chicken-avocado-spring-rolls.jpg"
                },
                new Appetizer{
                    Name = "Crispy Calamari",
                    Description = "Lightly breaded calamari served with a zesty marinara sauce.",
                    Protein = 10,
                    Calories = 350,
                    Price = 9.49,
                    Carbs = 15,
                    ImageURL = $"{_baseImagesUrl}/crispy-calamari.jpg"
                },
                new Appetizer{
                    Name = "Stuffed Mushrooms",
                    Description = "Mushroom caps filled with herbed cheese and breadcrumbs.",
                    Protein = 6,
                    Calories = 220,
                    Price = 7.99,
                    Carbs = 10,
                    ImageURL = $"{_baseImagesUrl}/stuffed-mushrooms.jpg"
                },
                new Appetizer{
                    Name = "Mozzarella Sticks",
                    Description = "Golden fried mozzarella with marinara dipping sauce.",
                    Protein = 8,
                    Calories = 400,
                    Price = 6.49,
                    Carbs = 30,
                    ImageURL = $"{_baseImagesUrl}/mozzarella-sticks.jpg"
                },
                new Appetizer{
                    Name = "Garlic Parmesan Fries",
                    Description = "Crispy fries tossed in garlic and parmesan cheese.",
                    Protein = 4,
                    Calories = 500,
                    Price = 5.99,
                    Carbs = 60,
                    ImageURL = $"{_baseImagesUrl}/garlic-parm-fries.jpg"
                }
        };

    }
