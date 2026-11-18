namespace ZbW.ProgrammingFoundation.Advent.Tag13_KaminKnacker._Loesung;

/// <summary>
///   Musterlösung: Tag 13 – Kamin-Knacker
/// </summary>
public static class KaminKnackerLoesung
{
  public const int MaxAttempts = 10;
  public const int CodeLength = 3;

  /// <summary>
  ///   Zählt, wie viele Ziffern an der richtigen Stelle stehen.
  /// </summary>
  /// <exception cref="ArgumentException">Wenn guess nicht aus genau 3 Ziffern besteht.</exception>
  public static int CountCorrectDigits(string code, string guess)
  {
    if (guess == null || guess.Length != CodeLength)
    {
      throw new ArgumentException($"Bitte genau {CodeLength} Ziffern eingeben.");
    }

    for (int i = 0; i < guess.Length; i++)
    {
      if (!char.IsDigit(guess[i]))
      {
        throw new ArgumentException("Nur Ziffern 0–9 erlaubt.");
      }
    }

    int correct = 0;
    for (int i = 0; i < CodeLength; i++)
    {
      if (code[i] == guess[i])
      {
        correct++;
      }
    }

    return correct;
  }

  /// <summary>
  ///   Zeigt pro Stelle, ob die Ziffer stimmt: "✓" richtig, "·" falsch, z. B. "✓ · ✓".
  ///   Wird erst aufgerufen, wenn CountCorrectDigits die Eingabe geprüft hat.
  /// </summary>
  public static string BuildHint(string code, string guess)
  {
    string hint = "";
    for (int i = 0; i < CodeLength; i++)
    {
      if (i > 0)
      {
        hint += " ";
      }

      hint += code[i] == guess[i] ? "✓" : "·";
    }

    return hint;
  }

  /// <summary>
  ///   Startet das Spiel Kamin-Knacker.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Kamin-Knacker – Lösung ===\n");

    Random random = new Random();
    string code = random.Next(0, 1000).ToString("D3");

    int attempts = 0;
    bool isCracked = false;

    try
    {
      Console.WriteLine($"Der Tresor hat einen {CodeLength}-stelligen Code. Du hast {MaxAttempts} Versuche.");

      while (attempts < MaxAttempts && !isCracked)
      {
        Console.Write($"Versuch {attempts + 1}: ");
        string input = Console.ReadLine();

        if (input == null)
        {
          // Eingabe wurde beendet (z. B. Ctrl+Z oder umgeleitete Eingabe zu Ende).
          break;
        }

        try
        {
          string guess = input.Trim();
          int correct = CountCorrectDigits(code, guess);
          attempts++;

          if (correct == CodeLength)
          {
            isCracked = true;
          }
          else
          {
            string digits = correct == 1 ? "Ziffer" : "Ziffern";
            Console.WriteLine($"{BuildHint(code, guess)}   ({correct} {digits} richtig)");
          }
        }
        catch (ArgumentException ex)
        {
          // Ungültige Eingabe: Meldung, aber kein Versuch verbraucht.
          Console.WriteLine(ex.Message);
        }
      }

      if (isCracked)
      {
        string tries = attempts == 1 ? "Versuch" : "Versuchen";
        Console.WriteLine($"🎁 Geknackt in {attempts} {tries}!");
      }
      else
      {
        Console.WriteLine($"Leider nicht geschafft. Der Code war {code}.");
      }
    }
    finally
    {
      Console.WriteLine("Kamin geschlossen.");
    }
  }
}
