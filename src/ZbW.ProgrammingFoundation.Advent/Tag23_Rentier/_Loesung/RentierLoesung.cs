namespace ZbW.ProgrammingFoundation.Advent.Tag23_Rentier._Loesung;

/// <summary>
///   Musterlösung: Tag 23 – Rentier mit Ausdauer
/// </summary>
public static class RentierLoesung
{
  /// <summary>
  ///   Testet die Klasse Reindeer.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Rentier mit Ausdauer – Lösung ===\n");

    Reindeer rudolph = new Reindeer("Rudolph");
    Console.WriteLine($"Start: {rudolph}");

    // rudolph.Energy = 100;  // kompiliert nicht: der Setter ist private (Kapselung)

    int leg = 1;
    while (rudolph.Fly(350))
    {
      Console.WriteLine($"Etappe {leg}: 350 km geflogen → {rudolph}");
      leg++;
    }

    Console.WriteLine($"Etappe {leg}: 350 km geht nicht mehr → {rudolph}");

    rudolph.Feed();
    Console.WriteLine($"Gefüttert → {rudolph}");

    bool flew = rudolph.Fly(350);
    Console.WriteLine($"Nochmals 350 km: {(flew ? "geflogen" : "zu müde")} → {rudolph}");

    for (int i = 0; i < 5; i++)
    {
      rudolph.Feed();
    }

    Console.WriteLine($"5× gefüttert (höchstens 100) → {rudolph}");

    try
    {
      rudolph.Fly(-10);
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }
  }
}
