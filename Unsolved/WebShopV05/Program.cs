

//variable
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 0;
int noOfDVDsInOrder = 0;
int noOfGamesInOrder = 0;

//flere variable, men de her er lavet for at koden er nemmere at læse. for et eksempel kig i 'The Agile Samurai' s196 - s202

double priceOfBooks = noOfBooksInOrder * netPriceBook;
double priceOfDVDs = noOfDVDsInOrder * netPriceDVD;
double priceOfGames = noOfGamesInOrder * netPriceGame;

// endnu flere variable

double tax = 1.10;
int shippingPrice = 49;
double creditCardFee = 1.02;

// udregn den totale pris, baseret på de info vi får givet i opgaven

double totalPrice = (( priceOfBooks + priceOfDVDs + priceOfGames ) * tax + shippingPrice) * creditCardFee;


// udskriv hvilke varer du køber og hvor meget det kommer til at koste

Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

