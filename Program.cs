
using ConsoleAppTarsas;

List<Osvenyek> osvenyek = File.ReadAllLines("osvenyek.txt").Select(x => new Osvenyek(x)).ToList();
List<int> dobasok = File.ReadAllText("dobasok.txt").Split(' ').Select(int.Parse).ToList();

Console.WriteLine($"2. feladat");
Console.WriteLine($"\tDobások száma: {dobasok.Count}");
Console.WriteLine($"\tÖsvények száma: {osvenyek.Count}");

Console.WriteLine("3. feladat");
Console.WriteLine($"\tAz egyik leghosszabb a(z) {osvenyek.FindIndex(x => x.Osveny.Length == osvenyek.Max(x => x.Osveny.Length))+1}. ösvény, hossza: {osvenyek.Max(x => x.Osveny.Length)}");

Console.WriteLine("4. feladat");
Console.Write("\tAdja meg egy ösvény sorszámát: ");
int sorszamOsveny = int.Parse(Console.ReadLine());
Console.Write("\tAdja meg a játékosok számát: ");
int sorszamJatekos= int.Parse(Console.ReadLine());

Console.WriteLine("5. feladat");
string megadottSor = osvenyek[sorszamOsveny].Osveny;
Console.WriteLine($"\tM: {megadottSor.Count(x => x == 'M')}");
Console.WriteLine($"\tV: {megadottSor.Count(x => x == 'V')}");
Console.WriteLine($"\tE: {megadottSor.Count(x => x == 'E')}");

// 6. feladat
File.WriteAllLines("kulonleges.txt", megadottSor.Select((x,c) => new {mezoSorszam = c+1, mezoTipus = x}).Where(x => x.mezoTipus != 'M').Select(x => $"{x.mezoSorszam}\t{x.mezoTipus}"));

Console.WriteLine("7. feladat");
Console.WriteLine("\tMajd egyszer kész lesz!");
Console.WriteLine("\tKészülőben lévő funkció!");
Console.WriteLine("\tHAGGYÁMÁ!!!!!!");

Console.WriteLine("8. feladat");
Console.WriteLine("\tElegem van!");
Console.WriteLine("\tÉn ezt nem!");
Console.WriteLine("\tKaki ez az egész!");
