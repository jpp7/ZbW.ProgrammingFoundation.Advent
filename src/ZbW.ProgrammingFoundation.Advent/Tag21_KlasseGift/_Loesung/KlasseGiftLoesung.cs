namespace ZbW.ProgrammingFoundation.Advent.Tag21_KlasseGift._Loesung;

/// <summary>
///   Musterlösung: Tag 21 – Die Klasse Gift
/// </summary>
public static class KlasseGiftLoesung
{
  /// <summary>
  ///   Erstellt drei Geschenke und gibt sie aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Die Klasse Gift – Lösung ===\n");

    Gift bike = new Gift("Velo", "Lena", 12.5);
    Gift book = new Gift("Buch", "Noah", 0.4);
    Gift lego = new Gift("Lego", "Mia", 1.2);

    Console.WriteLine(bike);
    Console.WriteLine(book);
    Console.WriteLine(lego);

    try
    {
      Gift ghost = new Gift("Luft", "Elias", 0);
      Console.WriteLine(ghost);
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"\nUngültiges Geschenk: {ex.Message}");
    }
  }
}
