using System;

// README.md를 읽고 코드를 작성하세요.
Vehicle[] vehicles =
{
    new Car { Name = "스포츠카", Speed = 120},
    new Airplane { Name = "보잉747", Speed = 900},
    new Boat { Name = "요트", Speed = 60}
};

Console.WriteLine("=== 경주 시작! ===");
vehicles[0].Move();
vehicles[1].Move();
vehicles[2].Move();
