namespace ZbW.ProgrammingFoundation.Advent.Tag11_Tuersteher._Loesung;

/// <summary>
///   Musterlösung: Tag 11 – Der geduldige Türsteher
/// </summary>
public static class TuersteherLoesung
{
  public const int FirstDoor = 1;
  public const int LastDoor = 24;

  /// <summary>
  ///   Fragt so lange nach, bis eine Zahl von 1 bis 24 eingegeben ist.
  /// </summary>
  /// <returns>Die gültige Türchen-Nummer.</returns>
  public static int ReadDoorNumber()
  {
    int door;
    bool isValid = false;

    do
    {
      Console.Write("Welches Türchen? ");

      if (!int.TryParse(Console.ReadLine(), out door))
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
    Console.WriteLine($"Türchen {door} geöffnet!");
  }
}
