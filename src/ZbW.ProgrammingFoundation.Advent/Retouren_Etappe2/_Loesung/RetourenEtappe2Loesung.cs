namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe2._Loesung;

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

/// <summary>
///   Musterlösung: Retouren-Werkstatt, Etappe 2 – Retouren auswerten.
///   Umbau auf Methoden mit Collections, ohne LINQ.
///
///   Beobachtung: Fast jede Methode braucht die vier parallelen Listen als Parameter.
///   Genau dieses Problem lösen in Etappe 3 die Klassen Return und ReturnDesk.
/// </summary>
public static class RetourenEtappe2Loesung
{
  public const decimal DefaultRefundRate = 0.8m;

  /// <summary>
  ///   Startet das Retourenprogramm mit 10 Beispiel-Retouren.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Retouren-Werkstatt, Etappe 2 – Lösung ===");

    List<string> children = new List<string>();
    List<string> articles = new List<string>();
    List<decimal> prices = new List<decimal>();
    List<ReturnReason> reasons = new List<ReturnReason>();

    AddSampleData(children, articles, prices, reasons);
    Console.WriteLine($"{children.Count} Beispiel-Retouren geladen.");

    bool isRunning = true;
    while (isRunning)
    {
      Console.WriteLine("\n1 = erfassen, 2 = anzeigen, 3 = Bericht, 4 = Bericht für ein Kind, 0 = beenden");
      Console.Write("Auswahl: ");
      string choice = Console.ReadLine();

      if (choice == null)
      {
        break;
      }

      switch (choice.Trim())
      {
        case "1":
          CaptureReturn(children, articles, prices, reasons);
          break;
        case "2":
          PrintList(children, articles, prices, reasons);
          break;
        case "3":
          PrintReport(children, articles, prices, reasons);
          break;
        case "4":
          string child = ReadNonEmpty("Kind: ");
          Console.WriteLine(ReportFor(children, articles, prices, reasons, child));
          break;
        case "0":
          isRunning = false;
          break;
        default:
          Console.WriteLine("Unbekannte Auswahl.");
          break;
      }
    }

