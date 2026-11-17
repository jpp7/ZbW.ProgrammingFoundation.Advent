namespace ZbW.ProgrammingFoundation.Advent.Tag08_ElfImKreis;

// ============================================================
// TAG 8 – Elf im Kreis (🔍 Was gibt das aus? | ⭐ Einfach | ~10 Min.)
//
// Drei Schleifen lesen und vorhersagen, eine vierte reparieren.
//
// Anforderungen:
//   - Für A, B, C: Anzahl Durchläufe und Ausgabe vorhersagen
//   - Danach starten (Menü: 8) und vergleichen
//   - D: Off-by-one-Fehler finden, es sollen genau 5 Geschenke sein
// ============================================================

public static class ElfImKreis
{
  /// <summary>
  ///   Führt die vier Schleifen von Elf Tinka aus.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Schleife A – Durchläufe: ___  Ausgabe: ___
    Console.Write("A: ");
    int a = 10;
    while (a > 0)
    {
      Console.Write(a + " ");
      a -= 4;
    }

    Console.WriteLine();

    // TODO 2: Schleife B – Durchläufe: ___  Ausgabe: ___
    Console.Write("B: ");
    int b = 100;
    do
    {
      Console.Write(b + " ");
      b++;
    } while (b < 100);

    Console.WriteLine();

    // TODO 3: Schleife C – Durchläufe: ___  Ausgabe: ___
    Console.Write("C: ");
    for (int i = 1; i < 12; i += 3)
    {
      Console.Write(i + " ");
    }

    Console.WriteLine();

    // TODO 4: Schleife D soll genau 5 Geschenke verteilen. Finde den Fehler.
    int giftCount = 0;
    for (int i = 0; i <= 5; i++)
    {
      giftCount++;
    }

    Console.WriteLine($"D: {giftCount} Geschenke verteilt (erwartet: 5)");
  }
}
