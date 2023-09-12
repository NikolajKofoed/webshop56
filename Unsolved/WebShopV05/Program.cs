
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 8;
int noOfDVDsInOrder = 3;
int noOfGamesInOrder = 2;

double priceOfBooks = noOfBooksInOrder * netPriceBook;
double priceOfDVDs = noOfDVDsInOrder * netPriceDVD;
double priceOfGames = noOfGamesInOrder * netPriceGame;

double tax = 1.10;
int shippingPrice = 49;
double creditCardFee = 1.02;

double totalPrice = ((( priceOfBooks + priceOfDVDs + priceOfGames ) * tax) + shippingPrice) * creditCardFee;


Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

