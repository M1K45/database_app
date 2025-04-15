# Pratformy progrmaistyczne .NET i Java - zajęcia nr. 2 
> Autor: Michał Kaszowski (272570)

## 1. Wstęp
Stworzono 2 aplikacje w technologii .NET: 
1. Jedną przy użyciu .NET MAUI, która umożliwia dodawanie miast i państw do bazy danych SQLite, pobierając informacje o nich z zewnętrznego API.
2. Drugą przy użyciu Windows Forms, która dodatkowo pozwala na sortowanie danych po strefie czasowej państwa (dla uproszczenia zakładając, że jest tylko jedna)

API wykorzystane do projektu jest dostępne [tutaj](https://openweathermap.org/current) (link do dokumentacji).

## 2. Struktura projektu
### Modele danych
- [`Weather.cs`](https://github.com/M1K45/database_app/blob/master/Weather.cs) - klasa reprezentująca dane pobrane z API, z obiektu tej klasy pobierane są dane do bazy danych.
- [`City.cs`](https://github.com/M1K45/database_app/blob/master/City.cs) - w pliku znajdują się klasy reprezentujące miasto i państwo w bazie danych

### Baza danych
- [`CityCountryDBContext.cs](https://github.com/M1K45/database_app/blob/master/CityCountryDBContext.cs) - klasa kontekstu bazy danych SQLite, zarządzająca tabelami miast i państw.

### Pliki dla Windows Forms
- [`Form1.Designer.cs`](https://github.com/M1K45/database_app/blob/master/Form1.Designer.cs) - strona główna aplikacji okienkowej
- [`Form1.cs`](https://github.com/M1K45/database_app/blob/master/Form1.cs) - logika pobierania, wyświetlania i sortowania danych, po wciśnięciu odpowiednich przycisków

### Pliki dla .NET MAUI
- [`MainPage.xaml`](https://github.com/M1K45/database_app/blob/master/MainPage.xaml) - strona główna aplikacji, zawierająca formularz dodawania miasta oraz możliwość pobierania miasta i państwa z API na podstawie nazwy miasta
-= [`MainPage.xaml.cs`](https://github.com/M1K45/database_app/blob/master/MainPage.xaml.cs) - Kod zaplecza, odpowiedzialny za interakcję bazy danych z GUI

## 3. Wykorzystane technologie 
- .NET 8.0
- MAUI
- C# 
- SQLite
