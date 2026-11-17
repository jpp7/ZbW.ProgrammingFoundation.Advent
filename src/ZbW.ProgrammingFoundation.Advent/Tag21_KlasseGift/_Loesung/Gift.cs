namespace ZbW.ProgrammingFoundation.Advent.Tag21_KlasseGift._Loesung;

/// <summary>
///   Musterlösung: Ein Geschenk aus der Werkstatt.
/// </summary>
public class Gift
{
  private double _weight;

  /// <summary>
  ///   Erstellt ein Geschenk.
  /// </summary>
  /// <param name="name">Bezeichnung des Geschenks.</param>
  /// <param name="recipient">Name der beschenkten Person.</param>
  /// <param name="weight">Gewicht in kg, grösser als 0.</param>
  /// <exception cref="ArgumentException">Wenn das Gewicht nicht grösser als 0 ist.</exception>
  public Gift(string name, string recipient, double weight)
  {
    Name = name;
    Recipient = recipient;
    Weight = weight;
  }

  /// <summary>
  ///   Bezeichnung des Geschenks.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  ///   Name der beschenkten Person.
  /// </summary>
  public string Recipient { get; set; }

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

  /// <summary>
  ///   Liefert eine lesbare Beschreibung des Geschenks.
  /// </summary>
  public override string ToString()
  {
    return $"{Name} für {Recipient} ({Weight:F2} kg)";
  }
}
