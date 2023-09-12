
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 0;
int noOfDVDsInOrder = 0;
int noOfGamesInOrder = 0;

double totalNetPrice = netPriceBook * noOfBooksInOrder + 
                       netPriceDVD * noOfDVDsInOrder + 
                       netPriceGame * noOfGamesInOrder;

// SO#1
bool receiveSpecialOffer1 = totalNetPrice > 1000;


// SO#2
bool receiveSpecialOffer2 = noOfBooksInOrder > noOfGamesInOrder;


// SO#3
bool receiveSpecialOffer3 = noOfGamesInOrder >= 10 || noOfDVDsInOrder >= 10 || noOfBooksInOrder > 10;


// SO#4
bool receiveSpecialOffer4 = noOfBooksInOrder >= 10 && noOfBooksInOrder <= 20 || noOfDVDsInOrder >= 10 && noOfDVDsInOrder <= 20 || noOfGamesInOrder >= 5;


// variable til at tælle hvor mange special offers der bliver sendt til kunden.
int numberOfSpecialOffersReceived = 0;

/* incrementere ('++' <- increment) aka (numberOfSpecialOffersReceived = numberOfSpecialOffersReceived + 1), hvis de returner true, hvis falsk sker der ingenting
 * fx hvis du har en net pris over 1000, og noOfBooksInOrder er større end noOfGamesInOrder
 * så numberOfSpecialOrdersRecieved = 2*/
if (receiveSpecialOffer1) { numberOfSpecialOffersReceived++; }
if (receiveSpecialOffer2) { numberOfSpecialOffersReceived++; }
if (receiveSpecialOffer3) { numberOfSpecialOffersReceived++; }
if (receiveSpecialOffer4) { numberOfSpecialOffersReceived++; }

// de her -> {  } er hvor man skriver hvad man vil have ens kode skal gøre, i dette tilfælde hvis receiveSpecialOffer er sandt.

// sammenlign numberOfSpecialOffersReceived med 2. hvis kunden har fået tilsendt 2 special offers, skal special offer 5 også sendes
bool receiveSpecialOffer5 = numberOfSpecialOffersReceived == 2;






Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");

Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
Console.WriteLine($"You qualify for special offer #5 : {receiveSpecialOffer5}");

