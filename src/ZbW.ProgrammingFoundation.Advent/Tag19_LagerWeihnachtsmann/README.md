# Tag 19 – Das Lager des Weihnachtsmanns

| Block | Format | Zeit |
|---|---|---|
| 05 | 🧩 Coden | 20′ |

## Story

Das Hauptlager wird digital. Lieferungen kommen in Schüben, Elfen holen einzelne Spielzeuge ab, und der Weihnachtsmann will jederzeit eine Übersicht – mal mit eigenem Titel, mal ohne.

## Aufgabe

Der Bestand ist ein `Dictionary<string, int>` (Spielzeug → Anzahl). Implementiere in `LagerWeihnachtsmann.cs`:

- `static void AddMany(Dictionary<string, int> stock, params string[] toys)`: Jedes übergebene Spielzeug erhöht den Bestand um 1. Neue Spielzeuge werden angelegt.
- `static bool TryTake(Dictionary<string, int> stock, string toy, out int remaining)`: Nimmt ein Stück heraus. Gibt `false` zurück, wenn das Spielzeug fehlt oder der Bestand 0 ist. `remaining` enthält den Bestand danach.
- `static void PrintStock(Dictionary<string, int> stock, string title = "Lager")`: gibt den Bestand mit Titel aus. Der Titel ist **optional**.

`Start()` zeigt alle drei Methoden in Aktion. Starten im Menü mit `19`.

## Hinweis

`params` erlaubt den Aufruf `AddMany(stock, "Teddy", "Teddy", "Kreisel")` ohne Array. Bei `out` muss die Methode dem Parameter auf jedem Weg einen Wert zuweisen – auch beim `return false`. Spickzettel Block 05 (05.07): «Methoden-Signatur».

## Lösung

`_Loesung/LagerWeihnachtsmannLoesung.cs`, im Menü mit `19L`.
