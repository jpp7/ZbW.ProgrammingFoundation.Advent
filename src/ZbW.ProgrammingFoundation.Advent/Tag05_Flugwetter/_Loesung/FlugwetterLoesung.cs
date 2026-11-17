namespace ZbW.ProgrammingFoundation.Advent.Tag05_Flugwetter._Loesung;

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

/// <summary>
///   Musterlösung: Tag 5 – Rentier-Flugwetter
/// </summary>
public static class FlugwetterLoesung
{
  /// <summary>
  ///   Liefert die Flugfreigabe für eine Wetterlage.
  /// </summary>
  public static string GetClearance(Weather weather)
  {
    return weather switch
    {
      Weather.Clear => "Start frei",
      Weather.Snow => "Start frei, langsam fliegen",
      Weather.Storm => "Kein Start",
      Weather.Fog => "Start frei",
      _ => "Unbekannt"
    };
  }

  /// <summary>
  ///   Liefert die Freigabe plus Zusatzinfo bei Nebel.
  /// </summary>
  public static string GetFlightInfo(Weather weather)
  {
    string extra = weather == Weather.Fog ? " – Rudolph vorne!" : "";
    return GetClearance(weather) + extra;
  }

  /// <summary>
  ///   Gibt die Freigabe für alle vier Wetterlagen aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Rentier-Flugwetter – Lösung ===\n");

    Console.WriteLine($"{Weather.Clear}: {GetFlightInfo(Weather.Clear)}");
    Console.WriteLine($"{Weather.Snow}: {GetFlightInfo(Weather.Snow)}");
    Console.WriteLine($"{Weather.Storm}: {GetFlightInfo(Weather.Storm)}");
    Console.WriteLine($"{Weather.Fog}: {GetFlightInfo(Weather.Fog)}");
  }
}
