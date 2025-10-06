string myString = "123";
int myNumber = Convert.ToInt32(myString); // konverzia zo string na int
myNumber = myNumber + 10;
myString = myString + "10";
Console.WriteLine(myNumber); // vypíše 133
Console.WriteLine(myString);