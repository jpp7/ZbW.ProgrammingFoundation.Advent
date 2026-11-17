# Tag 20 – ⭐ 4. Advent: Wunschzettel-Auswertung

| Block | Format | Zeit |
|---|---|---|
| 03–05 | 🧩 Coden | 40′ |

## Story

Am vierten Advent liegen alle Wunschzettel auf dem Tisch – leider als langer Text, den ein Elf abgetippt hat. Ein paar Zeilen sind dabei verrutscht. Der Weihnachtsmann will trotzdem wissen: Was wünschen sich die Kinder am häufigsten? Wer wünscht sich am meisten? Und wer alles will Lego?

## Aufgabe

In `WunschzettelAuswertung.cs` steht der Text schon als `string`:

```text
Lena: Velo, Buch, Lego
Noah: Lego, Schlitten
Mia: Puppe, Buch, Lego, Malkasten
Elias Velo, Helm
: Teddy
Lars:
Sofia: Malkasten
```

1. `static Dictionary<string, List<string>> ParseWishes(string text)`: Den Text in Zeilen zerlegen, jede Zeile in Name und Wünsche. Namen und Wünsche ohne Leerzeichen am Rand speichern. **Ungültige Zeilen** (kein `:`, leerer Name oder keine Wünsche) werden übersprungen und mit `"Übersprungen: …"` gemeldet.
2. `static string MostCommonWish(Dictionary<string, List<string>> wishes)`: der häufigste Wunsch.
3. `static string ChildWithMostWishes(Dictionary<string, List<string>> wishes)`: das Kind mit den meisten Wünschen.
4. `static List<string> ChildrenWishing(Dictionary<string, List<string>> wishes, string wish)`: alle Kinder, die sich `wish` wünschen.

Alles **ohne LINQ**. Starten im Menü mit `20`.

## Hinweis

`text.Split('\n')`, `line.Split(':')` und `part.Split(',')` zerlegen den Text; `.Trim()` entfernt Leerzeichen am Rand. Für den häufigsten Wunsch zählst du zuerst in einem `Dictionary<string, int>` und suchst danach das Maximum. Spickzettel Block 05 (05.07).

## Lösung

`_Loesung/WunschzettelAuswertungLoesung.cs`, im Menü mit `20L`. Erwartet: häufigster Wunsch Lego (3), meiste Wünsche Mia (4), Lego wünschen sich Lena, Noah, Mia; übersprungen werden 3 Zeilen.
