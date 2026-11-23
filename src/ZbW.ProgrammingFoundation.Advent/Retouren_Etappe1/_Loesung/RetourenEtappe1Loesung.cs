namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe1._Loesung;

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
///   Musterlösung: Retouren-Werkstatt, Etappe 1 – Retouren erfassen.
///   Bewusst ohne eigene Methoden: alles in einer Methode, Schleifen (Block 01–03)
///   und Listen (Block 05).
/// </summary>
public static class RetourenEtappe1Loesung
{
  public const decimal DefaultRefundRate = 0.8m;

  /// <summary>
  ///   Startet das Retourenprogramm.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Retouren-Werkstatt, Etappe 1 – Lösung ===");

    // Parallele Listen: Index i gehört in allen vier Listen zur selben Retoure.
    List<string> children = new List<string>();
    List<string> articles = new List<string>();
    List<decimal> prices = new List<decimal>();
    List<ReturnReason> reasons = new List<ReturnReason>();

    bool isRunning = true;

    // Liefert Console.ReadLine() null, ist die Eingabe zu Ende (z. B. Ctrl+Z oder
    // umgeleitete Eingabe). Danach kommt nie mehr etwas – also sauber aufhören,
    // statt endlos weiterzufragen.
    bool isInputClosed = false;

    while (isRunning && !isInputClosed)
    {
      Console.WriteLine("\n1 = Retoure erfassen, 2 = Retouren anzeigen, 0 = Beenden");
      Console.Write("Auswahl: ");
      string choice = Console.ReadLine();

      if (choice == null)
      {
        isInputClosed = true;
        break;
      }

      switch (choice.Trim())
      {
        case "1":
          // --- Kind ---
          string child = "";
          do
          {
            Console.Write("Kind: ");
            string childInput = Console.ReadLine();
            if (childInput == null)
            {
              isInputClosed = true;
              break;
            }

            child = childInput.Trim();
            if (child == "")
            {
              Console.WriteLine("Der Name darf nicht leer sein.");
            }
          } while (child == "");

          if (isInputClosed)
          {
            break;
          }

          // --- Artikel ---
          string article = "";
          do
          {
            Console.Write("Artikel: ");
            string articleInput = Console.ReadLine();
            if (articleInput == null)
            {
              isInputClosed = true;
              break;
            }

            article = articleInput.Trim();
            if (article == "")
            {
              Console.WriteLine("Der Artikel darf nicht leer sein.");
            }
          } while (article == "");

          if (isInputClosed)
          {
            break;
          }

          // --- Preis ---
          decimal price = 0;
          bool isPriceValid = false;
          do
          {
            Console.Write("Preis in CHF: ");
            string priceInput = Console.ReadLine();
            if (priceInput == null)
            {
              isInputClosed = true;
              break;
            }

            if (!decimal.TryParse(priceInput, out price))
            {
              Console.WriteLine("Das ist kein gültiger Betrag.");
            }
            else if (price <= 0)
            {
              Console.WriteLine("Der Preis muss grösser als 0 sein.");
            }
            else
            {
              isPriceValid = true;
            }
          } while (!isPriceValid);

          if (isInputClosed)
          {
            break;
          }

          // --- Grund ---
          ReturnReason reason = ReturnReason.Disliked;
          bool isReasonValid = false;
          do
          {
            Console.WriteLine("Grund: 1 = falsche Grösse, 2 = doppelt, 3 = defekt, 4 = gefällt nicht");
            Console.Write("Grund: ");
            string reasonInput = Console.ReadLine();
            if (reasonInput == null)
            {
              isInputClosed = true;
              break;
            }

            isReasonValid = true;
            switch (reasonInput.Trim())
            {
              case "1":
                reason = ReturnReason.WrongSize;
                break;
              case "2":
                reason = ReturnReason.Duplicate;
                break;
              case "3":
                reason = ReturnReason.Broken;
                break;
              case "4":
                reason = ReturnReason.Disliked;
                break;
              default:
                Console.WriteLine("Bitte 1 bis 4 eingeben.");
                isReasonValid = false;
                break;
            }
          } while (!isReasonValid);

          if (isInputClosed)
          {
            break;
          }

          children.Add(child);
          articles.Add(article);
          prices.Add(price);
          reasons.Add(reason);

          decimal refund = reason == ReturnReason.Broken ? price : price * DefaultRefundRate;
          if (reason == ReturnReason.Broken)
          {
            Console.WriteLine("Elfen-Garantie: voller Betrag zurück");
          }

          Console.WriteLine($"Erfasst: {article} von {child}, Rückerstattung {refund:F2} CHF");
          break;

        case "2":
          if (children.Count == 0)
          {
            Console.WriteLine("Noch keine Retouren erfasst.");
            break;
          }

          Console.WriteLine($"\n{"Nr",-3} {"Kind",-8} {"Artikel",-12} {"Preis",8} {"Grund",-10} {"Zurück",8}");
          for (int i = 0; i < children.Count; i++)
          {
            decimal itemRefund = reasons[i] == ReturnReason.Broken ? prices[i] : prices[i] * DefaultRefundRate;
            Console.WriteLine($"{i + 1,-3} {children[i],-8} {articles[i],-12} {prices[i],8:F2} {reasons[i],-10} {itemRefund,8:F2}");
          }

          break;

        case "0":
          isRunning = false;
          break;

        default:
          Console.WriteLine("Unbekannte Auswahl. Bitte 1, 2 oder 0 eingeben.");
          break;
      }
    }

    if (isInputClosed)
    {
      Console.WriteLine("\nEingabe beendet.");
    }

    Console.WriteLine("Retouren-Werkstatt geschlossen.");
  }
}
