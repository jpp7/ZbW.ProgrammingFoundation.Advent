# Tag 1 – Die Werkstatt-Rechenmaschine

| Block | Format | Zeit |
|---|---|---|
| 01 | 🔍 Was gibt das aus? | 10′ |

## Story

Der Weihnachtsmann digitalisiert seine Werkstatt. Als Erstes hat ein Elf die alte Rechenmaschine durch C# ersetzt. Auf seinem Zettel stehen sieben Ausdrücke – aber bei einigen ist er sich nicht mehr sicher, was herauskommt.

## Aufgabe

1. Öffne `Rechenmaschine.cs`. Lies jeden Ausdruck und schreib deine Vermutung in den Kommentar `// Vermutung: ___`.
2. Erst danach starten: im Menü `1` eingeben.
3. Vergleiche: Wo lagst du daneben? Warum?

Die Ausdrücke:

```csharp
17 / 5
17 % 5
17 / 5.0
(double)17 / 5
"Tag " + 1 + 2
$"{1 + 2}"
true && !false || false
```

## Hinweis

- Zwei `int` ergeben bei `/` wieder einen `int`. Sobald eine Seite `double` ist, wird mit Nachkommastellen gerechnet.
- `+` wird von links nach rechts ausgewertet. Steht links schon ein `string`, wird verkettet statt addiert.
- `!` bindet stärker als `&&`, und `&&` stärker als `||`.
- Spickzettel Block 01 (01.07), Abschnitt Operatoren.

## Lösung

Die Erklärungen stehen als Kommentare in `_Loesung/RechenmaschineLoesung.cs`. Im Menü startest du die Lösung mit `1L`.
