# Aufwärm-Quiz – Block 01 bis 06

10 Fragen zum Aufwärmen vor Etappe 3. Auf der Webseite wertet sich das Quiz direkt im Browser aus.

## 1. Was ergibt `7 / 2`, wenn beide Werte `int` sind?

Block: 01 · Spickzettel: 01.07 (Operatoren)

- [ ] `3.5`
- [x] `3`
- [ ] `4`
- [ ] Einen Compilerfehler

> `int / int` ergibt wieder einen `int`. Die Nachkommastellen werden abgeschnitten, nicht gerundet. Für `3.5` muss eine Seite `double` sein: `7 / 2.0`.

## 2. Welche Zeile kompiliert?

Block: 01 · Spickzettel: 01.07 (Datentypen)

- [ ] `decimal price = 4.50;`
- [x] `decimal price = 4.50m;`
- [ ] `int count = "5";`
- [ ] `bool isOpen = "true";`

> Ein `decimal`-Literal braucht das `m`. Ohne `m` ist `4.50` ein `double`, und der lässt sich nicht automatisch in `decimal` umwandeln.

## 3. Was gibt `Console.WriteLine(age >= 18 ? "Erwachsen" : "Kind");` bei `age = 18` aus?

Block: 02 · Spickzettel: 02.07 (Ternärer Operator)

- [x] `Erwachsen`
- [ ] `Kind`
- [ ] `True`
- [ ] Nichts

> `18 >= 18` ist wahr, also wird der Teil nach dem `?` gewählt.

## 4. Wofür ist ein `enum` gut?

Block: 02 · Spickzettel: 02.07 (enum)

- [ ] Um Zahlen schneller zu rechnen
- [x] Um benannte Werte statt magischer Zahlen oder Texte zu verwenden
- [ ] Um Texte zu verketten
- [ ] Um Fehler abzufangen

> `ReturnReason.Broken` ist lesbarer und sicherer als `3` oder `"defekt"`: Tippfehler meldet der Compiler.

## 5. Wie oft läuft `for (int i = 0; i <= 5; i++)`?

Block: 03 · Spickzettel: 03.07 (for-Schleife)

- [ ] 5-mal
- [x] 6-mal
- [ ] 4-mal
- [ ] Endlos

> `i` nimmt die Werte 0, 1, 2, 3, 4, 5 an – sechs Durchläufe. Ein klassischer Off-by-one-Fehler, wenn man 5 wollte.

## 6. Was ist der Unterschied zwischen `while` und `do-while`?

Block: 03 · Spickzettel: 03.07 (Schleifen)

- [ ] Es gibt keinen
- [ ] `do-while` läuft immer endlos
- [x] `do-while` prüft die Bedingung erst nach dem ersten Durchlauf
- [ ] `while` kann nur mit Zahlen arbeiten

> Darum passt `do-while` gut zur Eingabeprüfung: zuerst fragen, dann prüfen, bei Bedarf nochmals fragen.

## 7. Wie viele Elemente hat eine `List<string> names` – und wie viele ein Array `string[] wishes`?

Block: 04–05 · Spickzettel: 04.07 (Arrays), 05.07 (List)

- [ ] `names.Length` und `wishes.Count`
- [x] `names.Count` und `wishes.Length`
- [ ] Beide mit `.Size`
- [ ] Beide mit `.Count()`

> Arrays haben `.Length`, Listen `.Count`. `.Length` bei einer Liste kompiliert nicht.

## 8. Was passiert bei `dict["Schlitten"]`, wenn der Key fehlt?

Block: 05 · Spickzettel: 05.07 (Dictionary)

- [ ] Es wird `0` geliefert
- [ ] Es wird `null` geliefert
- [x] Es wird eine `KeyNotFoundException` geworfen
- [ ] Der Key wird automatisch angelegt

> Lesen mit `[]` wirft bei einem fehlenden Key eine Exception. Sicher geht es mit `TryGetValue` oder `ContainsKey`. (Schreiben mit `dict["x"] = 1` legt den Key dagegen an.)

## 9. Eine Methode `void DoubleValue(int x) { x = x * 2; }` wird mit `int gifts = 5; DoubleValue(gifts);` aufgerufen. Welchen Wert hat `gifts` danach?

Block: 05 · Spickzettel: 05.07 (Value Type als Kopie)

- [x] `5`
- [ ] `10`
- [ ] `0`
- [ ] Einen Compilerfehler

> `int` ist ein Value Type. Die Methode bekommt eine Kopie, das Original bleibt unverändert.

## 10. Was bewirkt `public int Energy { get; private set; }`?

Block: 06 · Spickzettel: 06.07 (Properties)

- [ ] Niemand kann `Energy` lesen
- [x] Alle können `Energy` lesen, aber nur die Klasse selbst kann den Wert ändern
- [ ] `Energy` kann nur im Konstruktor gesetzt werden
- [ ] `Energy` ist eine Konstante

> Das ist Kapselung: Von aussen geht es nur über Methoden wie `Feed()` oder `Fly()`, die die Regeln einhalten.
