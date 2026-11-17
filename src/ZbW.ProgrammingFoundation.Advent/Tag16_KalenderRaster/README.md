# Tag 16 – Das Kalender-Raster

| Block | Format | Zeit |
|---|---|---|
| 04 | 🧩 Coden | 20′ |

## Story

Nächstes Jahr bekommt die Werkstatt einen eigenen Adventskalender – mit gemischten Türchen, wie es sich gehört. Die Druckerei braucht dafür ein Raster mit 4 Zeilen und 6 Spalten.

## Aufgabe

In `KalenderRaster.cs`:

- `static int[,] CreateGrid()`: legt ein `int[4, 6]` an und füllt es der Reihe nach mit 1 bis 24.
- `static void Shuffle(int[,] grid, Random random)`: mischt das Raster mit dem **Tausch-Verfahren**: 100-mal zwei zufällige Positionen wählen und deren Werte tauschen.
- `static void PrintGrid(int[,] grid)`: gibt das Raster mit fester Breite pro Zahl aus.

**Bonus:** `static bool IsValid(int[,] grid)` prüft, ob jede Zahl von 1 bis 24 genau einmal vorkommt.

Starten im Menü mit `16`.

## Hinweis

Zeilen und Spalten erhältst du mit `grid.GetLength(0)` und `grid.GetLength(1)`. Tauschen geht über eine Hilfsvariable: `int temp = a; a = b; b = temp;`. Für den Bonus hilft ein `bool[] seen = new bool[25];`. Spickzettel Block 04 (04.07): mehrdimensionale Arrays.

## Lösung

`_Loesung/KalenderRasterLoesung.cs`, im Menü mit `16L`.
