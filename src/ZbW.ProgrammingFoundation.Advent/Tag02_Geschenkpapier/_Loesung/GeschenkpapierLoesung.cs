namespace ZbW.ProgrammingFoundation.Advent.Tag02_Geschenkpapier._Loesung;

/// <summary>
///   Musterlösung: Tag 2 – Geschenkpapier-Rechner
/// </summary>
public static class GeschenkpapierLoesung
{
  public const decimal PricePerSquareMeter = 0.85m;
  public const decimal SurchargeFactor = 1.2m;
  public const decimal SquareCentimetersPerSquareMeter = 10000m;

  /// <summary>
  ///   Berechnet den Papierbedarf in m² inklusive 20 % Zuschlag.
  /// </summary>
  public static decimal CalculatePaperArea(decimal widthCm, decimal heightCm)
  {
    decimal areaCm2 = 2 * widthCm * heightCm;
    return areaCm2 * SurchargeFactor / SquareCentimetersPerSquareMeter;
  }

  /// <summary>
  ///   Berechnet den Preis für eine Papierfläche.
  /// </summary>
  public static decimal CalculatePrice(decimal areaSquareMeters)
  {
    return areaSquareMeters * PricePerSquareMeter;
  }

  /// <summary>
  ///   Startet den Geschenkpapier-Rechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Geschenkpapier-Rechner ===\n");

    Console.Write("Breite in cm: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal widthCm) || widthCm <= 0)
    {
      Console.WriteLine("Ungültige Breite. Bitte eine positive Zahl eingeben.");
      return;
    }

    Console.Write("Höhe in cm: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal heightCm) || heightCm <= 0)
    {
      Console.WriteLine("Ungültige Höhe. Bitte eine positive Zahl eingeben.");
      return;
    }

    decimal area = CalculatePaperArea(widthCm, heightCm);
    decimal price = CalculatePrice(area);

    Console.WriteLine($"Papier: {area:F2} m², Preis: {price:F2} CHF");
  }
}
