LinkedList<int> numerki = new LinkedList<int>();

Console.WriteLine("Podaj ile chcesz liczb:");
int ilosc = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj te liczby:");

for (int i = 0; i < ilosc; i++)
{
    numerki.AddLast(int.Parse(Console.ReadLine()));
}

Console.WriteLine("Podałeś następujące liczby:");

for (var i = numerki.First(); i <= numerki.Last(); i++)
{
    Console.WriteLine(i);
}

foreach (int i in numerki)
{
    Console.WriteLine(i);
}


