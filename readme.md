# Projekt zaliczeniowy z przedmiotu Programowanie wizualne

## Opis projektu

Projekt ma na celu stworzenie aplikacji do zarządzania bazą danych. Aplikacja ma umożliwiać dodawanie, usuwanie, edycję
oraz wyświetlanie danych z bazy danych. Aplikacja ma być napisana w języku C# z wykorzystaniem blazor'a jako aplikacja
webowa.

Dodatkowo interfejs użytkownika musi pozwalać na przeglądanie danych zagnieżdżonych w tabelach oraz pozwalać na
dodawanie/odczytywanie/filtrowanie/wyszukiwanie/edycję i usuwanie danych z tabel.

Dodatkowym wymaganiem jest wykorzystanie dynamicznej zmiany bazy danych przy wykorzystaniu entity-framework.

## Użyte technologie

* [C#](https://docs.microsoft.com/dotnet/csharp/) - język programowania
* [.net7.0](https://dotnet.microsoft.com/) - framework
* [Entity Framework](https://docs.microsoft.com/en-us/ef/) - ORM
* [Blazor](https://blazor.net) - web framework
* [Tailwindcss](https://tailwindcss.com/) - baza do stylizacji
* [Sqlite](https://www.sqlite.org/index.html) - baza danych

### Użyte ikony - [Heroicons](https://heroicons.com/)

### Struktura

- [UI](./UI/UI.csproj) - zawiera interfejs użytkownika
- [Logic](./Logic/Logic.csproj) - zawiera logikę biznesową
- [DTO](./DTO/DTO.csproj) - zawiera obiekty do przesyłania danych
- [Models](./Models/Models.csproj) - zawiera modele bazy danych

### Konfiguracja

Aby uruchomić projekt należy:

- Wejść do folderu UI i wykonać komendę `dotnet run` lub `dotnet watch`

Aby uruchomić bazę danych w pamięci należy:

- Wejść do folderu UI i dodać do pliku [appsettings.json](UI/appsettings.json) następującą linię:

```json
"UseInMemoryDatabase": true
```

Aby uruchomić bazę danych dyskową należy:

- Wejść do folderu UI i dodać do pliku [appsettings.json](UI/appsettings.json) następującą linię:

```json
"UseInMemoryDatabase": false
```

### Wygląd aplikacji

- Widok główny

<img src="./Screenshots/home-menu.png" width="640">

- Widok tabeli dóbr z filtrowaniem

<img src="./Screenshots/goods-search.png" width="640">

- Widok tabeli dóbr z modelem edycji

<img src="./Screenshots/goods-edit.png" width="640">

- Widok tabeli dóbr z modelem potwierdzenia usunięcia

<img src="./Screenshots/goods-delete-confirmation.png" width="640">

- Widok szczegółów dostępnego dobra

<img src="./Screenshots/goods-good-view.png" width="640">

- Widok tabeli ras 

<img src="Screenshots/races-view.png" width="640">

- Widok tabeli ras z modelem edycji

<img src="Screenshots/races-edit.png" width="640">

- Widok szczegółów dostępnej rasy

<img src="Screenshots/races-race-view.png" width="640">

