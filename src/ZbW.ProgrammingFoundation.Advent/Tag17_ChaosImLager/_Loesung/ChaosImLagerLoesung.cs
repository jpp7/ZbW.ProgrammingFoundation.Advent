namespace ZbW.ProgrammingFoundation.Advent.Tag17_ChaosImLager._Loesung;

/// <summary>
///   Musterlösung: Tag 17 – Chaos im Lager
/// </summary>
public static class ChaosImLagerLoesung
{
  /// <summary>
  ///   Startet die korrigierte Inventur.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Chaos im Lager – Lösung ===\n");

    // Schritt 1: Regal durchzählen
    int[] shelf = { 4, 7, 2, 9 };
    int totalOnShelf = 0;

    // FIX 1: Der letzte gültige Index ist Length - 1. Mit <= wird shelf[4] gelesen,
    //        das gibt es nicht → IndexOutOfRangeException.
    for (int i = 0; i < shelf.Length; i++)
    {
      totalOnShelf += shelf[i];
    }

    Console.WriteLine($"Im Regal: {totalOnShelf} Teile");

    // Schritt 2: Neue Lieferung einlagern
    List<string> delivery = new List<string> { "Teddy", "Kreisel", "Puppe" };
    delivery.Add("Holzauto");

    // FIX 2: Listen haben .Count, Arrays haben .Length.
    //        Eine von Hand eingetragene Zahl stimmt nur, bis sich die Liste ändert.
    int deliveryCount = delivery.Count;
    Console.WriteLine($"Lieferung: {deliveryCount} Teile");

    // Schritt 3: Bestand abfragen
    Dictionary<string, int> stock = new Dictionary<string, int>
    {
      { "Teddy", 12 },
      { "Kreisel", 5 },
      { "Puppe", 8 }
    };
    Console.WriteLine($"Teddys: {stock["Teddy"]}");

    // FIX 3: dict["x"] wirft eine KeyNotFoundException, wenn der Key fehlt.
    //        TryGetValue liefert stattdessen false.
    if (stock.TryGetValue("Schlitten", out int sleighs))
    {
      Console.WriteLine($"Schlitten: {sleighs}");
    }
    else
    {
      Console.WriteLine("Schlitten: nicht im Lager");
    }

    // Schritt 4: Kaputtes Spielzeug aussortieren
    List<string> toys = new List<string> { "Teddy", "kaputt", "Kreisel", "kaputt", "Puppe" };

    // FIX 4: Während foreach darf die Liste nicht verändert werden
    //        → InvalidOperationException. Rückwärts mit for geht, weil das
    //        Entfernen die noch nicht besuchten Indizes nicht verschiebt.
    for (int i = toys.Count - 1; i >= 0; i--)
    {
      if (toys[i] == "kaputt")
      {
        toys.RemoveAt(i);
      }
    }

    // Alternative: toys.RemoveAll(t => t == "kaputt"); – das ist aber schon ein Lambda (später im Kurs).
    Console.WriteLine($"Nach dem Aussortieren: {string.Join(", ", toys)}");
  }
}
