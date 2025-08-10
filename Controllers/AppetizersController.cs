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
            Task.Delay(1000).Wait(); // Simulating a delay for demonstration purposes

            return Ok(new
            {
                request = Appetizers
            });
        }
        
        public List<object> Appetizers = new List<object>
        {
            new {
                    name = "Asian Flank Steak",
                    description = "This perfectly thin cut just melts in your mouth.",
                    protein = 14,
                    id = 1,
                    calories = 300,
                    price = 8.99,
                    carbs = 0,
                    imageURL = "https://placehold.co/600x400?text=Asian+Flank+Steak"
                },
                new {
                    name = "Blackened Shrimp",
                    description = "Seasoned shrimp from the depths of the Atlantic Ocean.",
                    protein = 4,
                    id = 2,
                    calories = 450,
                    price = 6.99,
                    carbs = 3,
                    imageURL = "https://placehold.co/600x400?text=Blackened+Shrimp"
                },
                new {
                    name = "Buffalo Chicken Bites",
                    description = "The tasty bites of chicken have just the right amount of kick to them.",
                    protein = 5,
                    id = 3,
                    calories = 800,
                    price = 7.49,
                    carbs = 22,
                    imageURL = "https://placehold.co/600x400?text=Buffalo+Chicken+Bites"
                },
                new {
                    name = "Chicken Avocado Spring Roll",
                    description = "These won't last 10 seconds once they hit the table.",
                    protein = 7,
                    id = 4,
                    calories = 480,
                    price = 12.99,
                    carbs = 19,
                    imageURL = "https://placehold.co/600x400?text=Chicken+Avocado+Spring+Roll"
                },
                new {
                    name = "Crispy Calamari",
                    description = "Lightly breaded calamari served with a zesty marinara sauce.",
                    protein = 10,
                    id = 5,
                    calories = 350,
                    price = 9.49,
                    carbs = 15,
                    imageURL = "https://placehold.co/600x400?text=Crispy+Calamari"
                },
                new {
                    name = "Stuffed Mushrooms",
                    description = "Mushroom caps filled with herbed cheese and breadcrumbs.",
                    protein = 6,
                    id = 6,
                    calories = 220,
                    price = 7.99,
                    carbs = 10,
                    imageURL = "https://placehold.co/600x400?text=Stuffed+Mushrooms"
                },
                new {
                    name = "Mozzarella Sticks",
                    description = "Golden fried mozzarella with marinara dipping sauce.",
                    protein = 8,
                    id = 7,
                    calories = 400,
                    price = 6.49,
                    carbs = 30,
                    imageURL = "https://placehold.co/600x400?text=Mozzarella+Sticks"
                },
                new {
                    name = "Garlic Parmesan Fries",
                    description = "Crispy fries tossed in garlic and parmesan cheese.",
                    protein = 4,
                    id = 8,
                    calories = 500,
                    price = 5.99,
                    carbs = 60,
                    imageURL = "https://placehold.co/600x400?text=Garlic+Parmesan+Fries"
                },
                new {
                    name = "Spicy Tuna Tartare",
                    description = "Fresh tuna tossed in a spicy sesame sauce, served with wonton chips.",
                    protein = 12,
                    id = 9,
                    calories = 320,
                    price = 11.99,
                    carbs = 18,
                    imageURL = "https://placehold.co/600x400?text=Spicy+Tuna+Tartare"
                },
                new {
                    name = "BBQ Pulled Pork Sliders",
                    description = "Mini sliders with slow-cooked BBQ pulled pork and coleslaw.",
                    protein = 13,
                    id = 10,
                    calories = 540,
                    price = 10.49,
                    carbs = 35,
                    imageURL = "https://placehold.co/600x400?text=BBQ+Pulled+Pork+Sliders"
                },
                new {
                    name = "Spinach Artichoke Dip",
                    description = "Creamy spinach and artichoke dip served with tortilla chips.",
                    protein = 5,
                    id = 11,
                    calories = 380,
                    price = 8.49,
                    carbs = 25,
                    imageURL = "https://placehold.co/600x400?text=Spinach+Artichoke+Dip"
                },
                new {
                    name = "Sweet Potato Wedges",
                    description = "Baked sweet potato wedges with a honey mustard dip.",
                    protein = 3,
                    id = 12,
                    calories = 290,
                    price = 5.49,
                    carbs = 40,
                    imageURL = "https://placehold.co/600x400?text=Sweet+Potato+Wedges"
                },
                new {
                    name = "Jalapeno Poppers",
                    description = "Jalapenos stuffed with cheese and fried to perfection.",
                    protein = 6,
                    id = 13,
                    calories = 330,
                    price = 6.99,
                    carbs = 17,
                    imageURL = "https://placehold.co/600x400?text=Jalapeno+Poppers"
                },
                new {
                    name = "Mini Crab Cakes",
                    description = "Golden mini crab cakes with a tangy remoulade sauce.",
                    protein = 9,
                    id = 14,
                    calories = 370,
                    price = 12.49,
                    carbs = 14,
                    imageURL = "https://placehold.co/600x400?text=Mini+Crab+Cakes"
                },
                new {
                    name = "Asian Flank Steak",
                    description = "This perfectly thin cut just melts in your mouth.",
                    protein = 14,
                    id = 1,
                    calories = 300,
                    price = 8.99,
                    carbs = 0,
                    imageURL = "https://placehold.co/600x400?text=Asian+Flank+Steak"
                },
                new {
                    name = "Blackened Shrimp",
                    description = "Seasoned shrimp from the depths of the Atlantic Ocean.",
                    protein = 4,
                    id = 2,
                    calories = 450,
                    price = 6.99,
                    carbs = 3,
                    imageURL = "https://placehold.co/600x400?text=Blackened+Shrimp"
                },
                new {
                    name = "Buffalo Chicken Bites",
                    description = "The tasty bites of chicken have just the right amount of kick to them.",
                    protein = 5,
                    id = 3,
                    calories = 800,
                    price = 7.49,
                    carbs = 22,
                    imageURL = "https://placehold.co/600x400?text=Buffalo+Chicken+Bites"
                },
                new {
                    name = "Chicken Avocado Spring Roll",
                    description = "These won't last 10 seconds once they hit the table.",
                    protein = 7,
                    id = 4,
                    calories = 480,
                    price = 12.99,
                    carbs = 19,
                    imageURL = "https://placehold.co/600x400?text=Chicken+Avocado+Spring+Roll"
                },
                new {
                    name = "Crispy Calamari",
                    description = "Lightly breaded calamari served with a zesty marinara sauce.",
                    protein = 10,
                    id = 5,
                    calories = 350,
                    price = 9.49,
                    carbs = 15,
                    imageURL = "https://placehold.co/600x400?text=Crispy+Calamari"
                },
                new {
                    name = "Stuffed Mushrooms",
                    description = "Mushroom caps filled with herbed cheese and breadcrumbs.",
                    protein = 6,
                    id = 6,
                    calories = 220,
                    price = 7.99,
                    carbs = 10,
                    imageURL = "https://placehold.co/600x400?text=Stuffed+Mushrooms"
                },
                new {
                    name = "Mozzarella Sticks",
                    description = "Golden fried mozzarella with marinara dipping sauce.",
                    protein = 8,
                    id = 7,
                    calories = 400,
                    price = 6.49,
                    carbs = 30,
                    imageURL = "https://placehold.co/600x400?text=Mozzarella+Sticks"
                },
                new {
                    name = "Garlic Parmesan Fries",
                    description = "Crispy fries tossed in garlic and parmesan cheese.",
                    protein = 4,
                    id = 8,
                    calories = 500,
                    price = 5.99,
                    carbs = 60,
                    imageURL = "https://placehold.co/600x400?text=Garlic+Parmesan+Fries"
                },
                new {
                    name = "Spicy Tuna Tartare",
                    description = "Fresh tuna tossed in a spicy sesame sauce, served with wonton chips.",
                    protein = 12,
                    id = 9,
                    calories = 320,
                    price = 11.99,
                    carbs = 18,
                    imageURL = "https://placehold.co/600x400?text=Spicy+Tuna+Tartare"
                },
                new {
                    name = "BBQ Pulled Pork Sliders",
                    description = "Mini sliders with slow-cooked BBQ pulled pork and coleslaw.",
                    protein = 13,
                    id = 10,
                    calories = 540,
                    price = 10.49,
                    carbs = 35,
                    imageURL = "https://placehold.co/600x400?text=BBQ+Pulled+Pork+Sliders"
                },
                new {
                    name = "Spinach Artichoke Dip",
                    description = "Creamy spinach and artichoke dip served with tortilla chips.",
                    protein = 5,
                    id = 11,
                    calories = 380,
                    price = 8.49,
                    carbs = 25,
                    imageURL = "https://placehold.co/600x400?text=Spinach+Artichoke+Dip"
                },
                new {
                    name = "Sweet Potato Wedges",
                    description = "Baked sweet potato wedges with a honey mustard dip.",
                    protein = 3,
                    id = 12,
                    calories = 290,
                    price = 5.49,
                    carbs = 40,
                    imageURL = "https://placehold.co/600x400?text=Sweet+Potato+Wedges"
                },
                new {
                    name = "Jalapeno Poppers",
                    description = "Jalapenos stuffed with cheese and fried to perfection.",
                    protein = 6,
                    id = 13,
                    calories = 330,
                    price = 6.99,
                    carbs = 17,
                    imageURL = "https://placehold.co/600x400?text=Jalapeno+Poppers"
                },
                new {
                    name = "Mini Crab Cakes",
                    description = "Golden mini crab cakes with a tangy remoulade sauce.",
                    protein = 9,
                    id = 14,
                    calories = 370,
                    price = 12.49,
                    carbs = 14,
                    imageURL = "https://placehold.co/600x400?text=Mini+Crab+Cakes"
                }
        };

    }
}
