namespace ZbW.ProgrammingFoundation.Advent.Tag01_Rechenmaschine;

// ============================================================
// TAG 1 – Die Werkstatt-Rechenmaschine (🔍 Was gibt das aus? | ⭐ Einfach | ~10 Min.)
//
// Ein Elf hat einen Zettel voller Ausdrücke. Was gibt jeder aus?
//
// Anforderungen:
//   - Zuerst von Hand vorhersagen (Kommentar "Vermutung" ausfüllen)
//   - Danach starten (Menü: 1) und vergleichen
//   - Für jede falsche Vermutung: Warum kam etwas anderes heraus?
// ============================================================

public static class Rechenmaschine
{
  /// <summary>
  ///   Gibt die sieben Ausdrücke vom Zettel des Elfen aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Die Werkstatt-Rechenmaschine ===\n");

    // TODO 1: Vermutung eintragen, dann starten und vergleichen.
    Console.WriteLine(17 / 5);                  // Vermutung: ___
    Console.WriteLine(17 % 5);                  // Vermutung: ___
    Console.WriteLine(17 / 5.0);                // Vermutung: ___
    Console.WriteLine((double)17 / 5);          // Vermutung: ___

    // TODO 2: Hier wird es knifflig – achte auf die Reihenfolge.
    Console.WriteLine("Tag " + 1 + 2);          // Vermutung: ___
    Console.WriteLine($"{1 + 2}");              // Vermutung: ___

    // TODO 3: Welcher Operator wird zuerst ausgewertet?
    Console.WriteLine(true && !false || false); // Vermutung: ___

    // TODO 4 (Bonus): Wie bringst du "Tag 3" auf den Bildschirm,
    //                 ohne die Zahlen 1 und 2 zu entfernen?
  }
}
