using System;

// README.md를 읽고 코드를 작성하세요.
Product product = new Product() { Name = "노트북", Price = 1500000 };

Console.WriteLine(product);


class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - \\{Price:#,###}";
    }
}
