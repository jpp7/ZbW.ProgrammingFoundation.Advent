namespace ZbW.ProgrammingFoundation.Advent.Tag14_WunschzettelIndex;

// ============================================================
// TAG 14 – Der Wunschzettel-Index (🔍 Was gibt das aus? | ⭐ Einfach | ~10 Min.)
//
// Array-Index, Value Type und Reference Type als Parameter.
//
// Anforderungen:
//   - Ausgaben A bis E vorhersagen, danach starten (Menü: 14)
//   - Erklären: Warum ändert sich das eine Original und das andere nicht?
// ============================================================

public static class WunschzettelIndex
{
  /// <summary>
  ///   Verdoppelt einen Wert – oder versucht es zumindest.
  /// </summary>
  /// <param name="x">Der Wert.</param>
  public static void DoubleValue(int x)
  {
    x = x * 2;
  }

  /// <summary>
  ///   Fügt der Liste einen Wunsch hinzu.
  /// </summary>
  /// <param name="list">Die Wunschliste.</param>
  public static void AddWish(List<string> list)
  {
    list.Add("Schlitten");
  }

  /// <summary>
  ///   Gibt die Ausgaben A bis E aus.
  /// </summary>
  public static void Start()
  {
    string[] wishes = { "Velo", "Buch", "Lego", "Pulli" };

    Console.WriteLine($"A: {wishes[wishes.Length - 1]}");   // Vermutung: ___
    Console.WriteLine($"B: {wishes[1]}");                   // Vermutung: ___

    int gifts = 5;
    DoubleValue(gifts);
    Console.WriteLine($"C: {gifts}");                       // Vermutung: ___

    List<string> wishList = new List<string> { "Velo" };
    AddWish(wishList);
    Console.WriteLine($"D: {wishList.Count}");              // Vermutung: ___
    Console.WriteLine($"E: {wishList[wishList.Count - 1]}"); // Vermutung: ___
  }
}
