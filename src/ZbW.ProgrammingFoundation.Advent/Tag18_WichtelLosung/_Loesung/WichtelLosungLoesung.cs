namespace ZbW.ProgrammingFoundation.Advent.Tag18_WichtelLosung._Loesung;

/// <summary>
///   Musterlösung: Tag 18 – Wichtel-Losung
/// </summary>
public static class WichtelLosungLoesung
{
  /// <summary>
  ///   Lost aus, wer wen beschenkt.
  /// </summary>
  public static Dictionary<string, string> Draw(List<string> names, Random random)
  {
    // Kopie, damit die Originalliste unverändert bleibt.
    List<string> receivers = new List<string>(names);

    do
    {
      Shuffle(receivers, random);
    } while (HasSelfAssignment(names, receivers));

    Dictionary<string, string> pairs = new Dictionary<string, string>();
    for (int i = 0; i < names.Count; i++)
    {
      pairs[names[i]] = receivers[i];
    }

    return pairs;
  }

  /// <summary>
  ///   Mischt eine Liste mit dem Tausch-Verfahren (Fisher-Yates).
  /// </summary>
  private static void Shuffle(List<string> list, Random random)
  {
    for (int i = list.Count - 1; i > 0; i--)
    {
      int j = random.Next(i + 1);
      string temp = list[i];
      list[i] = list[j];
      list[j] = temp;
    }
  }

  /// <summary>
  ///   Prüft, ob jemand sich selbst gezogen hat.
  /// </summary>
  private static bool HasSelfAssignment(List<string> givers, List<string> receivers)
  {
    for (int i = 0; i < givers.Count; i++)
    {
      if (givers[i] == receivers[i])
      {
        return true;
      }
    }

    return false;
  }

  /// <summary>
  ///   Führt die Losung durch und gibt das Ergebnis aus.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Wichtel-Losung – Lösung ===\n");

    List<string> names = new List<string> { "Anna", "Fritz", "Lumi", "Pips", "Tinka", "Bo" };
    Dictionary<string, string> pairs = Draw(names, new Random());

    foreach (KeyValuePair<string, string> pair in pairs)
    {
      Console.WriteLine($"{pair.Key,-6} → {pair.Value}");
    }
  }
}
