namespace ZbW.ProgrammingFoundation.Advent.Tag24_Schlittentour._Loesung;

/// <summary>
///   Musterlösung: Der Schlitten des Weihnachtsmanns.
/// </summary>
public class Sleigh
{
  // Privat: Von aussen kann niemand an der Ladung vorbei Geschenke hinzufügen.
  private List<Gift> _gifts = new List<Gift>();

  /// <summary>
  ///   Erstellt einen Schlitten mit maximaler Zuladung.
  /// </summary>
  /// <exception cref="ArgumentException">Wenn die Zuladung nicht grösser als 0 ist.</exception>
  public Sleigh(double maxLoad)
  {
    if (maxLoad <= 0)
    {
      throw new ArgumentException("Die Zuladung muss grösser als 0 sein.");
    }

    MaxLoad = maxLoad;
  }

  /// <summary>
  ///   Maximale Zuladung in kg.
  /// </summary>
  public double MaxLoad { get; }

  /// <summary>
  ///   Aktuelles Gewicht aller geladenen Geschenke.
  /// </summary>
  public double CurrentLoad
  {
    get
    {
      double total = 0;
      foreach (Gift gift in _gifts)
      {
        total += gift.Weight;
      }

      return total;
    }
  }

  /// <summary>
  ///   Anzahl geladener Geschenke.
  /// </summary>
  public int GiftCount
  {
    get { return _gifts.Count; }
  }

  /// <summary>
  ///   Lädt ein Geschenk, falls der Schlitten dadurch nicht zu schwer wird.
  /// </summary>
  /// <returns>true, wenn das Geschenk geladen wurde.</returns>
  public bool Load(Gift gift)
  {
    if (CurrentLoad + gift.Weight > MaxLoad)
    {
      return false;
    }

    _gifts.Add(gift);
    return true;
  }

  /// <summary>
  ///   Nimmt alle Geschenke für einen Ort heraus.
  /// </summary>
  /// <param name="city">Lieferort.</param>
  /// <returns>Eine neue Liste mit den abgeladenen Geschenken.</returns>
  public List<Gift> Unload(string city)
  {
    List<Gift> unloaded = new List<Gift>();

    // Rückwärts, damit RemoveAt die noch nicht besuchten Indizes nicht verschiebt.
    for (int i = _gifts.Count - 1; i >= 0; i--)
    {
      if (_gifts[i].City == city)
      {
        unloaded.Add(_gifts[i]);
        _gifts.RemoveAt(i);
      }
    }

    return unloaded;
  }
}
