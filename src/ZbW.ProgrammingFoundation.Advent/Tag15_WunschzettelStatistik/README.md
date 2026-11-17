# Tag 15 – Wunschzettel-Statistik

| Block | Format | Zeit |
|---|---|---|
| 04 | 🧩 Coden | 15′ |

## Story

Die Buchhaltung des Nordpols will wissen, was die Wünsche dieses Jahr kosten: Summe, teuerster Wunsch und Durchschnitt. Für die Statistik der Kinderalter braucht sie den Durchschnitt ein zweites Mal – diesmal für ganze Zahlen.

## Aufgabe

Implementiere in `WunschzettelStatistik.cs` ohne LINQ:

- `static decimal Sum(decimal[] values)`
- `static decimal Max(decimal[] values)`
- `static decimal Average(decimal[] values)`
- `static double Average(int[] values)` – eine **Überladung** mit demselben Namen

`Start()` gibt die Statistik als kleine Tabelle aus:

```text
Anzahl Wünsche :      6
Summe          : 412.30 CHF
Teuerster      : 189.00 CHF
Durchschnitt   :  68.72 CHF
Ø Alter        :   8.40 Jahre
```

Starten im Menü mit `15`.

## Hinweis

Für `Max` startest du mit dem ersten Element (`values[0]`) statt mit 0 – sonst gäbe es bei lauter negativen Werten ein falsches Ergebnis. Rechtsbündig formatieren: `{value,6:F2}`. Spickzettel Block 04 (04.07): «Methoden überladen».

## Lösung

`_Loesung/WunschzettelStatistikLoesung.cs`, im Menü mit `15L`.
