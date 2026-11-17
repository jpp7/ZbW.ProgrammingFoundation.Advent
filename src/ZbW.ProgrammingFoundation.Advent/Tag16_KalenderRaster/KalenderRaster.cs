namespace ZbW.ProgrammingFoundation.Advent.Tag16_KalenderRaster;

// ============================================================
// TAG 16 – Das Kalender-Raster (🧩 Coden | ⭐⭐ Mittel | ~20 Min.)
//
// Füllt ein 4×6-Raster mit 1–24, mischt es und gibt es aus.
//
// Anforderungen:
//   - int[4, 6] der Reihe nach mit 1–24 füllen
//   - Mischen mit dem Tausch-Verfahren (100 zufällige Vertauschungen)
//   - Raster mit fester Breite ausgeben
//   - Bonus: IsValid prüft, ob jede Zahl genau einmal vorkommt
// ============================================================

public static class KalenderRaster
{
  public const int Rows = 4;
  public const int Columns = 6;
  public const int SwapCount = 100;

  /// <summary>
  ///   Erstellt ein Raster mit den Zahlen 1 bis 24 in aufsteigender Reihenfolge.
  /// </summary>
  public static int[,] CreateGrid()
  {
    throw new NotImplementedException("TODO: CreateGrid implementieren");
  }

  /// <summary>
  ///   Mischt das Raster durch zufälliges Vertauschen von Positionen.
  /// </summary>
  public static void Shuffle(int[,] grid, Random random)
  {
    throw new NotImplementedException("TODO: Shuffle implementieren");
  }

  /// <summary>
  ///   Gibt das Raster zeilenweise aus.
  /// </summary>
  public static void PrintGrid(int[,] grid)
  {
    throw new NotImplementedException("TODO: PrintGrid implementieren");
  }

  /// <summary>
  ///   Bonus: Prüft, ob jede Zahl von 1 bis 24 genau einmal vorkommt.
  /// </summary>
  public static bool IsValid(int[,] grid)
  {
    throw new NotImplementedException("TODO (Bonus): IsValid implementieren");
  }

  /// <summary>
  ///   Erstellt, mischt und zeigt das Kalender-Raster.
  /// </summary>
  public static void Start()
  {
    // Hinweis: CreateGrid, Shuffle, PrintGrid und (Bonus) IsValid nacheinander aufrufen.
    throw new NotImplementedException("TODO: Start implementieren");
  }
}
