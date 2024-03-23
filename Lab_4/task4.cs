using System;
using System.Collections.Generic;
using System.Linq;

class Warehouse
{
    public List<Product> products;

    public Warehouse()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public List<Product> SearchProducts(Func<Product, bool> criteria)
    {
        return products.Where(criteria).ToList();
    }

    public void SortByManufacturer()
    {
        products.Sort((p1, p2) => string.Compare(p1.Manufacturer, p2.Manufacturer));
    }

    public void SortByPrice()
    {
        products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
    }

    public void SortByName()
    {
        products.Sort((p1, p2) => string.Compare(p1.Name, p2.Name));
    }

    public void DisplayProducts(List<Product> products)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Товарів не знайдено.");
            return;
        }

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

class Product
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime ArrivalDate { get; set; }
    public double Price { get; set; }
    public string Dimensions { get; set; }

    public override string ToString()
    {
        return $"Назва: {Name}, Виробник: {Manufacturer}, Дата надходження: {ArrivalDate.ToShortDateString()}, Ціна: {Price}, Габарити: {Dimensions}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Warehouse warehouse = new Warehouse();

        warehouse.AddProduct(new Product { Name = "Телефон", Manufacturer = "Samsung", ArrivalDate = DateTime.Parse("2024-03-20"), Price = 1000, Dimensions = "15x8x1" });
        warehouse.AddProduct(new Product { Name = "Ноутбук", Manufacturer = "Dell", ArrivalDate = DateTime.Parse("2024-03-22"), Price = 1500, Dimensions = "30x20x3" });
        warehouse.AddProduct(new Product { Name = "Телевізор", Manufacturer = "LG", ArrivalDate = DateTime.Parse("2024-03-25"), Price = 2000, Dimensions = "40x30x5" });

        Console.WriteLine("Результати пошуку за ціною менше 1500:");
        var cheapProducts = warehouse.SearchProducts(p => p.Price < 1500);
        warehouse.DisplayProducts(cheapProducts);
        Console.WriteLine();

        Console.WriteLine("Результати сортування за виробником:");
        warehouse.SortByManufacturer();
        warehouse.DisplayProducts(warehouse.products);
        Console.WriteLine();
    }
}
