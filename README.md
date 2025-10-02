# Portfolio

Moderni Blazor Server -pohjainen työnhakuportfolio, joka asettaa kerrosarkkitehtuurin valmiiksi jatkokehitystä varten. Tavoitteena on pitää ratkaisu kevyenä nyt, mutta antaa selkeät paikat liiketoimintalogiikalle, tietokannalle ja rajapinnoille myöhemmin.

## Rakenne
- `src/Portfolio.Web` – selainkerros (feature-pohjaiset sivut, lokalisointi, layoutit)
- `src/Portfolio.Application` – sovelluslogiikan rajapinnat ja palvelut
- `src/Portfolio.DAL` – tietokerroksen varaus (EF Core InMemory placeholder, repository-rata)
- `src/Portfolio.Contracts` – DTO:t, enumit ja abstrahoidut sopimukset kerrosten välillä

## Kehittäjän pikaohje
1. Asenna .NET SDK 8.0 tai uudempi.
2. Suorita `dotnet restore` ja `dotnet build` ratkaisun juuresta varmistaaksesi asetukset.
3. Aja sovellus komennolla `dotnet run --project src/Portfolio.Web/Portfolio.Web.csproj` tai käytä VS Code F5 -komentosarjaa.
4. Selain avautuu osoitteeseen `https://localhost:7267` (launchSettings asettaa myös HTTP-portin 5147).

## Lokalisaatio
- Oletuskulttuuri: `fi-FI`, fallback: `en-US`.
- Yhteiset tekstit `Resources/SharedResource(.resx/.fi.resx)` ja sivukohtaiset resurssit `Features/<Feature>/<Feature>Page.*.resx`.
- TODO: siirrä kulttuuriasetukset ja siemen-data oikeaan tietokantaan, kun ympäristöt on päätetty.

## Seuraavat askeleet
- Korvaa placeholder-palvelut oikealla datahaulla (DAL + ulkoiset integraatiot).
- Rakenna validoinnit ja mapperit, kun DTO:t tarkentuvat.
- Laajenna UI-tyylejä design systemin mukaisiksi ennen tuotantojulkaisua.

## Navbar
This branch initializes the Navbar feature.
