using System;
using System.Drawing;

// README.md를 읽고 코드를 작성하세요.
Product[] products =
{
    new Electronics { Name = "노트북", Price = 1500000, Warranty = 24 }
};


class Product
{
    protected string Name { get; set; }
    protected int Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - \\{Price:#,###}";
    }

    public virtual void GetDescription() => Console.WriteLine($"{Name}입니다.");
}

class Electronics : Product
{
    private int Warranty { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"(보증: {Warranty}개월)";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  → 전자기기입니다. 취급에 주의하세요.");
    }
}
class Clothing : Product
{
    private char Size { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"(사이즈: {Size})";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  → 의류입니다. 세탁 방법을 확인하세요.");
    }
}

class Food : Product
{
    private string ExpirationDate { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"(유통기한: {ExpirationDate})";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  → 식품입니다. 냉장 보관하세요.");
    }
}