# BaigiamasisDarbas

[Telia](https://www.telia.lt)   

1. Different methods to login to webselfcare
    1. Private client: there is a possibility to login by username and password
        1. Open webpage
        2. Click on "Prisijungti"
        3. Click on "Prisijungti"
        4. Select login method "Su slaptažodžiu"

        *Assert: check if username and password fields are visible*

    1. Private client: there is a possibility to login by bank account
        1. Open webpage
        2. Click on "Prisijungti"
        3. Click on "Prisijungti"
        4. Select login method "Per e. banką"
        5. Select bank from list
        6. Click on "Prisijungti"

        *Assert: check if user is redirected to selected bank login page*


2. New account creation
    1. Private client: unsuccessfull creation - wrong email
        1. Open webpage
        2. Click on "Prisijungti"
        3. Click on "Susikurkite paskyrą"
        4. Type "email" into Email input field
        5. Click on "Tęsti"
       
       *Assert: check if email input field becomes red and error message with text "Neteisingai įvestas el. pašto adresas" is visible* 


3. Global search functionality
    1. Search for existing product by product category name
        1. Open webpage
        2. Click on search icon
        3. Type product name "samsung"
        4. Press Enter (from keyboard)

        *Assert: check if header of results page contains the same name as it was in search input field* 



4. Product comparison
    1. Two products comparison
        1. Open webpage
        2. Click on E-shop selection
        3. Select "Telefonai"
        4. Select checkbox "Palyginti" next to the first phone from products list
        5. Select checkbox "Palyginti" next to the second phone from products list
        6. Click on "Prekių palyginimas" button
        7. Click on "Palyginti pasirinktas" button
        8. Open product comparison page

        *Assert: check if compared products titles are the same as they were selected from products list*


5. Phones page functionality
    1. Filters functionality
        1. Open webpage
        2. Click on E-shop selection
        3. Select "Telefonai"
        4. Select "Apple" checkbox

        *Assert: check if all products in results page contains selected checkbox value*



6. Buy a new product 
    1. Add product into basket without login
        1. Open webpage
        2. Click on E-shop selection
        3. Select "Telefonai"
        4. Select first phone from the list
        5. Select "Be mokėjimo plano" button
        6. Select "Visa kaina" radio button
        7. Click on "Užsakyti" button

        *Assert: check if the selected product was added into basket by comparing names*





