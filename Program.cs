using System;


//string joniBirthDay = "02/02/1995";
//DateTime dateTime = DateTime.Parse(joniBirthDay);
//Console.WriteLine($"Joni was born :  {dateTime}");

//DateTimeOffset dateTimeOffset = DateTimeOffset.Parse(joniBirthDay);
//Console.WriteLine($"Joni was born {dateTimeOffset}");



string userInput;
do
{
    Guid newGuid = Guid.NewGuid();
    string guidString = newGuid.ToString();
    Clipboard.SetText(guidString);
    Console.WriteLine("do you want another Guid ? (yes or press any bottom to exit )");
    userInput = Console.ReadLine();

}
while (userInput == "yes");