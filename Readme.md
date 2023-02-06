#Rozwi�zanie
1. Cz�� frontendowa - Tak z wykorzystaniem gotowego szablonu MVC
2. Cz�� backendowa - Tak z wykorzystaniem wersji .NET 7.

1.a) Frontend zawiera ekran logowania oraz rejestracji u�ytkownika - TAK z wykorzystaniem dost�pnego z biblioteki Mictrosft.AspNetCore.Idetntiy.UI/IdentityUser z .NET
przyk�adowy login:x1@x.pl has�o:1qazXSW@ ale mo�na za�o�y� swoje konto.

1.b) Frontend zawiera stron� z wy�wietlan� list� dodanych urz�dze�, mo�liwo�� dodania nowego urz�dzenia do listy oraz usuni�cia urz�dzenia z listy. - TAK.

2.a) Cz�� backendowa to standardowe web API z dwoma kontrolerami (users, devices). - TAK, kontroler Device utworzony bezpo�rednio w kodzie natomiast kontroler Users z wykorzystaniem dost�pnego z biblioteki Microsoft.AspNetCore.Idetntiy/IdentityUser z .NET

2.b) Musi ona posiada� dowoln� baz� danych (najlepiej SQLite aby osobne oprogramowania nie by�y konieczne do uruchomienia). - TAK jest SQLite, do��czony do solucji, w projekcie .WebApp w lokalizacji Data/Db.

2.c) Tabela users powinna zawiera� wszystkich u�ytkownik�w posiadaj�cych dost�p do korzystania z aplikacji. - TAK, u�ytkownicy dodawani s� do tabeli po zarejestrowaniu.
2.d) Tabela device powinna posiada� minimum kolumny Id, Name, SerialNumber. - TAK, zawiera

2.e) wzorce projektowe - TAK - wzorce i mechanizmy jak Repository pattern/Unityofowrk/mapper, DataTransferObjects/Viewmodels/Factory Dodatkowo podzia� projekt�w w solucji na .WebApp, .Domain., DataAccess, .Base

2.f) Logowanie do aplikacji powinno odbywa� si� w oparciu o konta u�ytkownik�w, kt�rzy zarejestrowali si� w aplikacji lub przez zewn�trznego dostawc� (np. konto systemu Windows). - Tak jest wewn�trzny mechanizm logowania/rejestracji oparty o bibliotek� Microsoft.AspNetCore.Idetntiy/IdentityUser z .NET

2.g) Aplikacja musi dowolnym sposobem trzyma� stan zalogowanego u�ytkownika np. (cookie, access token w przegl�darce). - tak wykorzystano domy�lny mechanizm Cookies - AspNetCore.Identity.Application  

2.h) Napisanie kilku test�w jednostkowych zostanie oceniono dodatkowo - TAK, dodano projekt oparty o xUnit, z kilkoma szybkimi testami.


#Cel zadania: 
sprawdzenie stylu pisania kodu, wykorzystywania wzorc�w itd.

#tre��:
Przygotowa� aplikacj� webow� w �rodowisku .NET:

1. Cz�� frontendowa napisana przy wykorzystaniu dowolnej biblioteki lub frameworka (np. Blazor, React, Angular, czysty JS/TS).
2. Cz�� backendowa napisania w .NET 6/7.

Frontend powinien zawiera� ekran logowania oraz rejestracji u�ytkownika, a tak�e stron� z wy�wietlan� list� dodanych urz�dze�, mo�liwo�� dodania nowego urz�dzenia do listy oraz usuni�cia urz�dzenia z listy.
Cz�� graficzna nie b�dzie szczeg�lnie oceniana dlatego nia nale�y przyk�ada� si� do wygl�du aplikacji.

Cz�� backendowa to standarodwe web API z dwoma kontrolerami (users, devices). Musi ona posiada� dowoln� baz� danych (najlepiej SQLite aby osobne oprogramowania nie by�y konieczne do uruchomienia).
Tabela users powinna zawiera� wszystkich u�ytkownik�w posiadaj�cych dost�p do korzystania z aplikacji. Tabela device powinna posiada� minimum kolumny Id, Name, SerialNumber.
Pomimo faktu, �e zadanie jest typowo CRUD-owe lepiej oceniane b�dzie je�li zostanie wykorzystany dowolny wzorzec projektowy (np. CQRS, Repository pattern).
Logowanie do aplikacji powinno odbywa� si� w opraciu o konta u�ytkownik�w, kt�rzy zarejestrowali si� w aplikacji lub przez zewn�trznego dostawc� (np. konto systemu Windows).
Aplikacja musi dowolnym sposobem trzyma� stan zalogownego u�ytkownika np. (cookie, access token w przegl�darce).
Napisanie kilku test�w jednostkowych zostanie oceniono dodatkowo.

Uko�czone zadanie (kody �r�d�owe, kr�tka instrukcja uruchomienia) nale�y umie�cic w dowolnym serwisie z repozytoriami kodu np. GitHub lub spakowa� i wys�a� jako za��cznik pod ten adres email...

