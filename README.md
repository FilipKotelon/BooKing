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
