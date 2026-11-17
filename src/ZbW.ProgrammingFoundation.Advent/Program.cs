using System.Text;

namespace ZbW.ProgrammingFoundation.Advent;

// ============================================================
// ADVENTSKALENDER – STARTMENÜ
//
// Türchen wählen und starten:
//   7    → deine Version von Tag 7 (Aufgabenordner)
//   7L   → die Musterlösung von Tag 7 (_Loesung)
//   E1   → Retouren-Werkstatt, Etappe 1 (E1L = Lösung)
//   C    → Cliffhanger aus Etappe 3
//   0    → Beenden
//
// Direktstart ohne Menü: dotnet run -- 7L
// An dieser Datei musst du nichts ändern.
// ============================================================

internal static class Program
{
  private static void Main(string[] args)
  {
    // Damit Emojis wie 🎄 und 🕯️ in der Konsole erscheinen.
    Console.OutputEncoding = Encoding.UTF8;

    if (args.Length > 0)
    {
      Run(args[0]);
      return;
    }

    while (true)
    {
      PrintMenu();
      Console.Write("Türchen: ");
      string input = Console.ReadLine();

      if (input == null || input.Trim() == "0")
      {
        Console.WriteLine("Bis morgen! 🎄");
        return;
      }

      Run(input);

      Console.WriteLine("\n[Enter] zurück zum Menü");
      if (Console.ReadLine() == null)
      {
        return;
      }
    }
  }

  private static void PrintMenu()
  {
    Console.WriteLine();
    Console.WriteLine("🎄 Adventskalender Programming Foundation 🎄");
    Console.WriteLine("Woche 1   1 Rechenmaschine        2 Geschenkpapier        3 Verwirrter Elf");
    Console.WriteLine("          4 Wichtel-Geschenk      5 Flugwetter            6 ⭐ Guetzli-Bäckerei");
    Console.WriteLine("Woche 2   7 Countdown             8 Elf im Kreis          9 Tannenbaum");
    Console.WriteLine("         10 Endlos-Werkbank      11 Türsteher            12 Lebkuchen-Pasch");
    Console.WriteLine("         13 ⭐ Kamin-Knacker");
    Console.WriteLine("Woche 3  14 Wunschzettel-Index   15 Wunschzettel-Statistik 16 Kalender-Raster");
    Console.WriteLine("         17 Chaos im Lager       18 Wichtel-Losung       19 Lager");
    Console.WriteLine("         20 ⭐ Wunschzettel-Auswertung");
    Console.WriteLine("Woche 4  21 Klasse Gift          22 Zwei Elfen           23 Rentier");
    Console.WriteLine("         24 🎄 Schlittentour");
    Console.WriteLine("Retouren E1 Erfassen  E2 Auswerten  E3 Klassen  C Cliffhanger");
    Console.WriteLine("Lösung: Nummer + L (z. B. 7L)   Beenden: 0");
  }

