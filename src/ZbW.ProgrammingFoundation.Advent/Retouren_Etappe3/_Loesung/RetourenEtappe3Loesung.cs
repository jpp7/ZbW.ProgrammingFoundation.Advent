namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe3._Loesung;

/// <summary>
///   Musterlösung: Retouren-Werkstatt, Etappe 3 – Umbau auf Klassen.
///   Hier steht nur noch Menü, Ein- und Ausgabe. Daten und Auswertung liegen in
///   Return und ReturnDesk. Vergleiche die Methodensignaturen mit Etappe 2:
///   Die vier parallelen Listen sind verschwunden.
/// </summary>
public static class RetourenEtappe3Loesung
{
  /// <summary>
  ///   Startet das Retourenprogramm mit 10 Beispiel-Retouren.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Retouren-Werkstatt, Etappe 3 – Lösung ===");

    ReturnDesk desk = new ReturnDesk();
    AddSampleData(desk);
    Console.WriteLine($"{desk.Count} Beispiel-Retouren geladen.");

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
          CaptureReturn(desk);
          break;
        case "2":
          PrintList(desk);
          break;
        case "3":
          PrintReport(desk);
          break;
        case "4":
          Console.WriteLine(desk.ReportFor(ReadNonEmpty("Kind: ")));
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

  /// <summary>
  ///   Erfasst eine Retoure über die Konsole.
  /// </summary>
  public static void CaptureReturn(ReturnDesk desk)
  {
    string child = ReadNonEmpty("Kind: ");
    string article = ReadNonEmpty("Artikel: ");
    decimal price = ReadPrice("Preis in CHF: ");
    ReturnReason reason = ReadReason();

    try
    {
      Return r = new Return(child, article, price, reason);
      desk.Add(r);

      if (r.Reason == ReturnReason.Broken)
      {
        Console.WriteLine("Elfen-Garantie: voller Betrag zurück");
      }

      Console.WriteLine($"Erfasst: {r.Article} von {r.Child}, Rückerstattung {r.Refund:F2} CHF");
    }
    catch (ArgumentException ex)
    {
      // Sollte dank der Eingabeprüfung nicht vorkommen – die Klasse schützt sich trotzdem selbst.
      Console.WriteLine($"Nicht erfasst: {ex.Message}");
    }
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

  /// <summary>
  ///   Gibt alle Retouren als Tabelle aus.
  /// </summary>
  public static void PrintList(ReturnDesk desk)
  {
    Console.WriteLine($"\n{"Nr",-3} {"Kind",-8} {"Artikel",-12} {"Preis",8} {"Grund",-10} {"Zurück",8}");

    List<Return> all = desk.GetAll();
    for (int i = 0; i < all.Count; i++)
    {
      Console.WriteLine($"{i + 1,-3} {all[i]}");
    }
  }

  /// <summary>
  ///   Gibt den Auswertungsbericht aus.
  /// </summary>
  public static void PrintReport(ReturnDesk desk, string title = "Retouren-Bericht")
  {
    Console.WriteLine($"\n=== {title} ===");
    Console.WriteLine($"Anzahl Retouren:   {desk.Count}");
    Console.WriteLine($"Total zurück:      {desk.TotalRefund():F2} CHF");
    Console.WriteLine($"Häufigster Grund:  {desk.MostCommonReason()}");

    if (desk.TryFindMostExpensive(out Return mostExpensive))
    {
      Console.WriteLine($"Teuerster Artikel: {mostExpensive.Article} ({mostExpensive.Price:F2} CHF)");
    }

    Console.WriteLine("\nGründe:");
    foreach (KeyValuePair<ReturnReason, int> entry in desk.CountReasons())
    {
      Console.WriteLine($"  {entry.Key,-10} {entry.Value,3}");
    }

    Console.WriteLine("\nRückerstattung pro Kind:");
    foreach (KeyValuePair<string, decimal> entry in desk.RefundPerChild())
    {
      Console.WriteLine($"  {entry.Key,-8} {entry.Value,8:F2} CHF");
    }
  }

  /// <summary>
  ///   Erfasst 10 Beispiel-Retouren.
  /// </summary>
  public static void AddSampleData(ReturnDesk desk)
  {
    desk.Add(new Return("Lena", "Pulli", 49.90m, ReturnReason.WrongSize));
    desk.Add(new Return("Noah", "Buch", 24.90m, ReturnReason.Duplicate));
    desk.Add(new Return("Mia", "Kreisel", 12.50m, ReturnReason.Broken));
    desk.Add(new Return("Lena", "Lego", 89.00m, ReturnReason.Disliked));
    desk.Add(new Return("Elias", "Helm", 59.00m, ReturnReason.WrongSize));
    desk.Add(new Return("Sofia", "Malkasten", 19.90m, ReturnReason.Duplicate));
    desk.Add(new Return("Noah", "Velo", 299.00m, ReturnReason.Disliked));
    desk.Add(new Return("Mia", "Puppe", 34.90m, ReturnReason.WrongSize));
    desk.Add(new Return("Lars", "Teddy", 29.90m, ReturnReason.Broken));
    desk.Add(new Return("Lena", "Handschuhe", 15.00m, ReturnReason.WrongSize));
  }
}
