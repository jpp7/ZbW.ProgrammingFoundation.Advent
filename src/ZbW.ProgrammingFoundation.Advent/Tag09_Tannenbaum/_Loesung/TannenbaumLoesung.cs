namespace ZbW.ProgrammingFoundation.Advent.Tag09_Tannenbaum._Loesung;

/// <summary>
///   Musterlösung: Tag 9 – Tannenbaum in der Konsole (inklusive Bonus)
/// </summary>
public static class TannenbaumLoesung
{
  public const int MinHeight = 3;
  public const int MaxHeight = 15;

  /// <summary>
  ///   Zeichnet einen Tannenbaum mit zufälligen Kugeln auf der Konsole.
  /// </summary>
  /// <param name="height">Anzahl Zeilen der Krone.</param>
  public static void DrawTree(int height)
  {
    // Nur EIN Random-Objekt für den ganzen Baum.
    Random random = new Random();

    for (int row = 0; row < height; row++)
    {
      for (int space = 0; space < height - row - 1; space++)
      {
        Console.Write(" ");
      }

      for (int star = 0; star < 2 * row + 1; star++)
      {
        // Bonus: etwa jeder fünfte Stern wird zur Kugel.
        if (random.Next(5) == 0)
        {
          Console.Write("o");
        }
        else
        {
          Console.Write("*");
        }
      }

      Console.WriteLine();
    }

    for (int space = 0; space < height - 1; space++)
    {
      Console.Write(" ");
    }

    Console.WriteLine("|");
  }

  /// <summary>
  ///   Liest die Höhe ein und zeichnet den Baum.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Tannenbaum in der Konsole – Lösung ===\n");
    Console.Write($"Höhe ({MinHeight}–{MaxHeight}): ");

    if (!int.TryParse(Console.ReadLine(), out int height))
    {
      Console.WriteLine("Bitte eine ganze Zahl eingeben.");
      return;
    }

    if (height < MinHeight || height > MaxHeight)
    {
      Console.WriteLine($"Die Höhe muss zwischen {MinHeight} und {MaxHeight} liegen.");
      return;
    }

    Console.WriteLine();
    DrawTree(height);
  }
}
