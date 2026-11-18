namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe3._Loesung;

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
///   Musterlösung: Eine einzelne Retoure.
/// </summary>
public class Return
{
  public const decimal DefaultRefundRate = 0.8m;

  private decimal _price;

  /// <summary>
  ///   Erstellt eine Retoure.
  /// </summary>
  /// <param name="child">Name des Kindes.</param>
  /// <param name="article">Zurückgegebener Artikel.</param>
  /// <param name="price">Preis in CHF, grösser als 0.</param>
  /// <param name="reason">Grund der Retoure.</param>
  /// <exception cref="ArgumentException">Bei leerem Namen, leerem Artikel oder Preis ≤ 0.</exception>
  public Return(string child, string article, decimal price, ReturnReason reason)
  {
    if (string.IsNullOrWhiteSpace(child))
    {
      throw new ArgumentException("Der Name des Kindes darf nicht leer sein.");
    }

    if (string.IsNullOrWhiteSpace(article))
    {
      throw new ArgumentException("Der Artikel darf nicht leer sein.");
    }

    Child = child.Trim();
    Article = article.Trim();
    Price = price;
    Reason = reason;
  }

  /// <summary>
  ///   Name des Kindes.
  /// </summary>
  public string Child { get; }

  /// <summary>
  ///   Zurückgegebener Artikel.
  /// </summary>
  public string Article { get; }

  /// <summary>
  ///   Preis in CHF. Muss grösser als 0 sein.
  /// </summary>
  public decimal Price
  {
    get { return _price; }
    private set
    {
      if (value <= 0)
      {
        throw new ArgumentException("Der Preis muss grösser als 0 sein.");
      }

      _price = value;
    }
  }

  /// <summary>
  ///   Grund der Retoure.
  /// </summary>
  public ReturnReason Reason { get; }

  /// <summary>
  ///   Rückerstattung: defekt 100 %, sonst 80 %. Wird berechnet, nicht gespeichert.
  /// </summary>
  public decimal Refund
  {
    get { return Reason == ReturnReason.Broken ? Price : Price * DefaultRefundRate; }
  }

  /// <summary>
  ///   Liefert eine Tabellenzeile für die Retoure.
  /// </summary>
  public override string ToString()
  {
    return $"{Child,-8} {Article,-12} {Price,8:F2} {Reason,-10} {Refund,8:F2}";
  }
}
