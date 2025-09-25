# Contributing

Kiitos kiinnostuksesta osallistua projektiin! Tämä ohjeistus kuvaa kehittäjille sovitun työtavan, jotta ylläpito pysyy selkeänä ja johdonmukaisena.

## Haaramalli
- `main`: tuotantoon hyväksytty, julkaistava versio.
- `dev`: aktiivinen kehityshaara, johon valmiit ominaisuudet yhdistetään ennen julkaisua.
- `feature/*`: yksittäisten ominaisuuksien tai korjausten työstö. Pidä haaran nimi ytimekkäänä ja kuvaavana (esim. `feature/project-gallery`).

## Commit-käytäntö
Noudata [Conventional Commits](https://www.conventionalcommits.org/) -formaattia: `type(scope): lyhyt kuvaus`.

Jokaisessa commitissa tulee lisäksi kirjata viestin runkoon kolme osiota:
- **WHY** - miksi muutos tehdään.
- **WHAT** - mitä teknisesti muuttui.
- **HOW** - miten ratkaisu toteutettiin tai miten vaikutukset on huomioitu.

Esimerkki:
```
feat(web): add project carousel

WHY: Portfolio tarvitsee selkeän projektien esittelytavan.
WHAT: Lisätty karusellikomponentti ja data-binding projektikortteihin.
HOW: Toteutettu Blazor-komponentti, lisätty tyylit `Shared/Carousel.razor.css` -tiedostoon.
```

## Pull Requestit
PR:t avataan `feature/*` -> `dev`. Käytä seuraavaa rakennetta kuvaamaan muutokset selkeästi:
```
## What
- Kuvaa käyttäjäarvon tai tärkeimmät koodimuutokset.

## Why
- Perustele, miksi muutos tarvitaan juuri nyt.

## How
- Selitä toteutustapa ja mainitse mahdolliset riskit tai seurantatarpeet.

## Screens
- Liitä kuvakaappaukset tai GIF, jos UI muuttuu. Muussa tapauksessa kerro "Ei UI-muutoksia".
```
Pidä PR:t pieninä ja itsenäisesti tarkastettavina. Varmista, että kaikki keskustelut on ratkaistu ennen yhdistämistä.

## Koodityyli ja analyysit
- Projekti käyttää `Microsoft.CodeAnalysis.NetAnalyzers` -pakettia staattiseen analyysiin.
- `TreatWarningsAsErrors = true` on pakollinen kaikissa projekteissa.
- Julkisille API-pinnoille on kirjoitettava XML-dokumentaatiokommentit.
- Säilytä koodikommentit harkiten: käytä `NOTE`, `TODO` ja `HACK` -tunnisteita vain, kun ne ovat oikeasti tarpeellisia ja pidä ne ajantasalla.

## Build ja testaus
Aja vähintään seuraavat komennot ennen PR:ää:
```
dotnet build
dotnet test
```
Lisäksi varmista, että analyysit ovat puhtaat eikä varoituksia jää jäljelle.

## Dokumentointi
- Päivitä README:t, arkkitehtuurikuvat ja muut dokumentit muutosten yhteydessä.
- Toteuta XML-doc-kommentit aina, kun julkinen API muuttuu.
- Kirjaa merkittävät päätökset tai avoimet kysymykset projektin dokumentaatioon.

Yhteistyö sujuu parhaiten avoimella viestinnällä - nosta kysymykset ajoissa ja ehdota parannuksia rohkeasti. Tervetuloa kehittämään!
