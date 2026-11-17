namespace ZbW.ProgrammingFoundation.Advent.Tag15_WunschzettelStatistik;

// ============================================================
// TAG 15 – Wunschzettel-Statistik (🧩 Coden | ⭐⭐ Mittel | ~15 Min.)
//
// Summe, Maximum und Durchschnitt von Geschenkpreisen, ohne LINQ.
//
// Anforderungen:
//   - Sum, Max, Average für decimal[]
//   - Überladung Average(int[]) für die Kinderalter
//   - Ausgabe als kleine Tabelle
// ============================================================

public static class WunschzettelStatistik
{
  /// <summary>
  ///   Summiert alle Werte.
  /// </summary>
  public static decimal Sum(decimal[] values)
  {
    throw new NotImplementedException("TODO: Sum implementieren");
  }

  /// <summary>
  ///   Liefert den grössten Wert.
  /// </summary>
  public static decimal Max(decimal[] values)
  {
    throw new NotImplementedException("TODO: Max implementieren");
  }

  /// <summary>
  ///   Liefert den Durchschnitt von decimal-Werten.
  /// </summary>
  public static decimal Average(decimal[] values)
  {
    throw new NotImplementedException("TODO: Average(decimal[]) implementieren");
  }

  /// <summary>
  ///   Liefert den Durchschnitt von int-Werten (Überladung).
  /// </summary>
  public static double Average(int[] values)
  {
    throw new NotImplementedException("TODO: Average(int[]) implementieren");
  }

  /// <summary>
  ///   Gibt die Statistik aus.
  /// </summary>
  public static void Start()
  {
    decimal[] prices = { 24.90m, 189.00m, 12.50m, 79.90m, 45.00m, 61.00m };
    int[] ages = { 6, 9, 11, 4, 12 };

    // Hinweis: Methoden aufrufen und als Tabelle ausgeben, siehe README.md.
    throw new NotImplementedException("TODO: Start implementieren");
  }
}
