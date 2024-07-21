
// For örnekleri 1: Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdım
using System;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!"); 
}
Console.WriteLine("------------------------------------------");
//For örnekleri 2: Konsol ekranına 1 ile 20 arasındaki sayıları yazdırdım
for (int i = 0;i <= 20; i++)
{
    Console.WriteLine("sayıdeğeri" + i);
}
Console.WriteLine("------------------------------------------");
//For örnekleri 3: 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırdım
for (int i = 0;i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("------------------------------------------");

//50 ile 150 arasındaki sayıların toplamını ekrana yazdırdım.
int sayi = 0;
for (int i = 50; i <= 150; i++)
{
    sayi += i;
    
}
Console.WriteLine("sayıların toplamları: " + sayi);
Console.WriteLine("------------------------------------------");


//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırdım
int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}
    Console.WriteLine("1-120 arası tek sayıların toplamı:" + tekToplam);
    Console.WriteLine("1-120 arası çift sayıların toplamı:" + ciftToplam);



