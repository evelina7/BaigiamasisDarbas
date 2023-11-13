# BaigiamasisDarbas

https://www.telia.lt/

1. Skirtingi prisijungimo prie savitarnos variantai:
    1. Yra galimybė prisijungti su el. paštu ir slaptažodžiu:
        1. Atsidaryti svetainę
        2. Spausti “Prisijungti”
        3. Pasirinkti prisijungimą būdą “Su slaptažodžiu”

            Assert: patikrinti, kad yra el. pašto ir slaptažodžio įvedimo laukai


2. Skirtingi prisijungimo prie savitarnos variantai:
    1. Yra galimybė jungtis per e.banką:
        1. Atsidaryti svetainę
        2. Spausti “Prisijungti”
        3. Pasirinkti prisijungimą būdą “Per e.banką”
        4. Pasirinkti swedbank
        5. Spausti "Prisijungti"
        
            Assert: patikrinti, kad vartotojas nukreipiamas į swedbank puslapį


3. Vartotojo paskyros sukūrimas:
    1. El. pašto įvedimo lauko validacija:
        1. Atsidaryti svetainę
        2. Spausti “Prisijungti”
        3. Privačių klientų paskyrų bloke spausti “Susikurkite paskyrą”
        4. El. pašto įvedimo lauke įvesti žodį “Test”
        5. Spausti mygtuką “Tęsti”

            Assert: patikrinti, ar laukas nusispalvino raudonai ir atsirado papildomas klaidos pranešimo tekstas


4. Viršutinio meniu funkcionalumas:
    1. Paieškos laukelis:
        1. Atsidaryti svetainę
        2. Paspausti paieškos mygtuką viršutiniame meniu
        3. Atsiradusiame laukelyje suvesti “Samsung”
        4. Spausti Paieškos mygtuką
   
           Assert: patikrinti, kad naujai atsidariusiame puslapyje prie paieškos rezultatų parašyta įvesta frazė “samsung”

5. Filtrų funkcionalumas mobliųjų telefonų puslapyje:
    1. Filtras pagal pavadinimą:
        1. Atsidaryti svetainę
        2. Viršutiniame meniu spausti E.parduotuvė
        3. Pasirinkti “Telefonai”
        4. Naujame puslapyje paskrolinti žemyn
        5. Pažymėti “Apple” pavadinimo checkbox’ą
         
        Assert: patikrinti, kad naujai atsidariusiame puslapyje atsirado antraštė “apple iphone mobilieji telefonai”   
       
        arba
        
        Assert: patikrinti, kad kiekvienas surastas rezultatas pavadinime turi žodį “apple”  ? 






