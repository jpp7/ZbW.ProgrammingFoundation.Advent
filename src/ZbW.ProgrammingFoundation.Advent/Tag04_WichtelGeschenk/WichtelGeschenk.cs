namespace ZbW.ProgrammingFoundation.Advent.Tag04_WichtelGeschenk;

// ============================================================
// TAG 4 – Darf der Wichtel das schenken? (🧩 Coden | ⭐ Einfach | ~15 Min.)
//
// Prüft mit Guard Clauses, ob ein Geschenk zum Alter passt.
//
// Anforderungen:
//   - Alter unter 0 oder über 120, Preis negativ: "Ungültig"
//   - Unter 12 Jahren: höchstens 30 CHF, sonst höchstens 50 CHF
//   - Rückgabe "OK" oder "Zu teuer"
//   - Guard Clauses statt verschachtelter if/else
// ============================================================

public static class WichtelGeschenk
{
  public const decimal MaxPriceChild = 30m;
  public const decimal MaxPriceOthers = 50m;
  public const int ChildAgeLimit = 12;

  /// <summary>
  ///   Prüft, ob ein Geschenk für ein bestimmtes Alter erlaubt ist.
  /// </summary>
  /// <param name="age">Alter der beschenkten Person.</param>
  /// <param name="price">Preis des Geschenks in CHF.</param>
  /// <returns>"Ungültig", "OK" oder "Zu teuer".</returns>
  public static string CheckGift(int age, decimal price)
  {
    // TODO 1: Guard Clause – ungültiges Alter (unter 0 oder über 120) → "Ungültig"

    // TODO 2: Guard Clause – negativer Preis → "Ungültig"

    // TODO 3: Limite bestimmen: unter ChildAgeLimit → MaxPriceChild, sonst MaxPriceOthers

    // TODO 4: price <= Limite → "OK", sonst "Zu teuer"

    throw new NotImplementedException("TODO: CheckGift implementieren");
  }

  /// <summary>
  ///   Ruft CheckGift mit einigen Testfällen auf.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Darf der Wichtel das schenken? ===\n");

    // Diese Testfälle sind schon da. Erwartet: OK, Zu teuer, OK, Zu teuer, Ungültig, Ungültig
    Console.WriteLine($"Alter 8, 25 CHF:  {CheckGift(8, 25m)}");
    Console.WriteLine($"Alter 8, 35 CHF:  {CheckGift(8, 35m)}");
    Console.WriteLine($"Alter 12, 50 CHF: {CheckGift(12, 50m)}");
    Console.WriteLine($"Alter 40, 51 CHF: {CheckGift(40, 51m)}");
    Console.WriteLine($"Alter -3, 10 CHF: {CheckGift(-3, 10m)}");
    Console.WriteLine($"Alter 10, -5 CHF: {CheckGift(10, -5m)}");

    // TODO 5 (Bonus): Alter und Preis von der Konsole einlesen (TryParse) und prüfen.
  }
}
