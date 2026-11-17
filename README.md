# ZbW.ProgrammingFoundation.Advent

🎄 **Adventskalender Programming Foundation** – freiwillige Repetition von Block 01–06 über die Unterrichtspause.

**Kalender:** <https://advent.pokora.ch> – dort öffnet sich jeden Tag ein Türchen mit Story, Aufgabe, Hinweis und Lösung.
In diesem Repository schreibst du den Code dazu.

> Freiwillig. Jedes Türchen bleibt offen, nachholen ist okay.

## Die Story

**Die Weihnachtswerkstatt:** Der Weihnachtsmann digitalisiert seine Werkstatt, und du hilfst jeden Tag mit einem kleinen Programm.
Werktags dauert ein Türchen 10–20 Minuten, an den Adventssonntagen und am 24. gibt es eine grössere Aufgabe.
Nach Weihnachten geht es weiter mit der **Retouren-Werkstatt** in drei Etappen.

| Format | Bedeutung |
|---|---|
| 🧩 Coden | kleines Programm schreiben |
| 🔍 Was gibt das aus? | Code lesen, Ausgabe vorhersagen, dann ausprobieren |
| 🐞 Bug-Jagd | fehlerhaften Code reparieren |

## Struktur

```text
src/
├── ZbW.ProgrammingFoundation.Advent.sln
├── Directory.Build.props
└── ZbW.ProgrammingFoundation.Advent/
    ├── Program.cs              Menü: Türchen wählen → starten
    ├── Tag01_Rechenmaschine/
    │   ├── README.md           Story + Aufgabe
    │   ├── Rechenmaschine.cs   deine Datei
    │   └── _Loesung/           Musterlösung
    ├── …
    ├── Tag24_Schlittentour/
    ├── Retouren_Etappe1/       ab 26.12.
    ├── Retouren_Etappe2/       ab 2.1.
    └── Retouren_Etappe3/       ab 1.2. (mit Aufwärm-Quiz und Cliffhanger)
```

## Übersicht

| Woche | Tage | Blöcke | Thema |
|---|---|---|---|
| 1 | 1–6 | 01–02 | Variablen, Operatoren, Kontrollstrukturen |
| 2 | 7–13 | 03 | Schleifen, Random, Fehlerbehandlung |
| 3 | 14–20 | 04–05 | Arrays, Methoden, Collections |
| 4 | 21–24 | 06 | Klassen & Objekte |
| Retouren | 26.12. / 2.1. / 1.2. | 01–06 | ein Projekt in drei Etappen |

Die Hilfe nimmt ab: In Woche 1–2 gibt es nummerierte TODOs, in Woche 3 nur Signaturen und einen Hinweis, ab Woche 4 nur noch den Aufgabentext.

## Für Studierende

Erstelle zuerst einen **Fork** dieses Repositories auf deinem eigenen GitHub-Account und klone danach deinen Fork lokal:

```powershell
git clone https://github.com/DEIN_USERNAME/ZbW.ProgrammingFoundation.Advent.git
cd ZbW.ProgrammingFoundation.Advent
```

Arbeite in deinem Fork, committe regelmässig und pushe deine Lösungen auf deinen GitHub-Account.

## Start

Öffne `src/ZbW.ProgrammingFoundation.Advent.sln` in Rider oder Visual Studio und starte das Projekt.
Es erscheint ein Menü:

| Eingabe | Startet |
|---|---|
| `7` | deine Version von Tag 7 |
| `7L` | die Musterlösung von Tag 7 |
| `E1` / `E1L` | Retouren-Werkstatt Etappe 1 / Lösung |
| `C` | Cliffhanger aus Etappe 3 |
| `0` | Beenden |

Ist ein Türchen noch nicht implementiert, meldet das Menü «🚧 Noch nicht fertig» statt abzustürzen.
Direktstart ohne Menü: `dotnet run --project src\ZbW.ProgrammingFoundation.Advent -- 7L`

## Build

```powershell
dotnet build src\ZbW.ProgrammingFoundation.Advent.sln --ignore-failed-sources
```

Der Zusatz `--ignore-failed-sources` ist nützlich, falls lokal ein privater NuGet-Feed konfiguriert ist, der ohne Anmeldung Warnungen erzeugt.
Zwei Warnungen in `Tag03_VerwirrterElf` sind Absicht: Sie gehören zur Bug-Jagd.

## Für den Dozenten

Die `README.md` jedes Tages ist die **einzige Quelle** für die Kalender-Webseite (`ws-advent` liest sie beim Build ein, ebenso die `_Loesung`-Dateien und `Retouren_Etappe3/Quiz.md`).
Korrekturen also nur hier machen. Das Format pro Tag: Titel, Tabelle mit Block / Format / Zeit, Abschnitte `## Story`, `## Aufgabe`, `## Hinweis`, `## Lösung`.
