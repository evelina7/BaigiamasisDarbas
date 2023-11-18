# BaigiamasisDarbas

https://www.telia.lt   //link'as dar bus sutvarkytas, kad atsivaizduotų gražiai

1. Different methods to login to webselfcare
    1. Private client: there is a possibility to login by username and password
        1. Open webpage
        2. Click on "Prisijungti"
        3. Click on "Prisijungti"
        4. Select login method "Su slaptažodžiu"

        Assert: check if username and password fields are visible

    1. Private client: there is a possibility to login by bank account
        1. Open webpage
        2. Click on "Prisijungti"
        3. Click on "Prisijungti"
        4. Select login method "Per e. banką"
        5. Select bank from list
        6. Click on "Prisijungti"

        Assert: check if user is redirected to selected bank login page


2. New account creation
    1. Private client: unsuccessfull creation - wrong email
        1. Open webpage
        2. Click on "Prisijungti"
        3. Click on "Susikurkite paskyrą"
        4. Type "email" into Email input field
        5. Click on "Tęsti"
       
       Assert: check if email input field becomes red and error message with text "Neteisingai įvestas el. pašto adresas" is visible 


3. Global search functionality
    1. Search for existing product by product category name
        1. Open webpage
        2. Click on search icon
        3. Type product name "samsung"
        4. Press Enter (from keyboard)

        Assert: check if header of results page contains the same name as it was in search input field 


4. Buying a product    
    1. Buy a product for full price without price plan for non-customer   (šis scenarijus man nepatinka, nes turi labai daug žingsnių. Galvojant, kad jei būtų kaip regression testai, jis kaip ir tiktų. Tačiau čia nėra regression testai, tad galbūt išskaidyti į mažesnius test scenarijus ir tiesiog juos tada paminėti prie preconditions? Pvz test scenarijus - produkto pridėjimas į krepšelį ir pan.)
        1. Open webpage
        2. Click on E-shop selection
        3. Select "Mobilieji telefonai"
        4. Click on a first phone from products list
        5. Select "Be plano"
        6. Select radio button "Visa kaina"
        7. Click on "Užsakyti"
        8. In a new page click on "Užsakyti" again
        9. 

        Assert: check if user is redirected to external page for payment

5. Product comparison
    1. Two products comparison
        1. Open webpage


6. Phones page functionality
    1. Filters functionality
        1. Open webpage




