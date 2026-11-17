namespace ZbW.ProgrammingFoundation.Advent.Tag19_LagerWeihnachtsmann._Loesung;

/// <summary>
///   Musterlösung: Tag 19 – Das Lager des Weihnachtsmanns
/// </summary>
public static class LagerWeihnachtsmannLoesung
{
  /// <summary>
  ///   Lagert beliebig viele Spielzeuge ein (je +1).
  /// </summary>
  public static void AddMany(Dictionary<string, int> stock, params string[] toys)
  {
    foreach (string toy in toys)
    {
      if (stock.ContainsKey(toy))
      {
        stock[toy]++;
      }
      else
      {
        stock[toy] = 1;
      }
    }
  }

  /// <summary>
  ///   Nimmt ein Stück eines Spielzeugs aus dem Lager.
  /// </summary>
  /// <returns>true, wenn ein Stück entnommen wurde.</returns>
  public static bool TryTake(Dictionary<string, int> stock, string toy, out int remaining)
  {
    if (!stock.TryGetValue(toy, out int count) || count == 0)
    {
      // out-Parameter müssen auf jedem Weg gesetzt werden.
      remaining = 0;
      return false;
    }

    stock[toy] = count - 1;
    remaining = count - 1;
    return true;
  }

  /// <summary>
  ///   Gibt den Bestand mit Titel aus.
  /// </summary>
  public static void PrintStock(Dictionary<string, int> stock, string title = "Lager")
  {
    Console.WriteLine($"--- {title} ---");
    foreach (KeyValuePair<string, int> entry in stock)
    {
      Console.WriteLine($"{entry.Key,-10} {entry.Value,3}");
    }
  }

  /// <summary>
  ///   Zeigt die Lagerverwaltung in Aktion.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Das Lager des Weihnachtsmanns – Lösung ===\n");

    Dictionary<string, int> stock = new Dictionary<string, int>();

    AddMany(stock, "Teddy", "Teddy", "Kreisel", "Puppe", "Teddy");
    AddMany(stock, "Holzauto");
    PrintStock(stock);

    if (TryTake(stock, "Teddy", out int teddysLeft))
    {
      Console.WriteLine($"\nTeddy entnommen, noch {teddysLeft} im Lager.");
    }

    TryTake(stock, "Holzauto", out _);
    if (!TryTake(stock, "Holzauto", out _))
    {
      Console.WriteLine("Holzauto: keines mehr da.");
    }

    if (!TryTake(stock, "Schlitten", out _))
    {
      Console.WriteLine("Schlitten: nicht im Lager.");
    }

    Console.WriteLine();
    PrintStock(stock, "Lager nach der Ausgabe");
  }
}
