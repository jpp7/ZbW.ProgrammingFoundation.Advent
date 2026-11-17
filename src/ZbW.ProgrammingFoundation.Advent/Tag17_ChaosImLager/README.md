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

Starte die App **im Debugger** (Rider: Debug, Visual Studio: F5) und wähle im Menü `17`. Der Absturz gehört zur Übung:

1. Der Debugger hält bei der Exception an. Lies den **Typ** der Exception und die **Meldung**.
2. Schau dir den **Stacktrace** an: Die oberste Zeile aus `ChaosImLager.cs` zeigt dir Datei und Zeilennummer.
3. Behebe den Fehler, starte erneut – so lange, bis das Programm ohne Exception durchläuft.

## Hinweis

Arrays haben `.Length`, Listen `.Count`. Mit `TryGetValue` oder `ContainsKey` fragst du ein Dictionary ohne Absturz ab. Während einer `foreach`-Schleife darf die Liste nicht verändert werden – rückwärts mit `for` geht. Spickzettel Block 04 und 05.

## Lösung

`_Loesung/ChaosImLagerLoesung.cs`, im Menü mit `17L`. Jede Korrektur ist mit `// FIX` markiert.
