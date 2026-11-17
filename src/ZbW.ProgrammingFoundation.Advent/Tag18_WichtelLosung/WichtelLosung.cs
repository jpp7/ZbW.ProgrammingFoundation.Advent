namespace ZbW.ProgrammingFoundation.Advent.Tag18_WichtelLosung;

// ============================================================
// TAG 18 – Wichtel-Losung (🧩 Coden | ⭐⭐ Mittel | ~20 Min.)
//
// Lost aus, wer wen beschenkt. Niemand zieht sich selbst.
//
// Anforderungen:
//   - List<string> mit 6 Namen
//   - Zufällige Zuteilung, jede Person genau einmal als Schenker und Beschenkte
//   - Niemand beschenkt sich selbst
//   - Ergebnis in Dictionary<string, string> (Schenker → Beschenkter)
// ============================================================

public static class WichtelLosung
{
  /// <summary>
  ///   Lost aus, wer wen beschenkt.
  /// </summary>
  /// <param name="names">Alle Teilnehmenden.</param>
  /// <param name="random">Zufallsgenerator.</param>
  /// <returns>Zuteilung Schenker → Beschenkter.</returns>
  public static Dictionary<string, string> Draw(List<string> names, Random random)
  {
    throw new NotImplementedException("TODO: Draw implementieren");
  }

  /// <summary>
  ///   Führt die Losung durch und gibt das Ergebnis aus.
  /// </summary>
  public static void Start()
  {
    List<string> names = new List<string> { "Anna", "Fritz", "Lumi", "Pips", "Tinka", "Bo" };

    // Hinweis: Draw aufrufen und jedes Paar mit foreach ausgeben.
    throw new NotImplementedException("TODO: Start implementieren");
  }
}
