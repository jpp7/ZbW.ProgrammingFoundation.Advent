namespace ZbW.ProgrammingFoundation.Advent.Tag19_LagerWeihnachtsmann;

// ============================================================
// TAG 19 – Das Lager des Weihnachtsmanns (🧩 Coden | ⭐⭐ Mittel | ~20 Min.)
//
// Lagerverwaltung mit Dictionary, params, out und optionalem Parameter.
//
// Anforderungen:
//   - AddMany mit params string[]
//   - TryTake mit out int remaining
//   - PrintStock mit optionalem Titel (Standard "Lager")
// ============================================================

public static class LagerWeihnachtsmann
{
  /// <summary>
  ///   Lagert beliebig viele Spielzeuge ein (je +1).
  /// </summary>
  public static void AddMany(Dictionary<string, int> stock, params string[] toys)
  {
    throw new NotImplementedException("TODO: AddMany implementieren");
  }

  /// <summary>
  ///   Nimmt ein Stück eines Spielzeugs aus dem Lager.
  /// </summary>
  /// <returns>true, wenn ein Stück entnommen wurde.</returns>
  public static bool TryTake(Dictionary<string, int> stock, string toy, out int remaining)
  {
    throw new NotImplementedException("TODO: TryTake implementieren");
  }

  /// <summary>
  ///   Gibt den Bestand mit Titel aus.
  /// </summary>
  public static void PrintStock(Dictionary<string, int> stock, string title = "Lager")
  {
    throw new NotImplementedException("TODO: PrintStock implementieren");
  }

  /// <summary>
  ///   Zeigt die Lagerverwaltung in Aktion.
  /// </summary>
  public static void Start()
  {
    Dictionary<string, int> stock = new Dictionary<string, int>();

    // Hinweis: Einlagern, ein paar Mal entnehmen (auch etwas, das fehlt),
    //          und PrintStock einmal mit und einmal ohne Titel aufrufen.
    throw new NotImplementedException("TODO: Start implementieren");
  }
}
