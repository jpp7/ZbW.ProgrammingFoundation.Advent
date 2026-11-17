namespace ZbW.ProgrammingFoundation.Advent.Tag20_WunschzettelAuswertung;

// ============================================================
// TAG 20 – ⭐ Wunschzettel-Auswertung (🧩 Coden | ⭐⭐⭐ Erweitert | ~40 Min.)
//
// Parst Wunschzettel aus einem Text und wertet sie aus, ohne LINQ.
//
// Anforderungen:
//   - Text in Dictionary<string, List<string>> parsen
//   - Ungültige Zeilen überspringen und melden
//   - Häufigster Wunsch, Kind mit den meisten Wünschen, alle Kinder mit "Lego"
// ============================================================

public static class WunschzettelAuswertung
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
    throw new NotImplementedException("TODO: ParseWishes implementieren");
  }

  /// <summary>
  ///   Liefert den Wunsch, der am häufigsten vorkommt.
  /// </summary>
  public static string MostCommonWish(Dictionary<string, List<string>> wishes)
  {
    throw new NotImplementedException("TODO: MostCommonWish implementieren");
  }

  /// <summary>
  ///   Liefert das Kind mit den meisten Wünschen.
  /// </summary>
  public static string ChildWithMostWishes(Dictionary<string, List<string>> wishes)
  {
    throw new NotImplementedException("TODO: ChildWithMostWishes implementieren");
  }

  /// <summary>
  ///   Liefert alle Kinder, die sich einen bestimmten Wunsch wünschen.
  /// </summary>
  public static List<string> ChildrenWishing(Dictionary<string, List<string>> wishes, string wish)
  {
    throw new NotImplementedException("TODO: ChildrenWishing implementieren");
  }

  /// <summary>
  ///   Parst den Text und gibt die Auswertung aus.
  /// </summary>
  public static void Start()
  {
    // Hinweis: ParseWishes(WishText) aufrufen, danach die drei Auswertungen ausgeben.
    throw new NotImplementedException("TODO: Start implementieren");
  }
}
