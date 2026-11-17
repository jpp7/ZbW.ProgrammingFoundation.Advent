namespace ZbW.ProgrammingFoundation.Advent.Tag14_WunschzettelIndex._Loesung;

/// <summary>
///   Musterlösung: Tag 14 – Der Wunschzettel-Index
/// </summary>
public static class WunschzettelIndexLoesung
{
  /// <summary>
  ///   Verdoppelt nur die lokale Kopie von x.
  /// </summary>
  public static void DoubleValue(int x)
  {
    x = x * 2;
  }

  /// <summary>
  ///   Fügt der übergebenen (gemeinsamen) Liste einen Wunsch hinzu.
  /// </summary>
  public static void AddWish(List<string> list)
  {
    list.Add("Schlitten");
  }

  /// <summary>
  ///   Gibt die Ausgaben aus. Die Erklärung steht jeweils im Kommentar.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Der Wunschzettel-Index – Lösung ===\n");

    string[] wishes = { "Velo", "Buch", "Lego", "Pulli" };

    // A: Pulli. Length ist 4, der letzte Index ist 4 - 1 = 3.
    Console.WriteLine($"A: {wishes[wishes.Length - 1]}");

    // B: Buch. Der Index beginnt bei 0, [1] ist also das zweite Element.
    Console.WriteLine($"B: {wishes[1]}");

    // C: 5. int ist ein Value Type. DoubleValue bekommt eine KOPIE von gifts
    //    und verdoppelt nur diese Kopie. Das Original bleibt 5.
    int gifts = 5;
    DoubleValue(gifts);
    Console.WriteLine($"C: {gifts}");

    // D: 2. List<string> ist ein Reference Type. AddWish bekommt einen Verweis
    //    auf DIESELBE Liste und fügt dort "Schlitten" hinzu.
    List<string> wishList = new List<string> { "Velo" };
    AddWish(wishList);
    Console.WriteLine($"D: {wishList.Count}");

    // E: Schlitten. Das zuletzt hinzugefügte Element.
    Console.WriteLine($"E: {wishList[wishList.Count - 1]}");

    // Merksatz: Bei einem Value Type wird der Wert kopiert,
    //           bei einem Reference Type der Verweis auf dasselbe Objekt.
  }
}
