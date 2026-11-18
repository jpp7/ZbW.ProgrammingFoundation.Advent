# Retouren-Werkstatt, Etappe 2 – Retouren auswerten

| Block | Format | Zeit |
|---|---|---|
| 04–05 | 🧩 Coden | 60–90′ |

## Story

Die Retouren stapeln sich. Der Weihnachtsmann will wissen, warum: Sind die Grössen falsch? Kommen zu viele Geschenke doppelt? Und wie viel Geld fliesst zurück? Zeit für eine Auswertung.

## Aufgabe

Baue dein Programm aus Etappe 1 auf **Methoden** und **Collections** um. Arbeite in deiner eigenen Lösung weiter. Hast du Etappe 1 nicht gemacht, ist `RetourenEtappe2.cs` dein Startpunkt: Dort liegt die Lösung von Etappe 1.

1. Zerlege das Programm in Methoden, z. B. für die Eingaben (`ReadNonEmpty`, `ReadPrice`, `ReadReason`) und für die Rückerstattung (`CalculateRefund`).
2. Ergänze die Auswertung, **ohne LINQ**:
   - Ein `Dictionary<ReturnReason, int>` zählt die Gründe.
   - Ein `Dictionary<string, decimal>` summiert die Rückerstattung pro Kind.
   - `ReturnReason MostCommonReason(...)` – bei Gleichstand gewinnt der Grund, der zuerst gezählt wurde (mit `>` vergleichen, nicht mit `>=`)
   - `decimal TotalRefund(...)`
   - `string ReportFor(..., string child)` – Bericht für ein Kind
   - `bool TryFindMostExpensive(..., out string article, out decimal price)`
   - `void PrintReport(..., string title = "Retouren-Bericht")` mit optionalem Titel
3. Beim Start werden **10 Beispiel-Retouren** vorbelegt, damit du direkt auswerten kannst. Die Daten liegen als fertige Methode `AddSampleData` in `RetourenEtappe2.cs` – kopiere sie in deine Lösung, dann kannst du deinen Bericht mit `E2L` vergleichen.
4. Das Menü bekommt neue Punkte: `3 = Bericht`, `4 = Bericht für ein Kind`.

Die `...` stehen für die Listen, die die Methode braucht. Starten im Menü mit `E2`.

## Hinweis

Zählen im Dictionary: `if (counts.ContainsKey(key)) counts[key]++; else counts[key] = 1;`. Bei `out` muss jeder Weg durch die Methode einen Wert zuweisen. Achte darauf, wie viele Listen du an jede Methode übergeben musst – in Etappe 3 räumen wir damit auf. Spickzettel Block 04 und 05.

## Lösung

`_Loesung/RetourenEtappe2Loesung.cs`, im Menü mit `E2L`.
