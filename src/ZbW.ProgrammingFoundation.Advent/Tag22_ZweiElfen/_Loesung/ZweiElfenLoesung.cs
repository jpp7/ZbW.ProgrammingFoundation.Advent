namespace ZbW.ProgrammingFoundation.Advent.Tag22_ZweiElfen._Loesung;

/// <summary>
///   Musterlösung: Tag 22 – Zwei Elfen, ein Geschenk.
///   Verwendet die Klasse Gift aus dem Aufgabenordner (sie ist nicht Teil der Aufgabe).
/// </summary>
public static class ZweiElfenLoesung
{
  /// <summary>
  ///   Gibt die Ausgaben aus. Die Erklärung steht jeweils im Kommentar.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Zwei Elfen, ein Geschenk – Lösung ===\n");

    // a und b zeigen auf DASSELBE Objekt. "Gift b = a" kopiert nur den Verweis.
    Gift a = new Gift("Velo", "Lena");
    Gift b = a;
    b.Name = "Ski";

    // A: Ski – a und b sind zwei Namen für ein und dasselbe Geschenk.
    Console.WriteLine($"A: {a.Name}");

    // B: Ski
    Console.WriteLine($"B: {b.Name}");

    // C: Ski – c ist ein NEUES Objekt (new). Eine Änderung an c betrifft a nicht.
    Gift c = new Gift("Velo", "Lena");
    c.Name = "Schlitten";
    Console.WriteLine($"C: {a.Name}");

    // D: Puppe für Niemand (0.8 kg)
    //    Zuerst läuft der parameterlose Konstruktor (Unbekannt, Niemand, 1),
    //    danach setzt der Object Initializer Name und Weight. Recipient bleibt "Niemand".
    Gift d = new Gift { Name = "Puppe", Weight = 0.8 };
    Console.WriteLine($"D: {d}");

    // E: Buch für Mia (1 kg)
    //    Der Konstruktor setzt mit this.Name / this.Recipient "Buch" und "Noah",
    //    danach überschreibt der Initializer Recipient mit "Mia".
    Gift e = new Gift("Buch", "Noah") { Recipient = "Mia" };
    Console.WriteLine($"E: {e}");
  }
}
