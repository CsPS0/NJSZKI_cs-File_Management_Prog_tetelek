#region 1.Feladat|szamok
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1. Feladat");
Console.ResetColor();

//Files
Console.Write("Adj meg egy számot! (1-3): ");
Console.ForegroundColor = ConsoleColor.Yellow;
string szam = Console.ReadLine();
Console.ResetColor();
string file_name = $"szamok{szam}.txt";
string[] sorok = File.ReadAllLines(file_name);

Console.Write("A választott fájl: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(file_name);
Console.ResetColor();

// a.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("a. Feladat");
Console.ResetColor();

int meret = Convert.ToInt32(sorok[0]);
int[] szamok = new int[meret];

for (int i = 1; i < sorok.Length; i++)
{
    szamok[i - 1] = Convert.ToInt32(sorok[i]);
}

// b.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("b. Feladat");
Console.ResetColor();

for (int i = 0; i < szamok.Length; i++)
{
    Console.WriteLine($"{i + 1}. szám: {szamok[i]}");
}

// c.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("c. Feladat");
Console.ResetColor();

Console.WriteLine(string.Join("\t", szamok));

// d.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("d. Feladat");
Console.ResetColor();

using (StreamWriter sw = new StreamWriter("parosaval.txt"))
{
    for (int i = 0; i < szamok.Length - 1; i += 2)
    {
        double atlagf = (szamok[i] + szamok[i + 1]) / 2.0;
        sw.WriteLine($"{szamok[i]};{szamok[i + 1]};{atlagf:F2}");
    }
}


// e.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("e. Feladat");
Console.ResetColor();

int osszeg = szamok.Sum();
Console.WriteLine("A számok összege: " + osszeg);

// f.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("f. Feladat");
Console.ResetColor();

double atlag = szamok.Average();
Console.WriteLine("A számok átlaga: " + atlag);

// g.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("g. Feladat");
Console.ResetColor();

int max = szamok.Max();
Console.WriteLine("A legnagyobb érték: " + max);

// h.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("h. Feladat");
Console.ResetColor();

int min = szamok.Min();
Console.WriteLine("A legkisebb érték: " + min);

// i.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("i. Feladat");
Console.ResetColor();

bool vanNulla = szamok.Contains(0);
Console.WriteLine(vanNulla ? "Van 0 a számok között." : "Nincs 0 a számok között.");

// j.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("j. Feladat");
Console.ResetColor();

int elsoNegativIndex = Array.FindIndex(szamok, x => x < 0);
Console.WriteLine(elsoNegativIndex >= 0 ? $"Első negatív szám pozíciója: {elsoNegativIndex + 1}" : "Nincs negatív szám.");

// k.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("k. Feladat");
Console.ResetColor();

double pozitivSzazalek = (double)szamok.Count(x => x > 0) / szamok.Length * 100;
Console.WriteLine($"Pozitív számok aránya: {pozitivSzazalek:F2}%");
#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}
Console.WriteLine("1 másodperc...");
Thread.Sleep(1000);
Console.ResetColor();
#endregion

#region 2.Feladat|nevek
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2. Feladat");
Console.ResetColor();

//Files
string nevek = "nevek.txt";
string[] sorokN = File.ReadAllLines(nevek);

// a.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("a. Feladat");
Console.ResetColor();

int ketKeresztnev = sorokN.Count(n => n.Split().Length == 2);
Console.WriteLine($"Két keresztnevűek száma: {ketKeresztnev}");

// b.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("b. Feladat");
Console.ResetColor();

Array.Sort(sorokN);
Console.WriteLine("Névsor:");
foreach (var nev in sorokN)
{
    Console.WriteLine(nev);
}

// c.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("c. Feladat");
Console.ResetColor();

Random rnd = new Random();
var randomNevek = sorokN.OrderBy(x => rnd.Next()).Distinct().Take(3);
File.WriteAllLines("felelok.txt", randomNevek);

// d.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("d. Feladat");
Console.ResetColor();

File.WriteAllLines("nagybetus.txt", sorokN.Select(n => n.ToUpper()));

// e.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("e. Feladat");
Console.ResetColor();

File.WriteAllLines("rendezett.txt", sorokN.OrderBy(n => n));

// f.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("f. Feladat");
Console.ResetColor();

var keresztnevek = new HashSet<string>();
foreach (var nev in sorokN)
{
    foreach (var kernev in nev.Split())
    {
        keresztnevek.Add(kernev);
    }
}
Console.WriteLine(string.Join(", ", keresztnevek.OrderBy(n => n)));

// g. Monogram keresés
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("g. Feladat");
Console.ResetColor();

//Console.Write("Adj meg egy monogramot (pl. 'bh'): ");
//string monogram = Console.ReadLine().ToUpper();
//var talalat = sorokN.FirstOrDefault(n => n.ToUpper().Split().Select(w => w[0]).Join("").Equals(monogram));
//Console.WriteLine(talalat != null ? $"Találat: {talalat}" : "Nincs ilyen monogramú személy.");
#endregion

#region pause
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Nyomj entert a továbblépéshez!");
while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}
Console.WriteLine("1 másodperc...");
Thread.Sleep(1000);
Console.ResetColor();
#endregion

#region 3.Feladat|https://mester.inf.elte.hu
// Nem lehetet bejelentkezni a Google Accountba, meg konkréta minden lépésemet BYPASS-elni kellett az otthoni anti-http miatt...
#endregion