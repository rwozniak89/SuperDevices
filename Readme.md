#Rozwi¹zanie
1. Czêœæ frontendowa - Tak z wykorzystaniem gotowego szablonu MVC
2. Czêœæ backendowa - Tak z wykorzystaniem wersji .NET 7.

1.a) Frontend zawiera ekran logowania oraz rejestracji u¿ytkownika - TAK z wykorzystaniem dostêpnego z biblioteki Mictrosft.AspNetCore.Idetntiy.UI/IdentityUser z .NET
przyk³adowy login:x1@x.pl has³o:1qazXSW@ ale mo¿na za³o¿yæ swoje konto.

1.b) Frontend zawiera stronê z wyœwietlan¹ list¹ dodanych urz¹dzeñ, mo¿liwoœæ dodania nowego urz¹dzenia do listy oraz usuniêcia urz¹dzenia z listy. - TAK.

2.a) Czêœæ backendowa to standardowe web API z dwoma kontrolerami (users, devices). - TAK, kontroler Device utworzony bezpoœrednio w kodzie natomiast kontroler Users z wykorzystaniem dostêpnego z biblioteki Microsoft.AspNetCore.Idetntiy/IdentityUser z .NET

2.b) Musi ona posiadaæ dowoln¹ bazê danych (najlepiej SQLite aby osobne oprogramowania nie by³y konieczne do uruchomienia). - TAK jest SQLite, do³¹czony do solucji, w projekcie .WebApp w lokalizacji Data/Db.

2.c) Tabela users powinna zawieraæ wszystkich u¿ytkowników posiadaj¹cych dostêp do korzystania z aplikacji. - TAK, u¿ytkownicy dodawani s¹ do tabeli po zarejestrowaniu.
2.d) Tabela device powinna posiadaæ minimum kolumny Id, Name, SerialNumber. - TAK, zawiera

2.e) wzorce projektowe - TAK - wzorce i mechanizmy jak Repository pattern/Unityofowrk/mapper, DataTransferObjects/Viewmodels/Factory Dodatkowo podzia³ projektów w solucji na .WebApp, .Domain., DataAccess, .Base

2.f) Logowanie do aplikacji powinno odbywaæ siê w oparciu o konta u¿ytkowników, którzy zarejestrowali siê w aplikacji lub przez zewnêtrznego dostawcê (np. konto systemu Windows). - Tak jest wewnêtrzny mechanizm logowania/rejestracji oparty o bibliotekê Microsoft.AspNetCore.Idetntiy/IdentityUser z .NET

2.g) Aplikacja musi dowolnym sposobem trzymaæ stan zalogowanego u¿ytkownika np. (cookie, access token w przegl¹darce). - tak wykorzystano domyœlny mechanizm Cookies - AspNetCore.Identity.Application  

2.h) Napisanie kilku testów jednostkowych zostanie oceniono dodatkowo - TAK, dodano projekt oparty o xUnit, z kilkoma szybkimi testami.


#Cel zadania: 
sprawdzenie stylu pisania kodu, wykorzystywania wzorców itd.

#treœæ:
Przygotowaæ aplikacjê webow¹ w œrodowisku .NET:

1. Czêœæ frontendowa napisana przy wykorzystaniu dowolnej biblioteki lub frameworka (np. Blazor, React, Angular, czysty JS/TS).
2. Czêœæ backendowa napisania w .NET 6/7.

Frontend powinien zawieraæ ekran logowania oraz rejestracji u¿ytkownika, a tak¿e stronê z wyœwietlan¹ list¹ dodanych urz¹dzeñ, mo¿liwoœæ dodania nowego urz¹dzenia do listy oraz usuniêcia urz¹dzenia z listy.
Czêœæ graficzna nie bêdzie szczególnie oceniana dlatego nia nale¿y przyk³adaæ siê do wygl¹du aplikacji.

Czêœæ backendowa to standarodwe web API z dwoma kontrolerami (users, devices). Musi ona posiadaæ dowoln¹ bazê danych (najlepiej SQLite aby osobne oprogramowania nie by³y konieczne do uruchomienia).
Tabela users powinna zawieraæ wszystkich u¿ytkowników posiadaj¹cych dostêp do korzystania z aplikacji. Tabela device powinna posiadaæ minimum kolumny Id, Name, SerialNumber.
Pomimo faktu, ¿e zadanie jest typowo CRUD-owe lepiej oceniane bêdzie jeœli zostanie wykorzystany dowolny wzorzec projektowy (np. CQRS, Repository pattern).
Logowanie do aplikacji powinno odbywaæ siê w opraciu o konta u¿ytkowników, którzy zarejestrowali siê w aplikacji lub przez zewnêtrznego dostawcê (np. konto systemu Windows).
Aplikacja musi dowolnym sposobem trzymaæ stan zalogownego u¿ytkownika np. (cookie, access token w przegl¹darce).
Napisanie kilku testów jednostkowych zostanie oceniono dodatkowo.

Ukoñczone zadanie (kody Ÿród³owe, krótka instrukcja uruchomienia) nale¿y umieœcic w dowolnym serwisie z repozytoriami kodu np. GitHub lub spakowaæ i wys³aæ jako za³¹cznik pod ten adres email...

