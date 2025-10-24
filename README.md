# Mini-Projekt CRUD: SeaCreature (Wymaganie A)

Projekt studencki (CRUD × 2 encje) realizujący Wymaganie A: pełny CRUD end-to-end dla jednej encji.

* Encja: SeaCreature (Mieszkańcy morskie)
* Technologia: .NET 8 (C#) Web API, Entity Framework Core, SQLite
* Frontend: HTML, CSS, JavaScript (SPA)



## 1. Opis Endpointów (API)

Główny kontroler znajduje się pod adresem /api/SeaCreatures.

| Metoda | URL | Opis |
| GET | /api/SeaCreatures | Pobiera listę wszystkich mieszkańców morskich. |
| GET | /api/SeaCreatures/{id} | Pobiera jednego mieszkańca o podanym ID. |
| POST | /api/SeaCreatures | Tworzy nowego mieszkańca (oczekuje JSON w body). |
| PUT | /api/SeaCreatures/{id} | Aktualizuje istniejącego mieszkańca (oczekuje JSON w body). |
| DELETE | /api/SeaCreatures/{id} | Usuwa mieszkańca o podanym ID. |



## 2. Jak uruchomić (Lokalnie)

Projekt składa się z dwóch części: Backendu (API) i Frontendu.

### A. Uruchomienie Backendu (SeaCreatureApi)

1.  Trzeba otworzyć plik .sln (SeaCreatureApi.sln) w Visual Studio 2022.
2.  Nastepnie otworzyć konsolę Package Manager Console (Tools > NuGet Package Manager > Package Manager Console).
3.  Wykonaj polecenie, aby stworzyć lokalną bazę danych SQLite:
   
    Update-Database
    
4.  Nacisnąć F5 lub zielony przycisk "Play", aby uruchomić serwer.
5.  I zanotować adres URL, na którym uruchomiło się API (https://localhost:7003).

### B. Uruchomienie Frontendu (SeaCreatureFrontend)

1.  Otworzyć folder SeaCreatureFrontend w dowolnym edytorze kodu (aktualnie zrobione w VS Code).
2.  Otworzyć plik **script.js**.
3.  Znaleźć stałą API_URL na górze pliku i upewnić się, że port jest taki samam, jak z Backendu.
4.  Otworzyć plik **index.html** bezpośrednio w przeglądarce (klikając go dwukrotnie).

---

## 3. Zrzut ekranu UI

Oto jak wygląda działająca aplikacja:

<img width="1906" height="964" alt="image" src="https://github.com/user-attachments/assets/2c8927e7-c52d-4e5a-bf06-a2d9ddc0c811" />
