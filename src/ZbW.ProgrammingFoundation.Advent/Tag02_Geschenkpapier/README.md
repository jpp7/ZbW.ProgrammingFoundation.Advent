# Tag 2 – Geschenkpapier-Rechner

| Block | Format | Zeit |
|---|---|---|
| 01 | 🧩 Coden | 15′ |

## Story

In der Packstation geht ständig das Geschenkpapier aus. Die Elfen schneiden mal zu viel, mal zu wenig. Ein kleiner Rechner soll sagen, wie viel Papier ein Geschenk braucht und was es kostet.

## Aufgabe

Ergänze `Geschenkpapier.cs`:

- Breite und Höhe des Geschenks in cm einlesen, mit `decimal.TryParse`. Bei einer ungültigen Eingabe eine Meldung ausgeben und abbrechen.
- Das Geschenk ist flach: Papier braucht es für Vorder- und Rückseite, also `2 × Breite × Höhe`.
- Dazu kommen 20 % Zuschlag für Überlappung und Falten.
- Umrechnen in m² (1 m² = 10 000 cm²).
- Preis: `0.85m` CHF pro m².
- Ausgabe mit `:F2`, z. B. `Papier: 0.14 m², Preis: 0.12 CHF`.

Starten im Menü mit `2`.

## Hinweis

- Konstanten statt magischer Zahlen: `const decimal PricePerSquareMeter = 0.85m;`
- `decimal` braucht das `m` am Ende des Literals.
- Testwerte: 30 × 20 cm ergibt 0.144 m² und 0.12 CHF.
- Spickzettel Block 01 (01.07): `TryParse`, Konstanten, Formatierung.

## Lösung

`_Loesung/GeschenkpapierLoesung.cs`, im Menü mit `2L`.
