# Tag 18 – Wichtel-Losung

| Block | Format | Zeit |
|---|---|---|
| 05 | 🧩 Coden | 20′ |

## Story

Sechs Elfen wichteln dieses Jahr untereinander. Letztes Jahr hat Elf Fritz sich selbst gezogen und sich ein Paar Socken geschenkt. Das soll nicht mehr passieren.

## Aufgabe

In `WichtelLosung.cs`:

- Eine `List<string>` mit 6 Namen ist vorgegeben.
- `static Dictionary<string, string> Draw(List<string> names, Random random)`: lost aus, wer wen beschenkt (Schenker → Beschenkter).
  - Jede Person beschenkt genau eine andere und wird genau einmal beschenkt.
  - Niemand darf sich selbst ziehen.
- Ergebnis ausgeben: `Anna → Fritz`.

Starten im Menü mit `18`.

## Hinweis

Ein einfacher Weg: Eine **Kopie** der Namensliste mischen (Tausch-Verfahren wie an Tag 16). Danach prüfen, ob irgendwo `names[i] == shuffled[i]` gilt – wenn ja, nochmals mischen (`do-while`). Erst wenn es passt, das Dictionary füllen. Kopie: `new List<string>(names)`. Spickzettel Block 05 (05.07): `List<T>`, `Dictionary<K, V>`.

## Lösung

`_Loesung/WichtelLosungLoesung.cs`, im Menü mit `18L`.
