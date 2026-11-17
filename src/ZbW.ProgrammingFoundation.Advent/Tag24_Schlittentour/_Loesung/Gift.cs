namespace ZbW.ProgrammingFoundation.Advent.Tag24_Schlittentour._Loesung;

/// <summary>
///   Musterlösung: Ein Geschenk mit Lieferort.
/// </summary>
public class Gift
{
  private double _weight;

  /// <summary>
  ///   Erstellt ein Geschenk.
  /// </summary>
  /// <exception cref="ArgumentException">Wenn das Gewicht nicht grösser als 0 ist.</exception>
  public Gift(string name, string recipient, string city, double weight)
  {
    Name = name;
    Recipient = recipient;
    City = city;
    Weight = weight;
  }

  public string Name { get; set; }
  public string Recipient { get; set; }
  public string City { get; set; }

  /// <summary>
  ///   Gewicht in kg. Muss grösser als 0 sein.
  /// </summary>
  public double Weight
  {
    get { return _weight; }
    set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Das Gewicht muss grösser als 0 sein.");
      }

      _weight = value;
    }
  }

  public override string ToString()
  {
    return $"{Name} für {Recipient} in {City} ({Weight:F1} kg)";
  }
}
