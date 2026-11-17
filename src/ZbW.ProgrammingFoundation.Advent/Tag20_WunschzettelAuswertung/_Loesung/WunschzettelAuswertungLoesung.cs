namespace ZbW.ProgrammingFoundation.Advent.Tag20_WunschzettelAuswertung._Loesung;

/// <summary>
///   Musterlösung: Tag 20 – Wunschzettel-Auswertung
/// </summary>
public static class WunschzettelAuswertungLoesung
{
  public const string WishText =
    "Lena: Velo, Buch, Lego\n" +
    "Noah: Lego, Schlitten\n" +
    "Mia: Puppe, Buch, Lego, Malkasten\n" +
    "Elias Velo, Helm\n" +
    ": Teddy\n" +
    "Lars:\n" +
    "Sofia: Malkasten";

  /// <summary>
  ///   Zerlegt den Text in Kind → Wunschliste. Ungültige Zeilen werden gemeldet.
  /// </summary>
  public static Dictionary<string, List<string>> ParseWishes(string text)
  {
    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
    string[] lines = text.Split('\n');

    foreach (string rawLine in lines)
    {
      string line = rawLine.Trim();
      string[] parts = line.Split(':');

      if (parts.Length != 2)
      {
        Console.WriteLine($"Übersprungen (kein ':'): \"{line}\"");
        continue;
      }

      string child = parts[0].Trim();
      if (child == "")
      {
        Console.WriteLine($"Übersprungen (kein Name): \"{line}\"");
        continue;
      }

      List<string> childWishes = new List<string>();
      foreach (string rawWish in parts[1].Split(','))
      {
        string wish = rawWish.Trim();
        if (wish != "")
        {
          childWishes.Add(wish);
        }
      }

      if (childWishes.Count == 0)
      {
        Console.WriteLine($"Übersprungen (keine Wünsche): \"{line}\"");
        continue;
      }

      result[child] = childWishes;
    }

    return result;
  }

  /// <summary>
  ///   Liefert den Wunsch, der am häufigsten vorkommt.
  /// </summary>
  public static string MostCommonWish(Dictionary<string, List<string>> wishes)
  {
    // 1. Zählen
    Dictionary<string, int> counts = new Dictionary<string, int>();
    foreach (List<string> childWishes in wishes.Values)
    {
      foreach (string wish in childWishes)
      {
        if (counts.ContainsKey(wish))
        {
          counts[wish]++;
        }
        else
        {
          counts[wish] = 1;
        }
      }
    }

    // 2. Maximum suchen
    string best = "";
    int bestCount = 0;
    foreach (KeyValuePair<string, int> entry in counts)
    {
      if (entry.Value > bestCount)
      {
        best = entry.Key;
        bestCount = entry.Value;
      }
    }

    return best;
  }

  /// <summary>
  ///   Liefert das Kind mit den meisten Wünschen.
  /// </summary>
  public static string ChildWithMostWishes(Dictionary<string, List<string>> wishes)
  {
    string best = "";
    int bestCount = 0;

    foreach (KeyValuePair<string, List<string>> entry in wishes)
    {
      if (entry.Value.Count > bestCount)
      {
        best = entry.Key;
        bestCount = entry.Value.Count;
      }
    }

    return best;
  }

  /// <summary>
  ///   Liefert alle Kinder, die sich einen bestimmten Wunsch wünschen.
  /// </summary>
  public static List<string> ChildrenWishing(Dictionary<string, List<string>> wishes, string wish)
  {
    List<string> children = new List<string>();

    foreach (KeyValuePair<string, List<string>> entry in wishes)
    {
      if (entry.Value.Contains(wish))
      {
        children.Add(entry.Key);
      }
    }

    return children;
  }

  /// <summary>
  ///   Parst den Text und gibt die Auswertung aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Wunschzettel-Auswertung – Lösung ===\n");

    Dictionary<string, List<string>> wishes = ParseWishes(WishText);

    Console.WriteLine($"\n{wishes.Count} gültige Wunschzettel:");
    foreach (KeyValuePair<string, List<string>> entry in wishes)
    {
      Console.WriteLine($"  {entry.Key,-6}: {string.Join(", ", entry.Value)}");
    }

    Console.WriteLine($"\nHäufigster Wunsch:      {MostCommonWish(wishes)}");
    Console.WriteLine($"Meiste Wünsche:         {ChildWithMostWishes(wishes)}");
    Console.WriteLine($"Wünschen sich Lego:     {string.Join(", ", ChildrenWishing(wishes, "Lego"))}");

    // Bonus-Hinweis für später im Kurs: Mit LINQ ginge z. B.
    // wishes.Values.SelectMany(w => w).GroupBy(w => w).OrderByDescending(g => g.Count()).First().Key
  }
}
