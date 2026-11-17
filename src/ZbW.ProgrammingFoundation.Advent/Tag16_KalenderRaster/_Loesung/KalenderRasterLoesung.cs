namespace ZbW.ProgrammingFoundation.Advent.Tag16_KalenderRaster._Loesung;

/// <summary>
///   Musterlösung: Tag 16 – Das Kalender-Raster (inklusive Bonus)
/// </summary>
public static class KalenderRasterLoesung
{
  public const int Rows = 4;
  public const int Columns = 6;
  public const int SwapCount = 100;

  /// <summary>
  ///   Erstellt ein Raster mit den Zahlen 1 bis 24 in aufsteigender Reihenfolge.
  /// </summary>
  public static int[,] CreateGrid()
  {
    int[,] grid = new int[Rows, Columns];
    int number = 1;

    for (int row = 0; row < Rows; row++)
    {
      for (int col = 0; col < Columns; col++)
      {
        grid[row, col] = number;
        number++;
      }
    }

    return grid;
  }

  /// <summary>
  ///   Mischt das Raster durch zufälliges Vertauschen von Positionen.
  /// </summary>
  public static void Shuffle(int[,] grid, Random random)
  {
    int rows = grid.GetLength(0);
    int columns = grid.GetLength(1);

    for (int i = 0; i < SwapCount; i++)
    {
      int row1 = random.Next(rows);
      int col1 = random.Next(columns);
      int row2 = random.Next(rows);
      int col2 = random.Next(columns);

      int temp = grid[row1, col1];
      grid[row1, col1] = grid[row2, col2];
      grid[row2, col2] = temp;
    }
  }

  /// <summary>
  ///   Gibt das Raster zeilenweise aus.
  /// </summary>
  public static void PrintGrid(int[,] grid)
  {
    for (int row = 0; row < grid.GetLength(0); row++)
    {
      for (int col = 0; col < grid.GetLength(1); col++)
      {
        Console.Write($"[{grid[row, col],2}] ");
      }

      Console.WriteLine();
    }
  }

  /// <summary>
  ///   Bonus: Prüft, ob jede Zahl von 1 bis 24 genau einmal vorkommt.
  /// </summary>
  public static bool IsValid(int[,] grid)
  {
    int max = grid.GetLength(0) * grid.GetLength(1);

    // seen[n] ist true, sobald die Zahl n gefunden wurde. Index 0 bleibt ungenutzt.
    bool[] seen = new bool[max + 1];

    foreach (int value in grid)
    {
      if (value < 1 || value > max || seen[value])
      {
        return false;
      }

      seen[value] = true;
    }

    // Jede Zahl wurde höchstens einmal gesehen, und es gibt genau max Felder:
    // also kommt jede Zahl genau einmal vor.
    return true;
  }

  /// <summary>
  ///   Erstellt, mischt und zeigt das Kalender-Raster.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Das Kalender-Raster – Lösung ===\n");

    int[,] grid = CreateGrid();
    Console.WriteLine("Vorher:");
    PrintGrid(grid);

    Shuffle(grid, new Random());
    Console.WriteLine("\nGemischt:");
    PrintGrid(grid);

    Console.WriteLine($"\nGültig: {IsValid(grid)}");

    grid[0, 0] = grid[0, 1];
    Console.WriteLine($"Nach absichtlichem Fehler (Doppel): {IsValid(grid)}");
  }
}
