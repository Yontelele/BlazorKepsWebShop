namespace LaborationBlazorKepsWebShop.Classes;

public class Cap
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }
    public string ImageUrl { get; set; }

    public Cap(int id, string name, string color, int price, string imageurl)
    {
        Id = id;
        Name = name;
        Color = color;
        Price = price;
        ImageUrl = imageurl;
    }
}
