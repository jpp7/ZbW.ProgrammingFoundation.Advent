namespace ZbW.ProgrammingFoundation.Advent.Tag12_LebkuchenPasch;

// ============================================================
// TAG 12 – Lebkuchen-Pasch (🧩 Coden | ⭐ Einfach | ~15 Min.)
//
// Simuliert, wie viele Würfe man im Schnitt für einen Pasch braucht.
//
// Anforderungen:
//   - Zwei Würfel (1–6) werfen, bis ein Pasch fällt; Würfe zählen
//   - 1000 Spiele simulieren
//   - Durchschnitt mit :F2 ausgeben (erwartet: etwa 6)
// ============================================================

public static class LebkuchenPasch
{
  public const int Games = 1000;

  /// <summary>
  ///   Würfelt mit zwei Würfeln, bis ein Pasch fällt.
  /// </summary>
  /// <param name="random">Zufallsgenerator, der für alle Spiele verwendet wird.</param>
  /// <returns>Anzahl Würfe bis zum Pasch.</returns>
  public static int RollUntilDouble(Random random)
  {
    // TODO 1: Zähler für Würfe anlegen

    // TODO 2: Schleife: zwei Würfel werfen (random.Next(1, 7)), Zähler erhöhen,
    //         bis beide Würfel gleich sind (do-while passt gut)

    // TODO 3: Anzahl Würfe zurückgeben

    throw new NotImplementedException("TODO: RollUntilDouble implementieren");
  }

  /// <summary>
  ///   Simuliert 1000 Spiele und gibt den Durchschnitt aus.
  /// </summary>
  public static void Start()
  {
    // TODO 4: Ein Random-Objekt erzeugen

    // TODO 5: for-Schleife über Games, Würfe aufsummieren

    // TODO 6: Durchschnitt berechnen ((double)total / Games) und mit :F2 ausgeben

    throw new NotImplementedException("TODO: Start implementieren");
  }
}
