namespace ZbW.ProgrammingFoundation.Advent.Tag07_Countdown._Loesung;

/// <summary>
///   Musterlösung: Tag 7 – Countdown bis Heiligabend
/// </summary>
public static class CountdownLoesung
{
  /// <summary>
  ///   Gibt den Countdown bis Heiligabend aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Countdown bis Heiligabend – Lösung ===\n");

    for (int day = 1; day <= 24; day++)
    {
      if (day == 24)
      {
        Console.WriteLine($"Tag {day} 🎄");
      }
      else if (day % 7 == 6)
      {
        // 6, 13 und 20 haben beim Teilen durch 7 alle den Rest 6.
        Console.WriteLine($"Tag {day} 🕯️");
      }
      else
      {
        Console.WriteLine($"Tag {day}");
      }
    }
  }
}
