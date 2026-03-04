using System;
using System.Collections.Generic;
using System.Text;

class Clothing : Product
{
    public char Size { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"(사이즈: {Size})";
    }
    public override void GetDescription()
    {
        Console.WriteLine($"  → 의류입니다. 세탁 방법을 확인하세요.");
    }
}
