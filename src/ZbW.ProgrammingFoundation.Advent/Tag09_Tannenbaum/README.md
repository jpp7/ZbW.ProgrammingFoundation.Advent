# Tag 9 – Tannenbaum in der Konsole

| Block | Format | Zeit |
|---|---|---|
| 03 | 🧩 Coden | 15′ |

## Story

Die Werkstatt braucht Weihnachtsdekoration, aber das Budget ist aufgebraucht. Zum Glück gibt es die Konsole: Ein Baum aus Sternchen kostet nichts.

## Aufgabe

In `Tannenbaum.cs`:

- Höhe einlesen (3 bis 15), mit `TryParse` und Bereichsprüfung.
- Mit verschachtelten Schleifen einen Baum zeichnen: Zeile `row` (ab 0) hat `height - row - 1` Leerzeichen und `2 * row + 1` Sterne.
- Darunter ein Stamm `|`, mittig.

Beispiel mit Höhe 4:

```text
   *
  ***
 *****
*******
   |
```

**Bonus:** Mit `Random` wird etwa jeder fünfte `*` zu einem `o` (Kugel).

Starten im Menü mit `9`.

## Hinweis

- Äussere Schleife: Zeilen. Innere Schleifen: zuerst Leerzeichen, dann Sterne.
- Der Stamm braucht `height - 1` Leerzeichen davor.
- Bonus: `random.Next(5) == 0` ist in etwa 20 % der Fälle wahr. Das `Random`-Objekt nur einmal erzeugen.
- Spickzettel Block 03 (03.07): verschachtelte Schleifen, `Random`.

## Lösung

`_Loesung/TannenbaumLoesung.cs`, im Menü mit `9L`.