    Console.WriteLine("Retouren-Werkstatt geschlossen.");
  }

  // ------------------------------------------------------------
  // Eingabe
  // ------------------------------------------------------------

  /// <summary>
  ///   Erfasst eine Retoure über die Konsole und hängt sie an die Listen an.
  /// </summary>
  public static void CaptureReturn(List<string> children, List<string> articles, List<decimal> prices, List<ReturnReason> reasons)
  {
    string child = ReadNonEmpty("Kind: ");
    string article = ReadNonEmpty("Artikel: ");
    decimal price = ReadPrice("Preis in CHF: ");
    ReturnReason reason = ReadReason();

    children.Add(child);
    articles.Add(article);
    prices.Add(price);
    reasons.Add(reason);

    if (reason == ReturnReason.Broken)
    {
      Console.WriteLine("Elfen-Garantie: voller Betrag zurück");
    }

    Console.WriteLine($"Erfasst: {article} von {child}, Rückerstattung {CalculateRefund(price, reason):F2} CHF");
  }

  /// <summary>
  ///   Liest einen nicht leeren Text ein.
  /// </summary>
  public static string ReadNonEmpty(string prompt)
  {
    string input;
    do
    {
      Console.Write(prompt);
      input = (Console.ReadLine() ?? "").Trim();
      if (input == "")
      {
        Console.WriteLine("Die Eingabe darf nicht leer sein.");
      }
    } while (input == "");

    return input;
  }

  /// <summary>
  ///   Liest einen Betrag grösser als 0 ein.
  /// </summary>
  public static decimal ReadPrice(string prompt)
  {
    while (true)
    {
      Console.Write(prompt);
      if (!decimal.TryParse(Console.ReadLine(), out decimal price))
      {
        Console.WriteLine("Das ist kein gültiger Betrag.");
      }
      else if (price <= 0)
      {
        Console.WriteLine("Der Preis muss grösser als 0 sein.");
      }
      else
      {
        return price;
      }
    }
  }

  /// <summary>
  ///   Liest einen Retourengrund über eine Nummer ein.
  /// </summary>
  public static ReturnReason ReadReason()
  {
    while (true)
    {
      Console.WriteLine("Grund: 1 = falsche Grösse, 2 = doppelt, 3 = defekt, 4 = gefällt nicht");
      Console.Write("Grund: ");
      switch ((Console.ReadLine() ?? "").Trim())
      {
        case "1": return ReturnReason.WrongSize;
        case "2": return ReturnReason.Duplicate;
        case "3": return ReturnReason.Broken;
        case "4": return ReturnReason.Disliked;
        default:
          Console.WriteLine("Bitte 1 bis 4 eingeben.");
          break;
      }
    }
  }

  // ------------------------------------------------------------
  // Berechnung
  // ------------------------------------------------------------

  /// <summary>
  ///   Berechnet die Rückerstattung: defekt 100 %, sonst 80 %.
  /// </summary>
  public static decimal CalculateRefund(decimal price, ReturnReason reason)
  {
    return reason == ReturnReason.Broken ? price : price * DefaultRefundRate;
  }

  /// <summary>
  ///   Zählt, wie oft jeder Grund vorkommt.
  /// </summary>
  public static Dictionary<ReturnReason, int> CountReasons(List<ReturnReason> reasons)
  {
    Dictionary<ReturnReason, int> counts = new Dictionary<ReturnReason, int>();
    foreach (ReturnReason reason in reasons)
    {
      if (counts.ContainsKey(reason))
      {
        counts[reason]++;
      }
      else
      {
        counts[reason] = 1;
      }
    }

    return counts;
  }

  /// <summary>
  ///   Liefert den häufigsten Grund.
  /// </summary>
  public static ReturnReason MostCommonReason(List<ReturnReason> reasons)
  {
    Dictionary<ReturnReason, int> counts = CountReasons(reasons);

    ReturnReason best = ReturnReason.Disliked;
    int bestCount = 0;
    foreach (KeyValuePair<ReturnReason, int> entry in counts)
    {
      if (entry.Value > bestCount)
      {
        best = entry.Key;
        bestCount = entry.Value;
      }
    }

    return best;
  }

  /// <summary>
  ///   Summiert die Rückerstattung pro Kind.
  /// </summary>
  public static Dictionary<string, decimal> RefundPerChild(List<string> children, List<decimal> prices, List<ReturnReason> reasons)
  {
    Dictionary<string, decimal> sums = new Dictionary<string, decimal>();
    for (int i = 0; i < children.Count; i++)
    {
      decimal refund = CalculateRefund(prices[i], reasons[i]);
      if (sums.ContainsKey(children[i]))
      {
        sums[children[i]] += refund;
      }
      else
      {
        sums[children[i]] = refund;
      }
    }

    return sums;
  }

  /// <summary>
  ///   Summiert alle Rückerstattungen.
  /// </summary>
  public static decimal TotalRefund(List<decimal> prices, List<ReturnReason> reasons)
  {
    decimal total = 0;
    for (int i = 0; i < prices.Count; i++)
    {
      total += CalculateRefund(prices[i], reasons[i]);
    }

    return total;
  }

  /// <summary>
  ///   Sucht den teuersten Artikel.
  /// </summary>
  /// <returns>false, wenn es keine Retouren gibt.</returns>
  public static bool TryFindMostExpensive(List<string> articles, List<decimal> prices, out string article, out decimal price)
  {
    article = "";
    price = 0;

    if (prices.Count == 0)
    {
      return false;
    }

    int bestIndex = 0;
    for (int i = 1; i < prices.Count; i++)
    {
      if (prices[i] > prices[bestIndex])
      {
        bestIndex = i;
      }
    }

    article = articles[bestIndex];
    price = prices[bestIndex];
    return true;
  }

  // ------------------------------------------------------------
  // Ausgabe
  // ------------------------------------------------------------

  /// <summary>
  ///   Liefert einen kurzen Bericht für ein Kind.
  /// </summary>
  public static string ReportFor(List<string> children, List<string> articles, List<decimal> prices, List<ReturnReason> reasons, string child)
  {
    string report = $"Retouren von {child}:";
    decimal sum = 0;
    int count = 0;

    for (int i = 0; i < children.Count; i++)
    {
      if (children[i] == child)
      {
        decimal refund = CalculateRefund(prices[i], reasons[i]);
        report += $"\n  {articles[i],-12} {reasons[i],-10} {refund,8:F2} CHF";
        sum += refund;
        count++;
      }
    }

    if (count == 0)
    {
      return $"Keine Retouren von {child}.";
    }

    return report + $"\n  Total: {sum:F2} CHF";
  }

  /// <summary>
  ///   Gibt alle Retouren als Tabelle aus.
  /// </summary>
  public static void PrintList(List<string> children, List<string> articles, List<decimal> prices, List<ReturnReason> reasons)
  {
    Console.WriteLine($"\n{"Nr",-3} {"Kind",-8} {"Artikel",-12} {"Preis",8} {"Grund",-10} {"Zurück",8}");
    for (int i = 0; i < children.Count; i++)
    {
      Console.WriteLine($"{i + 1,-3} {children[i],-8} {articles[i],-12} {prices[i],8:F2} {reasons[i],-10} {CalculateRefund(prices[i], reasons[i]),8:F2}");
    }
  }

  /// <summary>
  ///   Gibt den Auswertungsbericht aus.
  /// </summary>
  public static void PrintReport(List<string> children, List<string> articles, List<decimal> prices, List<ReturnReason> reasons, string title = "Retouren-Bericht")
  {
    Console.WriteLine($"\n=== {title} ===");
    Console.WriteLine($"Anzahl Retouren:   {children.Count}");
    Console.WriteLine($"Total zurück:      {TotalRefund(prices, reasons):F2} CHF");
    Console.WriteLine($"Häufigster Grund:  {MostCommonReason(reasons)}");

    if (TryFindMostExpensive(articles, prices, out string article, out decimal price))
    {
      Console.WriteLine($"Teuerster Artikel: {article} ({price:F2} CHF)");
    }

    Console.WriteLine("\nGründe:");
    foreach (KeyValuePair<ReturnReason, int> entry in CountReasons(reasons))
    {
      Console.WriteLine($"  {entry.Key,-10} {entry.Value,3}");
    }

    Console.WriteLine("\nRückerstattung pro Kind:");
    foreach (KeyValuePair<string, decimal> entry in RefundPerChild(children, prices, reasons))
    {
      Console.WriteLine($"  {entry.Key,-8} {entry.Value,8:F2} CHF");
    }
  }

  /// <summary>
  ///   Belegt die Listen mit 10 Beispiel-Retouren.
  /// </summary>
  public static void AddSampleData(List<string> children, List<string> articles, List<decimal> prices, List<ReturnReason> reasons)
  {
    string[] sampleChildren = { "Lena", "Noah", "Mia", "Lena", "Elias", "Sofia", "Noah", "Mia", "Lars", "Lena" };
    string[] sampleArticles = { "Pulli", "Buch", "Kreisel", "Lego", "Helm", "Malkasten", "Velo", "Puppe", "Teddy", "Handschuhe" };
    decimal[] samplePrices = { 49.90m, 24.90m, 12.50m, 89.00m, 59.00m, 19.90m, 299.00m, 34.90m, 29.90m, 15.00m };
    ReturnReason[] sampleReasons =
    {
      ReturnReason.WrongSize, ReturnReason.Duplicate, ReturnReason.Broken, ReturnReason.Disliked, ReturnReason.WrongSize,
      ReturnReason.Duplicate, ReturnReason.Disliked, ReturnReason.WrongSize, ReturnReason.Broken, ReturnReason.WrongSize
    };

    for (int i = 0; i < sampleChildren.Length; i++)
    {
      children.Add(sampleChildren[i]);
      articles.Add(sampleArticles[i]);
      prices.Add(samplePrices[i]);
      reasons.Add(sampleReasons[i]);
    }
  }
}
