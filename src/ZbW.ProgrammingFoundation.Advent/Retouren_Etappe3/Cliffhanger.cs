namespace ZbW.ProgrammingFoundation.Advent.Retouren_Etappe3;

// ============================================================
// CLIFFHANGER – Zwei identische Retouren (🔍 Was gibt das aus?)
//
// Starte im Menü mit C und schau dir die Ausgabe an.
// Warum ist das so? Notiere deine Vermutung.
// Am 9.2. lösen wir das Rätsel gemeinsam auf – hier gibt es keine Lösung.
//
// Damit das sofort läuft, verwendet diese Datei die Klasse Return aus _Loesung.
// ============================================================

public static class Cliffhanger
{
  /// <summary>
  ///   Vergleicht zwei Retouren und zwei Texte mit ==.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Cliffhanger ===\n");

    _Loesung.Return a = new("Velo", "Lena", 299m, _Loesung.ReturnReason.Disliked);
    _Loesung.Return b = new("Velo", "Lena", 299m, _Loesung.ReturnReason.Disliked);
    Console.WriteLine($"a == b: {a == b}");   // ???

    // Bonus: dasselbe mit zwei gleichen Texten
    string s1 = "Velo";
    Console.Write("\nTippe Velo und drücke Enter: ");
    string s2 = Console.ReadLine() ?? "";
    Console.WriteLine($"s1 == s2: {s1 == s2}"); // ???

    Console.WriteLine("\nDeine Vermutung? Notier sie dir und bring sie am 9.2. mit.");
  }
}
