namespace ZbW.ProgrammingFoundation.Advent.Tag10_EndlosWerkbank;

// ============================================================
// TAG 10 – Die Endlos-Werkbank (🐞 Bug-Jagd | ⭐⭐ Mittel | ~15 Min.)
//
// Die Werkbank baut Spielzeug. Sie enthält 3 Fehler.
//
// Anforderungen:
//   - Endlosschleife beheben: Bei 10 oder mehr Spielzeugen stoppen
//   - Random nur einmal erzeugen
//   - Fehler nicht verschlucken, sondern melden
//   - Pro Fehler einen kurzen Kommentar: Warum war das ein Problem?
//
// ⚠️ Unverändert gestartet läuft die Werkbank endlos (Ctrl+C).
// ============================================================

public static class EndlosWerkbank
{
  /// <summary>
  ///   Startet die (fehlerhafte) Werkbank.
  /// </summary>
  public static void Start()
  {
    string[] toyNames = { "Teddy", "Holzauto", "Kreisel", "Puppe" };

    int built = 0;
    while (built != 10)
    {
      Random random = new Random();
      string toy = toyNames[random.Next(toyNames.Length)];

      built += 3;
      Console.WriteLine($"3 × {toy} gebaut, total {built}");
    }

    Console.Write("Wie viele Spielzeuge willst du einpacken? ");
    try
    {
      int toPack = int.Parse(Console.ReadLine());
      Console.WriteLine($"{toPack} Spielzeuge eingepackt.");
    }
    catch
    {
    }
  }
}
