namespace ZbW.ProgrammingFoundation.Advent.Tag10_EndlosWerkbank._Loesung;

/// <summary>
///   Musterlösung: Tag 10 – Die Endlos-Werkbank
/// </summary>
public static class EndlosWerkbankLoesung
{
  /// <summary>
  ///   Startet die korrigierte Werkbank.
  /// </summary>
  public static void Start()
  {
    Console.WriteLine("=== Die Endlos-Werkbank – Lösung ===\n");

    string[] toyNames = { "Teddy", "Holzauto", "Kreisel", "Puppe" };

    // FIX 2: Random einmal VOR der Schleife erzeugen und wiederverwenden.
    //        In jeder Iteration ein neues Objekt ist unnötig. In älterem .NET
    //        lieferten so erzeugte Objekte sogar dieselben "Zufalls"zahlen.
    Random random = new Random();

    int built = 0;

    // FIX 1: built springt 0, 3, 6, 9, 12, ... und ist nie genau 10.
    //        Mit < statt != stoppt die Schleife, sobald 10 erreicht oder überschritten sind.
    while (built < 10)
    {
      string toy = toyNames[random.Next(toyNames.Length)];

      built += 3;
      Console.WriteLine($"3 × {toy} gebaut, total {built}");
    }

    Console.Write("Wie viele Spielzeuge willst du einpacken? ");
    try
    {
      int toPack = int.Parse(Console.ReadLine());
      Console.WriteLine($"{toPack} Spielzeuge eingepackt.");
    }
    catch (FormatException)
    {
      // FIX 3: Nur den erwarteten Fehler fangen und eine Meldung ausgeben.
      //        Ein leerer catch versteckt jeden Fehler – auch solche, die man sehen müsste.
      //        Alternative ohne Exception: int.TryParse.
      Console.WriteLine("Das war keine ganze Zahl. Es wurde nichts eingepackt.");
    }
  }
}
