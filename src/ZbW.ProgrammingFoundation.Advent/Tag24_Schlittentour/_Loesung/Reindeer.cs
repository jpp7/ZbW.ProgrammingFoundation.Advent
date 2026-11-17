namespace ZbW.ProgrammingFoundation.Advent.Tag24_Schlittentour._Loesung;

/// <summary>
///   Musterlösung: Ein Rentier aus dem Schlittenteam (wie Tag 23).
/// </summary>
public class Reindeer
{
  public const int MaxEnergy = 100;
  public const int FeedAmount = 30;
  public const int KilometersPerEnergy = 10;

  public Reindeer(string name)
  {
    Name = name;
    Energy = MaxEnergy;
  }

  public string Name { get; }

  /// <summary>
  ///   Energie von 0 bis 100. Von aussen nur lesbar.
  /// </summary>
  public int Energy { get; private set; }

  /// <summary>
  ///   Liefert den Energieverbrauch für eine Strecke (1 pro volle 10 km).
  /// </summary>
  public int GetCost(int km)
  {
    return km / KilometersPerEnergy;
  }

  /// <summary>
  ///   Prüft, ob die Energie für eine Strecke reicht.
  /// </summary>
  public bool CanFly(int km)
  {
    return GetCost(km) <= Energy;
  }

  /// <summary>
  ///   Fliegt eine Strecke, falls genug Energie vorhanden ist.
  /// </summary>
  /// <exception cref="ArgumentException">Bei negativer Strecke.</exception>
  public bool Fly(int km)
  {
    if (km < 0)
    {
      throw new ArgumentException("Die Strecke darf nicht negativ sein.");
    }

    if (!CanFly(km))
    {
      return false;
    }

    Energy -= GetCost(km);
    return true;
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

  public override string ToString()
  {
    return $"{Name} (Energie {Energy})";
  }
}
