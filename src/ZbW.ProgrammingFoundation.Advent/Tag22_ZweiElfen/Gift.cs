namespace ZbW.ProgrammingFoundation.Advent.Tag22_ZweiElfen;

/// <summary>
///   Ein Geschenk mit Name, Empfänger und Gewicht.
/// </summary>
public class Gift
{
  /// <summary>
  ///   Erstellt ein Geschenk ohne Angaben.
  /// </summary>
  public Gift()
  {
    Name = "Unbekannt";
    Recipient = "Niemand";
    Weight = 1;
  }

  /// <summary>
  ///   Erstellt ein Geschenk mit Name und Empfänger.
  /// </summary>
  public Gift(string name, string recipient)
  {
    this.Name = name;
    this.Recipient = recipient;
    this.Weight = 1;
  }

  public string Name { get; set; }
  public string Recipient { get; set; }
  public double Weight { get; set; }

  public override string ToString()
  {
    return $"{Name} für {Recipient} ({Weight} kg)";
  }
}
