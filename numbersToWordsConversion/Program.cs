string isNegative = "";
try
{
    Console.WriteLine("Enter a Number to convert to currency");
    string number = Console.ReadLine();
    number = Convert.ToDouble(number).ToString();
     
    if (number == "0")
    {
        Console.WriteLine("The number in currency fomat is \nZero Only");
    }

    Console.ReadKey();
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}