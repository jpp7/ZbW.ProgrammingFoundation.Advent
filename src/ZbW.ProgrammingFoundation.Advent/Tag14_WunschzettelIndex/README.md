# Tag 14 – Der Wunschzettel-Index

| Block | Format | Zeit |
|---|---|---|
| 04–05 | 🔍 Was gibt das aus? | 10′ |

## Story

Im Archiv liegen die Wunschzettel als Array und als Liste. Elf Lumi hat zwei Methoden geschrieben, die sie verändern sollen. Seltsam: Die eine Methode ändert das Original, die andere nicht.

## Aufgabe

1. Lies `WunschzettelIndex.cs` und sag für die Ausgaben A bis E vorher, was erscheint.
2. Starte im Menü mit `14` und vergleiche.
3. Erkläre in einem Satz: Warum ändert `DoubleValue` die Variable `gifts` **nicht**, `AddWish` die Liste `wishList` aber **schon**?

## Hinweis

`int` ist ein Value Type: Die Methode bekommt eine Kopie. `List<string>` ist ein Reference Type: Die Methode bekommt einen Verweis auf dieselbe Liste. Spickzettel Block 05 (05.07): «Value Type als Kopie», «Reference Type als gemeinsame Referenz».

## Lösung

`_Loesung/WunschzettelIndexLoesung.cs`, im Menü mit `14L`.
