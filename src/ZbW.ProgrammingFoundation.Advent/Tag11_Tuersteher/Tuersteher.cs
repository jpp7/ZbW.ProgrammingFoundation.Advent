namespace ZbW.ProgrammingFoundation.Advent.Tag11_Tuersteher;

// ============================================================
// TAG 11 – Der geduldige Türsteher (🧩 Coden | ⭐ Einfach | ~10 Min.)
//
// Fragt so lange nach, bis eine gültige Türchen-Nummer eingegeben ist.
//
// Anforderungen:
//   - do-while mit int.TryParse
//   - Gültig sind 1 bis 24
//   - Meldung "Das ist keine Zahl." oder "Türchen 1 bis 24, bitte."
//   - Eingabe zu Ende (ReadLine liefert null) → NoDoor zurückgeben
// ============================================================

public static class Tuersteher
{
  public const int FirstDoor = 1;
  public const int LastDoor = 24;

  /// <summary>
  ///   Rückgabe, wenn die Eingabe zu Ende ist und keine Nummer mehr kommt.
  /// </summary>
  public const int NoDoor = 0;

  /// <summary>
  ///   Fragt so lange nach, bis eine Zahl von 1 bis 24 eingegeben ist.
  /// </summary>
  /// <returns>Die gültige Türchen-Nummer oder NoDoor, wenn die Eingabe zu Ende ist.</returns>
  public static int ReadDoorNumber()
  {
    // TODO 1: Variablen: int door; bool isValid = false;

    // TODO 2: do { ... } while (!isValid);

    // TODO 3: In der Schleife:
    //         - Console.Write("Welches Türchen? ");
    //         - string input = Console.ReadLine();
    //           input == null → die Eingabe ist zu Ende (z. B. Ctrl+Z), es kommt nie mehr
    //           etwas: "Eingabe beendet." ausgeben und NoDoor zurückgeben (sonst Endlosschleife)
    //         - int.TryParse(input, ...) → false: "Das ist keine Zahl."
    //         - sonst Bereich prüfen → ausserhalb: "Türchen 1 bis 24, bitte."
    //         - sonst isValid = true

    // TODO 4: door zurückgeben

    throw new NotImplementedException("TODO: ReadDoorNumber implementieren");
  }

  /// <summary>
  ///   Fragt eine Türchen-Nummer ab und öffnet das Türchen.
  /// </summary>
  public static void Start()
  {
    int door = ReadDoorNumber();
    if (door == NoDoor)
    {
      Console.WriteLine("Kein Türchen geöffnet.");
      return;
    }

    Console.WriteLine($"Türchen {door} geöffnet!");
  }
}
