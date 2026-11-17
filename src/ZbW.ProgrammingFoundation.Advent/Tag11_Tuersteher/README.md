# Tag 11 – Der geduldige Türsteher

| Block | Format | Zeit |
|---|---|---|
| 03 | 🧩 Coden | 10′ |

## Story

Vor dem Adventskalender der Werkstatt steht ein Türsteher-Elf. Er lässt nur durch, wer eine gültige Türchen-Nummer nennt. Und er ist geduldig: Er fragt so lange nach, bis es passt.

## Aufgabe

Implementiere in `Tuersteher.cs` die Methode `static int ReadDoorNumber()`:

- Mit `do-while` und `int.TryParse` so lange nachfragen, bis eine Zahl von 1 bis 24 eingegeben ist.
- Passende Meldung je nach Fehler:
  - keine Zahl → `"Das ist keine Zahl."`
  - Zahl ausserhalb 1–24 → `"Türchen 1 bis 24, bitte."`
- Rückgabe: die gültige Nummer.

`Start()` ruft die Methode auf und gibt `"Türchen 7 geöffnet!"` aus. Starten im Menü mit `11`.

## Hinweis

- Eine `bool`-Variable `isValid` als Schleifenbedingung macht den Code lesbar.
- Erst prüfen, ob es überhaupt eine Zahl ist. Den Bereich nur prüfen, wenn das geklappt hat.
- Spickzettel Block 03 (03.07): `do-while`.

## Lösung

`_Loesung/TuersteherLoesung.cs`, im Menü mit `11L`.
