namespace ZbW.ProgrammingFoundation.Advent.Tag17_ChaosImLager;

// ============================================================
// TAG 17 – Chaos im Lager (🐞 Bug-Jagd | ⭐⭐ Mittel | ~15 Min.)
//
// Inventur mit Array, Liste und Dictionary. Enthält 4 Fehler.
//
// Anforderungen:
//   - Alle 4 Fehler finden und beheben
//   - Das Programm läuft danach ohne Exception durch
//   - Pro Fehler einen kurzen Kommentar: Was war falsch?
// ============================================================

public static class ChaosImLager
{
  /// <summary>
  ///   Startet die (fehlerhafte) Inventur.
  /// </summary>
  public static void Start()
  {
    // Schritt 1: Regal durchzählen
    int[] shelf = { 4, 7, 2, 9 };
    int totalOnShelf = 0;
    for (int i = 0; i <= shelf.Length; i++)
    {
      totalOnShelf += shelf[i];
    }

    Console.WriteLine($"Im Regal: {totalOnShelf} Teile");

    // Schritt 2: Neue Lieferung einlagern
    List<string> delivery = new List<string> { "Teddy", "Kreisel", "Puppe" };
    delivery.Add("Holzauto");

    // Der Elf wollte hier delivery.Length schreiben, aber das hat nicht kompiliert.
    // Er hat deshalb die Zahl von Hand eingetragen.
    // int deliveryCount = delivery.Length;
    int deliveryCount = 3;
    Console.WriteLine($"Lieferung: {deliveryCount} Teile");

    // Schritt 3: Bestand abfragen
    Dictionary<string, int> stock = new Dictionary<string, int>
    {
      { "Teddy", 12 },
      { "Kreisel", 5 },
      { "Puppe", 8 }
    };
    Console.WriteLine($"Teddys: {stock["Teddy"]}");
    Console.WriteLine($"Schlitten: {stock["Schlitten"]}");

    // Schritt 4: Kaputtes Spielzeug aussortieren
    List<string> toys = new List<string> { "Teddy", "kaputt", "Kreisel", "kaputt", "Puppe" };
    foreach (string toy in toys)
    {
      if (toy == "kaputt")
      {
        toys.Remove(toy);
      }
    }

    Console.WriteLine($"Nach dem Aussortieren: {string.Join(", ", toys)}");
  }
}
