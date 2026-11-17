namespace ZbW.ProgrammingFoundation.Advent.Tag08_ElfImKreis._Loesung;

/// <summary>
///   Musterlösung: Tag 8 – Elf im Kreis
/// </summary>
public static class ElfImKreisLoesung
{
  /// <summary>
  ///   Führt die Schleifen aus. Die Erklärung steht jeweils im Kommentar.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Elf im Kreis – Lösung ===\n");

    // A: 3 Durchläufe, Ausgabe "10 6 2".
    //    Danach ist a = -2, die Bedingung a > 0 ist falsch.
    Console.Write("A: ");
    int a = 10;
    while (a > 0)
    {
      Console.Write(a + " ");
      a -= 4;
    }

    Console.WriteLine();

    // B: 1 Durchlauf, Ausgabe "100".
    //    Die Bedingung b < 100 ist schon beim ersten Prüfen falsch,
    //    aber do-while prüft erst NACH dem ersten Durchlauf.
    Console.Write("B: ");
    int b = 100;
    do
    {
      Console.Write(b + " ");
      b++;
    } while (b < 100);

    Console.WriteLine();

    // C: 4 Durchläufe, Ausgabe "1 4 7 10".
    //    Nach 10 kommt 13, und 13 < 12 ist falsch.
    Console.Write("C: ");
    for (int i = 1; i < 12; i += 3)
    {
      Console.Write(i + " ");
    }

    Console.WriteLine();

    // D: Mit i <= 5 läuft die Schleife für 0, 1, 2, 3, 4, 5 – also 6-mal.
    //    FIX: Ab 0 zählen und < verwenden (oder ab 1 zählen und <=).
    int giftCount = 0;
    for (int i = 0; i < 5; i++)
    {
      giftCount++;
    }

    Console.WriteLine($"D: {giftCount} Geschenke verteilt (erwartet: 5)");
  }
}
