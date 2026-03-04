using System;
using System.Drawing;

// README.md를 읽고 코드를 작성하세요.
Product[] products =
{
    new Electronics { Name = "노트북", Price = 1500000, Warranty = 24 },
    new Clothing { Name = "청바지", Price = 89000, Size = 'M' },
    new Food { Name = "우유", Price = 3500, ExpirationDate = "2026-06-15" }
};

Console.WriteLine("=== 상품 카탈로그 ===");
ShowInfo(products[0]);
ShowInfo(products[1]);
ShowInfo(products[2]);

void ShowInfo(Product product)
{
    Console.WriteLine(product);
    product.GetDescription();
}
