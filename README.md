# BooKing
Strona napisana w ASP.NET Core pozwalająca na księgowanie pobytu w hotelach.

## Funkcjonalności od strony użytkownika
* Przeglądanie dostępnych apartamentów w postaci listy
* Możliwość przesłania zapytania o pobyt w danym hotelu formularzem kontaktowym
* Widok pojedynczego apartamentu, zawierający jego lokalizację, ilość miejsc noclegowych, opis oraz galerię zdjęć

## Funkcjonalności panelu administracyjnego
* Zarządzanie apartamentami: dodawanie, edycja, usuwanie
* Możliwość dodawania galerii dla apartamentu poprzez wgranie zdjęć nowych lub wybranie dodanych wcześniej z biblioteki 
* Przeglądanie wiadomości od użytkowników z możliwością podglądu apartamentu, z którego napisał użytkownik

## Instalacja projektu
### 1. Pobranie repozytorium
Do wybranego przez siebie katalogu należy skopiować repozytorium poprzez wpisanie w wierszu poleceń
```
git clone https://github.com/FilipKotelon/BooKing.git
```
lub pobranie repozytorium ręcznie w formie .zip i rozpakowanie go.

### 2. Instalacja bazy danych oraz potrzebnych narzędzi
Do przeglądania kodu oraz uruchomienia projektu potrzebny jest program Visual Studio 2019 (darmowa wersja Community wystarczy). 
Po jego zainstalowaniu w wierszu poleceń należy wykonać poniższe polecenia:
```
sqllocaldb create booking
sqllocaldb start booking
```
Następnie w Visual Studio należy otworzyć okno "SQL Server Object Explorer" i kliknąć ikonkę z etykietą "Add SQL Server". Z dostępnych instancji w zakładce "Local" należy wybrać "booking", a następnie wcisnąć przycisk "Connect"(pozostałe opcje domyślne).

W drzewku, trzeva rozwinąć nowo dodaną instancję "booking", kliknąć prawym przyciskiem myszy na "Databases", wybrać "Add New Database" i nazwać bazę danych "booking".

### 3. Aktualizacja schematu bazy danych
W wierszu poleceń otwartym w katalogu zawierającym plik .csproj należy wpisać kolejno te komendy:
```
dotnet tool install --global dotnet-ef
dotnet ef migrations add Initial
dotnet ef database update
```

Po wykonaniu tych czynności projekt jest gotowy do użytkowania.

## Opcjonalnie: edycja plików js i scss
Aby edytować pliki js oraz scss należy w 3 osobnych oknach wiersza poleceń (otwartego w katalogu zawierającym plik .csproj) wykonać 3 osobne komendy:
```
//Do kompilowania głównych styli
nmp run compile:sass
//Do kompilowania styli panelu administracyjnego
npm run compile-admin:sass
//Do przetwarzania js na wersję działającą we wszystkich wspieranych przeglądarkach
npm run dev
```
Pliki wwwroot/js/admin.js oraz wwwroot/js/site.js nie powinny być ręcznie edytowane - są docelowymi plikami z przetworzonym kodem. Zamiast tego należy edytować pliki znajdujące się w folderach odpowiadających im nazwom.
Podobnie jest z plikami css - wwwroot/css/admin.css oraz wwwroot/css/style.css. Aby edytować style, należy edytować je w plikach scss.
