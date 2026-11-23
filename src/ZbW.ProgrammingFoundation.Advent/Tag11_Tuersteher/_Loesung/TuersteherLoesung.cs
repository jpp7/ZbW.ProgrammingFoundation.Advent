namespace ZbW.ProgrammingFoundation.Advent.Tag11_Tuersteher._Loesung;

/// <summary>
///   Musterlösung: Tag 11 – Der geduldige Türsteher
/// </summary>
public static class TuersteherLoesung
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
    int door;
    bool isValid = false;

    do
    {
      Console.Write("Welches Türchen? ");
      string input = Console.ReadLine();

      // null = Eingabe zu Ende (z. B. Ctrl+Z). Ohne diese Prüfung fragt die Schleife endlos.
      if (input == null)
      {
        Console.WriteLine("\nEingabe beendet.");
        return NoDoor;
      }

      if (!int.TryParse(input, out door))
      {
        Console.WriteLine("Das ist keine Zahl.");
      }
      else if (door < FirstDoor || door > LastDoor)
      {
        Console.WriteLine($"Türchen {FirstDoor} bis {LastDoor}, bitte.");
      }
      else
      {
        isValid = true;
      }
    } while (!isValid);

    return door;
  }

  /// <summary>
  ///   Fragt eine Türchen-Nummer ab und öffnet das Türchen.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Der geduldige Türsteher – Lösung ===\n");
    int door = ReadDoorNumber();
    if (door == NoDoor)
    {
      Console.WriteLine("Kein Türchen geöffnet.");
      return;
    }

    Console.WriteLine($"Türchen {door} geöffnet!");
  }
}
