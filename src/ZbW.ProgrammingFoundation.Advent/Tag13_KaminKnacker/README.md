# Tag 13 – ⭐ 3. Advent: Kamin-Knacker

| Block | Format | Zeit |
|---|---|---|
| 01–03 | 🧩 Coden | 30–40′ |

## Story

Die Geschenke für den Weihnachtsabend liegen in einem Tresor im Kamin. Leider hat der Weihnachtsmann den dreistelligen Code vergessen. Der Tresor ist aber gesprächig: Nach jedem Versuch verrät er, wie viele Ziffern an der richtigen Stelle stehen. Nach 10 Fehlversuchen schliesst sich der Kamin.

## Aufgabe

Baue in `KaminKnacker.cs` das Spiel:

1. Einen dreistelligen Zufallscode erzeugen, z. B. `"042"` (führende Nullen erlaubt).
2. `static int CountCorrectDigits(string code, string guess)`:
   - Wirft eine `ArgumentException`, wenn `guess` nicht aus genau 3 Ziffern besteht.
   - Liefert sonst die Anzahl Ziffern, die an der richtigen Stelle stehen.
3. Maximal 10 Versuche. Nach jedem Versuch: `"x Ziffern richtig an richtiger Stelle"`.
4. Eine ungültige Eingabe wird mit `catch (ArgumentException ex)` abgefangen, die Meldung ausgegeben – und zählt **nicht** als Versuch.
5. Bei 3 richtigen: Glückwunsch mit Anzahl Versuchen. Nach 10 Fehlversuchen: Code verraten.
6. Ein `finally` gibt am Schluss immer `"Kamin geschlossen."` aus.

Starten im Menü mit `13`.

## Hinweis

- Code erzeugen: `random.Next(0, 1000).ToString("D3")` ergibt immer drei Stellen.
- Ein `string` lässt sich wie ein Array lesen: `code[0]`, `guess.Length`.
- Ziffer prüfen: `char.IsDigit(guess[i])`.
- Zum Testen kannst du den Code vorübergehend ausgeben.
- Spickzettel Block 03 (03.07): `try/catch/finally`, `throw`.

## Lösung

`_Loesung/KaminKnackerLoesung.cs`, im Menü mit `13L`.
