# Tag 12 – Lebkuchen-Pasch

| Block | Format | Zeit |
|---|---|---|
| 03 | 🧩 Coden | 15′ |

## Story

In der Pause spielen die Elfen «Lebkuchen-Pasch»: Wer mit zwei Würfeln einen Pasch wirft, bekommt einen Lebkuchen. Elf Bo behauptet, im Schnitt brauche man etwa 6 Würfe. Stimmt das?

## Aufgabe

In `LebkuchenPasch.cs`:

1. `static int RollUntilDouble(Random random)`: Mit zwei Würfeln (je 1–6) würfeln, bis beide gleich sind. Rückgabe: Anzahl Würfe.
2. In `Start()` das Ganze 1000-mal wiederholen und die Würfe zusammenzählen.
3. Den Durchschnitt mit zwei Nachkommastellen ausgeben. Erwartet ist etwa 6.

Starten im Menü mit `12`.

## Hinweis

- `random.Next(1, 7)` liefert 1 bis 6 – die obere Grenze ist exklusiv.
- Ein `Random`-Objekt für alle 1000 Spiele, als Parameter übergeben.
- Durchschnitt: `(double)totalRolls / Games` – sonst Ganzzahldivision.
- Warum 6? Von 36 Kombinationen sind 6 ein Pasch, also 1 von 6.
- Spickzettel Block 03 (03.07): `while`, `Random`.

## Lösung

`_Loesung/LebkuchenPaschLoesung.cs`, im Menü mit `12L`.
