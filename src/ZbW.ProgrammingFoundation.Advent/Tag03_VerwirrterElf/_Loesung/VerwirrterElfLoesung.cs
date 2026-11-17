namespace ZbW.ProgrammingFoundation.Advent.Tag03_VerwirrterElf._Loesung;

/// <summary>
///   Musterlösung: Tag 3 – Der verwirrte Elf
/// </summary>
public static class VerwirrterElfLoesung
{
  /// <summary>
  ///   Startet die korrigierte Guetzli-Verteilung.
  /// </summary>
  public static void Start()
  {
    const int ElfCount = 4;

    // FIX 2: decimal-Literale brauchen ein m. Ohne m ist 0.40 ein double,
    //        und double lässt sich nicht automatisch in decimal umwandeln.
    decimal pricePerCookie = 0.40m;

    Console.Write("Wie viele Guetzli sind in der Dose? ");

    // FIX 3: int.Parse stürzt bei "viele" mit einer FormatException ab.
    //        TryParse liefert stattdessen false.
    if (!int.TryParse(Console.ReadLine(), out int cookies) || cookies < 0)
    {
      Console.WriteLine("Bitte eine ganze Zahl ab 0 eingeben.");
      return;
    }

    // FIX 4: int / int schneidet die Nachkommastellen ab (10 / 4 = 2).
    //        Mit dem Cast wird als double gerechnet (10.0 / 4 = 2.5).
    double cookiesPerElf = (double)cookies / ElfCount;
    decimal totalPrice = cookies * pricePerCookie;

    Console.WriteLine($"Jeder Elf bekommt {cookiesPerElf:F2} Guetzli.");
    Console.WriteLine($"Die Dose ist {totalPrice:F2} CHF wert.");

    bool isNaughty = false;

    // FIX 1: = weist true zu, die Bedingung war deshalb immer wahr.
    //        == vergleicht. Noch kürzer: if (isNaughty)
    if (isNaughty == true)
    {
      Console.WriteLine("Rute statt Guetzli!");
    }
    else
    {
      Console.WriteLine("Brav gewesen, guten Appetit!");
    }
  }
}
