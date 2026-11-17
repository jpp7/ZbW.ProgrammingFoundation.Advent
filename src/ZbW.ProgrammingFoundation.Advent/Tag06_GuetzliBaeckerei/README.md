# Tag 6 – ⭐ 2. Advent: Guetzli-Bäckerei

| Block | Format | Zeit |
|---|---|---|
| 01–02 | 🧩 Coden | 30–40′ |

## Story

Am zweiten Advent wird in der Werkstatt gebacken. Die Bäcker-Elfen wollen wissen, wie viel Mehl und Zucker sie brauchen, wie lange die Bleche im Ofen bleiben und was das Ganze kostet. Wer viel bäckt, bekommt beim Müller Rabatt.

## Aufgabe

Baue in `GuetzliBaeckerei.cs` einen Rechner:

1. Sorte wählen über eine Nummer: `1` Mailänderli, `2` Zimtstern, `3` Brunsli, `4` Spitzbuben (`enum CookieType`).
2. Anzahl Bleche eingeben (1 bis 20).
3. Mit `switch` pro Sorte bestimmen:

   | Sorte | Mehl pro Blech | Zucker pro Blech | Backzeit | Kosten pro Blech |
   |---|---|---|---|---|
   | Mailänderli | 250 g | 125 g | 10 Min. | 4.50 CHF |
   | Zimtstern | 0 g | 200 g | 6 Min. | 6.20 CHF |
   | Brunsli | 0 g | 250 g | 5 Min. | 5.80 CHF |
   | Spitzbuben | 300 g | 100 g | 8 Min. | 5.10 CHF |

4. Mengenrabatt mit `if / else if`: ab 10 Blechen 15 %, ab 5 Blechen 10 %, ab 3 Blechen 5 %.
5. Ausgabe: Mehl und Zucker total, Backzeit pro Blech, Kosten vor und nach Rabatt.

Alle Eingaben werden validiert: keine Zahl, Sorte ausserhalb 1–4 oder Bleche ausserhalb 1–20 ergeben eine Meldung und das Programm endet sauber.

Starten im Menü mit `6`.

## Hinweis

- Von der Nummer zum enum: `CookieType type = (CookieType)(choice - 1);` – aber erst nach der Prüfung, ob `choice` zwischen 1 und 4 liegt.
- Bei der Rabatt-Staffel die grösste Schwelle zuerst prüfen, sonst greift immer die kleinste.
- Testwert: 5 Bleche Mailänderli ergeben 1250 g Mehl, 625 g Zucker, 22.50 CHF vor und 20.25 CHF nach Rabatt.
- Spickzettel Block 01 und 02.

## Lösung

`_Loesung/GuetzliBaeckereiLoesung.cs`, im Menü mit `6L`.
