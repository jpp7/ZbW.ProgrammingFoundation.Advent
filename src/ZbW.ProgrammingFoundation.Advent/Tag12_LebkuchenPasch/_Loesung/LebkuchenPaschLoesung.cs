namespace ZbW.ProgrammingFoundation.Advent.Tag12_LebkuchenPasch._Loesung;

/// <summary>
///   Musterlösung: Tag 12 – Lebkuchen-Pasch
/// </summary>
public static class LebkuchenPaschLoesung
{
  public const int Games = 1000;

  /// <summary>
  ///   Würfelt mit zwei Würfeln, bis ein Pasch fällt.
  /// </summary>
  /// <param name="random">Zufallsgenerator, der für alle Spiele verwendet wird.</param>
  /// <returns>Anzahl Würfe bis zum Pasch.</returns>
  public static int RollUntilDouble(Random random)
  {
    int rolls = 0;
    int dice1;
    int dice2;

    do
    {
      dice1 = random.Next(1, 7);
      dice2 = random.Next(1, 7);
      rolls++;
    } while (dice1 != dice2);

    return rolls;
  }

  /// <summary>
  ///   Simuliert 1000 Spiele und gibt den Durchschnitt aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Lebkuchen-Pasch – Lösung ===\n");

    Random random = new Random();
    int totalRolls = 0;

    for (int game = 0; game < Games; game++)
    {
      totalRolls += RollUntilDouble(random);
    }

    double average = (double)totalRolls / Games;
    Console.WriteLine($"{Games} Spiele, {totalRolls} Würfe");
    Console.WriteLine($"Durchschnitt bis zum Pasch: {average:F2} Würfe");
  }
}
