Dictionary<string, string> ksiazkaTelefoniczna
    = new Dictionary<string, string>();

ksiazkaTelefoniczna["Jan Kowalski"] = "543-753-987";
ksiazkaTelefoniczna["Michał Nowak"] = "123-768-943";
ksiazkaTelefoniczna["Bartek Kowalski"] = "823-243-682";

if (ksiazkaTelefoniczna.ContainsKey("Bartek Kozioł"))
{
    Console.WriteLine("Jest");
}
else
{
    Console.WriteLine("Nie ma");
}

string szukanyTel;
if (ksiazkaTelefoniczna.TryGetValue("Bartek Kowalski", out szukanyTel))
{
    Console.WriteLine("Znaleziono " + szukanyTel);
}

foreach (var p in ksiazkaTelefoniczna)
{
    Console.WriteLine(p.Key + ": " + p.Value);
}

