namespace _029_Join;

public class Product
{
    public string Name {get; set;}
    public int CategoryId {get; set;}

    public Product(string Name, int CategoryId) {
        this.Name = Name;
        this.CategoryId = CategoryId;
    }
}
