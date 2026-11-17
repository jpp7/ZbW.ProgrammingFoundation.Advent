# Tag 4 – Darf der Wichtel das schenken?

| Block | Format | Zeit |
|---|---|---|
| 02 | 🧩 Coden | 15′ |

## Story

Beim Wichteln in der Werkstatt gibt es Regeln: Für Kinder unter 12 Jahren darf ein Geschenk höchstens 30 CHF kosten, für alle anderen höchstens 50 CHF. Der Weihnachtsmann will eine Methode, die das prüft, bevor eingepackt wird.

## Aufgabe

Implementiere in `WichtelGeschenk.cs` die Methode

```csharp
static string CheckGift(int age, decimal price)
```

- Ungültiges Alter (unter 0 oder über 120) oder negativer Preis: `"Ungültig"`
- Unter 12 Jahren: höchstens 30 CHF erlaubt
- Ab 12 Jahren: höchstens 50 CHF erlaubt
- Rückgabe: `"OK"` oder `"Zu teuer"`

Verwende **Guard Clauses**: Ungültige Fälle werden zuerst mit `return` erledigt, danach kommt der Normalfall ohne tiefe Verschachtelung.

`Start()` ruft die Methode mit ein paar Testfällen auf. Starten im Menü mit `4`.

## Hinweis

- Guard Clause: `if (age < 0 || age > 120) { return "Ungültig"; }`
- Grenzwerte testen: 12 Jahre mit 30 CHF? 11 Jahre mit 30.05 CHF?
- Konstanten für die Limiten machen den Code lesbarer.
- Spickzettel Block 02 (02.07): `if`, logische Operatoren.

## Lösung

`_Loesung/WichtelGeschenkLoesung.cs`, im Menü mit `4L`.
