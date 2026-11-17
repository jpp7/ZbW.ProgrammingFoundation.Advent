# Tag 17 – Chaos im Lager

| Block | Format | Zeit |
|---|---|---|
| 04–05 | 🐞 Bug-Jagd | 15′ |

## Story

Inventur im Spielzeuglager. Der Lager-Elf hat ein Programm geschrieben, das Regale durchzählt, den Bestand anzeigt und kaputtes Spielzeug aussortiert. Leider stürzt es bei jedem Schritt ab – und wo es nicht abstürzt, zählt es falsch.

## Aufgabe

In `ChaosImLager.cs` stecken **vier Fehler**:

1. Eine `IndexOutOfRangeException` beim Durchzählen des Regals.
2. Eine Anzahl, die nicht mehr stimmt, sobald jemand etwas einlagert. (Die ursprüngliche Zeile mit `.Length` hat nicht kompiliert.)
3. Eine `KeyNotFoundException` bei der Bestandsabfrage.
4. Eine `InvalidOperationException` beim Aussortieren.

Starte im Menü mit `17`, lies die Fehlermeldung, behebe den Fehler, starte erneut. So lange, bis alles läuft.

## Hinweis

Arrays haben `.Length`, Listen `.Count`. Mit `TryGetValue` oder `ContainsKey` fragst du ein Dictionary ohne Absturz ab. Während einer `foreach`-Schleife darf die Liste nicht verändert werden – rückwärts mit `for` geht. Spickzettel Block 04 und 05.

## Lösung

`_Loesung/ChaosImLagerLoesung.cs`, im Menü mit `17L`. Jede Korrektur ist mit `// FIX` markiert.
