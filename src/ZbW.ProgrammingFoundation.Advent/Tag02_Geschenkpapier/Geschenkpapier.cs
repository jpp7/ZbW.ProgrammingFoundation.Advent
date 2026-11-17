namespace ZbW.ProgrammingFoundation.Advent.Tag02_Geschenkpapier;

// ============================================================
// TAG 2 – Geschenkpapier-Rechner (🧩 Coden | ⭐ Einfach | ~15 Min.)
//
// Berechnet den Papierbedarf und den Preis für ein flaches Geschenk.
//
// Anforderungen:
//   - Breite und Höhe in cm mit decimal.TryParse einlesen
//   - Fläche = 2 × Breite × Höhe, plus 20 % Zuschlag
//   - Umrechnen in m² (÷ 10 000)
//   - Preis 0.85 CHF pro m²
//   - Ausgabe mit :F2
// ============================================================

public static class Geschenkpapier
{
  public const decimal PricePerSquareMeter = 0.85m;
  public const decimal SurchargeFactor = 1.2m;
  public const decimal SquareCentimetersPerSquareMeter = 10000m;

  /// <summary>
  ///   Berechnet den Papierbedarf in m² inklusive 20 % Zuschlag.
  /// </summary>
  /// <param name="widthCm">Breite des Geschenks in cm.</param>
  /// <param name="heightCm">Höhe des Geschenks in cm.</param>
  /// <returns>Papierbedarf in m².</returns>
  public static decimal CalculatePaperArea(decimal widthCm, decimal heightCm)
  {
    // TODO: Fläche in cm² berechnen (Vorder- und Rückseite),
    //       mit SurchargeFactor multiplizieren
    //       und durch SquareCentimetersPerSquareMeter teilen.
    throw new NotImplementedException("TODO: CalculatePaperArea implementieren");
  }

  /// <summary>
  ///   Berechnet den Preis für eine Papierfläche.
  /// </summary>
  /// <param name="areaSquareMeters">Fläche in m².</param>
  /// <returns>Preis in CHF.</returns>
  public static decimal CalculatePrice(decimal areaSquareMeters)
  {
    // TODO: Fläche × PricePerSquareMeter
    throw new NotImplementedException("TODO: CalculatePrice implementieren");
  }

  /// <summary>
  ///   Startet den Geschenkpapier-Rechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Breite einlesen
    //         Console.Write("Breite in cm: ");
    //         if (!decimal.TryParse(Console.ReadLine(), out decimal widthCm)) { ... return; }

    // TODO 2: Höhe einlesen (gleiche Technik wie TODO 1)

    // TODO 3: CalculatePaperArea und CalculatePrice aufrufen

    // TODO 4: Ergebnis ausgeben: $"Papier: {area:F2} m², Preis: {price:F2} CHF"

    throw new NotImplementedException("TODO: Start implementieren");
  }
}
