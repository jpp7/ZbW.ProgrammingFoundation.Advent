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
// ============================================================

public static class Tuersteher
{
  public const int FirstDoor = 1;
  public const int LastDoor = 24;

  /// <summary>
  ///   Fragt so lange nach, bis eine Zahl von 1 bis 24 eingegeben ist.
  /// </summary>
  /// <returns>Die gültige Türchen-Nummer.</returns>
  public static int ReadDoorNumber()
  {
    // TODO 1: Variablen: int door; bool isValid = false;

    // TODO 2: do { ... } while (!isValid);

    // TODO 3: In der Schleife:
    //         - Console.Write("Welches Türchen? ");
    //         - int.TryParse(...) → false: "Das ist keine Zahl."
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
    Console.WriteLine($"Türchen {door} geöffnet!");
  }
}
