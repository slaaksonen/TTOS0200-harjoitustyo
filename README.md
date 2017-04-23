# TTOS0200-harjoitustyo

## Harjoitustyön tekijät

	Sebastian Laaksonen
	Jon Sundberg
	Aapo Ratas

## Laukkukaupan inventaario työkalu

	Tarkoituksena rakentaa työkalu johon voidaan kirjata tuotteet. Tuotteet tulee pystyä
	erottelemaan (esim. laukku, lompakko, matkalaukku jne..). Työkalu myös laskee loppusummat
	ja mahdollistaa jokaisen tuoteryhmän tulostamisen tiedostoon.
	
## Ominaisuudet

	- Mahdollisuus lisätä tuotteet
	- Tuotteiden erittely (esim. nahkalaukku, matkalaukku, lompakko jne..)
	- Mahdollisuus tulostaa kaikki tuoteryhmistä tiedostoon
	- Tulostaa lopullinen "inventaario"
	- Versionhallinta GitHubissa
	
## Alustava suunnitelma

![](http://hajotus.net/~sebastianl/TTOS0200/kaavio.png)

## Zip - tiedosto

[TTOS0200-harjoitustyo](http://student.labranet.jamk.fi/~K2132/harjoitustyo/)

# Raportti

## Johdanto

Ryhmämme aiheeksi valikoitui suunnitella ja toteuttaa inventaariotyökalu, joka helpottaa tietojen tallentamista, sekä esimerkiksi vanhojen inventaarioiden tarkastelua.
Tavoitteenamme oli toteuttaa yksinkertainen ja selkeä sovellus, johon syötetään tuotteiden tietoja, ja lopuksi tallennetaan koko inventaario tekstitiedostoksi. Kaikki inventaariot tallentuvat samaan kansioon, ja ne voidaan myöhemmin avata tarkastelua varten.


## Käyttöympäristö

Sovelluksen suunnitteluun käytimme Sebastianin kotikonetta ja ohjelmoinnin suoritimme Visual Studiolla. Sovelluksen tekoon käytimme UWP(Universal Windows Platformia), minkä graafisen puolen kielenä on opintojaksolta tuttu Xaml ja ohjelmistopuolen kielenä C#.

## Toteutus

### Graafinen toteutus

Lähdimme toteuttamaan työtä ensiksi suunnittelemalla sovelluksen loogisen toiminnan alkaen ensimmäisestä vaiheesta (mitä ruudulla näkyy, mitä vaihtoehtoja käyttäjällä tulee olla, ja mitä välivaiheita tulee olla näiden tarpeiden toteuttamiseksi). Kun idea oli selvillä, aloimme toteuttamaan sovelluksen graafista puolta. Loimme Xamlia käyttäen alkunäkymän, mistä käyttäjä voi esimerkiksi valita uuden inventaarion luomisen, tai vanhojen selailun. Teimme graafisesta puolesta täysin toimivan, eli loimme napit ja linkit eri näkymien välille.

### Toiminnallisen puolen toteutus

Kun saimme graafisen näkymän toimimaan, aloimme suorittamaan toiminnallista puolta. 
Ensimmäinen asia mitä lähdimme pohtimaan oli se, kuinka uuden inventaarion luomisessa saamme luotua uuden tiedoston, sekä tallennettua kaikki syötetty tieto tähän yhteen tiedostoon. Ongelmia hieman tuotti se, kuinka tiedostoon tallennettavaa dataa saadaan lisättyä ilman että se korvaa vanhan datan. Toiseksi selvitimme kuinka saamme avattua nämä tiedostot. Muuten koodaaminen oli melko selkeää, eikä tuottanut meille suurempia ongelmia. 


## Työaikaraportti

Harjoituksen teon suoritimme aina yhdessä joko paikanpäällä tai etäyhteyden / Skypen välityksellä. Alkuvaiheessa olimme enemmän paikanpäällä, mutta kun kuviot alkoivat olemaan selvät siirryimme etätyöskentelyyn. Jokainen ryhmämme jäsen etsi tietoa ja eri toteutustapoja, sekä testasi niitä myös itsenäisesti, mutta toteutuksen teimme lopulta yhdessä ja laskimme vain tämän ajan työajaksi. Itse työn rakenteen suunnitteluun meillä kului noin pari tuntia. Graafiseen toteutukseen aikaa meni enemmän, noin 6 tuntia, sillä alkuun oli hieman vaikeuksia herätellä muistia Xamlin käytön kanssa. Tämän vaiheen suoritimme kerralla. Ennen toiminnallisen osuuden alkua etsimme erilaisia tapoja toteuttaa, esimerkiksi juuri uuden tiedoston luotiin. Jätimme tämän roikkumaan jokaisen ajatuksiin, ja kun lopulta aloimme toteuttamaan tehtävää oli meillä jo melko selvää, miten tämä saadaan toteutettua. Aikaa toteutukseen kului noin 12 tuntia, ja jaoimme sen kahteen osaan, jonka aikana saimme sovelluksen lähestulkoon valmiiksi. Lopuksi vielä testasimme ohjelman toimivuuden mihin kului noin tunti.

## Ongelmat/Ratkaisut

Ensimmäinen ongelma meillä oli luoda uusi teksti tiedosto. Tämän tekemiseen meillä kului useampi tovi. Useiden ohjeiden avulla saimme kuitenkin lopulta tämänkin tehtyä.  Ehkä suurin ongelmamme oli kuitenkin saada kaikki tuotteet tulostettua teksti tiedostoon, sillä meidän skenaariossamme aina viimeisin tuote korvasi kaiken muun. Tämän selvittämiseen meillä kului useampi tunti. Lopulta ratkaisu oli liiankin helppo, sillä meidän tulostus komentomme kirjoitti uuden tekstin aina vanhan päälle. Append komennolla saimme lopulta kaiken tekstin tiedostoon.

## Testaus

Testasimme ohjelmaa tottakai jatkuvasti, mutta lopuksi kävimme vielä jokaisen kohdan erikseen läpi. Kokeilimme myös tietoisesti käyttää sovellusta ’’väärin’’ ja katsoa johtaako se jonkinlaisiin ongelmiin, mutta sovellus toimi näissäkin tapauksissa toivotulla tavalla.

## Yhteenveto

Mielestäni saimme tehtävän toteutettua melko hyvin ja hyvässä ajassa ilman suurempia ongelmia. Työ itsessään ei ole ehkä vaikeimmasta päästä, mutta mielestäni se soveltaa kurssilla opittuja asioita melko hyvin.  Uuttakin tuli hieman opittua ja aivan kaikkea työssä käytetyistä tekniikoista ei myöskään ole käyty tunnilla. Antaisin työstä arvosanaksi 3, sillä toteutuksesta tuli niin kuin pitikin: yksinkertainen ja selkeä.
