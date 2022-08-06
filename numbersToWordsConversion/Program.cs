using TWord;

Console.WriteLine("Enter a Number to convert to currency:");
string number = Console.ReadLine();
var result = Convert.ToDecimal(number);

IAtWord at = new AtWordBuilder()
               .SetLanguage(Language.English)
               .SetCurrency(CurrencySymbol.USD)
               .Build();

var words = at.ToWords(result);
Console.WriteLine(words); 
