# Retouren-Werkstatt, Etappe 3 – Umbau auf Klassen

| Block | Format | Zeit |
|---|---|---|
| 06 (→ 07) | 🧩 Coden | 60–90′ |

## Story

Bald geht der Unterricht weiter. Die Retouren-Werkstatt läuft, aber der Code ist unübersichtlich: Vier Listen, die immer zusammenpassen müssen, und Methoden mit fünf Parametern. Höchste Zeit, aufzuräumen – mit Klassen. Und ganz am Schluss wartet ein Rätsel.

## Aufgabe

**Zum Aufwärmen:** Löse auf der Webseite das Aufwärm-Quiz mit 10 Fragen zu Block 01–06.

**Der Umbau:** Arbeite in deiner Lösung von Etappe 2 weiter. Hast du Etappe 2 nicht gemacht, ist `RetourenEtappe3.cs` dein Startpunkt.

1. Klasse **`Return`** in `Return.cs`:
   - Properties `Child`, `Article`, `Price` und `Reason`
   - `Price` wird validiert: ≤ 0 löst eine `ArgumentException` aus
   - Read-only `Refund`, **berechnet** (defekt 100 %, sonst 80 %)
   - Konstruktor `Return(string article, string child, decimal price, ReturnReason reason)`
   - `ToString()` für eine Tabellenzeile
2. Klasse **`ReturnDesk`** in `ReturnDesk.cs`:
   - Eine **private** `List<Return>`
   - Methoden `Add(Return r)`, `TotalRefund()`, `MostCommonReason()`, `ReportFor(string child)`
   - Von aussen lässt sich die Liste nicht verändern (Kapselung).
3. `RetourenEtappe3.cs` enthält danach nur noch Menü, Ein- und Ausgabe. Jede Klasse steht in ihrer eigenen Datei.

Starten im Menü mit `E3`.

## Cliffhanger 🔍

Zum Schluss ein Rätsel – **ohne Lösung**:

```csharp
Return a = new("Velo", "Lena", 299m, ReturnReason.Disliked);
Return b = new("Velo", "Lena", 299m, ReturnReason.Disliked);
Console.WriteLine(a == b);   // ???
```

> Zwei identische Retouren – warum sagt C# `False`? Notiere deine Vermutung. Am 9.2. lösen wir das Rätsel.

**Bonus:** Dasselbe mit zwei gleichen `string`s ergibt `True`. Warum? Auch das lösen wir in Block 07 auf.

Ausprobieren im Menü mit `C`.

## Hinweis

Brauchst du die Retouren für die Anzeige, gib eine **Kopie** der Liste heraus (`new List<Return>(_returns)`) oder nur Zahlen – nie die private Liste selbst. Vergleiche am Schluss die Methodensignaturen mit Etappe 2: Wo sind die vier Listen geblieben? Spickzettel Block 06 (06.07).

## Lösung

`_Loesung/Return.cs`, `_Loesung/ReturnDesk.cs` und `_Loesung/RetourenEtappe3Loesung.cs`, im Menü mit `E3L`. Für den Cliffhanger gibt es bewusst keine Lösung.
