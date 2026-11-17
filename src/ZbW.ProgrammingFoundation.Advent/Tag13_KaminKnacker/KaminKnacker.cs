namespace ZbW.ProgrammingFoundation.Advent.Tag13_KaminKnacker;

// ============================================================
// TAG 13 – ⭐ Kamin-Knacker (🧩 Coden | ⭐⭐ Mittel | ~30–40 Min.)
//
// Errate einen dreistelligen Code in höchstens 10 Versuchen.
//
// Anforderungen:
//   - Dreistelliger Zufallscode ("000" bis "999")
//   - CountCorrectDigits wirft ArgumentException bei ungültiger Eingabe
//   - Ungültige Eingaben zählen nicht als Versuch
//   - Maximal 10 Versuche, danach Code verraten
//   - finally gibt "Kamin geschlossen." aus
// ============================================================

public static class KaminKnacker
{
  public const int MaxAttempts = 10;
  public const int CodeLength = 3;

  /// <summary>
  ///   Zählt, wie viele Ziffern an der richtigen Stelle stehen.
  /// </summary>
  /// <param name="code">Der geheime Code (3 Ziffern).</param>
  /// <param name="guess">Der Rateversuch.</param>
  /// <returns>Anzahl richtiger Ziffern an richtiger Stelle (0–3).</returns>
  /// <exception cref="ArgumentException">Wenn guess nicht aus genau 3 Ziffern besteht.</exception>
  public static int CountCorrectDigits(string code, string guess)
  {
    // TODO 1: guess prüfen: null, Länge != CodeLength → ArgumentException("Bitte genau 3 Ziffern eingeben.")

    // TODO 2: Jedes Zeichen mit char.IsDigit prüfen → sonst ArgumentException("Nur Ziffern 0–9 erlaubt.")

    // TODO 3: for-Schleife über die Stellen, code[i] == guess[i] zählen

    throw new NotImplementedException("TODO: CountCorrectDigits implementieren");
  }

  /// <summary>
  ///   Startet das Spiel Kamin-Knacker.
  /// </summary>
  public static void Start()
  {
    // TODO 4: Code erzeugen: new Random().Next(0, 1000).ToString("D3")

    // TODO 5: try { ... } finally { Console.WriteLine("Kamin geschlossen."); }

    // TODO 6: Im try: Schleife, solange attempts < MaxAttempts und noch nicht geknackt
    //         - Eingabe lesen
    //         - try { int correct = CountCorrectDigits(code, input); attempts++; ... }
    //           catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
    //         - Meldung: $"{correct} Ziffern richtig an richtiger Stelle"

    // TODO 7: Nach der Schleife: Glückwunsch mit Anzahl Versuchen oder Code verraten

    throw new NotImplementedException("TODO: Start implementieren");
  }
}
