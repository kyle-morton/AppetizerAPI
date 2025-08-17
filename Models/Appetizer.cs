namespace AppetizersAPI.Models;

public class Appetizer
{
    public string name { get; set; }
    public string description { get; set; }
    public int protein { get; set; }
    public int id { get; set; }
    public int calories { get; set; }
    public double price { get; set; }
    public int carbs { get; set; }
    public string imageURL { get; set; }
}