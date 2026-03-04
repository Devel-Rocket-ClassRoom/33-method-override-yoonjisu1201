using System;
using System.Collections.Generic;
using System.Text;

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}

class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}

class Boat : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 향해 달립니다! 속도: {Speed}km/h");
    }
}
