/*
 1. Feladat
    Kérjen be egy egész értéket (n1), majd írja ki 0-tól n1-ig a 
    2 hatványait, (ne Pow-val), az alábbi formátumban:
    2^0 = 1
    2^1 = 2
    2^2 = 4
 */
// Kettő hatványainak számítása
Console.WriteLine("2 hatványai");
Console.Write("Adjon meg egy egész számot: ");
int n1 = int.Parse(Console.ReadLine()!);

int hatv = 1;
for (int i = 0; i <= n1; i++)
{
  Console.WriteLine($"2^{i} = {hatv,3}");
  hatv *= 2;
}
//--------------------------------------------------------------
/*
 2. Feladat
    Kérjen be egy egész értéket (n2), majd írja ki a Fibonacci sorozat 
    első n2 elemét, az alábbi formátumban:
    Fibonacci sorozat:
    0 1 1 2 3 5 8 ...
 */
// Fibonacci sorozat
Console.WriteLine("Fibonacci sorozat:");
Console.Write("Adjon meg egy egész számot: ");
int n2 = int.Parse(Console.ReadLine()!);
int[] fibonacci = new int[n2];

for (int i = 0; i < n2; i++)
{
  if (i == 0)
    fibonacci[i] = 0;
  else
    if (i == 1)
      fibonacci[i] = 1;
    else
      fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

for (int i = 0; i < n2; i++)
{
  Console.Write(fibonacci[i]);
  if (i < n2 - 1)
    Console.Write(" ");
}
Console.WriteLine();
//--------------------------------------------------------------
/*
 3. Feladat 
 Az előző feladatnál tegye ellenőrzötté az n értéként beolvasását.
 Az érték legalább 3 legyen, ha nem megfelelő értéket kap, akkor 
 adjon hibaüzenetet és az értéket kérje újra, amíg jó adatot nem kap. 
 */
// Fibonacci sorozat
Console.WriteLine("Fibonacci sorozat:");
int n3;
do
{
  Console.Write("Adjon meg egy egész számot (3..): ");
  n3 = int.Parse(Console.ReadLine()!);
  if (n3 < 3)
    Console.WriteLine("Hiba: Az érték legalább 3 legyen!");
} while (n3 < 3);
int[] f = new int[n3];

for (int i = 0; i < n3; i++)
{
  if (i == 0)
    f[i] = 0;
  else
    if (i == 1)
      f[i] = 1;
    else
      f[i] = f[i - 1] + f[i - 2];
}

for (int i = 0; i < n3; i++)
{
  Console.Write(f[i]);
  if (i < n3 - 1)
    Console.Write(" ");
}
Console.WriteLine();
//--------------------------------------------------------------
/*
 4. Feladat
 Kérjen be ellenőrzötten egy egynél nagyobb egész értéket (N), 
 hozzon létre egy N méretű, int típusú tömböt. 
 Olvasson be a konzolról a tömbelemekbe adatokat. 
 */
// Tömb beolvasása
Console.WriteLine("Tömb létrehozása és beolvasása");
int n4;
do
{
  Console.Write("Adjon meg egy egész számot (2..): ");
  n4 = int.Parse(Console.ReadLine()!);
  if (n4 <= 1)
    Console.WriteLine("Hiba: Az érték nagyobb legyen egynél!");
} while (n4 <= 1);

int[] tomb = new int[n4];
Console.WriteLine("Adja meg a tömb elemeit:");
for (int i = 0; i < n4; i++)
{
  Console.Write($"{i + 1}. elem: ");
  tomb[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("A tömb elemei:");
for (int i = 0; i < n4; i++)
{
  Console.Write(tomb[i]);
  if (i < n4 - 1)
    Console.Write(" ");
}
Console.WriteLine();
//--------------------------------------------------------------
/*
 5. Feladat
 Szimulálja a "Buggy egy, jobbra megy" játékot. A körben ülő játékosok 
 sorban mondanak egymást követő egész számokat. Amikor 7-re végződő, 
 vagy 7-tel osztható szám következik, akkor helyette azt mondja a játékos: 
 "Buggy (hibás)" és ekkor a körbejárás megfordul. 
 Jobbra kezdünk. Sorban írja ki a számokat és a megfelelő helyen a 
 !-t, és minden elem után írja ki a j vagy a b kódot, ami megadja 
 a körbejárás irányát. A szimulátor minta eredménye és kimenete:
 1j 2j 3j 4j 5j 6j !b 8b 9b 10b 11b 12b 13b !j 15j 16j !b 18b 19b …
 */
// Buggy játék szimulációja
Console.WriteLine("Buggy játék szimulációja:");
int irany=0; // 0: jobbra, 0: balra
char[] iranyk = { 'b', 'j' }; // j: jobbra, b: balra
for (int i = 1; i<=20; i++)
{
  if (i % 7 == 0 || i%10==7)
  {
    irany = (irany+1)%2;
    Console.Write($" {iranyk[irany]}!");
  }
  else 
    Console.Write($" {iranyk[irany]}{i}");
}