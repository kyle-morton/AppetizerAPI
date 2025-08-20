using System.ComponentModel.DataAnnotations;


namespace AppetizersAPI.Models;

public class Appetizer
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Protein { get; set; }
    public int Calories { get; set; }
    public double Price { get; set; }
    public int Carbs { get; set; }
    public string ImageURL { get; set; }
}