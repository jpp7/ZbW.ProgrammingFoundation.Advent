# Tag 21 – Die Klasse `Gift`

| Block | Format | Zeit |
|---|---|---|
| 06 | 🧩 Coden | 15′ |

## Story

Bis jetzt waren Geschenke in der Werkstatt nur Texte und Zahlen, verteilt auf mehrere Variablen. Das wird unübersichtlich. Ab heute bekommt jedes Geschenk eine eigene Klasse.

## Aufgabe

- Schreibe in `Gift.cs` die Klasse `Gift` mit den Properties `Name`, `Recipient` (Empfänger) und `Weight` (Gewicht in kg, `double`).
- `Weight` wird validiert: Ein Wert ≤ 0 löst eine `ArgumentException` aus.
- Ein Konstruktor setzt alle drei Werte.
- `ToString()` liefert z. B. `"Velo für Lena (12.50 kg)"`.
- In `KlasseGift.cs` erstellst du in `Start()` drei Geschenke und gibst sie aus. Probier auch ein ungültiges Gewicht aus und fang die Exception ab.

Jede Klasse steht in ihrer eigenen Datei. Starten im Menü mit `21`.

## Hinweis

Für die Validierung brauchst du ein Property mit Rumpf und ein privates Feld (`_weight`). Spickzettel Block 06 (06.07): Felder und Properties, Konstruktoren.

## Lösung

`_Loesung/Gift.cs` und `_Loesung/KlasseGiftLoesung.cs`, im Menü mit `21L`.
