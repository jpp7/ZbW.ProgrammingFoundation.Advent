# Tag 5 – Rentier-Flugwetter

| Block | Format | Zeit |
|---|---|---|
| 02 | 🧩 Coden | 15′ |

## Story

Bevor die Rentiere abheben, schaut der Fluglotse auf das Wetter. Bei Sturm bleibt der Schlitten am Boden, bei Nebel muss Rudolph mit seiner roten Nase vorne fliegen.

## Aufgabe

In `Flugwetter.cs` gibt es schon das `enum Weather { Clear, Snow, Storm, Fog }`.

- Implementiere `static string GetClearance(Weather weather)` mit einer **switch expression**:
  - `Clear` → `"Start frei"`
  - `Snow` → `"Start frei, langsam fliegen"`
  - `Storm` → `"Kein Start"`
  - `Fog` → `"Start frei"`
- Implementiere `static string GetFlightInfo(Weather weather)`: Sie hängt mit dem **ternären Operator** bei Nebel `" – Rudolph vorne!"` an die Freigabe an.
- `Start()` gibt alle vier Wetterlagen aus.

Starten im Menü mit `5`.

## Hinweis

- Switch expression: `string text = weather switch { Weather.Clear => "...", ... , _ => "Unbekannt" };`
- Ternärer Operator: `bedingung ? wennJa : wennNein`
- Spickzettel Block 02 (02.07): `enum`, switch expression.

## Lösung

`_Loesung/FlugwetterLoesung.cs`, im Menü mit `5L`.
