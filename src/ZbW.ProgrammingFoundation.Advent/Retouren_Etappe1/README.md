# Retouren-Werkstatt, Etappe 1 – Retouren erfassen

| Block | Format | Zeit |
|---|---|---|
| 01–03, Listen aus Block 05 | 🧩 Coden | 60–90′ |

## Story

Nach Weihnachten ist vor Weihnachten: Kaum sind die Geschenke ausgepackt, kommen die Umtausch-Wünsche. Der Pulli ist zu klein, das Buch kam doppelt, der Kreisel dreht nicht mehr. Die Werkstatt braucht ein Retourenprogramm – und du baust es in drei Etappen. Heute: Retouren erfassen.

## Aufgabe

Baue in `RetourenEtappe1.cs` ein Konsolenprogramm mit Menü in einer `while`-Schleife:

```text
1 = Retoure erfassen
2 = Retouren anzeigen
0 = Beenden
```

Pro Retoure werden erfasst:

| Feld | Typ | Regel |
|---|---|---|
| Kind | `string` | nicht leer |
| Artikel | `string` | nicht leer |
| Preis | `decimal` | grösser als 0, mit `TryParse` |
| Grund | `ReturnReason` | Auswahl über eine Nummer, mit `switch` |

Das `enum ReturnReason { WrongSize, Duplicate, Broken, Disliked }` ist schon da.

- Gespeichert wird in **vier Listen mit gemeinsamem Index** (`List<string> children`, `List<string> articles`, `List<decimal> prices`, `List<ReturnReason> reasons`): Der Eintrag mit Index `i` gehört in allen vier Listen zur selben Retoure. Merk dir, wie sich das anfühlt – in Etappe 3 räumen wir damit auf.
- Nach dem Erfassen: Bei `Broken` erscheint `"Elfen-Garantie: voller Betrag zurück"`, sonst gibt es 80 % zurück. Die Rückerstattung berechnest du mit dem **ternären Operator**.
- Ungültige Eingaben werden mit einer Meldung wiederholt – das Programm stürzt nie ab.
- «Anzeigen» listet alle Retouren mit Nummer, Kind, Artikel, Preis, Grund und Rückerstattung.

Starten im Menü mit `E1`. Bewahre deine Lösung auf – Etappe 2 baut darauf auf.

## Hinweis

Für jede Eingabe eignet sich ein `do-while`, das wiederholt, bis die Eingabe gültig ist (wie beim Türsteher an Tag 11). Die Grund-Auswahl: Nummer 1–4 einlesen, dann `switch` auf `ReturnReason`. Rückerstattung: `decimal refund = reason == ReturnReason.Broken ? price : price * 0.8m;`. Spickzettel Block 01–03, für die Listen Block 05.

## Lösung

`_Loesung/RetourenEtappe1Loesung.cs`, im Menü mit `E1L`.
