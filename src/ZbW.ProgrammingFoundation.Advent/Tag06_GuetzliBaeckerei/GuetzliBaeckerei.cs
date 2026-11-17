namespace ZbW.ProgrammingFoundation.Advent.Tag06_GuetzliBaeckerei;

// ============================================================
// TAG 6 – ⭐ Guetzli-Bäckerei (🧩 Coden | ⭐⭐ Mittel | ~30–40 Min.)
//
// Berechnet Zutaten, Backzeit und Kosten für eine Ladung Guetzli.
//
// Anforderungen:
//   - Sorte über Nummer 1–4 wählen (enum CookieType)
//   - Anzahl Bleche 1–20 einlesen
//   - Mehl, Zucker, Backzeit und Kosten pro Blech mit switch
//   - Mengenrabatt mit if / else if (10+: 15 %, 5+: 10 %, 3+: 5 %)
//   - Alle Eingaben validieren, kein Absturz
// ============================================================

/// <summary>
///   Guetzli-Sorten der Werkstatt.
/// </summary>
public enum CookieType
{
  Mailaenderli,
  Zimtstern,
  Brunsli,
  Spitzbuben
}

public static class GuetzliBaeckerei
{
  /// <summary>
  ///   Liefert den Rabatt in Prozent (0, 5, 10 oder 15) für eine Anzahl Bleche.
  /// </summary>
  /// <param name="sheets">Anzahl Bleche.</param>
  /// <returns>Rabatt in Prozent.</returns>
  public static decimal GetDiscountPercent(int sheets)
  {
    // TODO: if / else if – grösste Schwelle zuerst prüfen
    throw new NotImplementedException("TODO: GetDiscountPercent implementieren");
  }

  /// <summary>
  ///   Startet die Guetzli-Bäckerei auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Sorten anzeigen und Nummer einlesen (int.TryParse, Bereich 1–4)
    //         Bei Fehler: Meldung ausgeben und return.

    // TODO 2: Nummer in CookieType umwandeln: (CookieType)(choice - 1)

    // TODO 3: Anzahl Bleche einlesen (int.TryParse, Bereich 1–20)

    // TODO 4: Mit switch (type) pro Sorte festlegen:
    //         int flourPerSheet, int sugarPerSheet, int bakeMinutes, decimal costPerSheet
    //         (Werte siehe README.md)

    // TODO 5: Totale berechnen: Mehl, Zucker, Kosten vor Rabatt

    // TODO 6: Rabatt mit GetDiscountPercent bestimmen, Kosten nach Rabatt berechnen

    // TODO 7: Alles übersichtlich ausgeben (Beträge mit :F2)

    throw new NotImplementedException("TODO: Start implementieren");
  }
}
