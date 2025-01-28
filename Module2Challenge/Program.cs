
using System;

// MPG Calculator
// Ask for user input: prompt for number of miles driven; 
// ask user for amount of gasoline used (in gallons);

// Variables
Console.WriteLine("Enter number of miles driven: "); // Prompting for user input
double milesDriven = Convert.ToDouble(Console.ReadLine()); // converting to a double

// repeat for second prompt - gallons used
Console.WriteLine("Enter number of gallons used: ");
double gallonsUsed = Convert.ToDouble(Console.ReadLine());
// use both sets of user input to do math, set in variable
// milesDriven = Convert.ToDouble(milesDriven);
// gallonsUsed = Convert.ToDouble(gallonsUsed);
double mpg = milesDriven / gallonsUsed;
string convertedMPG = $"The total MPG per trip indicated is {mpg:0.00} mpg."; // setting variable - needed a string to use, I was having issues converting other ways
// did some suplimental research to figure out best path forward - tried useing Mtah.Round, but that was a little shaky/I read that is not a good habit to get into
// ended with string method above, using the mpg variable to set decimal format issue (initially was printing up to 9 digits due to variable type - which can be helpful, 
// but in this instance it is unecesarry to have that many)
// Output once input is entered, and program does math
Console.WriteLine(convertedMPG);