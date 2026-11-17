# Tag 8 – Elf im Kreis

| Block | Format | Zeit |
|---|---|---|
| 03 | 🔍 Was gibt das aus? | 10′ |

## Story

Elf Tinka läuft seit dem Frühstück im Kreis. Sie hat drei Schleifen gebaut und weiss nicht mehr, wie oft jede läuft. In der vierten hat sich ausserdem ein Fehler versteckt: Es kommt immer ein Geschenk zu viel heraus.

## Aufgabe

1. Lies in `ElfImKreis.cs` die drei Schleifen A, B und C. Notiere für jede: Wie oft läuft sie, und was wird ausgegeben?
2. Starte im Menü mit `8` und vergleiche.
3. Schleife D soll genau 5 Geschenke verteilen. Finde den Off-by-one-Fehler und korrigiere ihn.

## Hinweis

- `do-while` prüft die Bedingung erst am Ende – der Körper läuft also mindestens einmal.
- `i += 3` springt in Dreierschritten. Schreib die Werte von `i` auf, bis die Bedingung falsch wird.
- Zählst du ab 0, gehört `<` zur Anzahl. Zählst du ab 1, gehört `<=` dazu.
- Spickzettel Block 03 (03.07): Schleifen.

## Lösung

`_Loesung/ElfImKreisLoesung.cs`, im Menü mit `8L`. Die Anzahl Durchläufe steht jeweils im Kommentar.
