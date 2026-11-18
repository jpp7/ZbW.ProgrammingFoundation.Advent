namespace ZbW.ProgrammingFoundation.Advent.Tag24_Schlittentour._Loesung;

/// <summary>
///   Musterlösung: Tag 24 – Finale: Die Schlittentour
/// </summary>
public static class SchlittentourLoesung
{
  public const double SleighMaxLoad = 22.0;

  /// <summary>
  ///   Lädt den Schlitten, fliegt die Tour und gibt die Übersicht aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== 🎄 Die Schlittentour – Lösung ===\n");

    // 1. Schlitten beladen
    Sleigh sleigh = new Sleigh(SleighMaxLoad);
    List<Gift> gifts = new List<Gift>
    {
      new Gift("Velo", "Lena", "Arbon", 12.5),
      new Gift("Buch", "Noah", "Rorschach", 0.4),
      new Gift("Lego", "Mia", "Arbon", 1.2),
      new Gift("Schlitten", "Elias", "St. Gallen", 8.0),
      new Gift("Malkasten", "Sofia", "Rorschach", 0.6),
      new Gift("Puppe", "Lars", "St. Gallen", 0.8)
    };

    List<Gift> rejected = new List<Gift>();
    foreach (Gift gift in gifts)
    {
      if (!sleigh.Load(gift))
      {
        rejected.Add(gift);
        Console.WriteLine($"Abgelehnt (zu schwer): {gift}");
      }
    }

    Console.WriteLine($"Geladen: {GiftsText(sleigh.GiftCount)}, {sleigh.CurrentLoad:F2} von {sleigh.MaxLoad:F2} kg\n");

    // 2. Team und Tour
    List<Reindeer> team = new List<Reindeer>
    {
      new Reindeer("Rudolph"),
      new Reindeer("Comet"),
      new Reindeer("Blitzen")
    };

    Dictionary<string, int> tour = new Dictionary<string, int>
    {
      { "Arbon", 720 },
      { "Rorschach", 80 },
      { "St. Gallen", 250 }
    };

    // 3. Tour fliegen
    int totalDistance = 0;
    int deliveredCount = 0;

    foreach (KeyValuePair<string, int> stage in tour)
    {
      string city = stage.Key;
      int km = stage.Value;

      // Vor jeder Etappe: jedes Rentier muss genug Energie haben.
      foreach (Reindeer reindeer in team)
      {
        while (!reindeer.CanFly(km))
        {
          reindeer.Feed();
          Console.WriteLine($"  🥕 {reindeer.Name} gefüttert → Energie {reindeer.Energy}");
        }
      }

      foreach (Reindeer reindeer in team)
      {
        reindeer.Fly(km);
      }

      totalDistance += km;

      List<Gift> delivered = sleigh.Unload(city);
      deliveredCount += delivered.Count;

      Console.WriteLine($"✈️  {city} ({km} km): {GiftsText(delivered.Count)} abgeliefert");
      foreach (Gift gift in delivered)
      {
        Console.WriteLine($"     🎁 {gift}");
      }
    }

    // 4. Übersicht
    Console.WriteLine("\n=== Tourübersicht ===");
    Console.WriteLine($"Abgeliefert:    {GiftsText(deliveredCount)}");
    Console.WriteLine($"Nicht geladen:  {GiftsText(rejected.Count)}");
    Console.WriteLine($"Noch im Schlitten: {sleigh.GiftCount}");
    Console.WriteLine($"Gesamtdistanz:  {totalDistance} km");
    foreach (Reindeer reindeer in team)
    {
      Console.WriteLine($"  {reindeer}");
    }

    if (rejected.Count > 0)
    {
      Console.WriteLine("\nFür die zweite Runde liegen bereit:");
      foreach (Gift gift in rejected)
      {
        Console.WriteLine($"  {gift}");
      }
    }

    Console.WriteLine("\nFrohe Weihnachten! 🎄");
  }

  /// <summary>
  ///   "1 Geschenk" oder "3 Geschenke" – Einzahl oder Mehrzahl.
  /// </summary>
  private static string GiftsText(int count)
  {
    return count == 1 ? "1 Geschenk" : $"{count} Geschenke";
  }
}
