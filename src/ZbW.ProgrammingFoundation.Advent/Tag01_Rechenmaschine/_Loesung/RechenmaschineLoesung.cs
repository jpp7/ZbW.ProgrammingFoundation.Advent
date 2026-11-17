namespace ZbW.ProgrammingFoundation.Advent.Tag01_Rechenmaschine._Loesung;

/// <summary>
///   Musterlösung: Tag 1 – Die Werkstatt-Rechenmaschine
/// </summary>
public static class RechenmaschineLoesung
{
  /// <summary>
  ///   Gibt die Ausdrücke mit Ergebnis aus. Die Erklärung steht jeweils im Kommentar.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Die Werkstatt-Rechenmaschine – Lösung ===\n");

    // 3: int / int ergibt int. Die Nachkommastellen werden abgeschnitten (nicht gerundet).
    Console.WriteLine($"17 / 5                  = {17 / 5}");

    // 2: % liefert den Rest der Ganzzahldivision (17 = 3 * 5 + 2).
    Console.WriteLine($"17 % 5                  = {17 % 5}");

    // 3.4: Eine Seite ist double, also wird mit Nachkommastellen gerechnet.
    Console.WriteLine($"17 / 5.0                = {17 / 5.0}");

    // 3.4: Der Cast wirkt zuerst auf 17, danach wird double / int gerechnet.
    //      Achtung: (double)(17 / 5) ergäbe 3, weil die Klammer zuerst als int gerechnet wird.
    Console.WriteLine($"(double)17 / 5          = {(double)17 / 5}");

    // Tag 12: Von links nach rechts. "Tag " + 1 ergibt "Tag 1", danach + 2 ergibt "Tag 12".
    Console.WriteLine("\"Tag \" + 1 + 2          = " + ("Tag " + 1 + 2));

    // 3: Im Platzhalter wird zuerst gerechnet, danach wird das Ergebnis eingesetzt.
    Console.WriteLine("$\"{1 + 2}\"              = " + $"{1 + 2}");

    // True: !false ist true, true && true ist true, true || false ist true.
    //       Reihenfolge: ! vor && vor ||.
    Console.WriteLine($"true && !false || false = {true && !false || false}");

    // Bonus: Klammern erzwingen zuerst die Addition.
    Console.WriteLine("\nBonus: \"Tag \" + (1 + 2) = " + ("Tag " + (1 + 2)));
  }
}
