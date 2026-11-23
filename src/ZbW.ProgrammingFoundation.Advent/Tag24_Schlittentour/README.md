# Tag 24 – 🎄 Finale: Die Schlittentour

| Block | Format | Zeit |
|---|---|---|
| 01–06 | 🧩 Coden | 60′ |

## Story

Heiligabend. Der Schlitten steht bereit, die Rentiere scharren mit den Hufen, und die Werkstatt hat drei Wochen lang Programme geschrieben. Jetzt kommt alles zusammen: Geschenke laden, Tour fliegen, Rentiere bei Laune halten – und am Schluss eine Übersicht für den Weihnachtsmann. Wegen dichtem Nebel über dem Bodensee fliegt der Schlitten heute grosse Umwege, darum sind die Etappen so lang.

## Aufgabe

Du brauchst drei Klassen, jede in ihrer eigenen Datei (Gerüste liegen bereit):

**`Gift`** – wie an Tag 21, ergänzt um `City` (Ort, an den das Geschenk geliefert wird).

**`Reindeer`** – wie an Tag 23 (`Name`, `Energy` mit `private set`, `Fly(int km)`, `Feed()`).

**`Sleigh`**
- `MaxLoad` (maximale Zuladung in kg), im Konstruktor gesetzt.
- Eine **private** `List<Gift>`.
- `bool Load(Gift gift)`: lädt das Geschenk, ausser der Schlitten würde zu schwer. Dann `false`.
- `double CurrentLoad` und `int GiftCount` (nur lesbar).
- `List<Gift> Unload(string city)`: nimmt alle Geschenke für diesen Ort heraus und gibt sie zurück.

**Die Tour** in `Schlittentour.cs`:
1. Einen Schlitten mit 22 kg Zuladung erstellen und die vorgegebenen Geschenke laden. Abgelehnte Geschenke melden.
2. Ein Team als `List<Reindeer>` mit drei Rentieren.
3. Die Tour als `Dictionary<string, int>` (Ort → Distanz in km).
4. Vor jeder Etappe prüfen, ob **jedes** Rentier genug Energie hat. Falls nicht, wird es gefüttert, bis es reicht.
   Braucht eine Etappe mehr Energie, als ein Rentier überhaupt haben kann (mehr als 100 Energie, also ab 1010 km), hilft auch Füttern nicht – die Fütterschleife liefe endlos. Solche Etappen lehnst du **vor dem Fliegen** ab: Meldung `"Etappe zu lang für dieses Team"`, nicht fliegen, nichts abladen, weiter zur nächsten Etappe.
5. Fliegen, am Ort abladen und ausgeben, was geliefert wurde.
6. Am Schluss eine Tourübersicht: abgelieferte Geschenke, Gesamtdistanz, Energie pro Rentier.

Starten im Menü mit `24`.

### Vorgaben

```text
Geschenke (Name, Empfänger, Ort, kg):
  Velo, Lena, Arbon, 12.5
  Buch, Noah, Rorschach, 0.4
  Lego, Mia, Arbon, 1.2
  Schlitten, Elias, St. Gallen, 8.0
  Malkasten, Sofia, Rorschach, 0.6
  Puppe, Lars, St. Gallen, 0.8

Tour (Ort, km):
  Arbon 720, Rorschach 80, St. Gallen 250

Team: Rudolph, Comet, Blitzen
```

### Selbstcheck

Mit den Vorgaben und in dieser Ladereihenfolge sollte deine Tour so enden: **5 Geschenke** abgeliefert, **1 Geschenk** abgelehnt (der Schlitten), **1050 km** geflogen, jedes Rentier hat am Schluss **25 Energie**. Gewichte wie an Tag 21 mit zwei Nachkommastellen (`12.50 kg`).

## Hinweis

Kopiere deine Klassen von Tag 21 und 23 als Startpunkt. Beim Abladen nicht in einer `foreach`-Schleife aus der Liste entfernen (Tag 17!). Damit die Liste privat bleibt, gibst du nie die Liste selbst heraus, sondern nur Zahlen oder eine neue Liste. Spickzettel Block 05 und 06.

## Lösung

`_Loesung/Gift.cs`, `_Loesung/Reindeer.cs`, `_Loesung/Sleigh.cs` und `_Loesung/SchlittentourLoesung.cs`, im Menü mit `24L`.
