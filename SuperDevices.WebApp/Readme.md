#rozwiązanie
1. Część frontendowa - Tak z wykorzystaniem gotowego szablonu MVC
2. Część backendowa - Tak z wykrozystaniem wersji .NET 7.

1.a) Frontend zawiera ekran logowania oraz rejestracji użytkownika - TAK z wykorzystaniem dostępnego z biblioteki Mictrosft.AspNetCore.Idetntiy.UI/IdentityUser z .NET
1.b) Frontend zawiera stronę z wyświetlaną listą dodanych urządzeń, możliwość dodania nowego urządzenia do listy oraz usunięcia urządzenia z listy. - TAK.

2.a) Część backendowa to standarodwe web API z dwoma kontrolerami (users, devices). - TAK, kontroler Device utworzony bezpośrednio w kodzie natomiast kontroler Users z wykorzystaniem dostępnego z biblioteki Microsoft.AspNetCore.Idetntiy/IdentityUser z .NET
2.b) Musi ona posiadać dowolną bazę danych (najlepiej SQLite aby osobne oprogramowania nie były konieczne do uruchomienia). - Tak jest SQLite, dołączony do projektu.
2.c) Tabela users powinna zawierać wszystkich użytkowników posiadających dostęp do korzystania z aplikacji. - Tak, użytkonicy dodawani są do dtabeli po zarejetrowaniu.
2.d) Tabela device powinna posiadać minimum kolumny Id, Name, SerialNumber. - Tak, zawiera
TODO: 2.e) wzorce projektowe Repository pattern, Unityofowrk, mapper, Viewmodels...
2.f) Logowanie do aplikacji powinno odbywać się w opraciu o konta użytkowników, którzy zarejestrowali się w aplikacji lub przez zewnętrznego dostawcę (np. konto systemu Windows). - Tak jest wewnętrzny mechanizm logowania/rejestracji oparty o bibliotekę Microsoft.AspNetCore.Idetntiy/IdentityUser z .NET
2.g) Aplikacja musi dowolnym sposobem trzymać stan zalogownego użytkownika np. (cookie, access token w przeglądarce). - tak wykorzystano domyślny mchanizm Cookies - AspNetCore.Identity.Application  
TODO: 2.h) Napisanie kilku testów jednostkowych zostanie oceniono dodatkowo.



#Cel zadania: 
sprawdzenie stylu pisania kodu, wykorzystywania wzorców itd.

#treść:
Przygotować aplikację webową w środowisku .NET:

1. Część frontendowa napisana przy wykorzystaniu dowolnej biblioteki lub frameworka (np. Blazor, React, Angular, czysty JS/TS).
2. Część backendowa napisania w .NET 6/7.

Frontend powinien zawierać ekran logowania oraz rejestracji użytkownika, a także stronę z wyświetlaną listą dodanych urządzeń, możliwość dodania nowego urządzenia do listy oraz usunięcia urządzenia z listy.
Część graficzna nie będzie szczególnie oceniana dlatego nia należy przykładać się do wyglądu aplikacji.

Część backendowa to standarodwe web API z dwoma kontrolerami (users, devices). Musi ona posiadać dowolną bazę danych (najlepiej SQLite aby osobne oprogramowania nie były konieczne do uruchomienia).
Tabela users powinna zawierać wszystkich użytkowników posiadających dostęp do korzystania z aplikacji. Tabela device powinna posiadać minimum kolumny Id, Name, SerialNumber.
Pomimo faktu, że zadanie jest typowo CRUD-owe lepiej oceniane będzie jeśli zostanie wykorzystany dowolny wzorzec projektowy (np. CQRS, Repository pattern).
Logowanie do aplikacji powinno odbywać się w opraciu o konta użytkowników, którzy zarejestrowali się w aplikacji lub przez zewnętrznego dostawcę (np. konto systemu Windows).
Aplikacja musi dowolnym sposobem trzymać stan zalogownego użytkownika np. (cookie, access token w przeglądarce).
Napisanie kilku testów jednostkowych zostanie oceniono dodatkowo.

Ukończone zadanie (kody źródłowe, krótka instrukcja uruchomienia) należy umieścic w dowolnym serwisie z repozytoriami kodu np. GitHub lub spakować i wysłać jako załącznik pod ten adres email




#Extra
##Packages
Microsoft.EntityFrameworkCore 
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Sqlite

##PM
ls
cd Meg
dotnet ef migrations add initX
dotnet ef database update

## DB Browser for SQLite
https://sqlitebrowser.org/

### for sqlite migrations
table.Column<string>(nullable:  -> table.Column<string>(maxLength: 256, nullable:
(max) -> (256)
