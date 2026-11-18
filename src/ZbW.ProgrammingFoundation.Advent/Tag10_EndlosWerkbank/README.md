# Tag 10 – Die Endlos-Werkbank

| Block | Format | Zeit |
|---|---|---|
| 03 | 🐞 Bug-Jagd | 15′ |

## Story

Die neue Werkbank soll Spielzeug bauen, bis 10 Stück fertig sind. Stattdessen läuft sie die ganze Nacht durch. Ausserdem wählt sie das Spielzeug nicht wirklich zufällig, und wenn ein Elf eine falsche Zahl eintippt, passiert – gar nichts. Nicht einmal eine Meldung.

## Aufgabe

In `EndlosWerkbank.cs` stecken **drei Fehler**:

1. Eine Schleife, die nie abbricht.
2. `new Random()` wird in jeder Iteration neu erzeugt.
3. Ein `catch`, der jeden Fehler ohne Meldung verschluckt.

Behebe alle drei und schreib zu jedem einen kurzen Kommentar: Warum war das ein Problem?

> ⚠️ Startest du die Werkbank unverändert (Menü `10`), läuft sie endlos – das gehört zur Übung. Abbrechen mit **Ctrl+C** oder im Debugger mit **Pause** (Rider/Visual Studio: «Break All»): Dann siehst du, in welcher Zeile die Schleife hängt und welchen Wert `built` hat. Besser noch: zuerst den Code lesen.

## Hinweis

- Die Werkbank baut pro Durchgang 3 Spielzeuge. Erreicht der Zähler je **genau** 10? Und wenn du es korrigierst: Ist 12 statt 10 okay? (Für die Werkstatt ja – gemeint ist «mindestens 10».)
- Ein `Random` gehört einmal vor die Schleife. In älterem .NET lieferten schnell hintereinander erzeugte Objekte sogar dieselben Zahlen; heute ist es vor allem unnötig und unklar.
- Ein leerer `catch { }` versteckt Fehler. Fang nur, was du erwartest, und gib eine Meldung aus. Bei `int.Parse` sind das zwei Fälle: `FormatException` (`viele`) und `OverflowException` (`99999999999`). Ohne Exceptions geht es mit `int.TryParse`.
- Spickzettel Block 03 (03.07): Schleifen, `Random`, `try/catch`.

## Lösung

`_Loesung/EndlosWerkbankLoesung.cs`, im Menü mit `10L`. Jede Korrektur ist mit `// FIX` markiert.
