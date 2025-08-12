using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AppetizersAPI.Controllers
{
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
                    id = id++, 
                    name = a.name,
                    description = a.description,
                    price = a.price,
                    protein = a.protein,
                    calories = a.calories,
                    carbs = a.carbs,   
                    imageURL = a.imageURL
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
                    name = "Asian Flank Steak",
                    description = "This perfectly thin cut just melts in your mouth.",
                    protein = 14,
                    calories = 300,
                    price = 8.99,
                    carbs = 0,
                    imageURL = $"{_baseImagesUrl}/asian-flank-steak.jpg" 
                },
                new Appetizer {
                    name = "Blackened Shrimp",
                    description = "Seasoned shrimp from the depths of the Atlantic Ocean.",
                    protein = 4,
                    calories = 450,
                    price = 6.99,
                    carbs = 3,
                    imageURL = $"{_baseImagesUrl}/blackened-shrimp.jpg" 
                },
                new Appetizer{
                    name = "Buffalo Chicken Bites",
                    description = "The tasty bites of chicken have just the right amount of kick to them.",
                    protein = 5,
                    calories = 800,
                    price = 7.49,
                    carbs = 22,
                    imageURL = $"{_baseImagesUrl}/buffalo-chicken-bites.jpg" 
                },
                new Appetizer{
                    name = "Chicken Avocado Spring Roll",
                    description = "These won't last 10 seconds once they hit the table.",
                    protein = 7,
                    calories = 480,
                    price = 12.99,
                    carbs = 19,
                    imageURL = $"{_baseImagesUrl}/chicken-avocado-spring-rolls.jpg"
                },
                new Appetizer{
                    name = "Crispy Calamari",
                    description = "Lightly breaded calamari served with a zesty marinara sauce.",
                    protein = 10,
                    calories = 350,
                    price = 9.49,
                    carbs = 15,
                    imageURL = $"{_baseImagesUrl}/crispy-calamari.jpg"
                },
                new Appetizer{
                    name = "Stuffed Mushrooms",
                    description = "Mushroom caps filled with herbed cheese and breadcrumbs.",
                    protein = 6,
                    calories = 220,
                    price = 7.99,
                    carbs = 10,
                    imageURL = $"{_baseImagesUrl}/stuffed-mushrooms.jpg"
                },
                new Appetizer{
                    name = "Mozzarella Sticks",
                    description = "Golden fried mozzarella with marinara dipping sauce.",
                    protein = 8,
                    calories = 400,
                    price = 6.49,
                    carbs = 30,
                    imageURL = $"{_baseImagesUrl}/mozzarella-sticks.jpg"
                },
                new Appetizer{
                    name = "Garlic Parmesan Fries",
                    description = "Crispy fries tossed in garlic and parmesan cheese.",
                    protein = 4,
                    calories = 500,
                    price = 5.99,
                    carbs = 60,
                    imageURL = $"{_baseImagesUrl}/garlic-parm-fries.jpg"
                }
        };

    }
}