  /// <summary>
  ///   Startet das gewählte Türchen. Fehlt die Implementierung noch, erscheint ein Hinweis statt eines Absturzes.
  /// </summary>
  private static void Run(string choice)
  {
    string key = choice.Trim().ToUpperInvariant();
    Console.WriteLine();

    try
    {
      switch (key)
      {
        // ---- Woche 1 ----
        case "1": Tag01_Rechenmaschine.Rechenmaschine.Start(); break;
        case "1L": Tag01_Rechenmaschine._Loesung.RechenmaschineLoesung.Start(); break;
        case "2": Tag02_Geschenkpapier.Geschenkpapier.Start(); break;
        case "2L": Tag02_Geschenkpapier._Loesung.GeschenkpapierLoesung.Start(); break;
        case "3": Tag03_VerwirrterElf.VerwirrterElf.Start(); break;
        case "3L": Tag03_VerwirrterElf._Loesung.VerwirrterElfLoesung.Start(); break;
        case "4": Tag04_WichtelGeschenk.WichtelGeschenk.Start(); break;
        case "4L": Tag04_WichtelGeschenk._Loesung.WichtelGeschenkLoesung.Start(); break;
        case "5": Tag05_Flugwetter.Flugwetter.Start(); break;
        case "5L": Tag05_Flugwetter._Loesung.FlugwetterLoesung.Start(); break;
        case "6": Tag06_GuetzliBaeckerei.GuetzliBaeckerei.Start(); break;
        case "6L": Tag06_GuetzliBaeckerei._Loesung.GuetzliBaeckereiLoesung.Start(); break;

        // ---- Woche 2 ----
        case "7": Tag07_Countdown.Countdown.Start(); break;
        case "7L": Tag07_Countdown._Loesung.CountdownLoesung.Start(); break;
        case "8": Tag08_ElfImKreis.ElfImKreis.Start(); break;
        case "8L": Tag08_ElfImKreis._Loesung.ElfImKreisLoesung.Start(); break;
        case "9": Tag09_Tannenbaum.Tannenbaum.Start(); break;
        case "9L": Tag09_Tannenbaum._Loesung.TannenbaumLoesung.Start(); break;
        case "10": Tag10_EndlosWerkbank.EndlosWerkbank.Start(); break;
        case "10L": Tag10_EndlosWerkbank._Loesung.EndlosWerkbankLoesung.Start(); break;
        case "11": Tag11_Tuersteher.Tuersteher.Start(); break;
        case "11L": Tag11_Tuersteher._Loesung.TuersteherLoesung.Start(); break;
        case "12": Tag12_LebkuchenPasch.LebkuchenPasch.Start(); break;
        case "12L": Tag12_LebkuchenPasch._Loesung.LebkuchenPaschLoesung.Start(); break;
        case "13": Tag13_KaminKnacker.KaminKnacker.Start(); break;
        case "13L": Tag13_KaminKnacker._Loesung.KaminKnackerLoesung.Start(); break;

        // ---- Woche 3 ----
        case "14": Tag14_WunschzettelIndex.WunschzettelIndex.Start(); break;
        case "14L": Tag14_WunschzettelIndex._Loesung.WunschzettelIndexLoesung.Start(); break;
        case "15": Tag15_WunschzettelStatistik.WunschzettelStatistik.Start(); break;
        case "15L": Tag15_WunschzettelStatistik._Loesung.WunschzettelStatistikLoesung.Start(); break;
        case "16": Tag16_KalenderRaster.KalenderRaster.Start(); break;
        case "16L": Tag16_KalenderRaster._Loesung.KalenderRasterLoesung.Start(); break;
        case "17": Tag17_ChaosImLager.ChaosImLager.Start(); break;
        case "17L": Tag17_ChaosImLager._Loesung.ChaosImLagerLoesung.Start(); break;
        case "18": Tag18_WichtelLosung.WichtelLosung.Start(); break;
        case "18L": Tag18_WichtelLosung._Loesung.WichtelLosungLoesung.Start(); break;
        case "19": Tag19_LagerWeihnachtsmann.LagerWeihnachtsmann.Start(); break;
        case "19L": Tag19_LagerWeihnachtsmann._Loesung.LagerWeihnachtsmannLoesung.Start(); break;
        case "20": Tag20_WunschzettelAuswertung.WunschzettelAuswertung.Start(); break;
        case "20L": Tag20_WunschzettelAuswertung._Loesung.WunschzettelAuswertungLoesung.Start(); break;

        // ---- Woche 4 ----
        case "21": Tag21_KlasseGift.KlasseGift.Start(); break;
        case "21L": Tag21_KlasseGift._Loesung.KlasseGiftLoesung.Start(); break;
        case "22": Tag22_ZweiElfen.ZweiElfen.Start(); break;
        case "22L": Tag22_ZweiElfen._Loesung.ZweiElfenLoesung.Start(); break;
        case "23": Tag23_Rentier.Rentier.Start(); break;
        case "23L": Tag23_Rentier._Loesung.RentierLoesung.Start(); break;
        case "24": Tag24_Schlittentour.Schlittentour.Start(); break;
        case "24L": Tag24_Schlittentour._Loesung.SchlittentourLoesung.Start(); break;

        // ---- Retouren-Werkstatt ----
        case "E1": Retouren_Etappe1.RetourenEtappe1.Start(); break;
        case "E1L": Retouren_Etappe1._Loesung.RetourenEtappe1Loesung.Start(); break;
        case "E2": Retouren_Etappe2.RetourenEtappe2.Start(); break;
        case "E2L": Retouren_Etappe2._Loesung.RetourenEtappe2Loesung.Start(); break;
        case "E3": Retouren_Etappe3.RetourenEtappe3.Start(); break;
        case "E3L": Retouren_Etappe3._Loesung.RetourenEtappe3Loesung.Start(); break;
        case "C": Retouren_Etappe3.Cliffhanger.Start(); break;

        default:
          Console.WriteLine($"Unbekannte Auswahl: \"{choice}\"");
          break;
      }
    }
    catch (NotImplementedException ex)
    {
      Console.WriteLine($"🚧 Noch nicht fertig: {ex.Message}");
      Console.WriteLine("   Öffne den Aufgabenordner, lies README.md und leg los.");
    }
  }
}
