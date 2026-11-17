# Tag 23 – Rentier mit Ausdauer

| Block | Format | Zeit |
|---|---|---|
| 06 | 🧩 Coden | 20′ |

## Story

Morgen ist der grosse Flug. Der Stallmeister will vorher wissen, wie weit jedes Rentier kommt. Und er will sicher sein, dass niemand die Energie eines Rentiers einfach auf 100 setzt, ohne es zu füttern.

## Aufgabe

Schreibe in `Reindeer.cs` die Klasse `Reindeer`:

- `Name` (wird im Konstruktor gesetzt)
- `Energy` von 0 bis 100, startet bei 100. Von aussen nur lesbar (`private set`).
- `bool Fly(int km)`: Pro volle 10 km wird 1 Energie verbraucht (`km / 10`). Reicht die Energie nicht, wird **nicht** geflogen, und die Methode gibt `false` zurück. Negative Kilometer lösen eine `ArgumentException` aus.
- `void Feed()`: +30 Energie, höchstens 100.
- `ToString()`: z. B. `"Rudolph (Energie 70)"`

In `Rentier.cs` testest du in `Start()`: ein Rentier fliegt mehrmals, bis die Energie nicht mehr reicht, wird gefüttert und fliegt weiter.

Starten im Menü mit `23`.

## Hinweis

Versuch einmal `rudolph.Energy = 100;` in `Start()` – der Compiler muss das verbieten. Genau das ist Kapselung. Spickzettel Block 06 (06.07): Auto-Properties.

## Lösung

`_Loesung/Reindeer.cs` und `_Loesung/RentierLoesung.cs`, im Menü mit `23L`.
