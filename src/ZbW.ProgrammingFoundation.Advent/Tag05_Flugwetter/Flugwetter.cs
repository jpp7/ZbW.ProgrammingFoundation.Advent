namespace ZbW.ProgrammingFoundation.Advent.Tag05_Flugwetter;

// ============================================================
// TAG 5 – Rentier-Flugwetter (🧩 Coden | ⭐ Einfach | ~15 Min.)
//
// Liefert die Flugfreigabe für den Schlitten je nach Wetter.
//
// Anforderungen:
//   - enum Weather { Clear, Snow, Storm, Fog }
//   - GetClearance mit switch expression
//   - GetFlightInfo hängt bei Nebel mit ?: " – Rudolph vorne!" an
//   - Start gibt alle vier Wetterlagen aus
// ============================================================

/// <summary>
///   Mögliche Wetterlagen am Nordpol.
/// </summary>
public enum Weather
{
  Clear,
  Snow,
  Storm,
  Fog
}

public static class Flugwetter
{
  /// <summary>
  ///   Liefert die Flugfreigabe für eine Wetterlage.
  /// </summary>
  /// <param name="weather">Aktuelle Wetterlage.</param>
  /// <returns>Freigabetext.</returns>
  public static string GetClearance(Weather weather)
  {
    // TODO 1: switch expression
    //         return weather switch
    //         {
    //           Weather.Clear => "Start frei",
    //           ...
    //           _ => "Unbekannt"
    //         };
    throw new NotImplementedException("TODO: GetClearance implementieren");
  }

  /// <summary>
  ///   Liefert die Freigabe plus Zusatzinfo bei Nebel.
  /// </summary>
  /// <param name="weather">Aktuelle Wetterlage.</param>
  /// <returns>Freigabe, bei Nebel mit " – Rudolph vorne!".</returns>
  public static string GetFlightInfo(Weather weather)
  {
    // TODO 2: GetClearance aufrufen und mit ?: bei Weather.Fog den Zusatz anhängen
    throw new NotImplementedException("TODO: GetFlightInfo implementieren");
  }

  /// <summary>
  ///   Gibt die Freigabe für alle vier Wetterlagen aus.
  /// </summary>
  public static void Start()
  {
    // TODO 3: Für jede Wetterlage eine Zeile ausgeben, z. B.
    //         Console.WriteLine($"{Weather.Clear}: {GetFlightInfo(Weather.Clear)}");

    throw new NotImplementedException("TODO: Start implementieren");
  }
}
