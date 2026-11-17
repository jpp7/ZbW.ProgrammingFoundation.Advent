namespace ZbW.ProgrammingFoundation.Advent.Tag15_WunschzettelStatistik._Loesung;

/// <summary>
///   Musterlösung: Tag 15 – Wunschzettel-Statistik
/// </summary>
public static class WunschzettelStatistikLoesung
{
  /// <summary>
  ///   Summiert alle Werte.
  /// </summary>
  public static decimal Sum(decimal[] values)
  {
    decimal sum = 0;
    foreach (decimal value in values)
    {
      sum += value;
    }

    return sum;
  }

  /// <summary>
  ///   Liefert den grössten Wert.
  /// </summary>
  public static decimal Max(decimal[] values)
  {
    // Mit dem ersten Element starten, nicht mit 0.
    decimal max = values[0];
    for (int i = 1; i < values.Length; i++)
    {
      if (values[i] > max)
      {
        max = values[i];
      }
    }

    return max;
  }

  /// <summary>
  ///   Liefert den Durchschnitt von decimal-Werten.
  /// </summary>
  public static decimal Average(decimal[] values)
  {
    return Sum(values) / values.Length;
  }

  /// <summary>
  ///   Liefert den Durchschnitt von int-Werten (Überladung).
  /// </summary>
  public static double Average(int[] values)
  {
    int sum = 0;
    foreach (int value in values)
    {
      sum += value;
    }

    // Cast vor der Division, sonst Ganzzahldivision.
    return (double)sum / values.Length;
  }

  /// <summary>
  ///   Gibt die Statistik aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Wunschzettel-Statistik – Lösung ===\n");

    decimal[] prices = { 24.90m, 189.00m, 12.50m, 79.90m, 45.00m, 61.00m };
    int[] ages = { 6, 9, 11, 4, 12 };

    // Der Compiler wählt die passende Überladung anhand des Parametertyps.
    Console.WriteLine($"Anzahl Wünsche : {prices.Length,6}");
    Console.WriteLine($"Summe          : {Sum(prices),6:F2} CHF");
    Console.WriteLine($"Teuerster      : {Max(prices),6:F2} CHF");
    Console.WriteLine($"Durchschnitt   : {Average(prices),6:F2} CHF");
    Console.WriteLine($"Ø Alter        : {Average(ages),6:F2} Jahre");
  }
}
