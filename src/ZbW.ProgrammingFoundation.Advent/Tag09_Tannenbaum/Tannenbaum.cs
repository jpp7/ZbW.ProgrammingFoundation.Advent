namespace ZbW.ProgrammingFoundation.Advent.Tag09_Tannenbaum;

// ============================================================
// TAG 9 – Tannenbaum in der Konsole (🧩 Coden | ⭐ Einfach | ~15 Min.)
//
// Zeichnet einen Baum aus Sternchen mit Stamm.
//
// Anforderungen:
//   - Höhe 3–15 mit TryParse einlesen
//   - Verschachtelte Schleifen: Leerzeichen, dann Sterne
//   - Stamm "|" mittig unter dem Baum
//   - Bonus: Mit Random wird etwa jeder fünfte * zu einem o
// ============================================================

public static class Tannenbaum
{
  /// <summary>
  ///   Zeichnet einen Tannenbaum auf der Konsole.
  /// </summary>
  /// <param name="height">Anzahl Zeilen der Krone.</param>
  public static void DrawTree(int height)
  {
    // TODO 2: Äussere Schleife über die Zeilen: for (int row = 0; row < height; row++)

    // TODO 3: Innere Schleife 1: height - row - 1 Leerzeichen mit Console.Write(" ")

    // TODO 4: Innere Schleife 2: 2 * row + 1 Sterne mit Console.Write("*")
    //         Danach Console.WriteLine() für die nächste Zeile.

    // TODO 5: Stamm: height - 1 Leerzeichen, dann "|"

    // BONUS: Ein Random-Objekt VOR den Schleifen erzeugen,
    //        in der Sternschleife mit random.Next(5) == 0 ein "o" statt "*" ausgeben.

    throw new NotImplementedException("TODO: DrawTree implementieren");
  }

  /// <summary>
  ///   Liest die Höhe ein und zeichnet den Baum.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Höhe einlesen (int.TryParse, Bereich 3–15)
    //         Bei Fehler: Meldung und return.
    //         Danach DrawTree(height) aufrufen.

    throw new NotImplementedException("TODO: Start implementieren");
  }
}
