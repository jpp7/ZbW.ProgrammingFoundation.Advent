namespace ZbW.ProgrammingFoundation.Advent.Tag04_WichtelGeschenk._Loesung;

/// <summary>
///   Musterlösung: Tag 4 – Darf der Wichtel das schenken?
/// </summary>
public static class WichtelGeschenkLoesung
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
    // Guard Clauses: ungültige Fälle zuerst und sofort verlassen.
    if (age < 0 || age > 120)
    {
      return "Ungültig";
    }

    if (price < 0)
    {
      return "Ungültig";
    }

    // Normalfall: ohne Verschachtelung.
    decimal limit = age < ChildAgeLimit ? MaxPriceChild : MaxPriceOthers;

    if (price <= limit)
    {
      return "OK";
    }

    return "Zu teuer";
  }

  /// <summary>
  ///   Ruft CheckGift mit Testfällen auf und prüft danach eine eigene Eingabe.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Darf der Wichtel das schenken? – Lösung ===\n");

    Console.WriteLine($"Alter 8, 25 CHF:  {CheckGift(8, 25m)}");
    Console.WriteLine($"Alter 8, 35 CHF:  {CheckGift(8, 35m)}");
    Console.WriteLine($"Alter 12, 50 CHF: {CheckGift(12, 50m)}");
    Console.WriteLine($"Alter 40, 51 CHF: {CheckGift(40, 51m)}");
    Console.WriteLine($"Alter -3, 10 CHF: {CheckGift(-3, 10m)}");
    Console.WriteLine($"Alter 10, -5 CHF: {CheckGift(10, -5m)}");

    // Bonus: eigene Eingabe
    Console.Write("\nAlter: ");
    if (!int.TryParse(Console.ReadLine(), out int age))
    {
      Console.WriteLine("Keine gültige Zahl.");
      return;
    }

    Console.Write("Preis in CHF: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal price))
    {
      Console.WriteLine("Kein gültiger Betrag.");
      return;
    }

    Console.WriteLine($"Ergebnis: {CheckGift(age, price)}");
  }
}
