# Tag 3 – Der verwirrte Elf

| Block | Format | Zeit |
|---|---|---|
| 01 | 🐞 Bug-Jagd | 10′ |

## Story

Elf Pips hat ein Programm für die Guetzli-Verteilung geschrieben. Es läuft, aber die Resultate sind seltsam: Jeder Elf bekommt «Rute statt Guetzli», die Guetzli kosten nichts, und bei einer falschen Eingabe stürzt alles ab.

## Aufgabe

In `VerwirrterElf.cs` stecken **vier Fehler**. Finde und behebe sie:

1. Eine Bedingung, die immer wahr ist.
2. Ein Preis, der nicht kompiliert hat – Pips hat die Zeile deshalb auskommentiert und rechnet mit 0 weiter.
3. Ein Absturz, wenn jemand «viele» statt einer Zahl eintippt.
4. Eine Division, bei der Nachkommastellen verloren gehen.

Starten im Menü mit `3`. Probier auch eine ungültige Eingabe aus.

## Hinweis

- Vergleichen geht mit `==`, zuweisen mit `=`. Bei `bool` kompiliert beides – leider.
- Ein `decimal`-Literal braucht ein `m`: `0.40m`.
- Benutzereingaben immer mit `TryParse` prüfen.
- `int / int` schneidet ab. Erst umwandeln, dann teilen.
- Spickzettel Block 01 (01.07).

## Lösung

`_Loesung/VerwirrterElfLoesung.cs`, im Menü mit `3L`. Jede Korrektur ist mit `// FIX` markiert.
