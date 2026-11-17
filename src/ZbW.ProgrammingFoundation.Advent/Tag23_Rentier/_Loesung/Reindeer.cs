namespace ZbW.ProgrammingFoundation.Advent.Tag23_Rentier._Loesung;

/// <summary>
///   Musterlösung: Ein Rentier aus dem Stall des Weihnachtsmanns.
/// </summary>
public class Reindeer
{
  public const int MaxEnergy = 100;
  public const int FeedAmount = 30;
  public const int KilometersPerEnergy = 10;

  /// <summary>
  ///   Erstellt ein Rentier mit voller Energie.
  /// </summary>
  /// <param name="name">Name des Rentiers.</param>
  public Reindeer(string name)
  {
    Name = name;
    Energy = MaxEnergy;
  }

  /// <summary>
  ///   Name des Rentiers.
  /// </summary>
  public string Name { get; }

  /// <summary>
  ///   Energie von 0 bis 100. Von aussen nur lesbar.
  /// </summary>
  public int Energy { get; private set; }

  /// <summary>
  ///   Fliegt eine Strecke, falls genug Energie vorhanden ist.
  /// </summary>
  /// <param name="km">Strecke in km.</param>
  /// <returns>true, wenn geflogen wurde.</returns>
  /// <exception cref="ArgumentException">Bei negativer Strecke.</exception>
  public bool Fly(int km)
  {
    if (km < 0)
    {
      throw new ArgumentException("Die Strecke darf nicht negativ sein.");
    }

    int cost = GetCost(km);
    if (cost > Energy)
    {
      return false;
    }

    Energy -= cost;
    return true;
  }

  /// <summary>
  ///   Liefert den Energieverbrauch für eine Strecke (1 pro volle 10 km).
  /// </summary>
  public int GetCost(int km)
  {
    return km / KilometersPerEnergy;
  }

  /// <summary>
  ///   Füttert das Rentier: +30 Energie, höchstens 100.
  /// </summary>
  public void Feed()
  {
    Energy += FeedAmount;
    if (Energy > MaxEnergy)
    {
      Energy = MaxEnergy;
    }
  }

  /// <summary>
  ///   Liefert Name und Energie.
  /// </summary>
  public override string ToString()
  {
    return $"{Name} (Energie {Energy})";
  }
}
