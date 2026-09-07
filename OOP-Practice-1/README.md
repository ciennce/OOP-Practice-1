# OOP-Practice-1 – Bank Console

Konsolen-Übung zur Objektorientierung: Eine kleine Bank, in der man Konten anlegen,
Geld einzahlen, auszahlen und Kontostände abfragen kann. Alle Daten leben nur im
Speicher und sind nach dem Beenden weg.

## Starten

In Visual Studio `OOP-Practice-1` als Startprojekt setzen und F5, oder:

```
dotnet run --project OOP-Practice-1
```

## Bedienung

```
[1] Create Account      Name eingeben, eine zufällige Iban wird erzeugt
[2] Deposit             Iban eingeben, Betrag einzahlen
[3] Payout              Iban eingeben, Betrag auszahlen (nur bis zum Kontostand)
[4] Show Balance        Iban eingeben, Kontostand anzeigen
[5] Show All Accounts   Alle Konten mit Name, Iban und Kontostand
[6] Quit                Programm beenden
```

Die Menüauswahl erfolgt per Tastendruck ohne Enter. Für Deposit, Payout und
Show Balance muss die Iban exakt so eingegeben werden, wie sie beim Anlegen
angezeigt wurde, inklusive Leerzeichen.

## Struktur

| Datei | Zweck |
|---|---|
| `Main/Program.cs` | Einstieg, erzeugt die `GUI` und startet `Run()` |
| `Gui/GUI.cs` | Hauptschleife, Menüanzeige, Tastenauswertung, Helfer `AwaitEnter()` |
| `Bank/BankDatabase.cs` | Kontenliste (`List<Account>`), Konto anlegen, Iban erzeugen, Konto per Iban suchen (`CheckUser`), Übersicht |
| `Bank/Account.cs` | Ein Konto: `Name`, `Iban`, `Balance`, Ein- und Auszahlung mit Prüfung |

Aufrufkette: `Program` → `GUI.Run()` → `BankDatabase` → `Account`.

## Konzepte, die hier geübt werden

- Trennung von Menüsteuerung (`GUI`) und Fachlogik (`BankDatabase`, `Account`)
- Property mit privatem Setter (`Balance { get; private set; }`), damit der Kontostand nur über `Deposit`/`Payout` verändert werden kann
- Nullable-Rückgabe (`Account?`) und Null-Conditional-Operator: `db.CheckUser()?.Deposit()`
- `List<T>` mit `FirstOrDefault` durchsuchen
- Statische Helfermethode (`GUI.AwaitEnter`) statt kopiertem Code
- Menüsteuerung mit `while` + `switch` über ein `char` aus `Console.ReadKey`

## Unterschied zum Vorgängerprojekt (ObjoWkPractice_3)

- Menü-Ein-/Ausgabe liegt nicht mehr in der Modellklasse, sondern in einer eigenen `GUI`-Klasse
- Menüeingabe wird als `char` verglichen statt mit `Convert.ToInt32` geparst, falsche Tasten stürzen nicht mehr ab
- Prüfungen (leere Kontenliste, negative Einzahlung, ungedeckte Auszahlung) vor jeder Aktion

## Bekannte Schwächen / offene Punkte

- `[6] Quit` beendet das Programm nicht: das `break` verlässt nur den `switch`, nicht die `while`-Schleife → `return` oder ein `running`-Flag
- `Convert.ToInt32(Console.ReadLine())` in `Deposit`/`Payout` wirft bei Nicht-Zahlen eine `FormatException` → `int.TryParse` verwenden
- `Account.Deposit`/`Payout` lesen selbst von der Konsole; besser `Deposit(int amount)` mit Rückgabewert, die `GUI` fragt den Betrag ab
- `ShowBalance` gibt bei unbekannter Iban `Balance: $` aus und wartet nicht auf Enter; Fehlermeldungen aus `CheckUser` verschwinden sofort hinter dem nächsten `Console.Clear`
- `BankDatabase.Database` ist ein öffentliches Feld → `private readonly List<Account> accounts`
- Die generierte Iban ist zufällig und schwer abzutippen; ein kurzes Format oder Suche nach Name wäre benutzerfreundlicher
