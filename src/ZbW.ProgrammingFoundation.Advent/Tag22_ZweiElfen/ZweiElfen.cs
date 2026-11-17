namespace ZbW.ProgrammingFoundation.Advent.Tag22_ZweiElfen;

// ============================================================
// TAG 22 – Zwei Elfen, ein Geschenk (🔍 Was gibt das aus? | ⭐ Einfach | ~10 Min.)
//
// Referenzen, Object Initializer und Konstruktor mit this.
//
// Anforderungen:
//   - Ausgaben A bis E vorhersagen, danach starten (Menü: 22)
//   - Erklären: Warum ändert b.Name auch a.Name?
// ============================================================

public static class ZweiElfen
{
  /// <summary>
  ///   Gibt die Ausgaben A bis E aus.
  /// </summary>
  public static void Start()
  {
    Gift a = new Gift("Velo", "Lena");
    Gift b = a;
    b.Name = "Ski";

    Console.WriteLine($"A: {a.Name}");   // Vermutung: ___
    Console.WriteLine($"B: {b.Name}");   // Vermutung: ___

    Gift c = new Gift("Velo", "Lena");
    c.Name = "Schlitten";
    Console.WriteLine($"C: {a.Name}");   // Vermutung: ___

    Gift d = new Gift { Name = "Puppe", Weight = 0.8 };
    Console.WriteLine($"D: {d}");        // Vermutung: ___

    Gift e = new Gift("Buch", "Noah") { Recipient = "Mia" };
    Console.WriteLine($"E: {e}");        // Vermutung: ___
  }
}
