namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe3._Loesung;

/// <summary>
///   Musterlösung: Der Retourenschalter verwaltet alle Retouren.
/// </summary>
public class ReturnDesk
{
  // Privat: Von aussen geht alles über Add – niemand kann die Liste leeren oder umsortieren.
  private List<Return> _returns = new List<Return>();

  /// <summary>
  ///   Anzahl erfasster Retouren.
  /// </summary>
  public int Count
  {
    get { return _returns.Count; }
  }

  /// <summary>
  ///   Erfasst eine Retoure.
  /// </summary>
  /// <exception cref="ArgumentNullException">Wenn r null ist.</exception>
  public void Add(Return r)
  {
    if (r == null)
    {
      throw new ArgumentNullException(nameof(r));
    }

    _returns.Add(r);
  }

  /// <summary>
  ///   Liefert eine Kopie der Liste. Änderungen an der Kopie betreffen den Schalter nicht.
  /// </summary>
  public List<Return> GetAll()
  {
    return new List<Return>(_returns);
  }

  /// <summary>
  ///   Summiert alle Rückerstattungen.
  /// </summary>
  public decimal TotalRefund()
  {
    decimal total = 0;
    foreach (Return r in _returns)
    {
      total += r.Refund;
    }

    return total;
  }

  /// <summary>
  ///   Zählt, wie oft jeder Grund vorkommt.
  /// </summary>
  public Dictionary<ReturnReason, int> CountReasons()
  {
    Dictionary<ReturnReason, int> counts = new Dictionary<ReturnReason, int>();
    foreach (Return r in _returns)
    {
      if (counts.ContainsKey(r.Reason))
      {
        counts[r.Reason]++;
      }
      else
      {
        counts[r.Reason] = 1;
      }
    }

    return counts;
  }

  /// <summary>
  ///   Liefert den häufigsten Grund.
  /// </summary>
  public ReturnReason MostCommonReason()
  {
    ReturnReason best = ReturnReason.Disliked;
    int bestCount = 0;

    foreach (KeyValuePair<ReturnReason, int> entry in CountReasons())
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
  public Dictionary<string, decimal> RefundPerChild()
  {
    Dictionary<string, decimal> sums = new Dictionary<string, decimal>();
    foreach (Return r in _returns)
    {
      if (sums.ContainsKey(r.Child))
      {
        sums[r.Child] += r.Refund;
      }
      else
      {
        sums[r.Child] = r.Refund;
      }
    }

    return sums;
  }

  /// <summary>
  ///   Sucht die Retoure mit dem höchsten Preis.
  /// </summary>
  /// <returns>false, wenn es keine Retouren gibt.</returns>
  public bool TryFindMostExpensive(out Return mostExpensive)
  {
    mostExpensive = null;
    foreach (Return r in _returns)
    {
      if (mostExpensive == null || r.Price > mostExpensive.Price)
      {
        mostExpensive = r;
      }
    }

    return mostExpensive != null;
  }

  /// <summary>
  ///   Liefert einen kurzen Bericht für ein Kind.
  /// </summary>
  public string ReportFor(string child)
  {
    string report = $"Retouren von {child}:";
    decimal sum = 0;
    int count = 0;

    foreach (Return r in _returns)
    {
      if (r.Child == child)
      {
        report += $"\n  {r.Article,-12} {r.Reason,-10} {r.Refund,8:F2} CHF";
        sum += r.Refund;
        count++;
      }
    }

    if (count == 0)
    {
      return $"Keine Retouren von {child}.";
    }

    return report + $"\n  Total: {sum:F2} CHF";
  }
}
