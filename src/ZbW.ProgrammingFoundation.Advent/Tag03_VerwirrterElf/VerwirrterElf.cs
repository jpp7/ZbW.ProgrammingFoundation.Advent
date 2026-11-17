namespace ZbW.ProgrammingFoundation.Advent.Tag03_VerwirrterElf;

// ============================================================
// TAG 3 – Der verwirrte Elf (🐞 Bug-Jagd | ⭐ Einfach | ~10 Min.)
//
// Das Programm verteilt Guetzli auf 4 Elfen. Es enthält 4 Fehler.
//
// Anforderungen:
//   - Alle 4 Fehler finden und beheben
//   - Ungültige Eingaben dürfen das Programm nicht abstürzen lassen
//   - Bei 10 Guetzli soll jeder Elf 2.50 Guetzli bekommen
//   - Pro Fehler einen kurzen Kommentar: Was war falsch?
// ============================================================

public static class VerwirrterElf
{
  /// <summary>
  ///   Startet die (fehlerhafte) Guetzli-Verteilung.
  /// </summary>
  public static void Start()
  {
    const int ElfCount = 4;

    // Pips wollte hier den Preis pro Guetzli speichern, aber der Compiler hat gemeckert.
    // Deshalb hat er die Zeile auskommentiert und rechnet mit 0 weiter.
    // decimal pricePerCookie = 0.40;
    decimal pricePerCookie = 0;

    Console.Write("Wie viele Guetzli sind in der Dose? ");
    int cookies = int.Parse(Console.ReadLine());

    double cookiesPerElf = cookies / ElfCount;
    decimal totalPrice = cookies * pricePerCookie;

    Console.WriteLine($"Jeder Elf bekommt {cookiesPerElf:F2} Guetzli.");
    Console.WriteLine($"Die Dose ist {totalPrice:F2} CHF wert.");

    bool isNaughty = false;
    if (isNaughty = true)
    {
      Console.WriteLine("Rute statt Guetzli!");
    }
    else
    {
      Console.WriteLine("Brav gewesen, guten Appetit!");
    }
  }
}
