namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe1;

// ============================================================
// RETOUREN-WERKSTATT, ETAPPE 1 – Retouren erfassen (🧩 Coden | ⭐⭐ Mittel | ~60–90 Min.)
//
// Konsolenmenü zum Erfassen und Anzeigen von Retouren. Stoff Block 01–03, Listen aus Block 05.
//
// Anforderungen:
//   - Menü in einer while-Schleife: 1 = erfassen, 2 = anzeigen, 0 = beenden
//   - Kind und Artikel nicht leer, Preis > 0 (TryParse), Grund per Nummer + switch
//   - Speichern in parallelen Listen
//   - Rückerstattung mit ?: (Broken 100 %, sonst 80 %)
//   - Ungültige Eingaben wiederholen, nie abstürzen
//
// Aufgabe und Details: siehe README.md
// ============================================================

/// <summary>
///   Gründe für eine Retoure.
/// </summary>
public enum ReturnReason
{
  WrongSize,
  Duplicate,
  Broken,
  Disliked
}

public static class RetourenEtappe1
{
  /// <summary>
  ///   Startet das Retourenprogramm.
  /// </summary>
  public static void Start()
  {
    throw new NotImplementedException("TODO: Retourenprogramm implementieren (Aufgabe siehe README.md)");
  }
}
