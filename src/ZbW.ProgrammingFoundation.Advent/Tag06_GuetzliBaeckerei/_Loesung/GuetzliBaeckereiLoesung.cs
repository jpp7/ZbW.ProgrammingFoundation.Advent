namespace ZbW.ProgrammingFoundation.Advent.Tag06_GuetzliBaeckerei._Loesung;

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

/// <summary>
///   Musterlösung: Tag 6 – Guetzli-Bäckerei
/// </summary>
public static class GuetzliBaeckereiLoesung
{
  public const int MinSheets = 1;
  public const int MaxSheets = 20;

  /// <summary>
  ///   Liefert den Rabatt in Prozent (0, 5, 10 oder 15) für eine Anzahl Bleche.
  /// </summary>
  public static decimal GetDiscountPercent(int sheets)
  {
    // Grösste Schwelle zuerst, sonst würde bei 12 Blechen schon "ab 3" greifen.
    if (sheets >= 10)
    {
      return 15m;
    }
    else if (sheets >= 5)
    {
      return 10m;
    }
    else if (sheets >= 3)
    {
      return 5m;
    }

    return 0m;
  }

  /// <summary>
  ///   Startet die Guetzli-Bäckerei auf der Konsole.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Guetzli-Bäckerei – Lösung ===\n");
    Console.WriteLine("1 = Mailänderli, 2 = Zimtstern, 3 = Brunsli, 4 = Spitzbuben");
    Console.Write("Sorte: ");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
      Console.WriteLine("Bitte eine Zahl eingeben.");
      return;
    }

    if (choice < 1 || choice > 4)
    {
      Console.WriteLine("Diese Sorte gibt es nicht. Erlaubt sind 1 bis 4.");
      return;
    }

    CookieType type = (CookieType)(choice - 1);

    Console.Write($"Anzahl Bleche ({MinSheets}–{MaxSheets}): ");
    if (!int.TryParse(Console.ReadLine(), out int sheets))
    {
      Console.WriteLine("Bitte eine Zahl eingeben.");
      return;
    }

    if (sheets < MinSheets || sheets > MaxSheets)
    {
      Console.WriteLine($"So viele Bleche passen nicht in den Ofen. Erlaubt sind {MinSheets} bis {MaxSheets}.");
      return;
    }

    int flourPerSheet;
    int sugarPerSheet;
    int bakeMinutes;
    decimal costPerSheet;

    switch (type)
    {
      case CookieType.Mailaenderli:
        flourPerSheet = 250;
        sugarPerSheet = 125;
        bakeMinutes = 10;
        costPerSheet = 4.50m;
        break;
      case CookieType.Zimtstern:
        flourPerSheet = 0;
        sugarPerSheet = 200;
        bakeMinutes = 6;
        costPerSheet = 6.20m;
        break;
      case CookieType.Brunsli:
        flourPerSheet = 0;
        sugarPerSheet = 250;
        bakeMinutes = 5;
        costPerSheet = 5.80m;
        break;
      case CookieType.Spitzbuben:
        flourPerSheet = 300;
        sugarPerSheet = 100;
        bakeMinutes = 8;
        costPerSheet = 5.10m;
        break;
      default:
        Console.WriteLine("Unbekannte Sorte.");
        return;
    }

    int totalFlour = flourPerSheet * sheets;
    int totalSugar = sugarPerSheet * sheets;
    decimal costBefore = costPerSheet * sheets;
    decimal discountPercent = GetDiscountPercent(sheets);
    decimal costAfter = costBefore * (100 - discountPercent) / 100;

    Console.WriteLine($"\n{sheets} Blech(e) {type}");
    Console.WriteLine($"Mehl:      {totalFlour} g");
    Console.WriteLine($"Zucker:    {totalSugar} g");
    Console.WriteLine($"Backzeit:  {bakeMinutes} Min. pro Blech");
    Console.WriteLine($"Kosten:    {costBefore:F2} CHF");
    Console.WriteLine($"Rabatt:    {discountPercent} %");
    Console.WriteLine($"Zu zahlen: {costAfter:F2} CHF");
  }
}
