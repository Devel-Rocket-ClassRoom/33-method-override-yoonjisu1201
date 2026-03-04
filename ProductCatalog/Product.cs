using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - \\{Price:#,###} ";
    }

    public virtual void GetDescription() => Console.WriteLine($"{Name}입니다.");
}
