/*
Given two lists, one containing Product objects and the other containing Category objects.
Both classes need a CategoryId property.
Create a console application that joins the two lists based on the CategoryId using LINQ.
*/


using _029_Join;

List<Category> categories = new List<Category>(){new Category("First courses", 1),
                                                 new Category("Second courses", 2),
                                                 new Category("Desserts", 3),
                                                 new Category("Drinks", 4)
                                                };

List<Product> products = new List<Product>(){new Product("Pasta Carbonara", 1),
                                             new Product("Risotto Milanese style", 1),
                                             new Product("Pasta Ligurian style", 1),
                                             new Product("Risotto with Pear and Taleggio", 1),
                                             new Product("Salmon with Baked Pumpkin", 2),
                                             new Product("Baked Sausage and Potatoes", 2),
                                             new Product("Chicken Curry", 2),
                                             new Product("Potato gataeau", 2),
                                             new Product("Tiramisù", 3),
                                             new Product("Brownie", 3),
                                             new Product("Apple Pie", 3),
                                             new Product("Cheesecake", 3),
                                             new Product("Still Water", 4),
                                             new Product("Sparkling Water", 4),
                                             new Product("Beer", 4),
                                             new Product("Coca Cola", 4),
                                            };


var result = from product in products
             join category in categories
             on product.CategoryId equals category.CategoryId
             select new 
             {
                ProductName = product.Name, CategoryName = category.Name
             };


 foreach(var item in result){
    System.Console.WriteLine($"{item.ProductName} ({item.CategoryName})");
 }   