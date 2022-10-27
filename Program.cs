// Celsius to Farenheit
double userInput;
(double, tempature) CelsiusToFarenheit (double tempInCelsius)
{
    double tempInFarenheit;
    tempInFarenheit = (tempInCelsius *(9)) /5 + 32;
    Console.WriteLine($"{userInput} {tempature.Celsius} is {tempInFarenheit} {tempature.Fahrenheit}");
    return (tempInFarenheit, tempature.Fahrenheit);
}


// Celsius to Kelvin

(double, tempature) CelsiusToKelvin(double tempInCelsius)
{
    double tempInKelvin;
    tempInKelvin = tempInCelsius + 273.15;
    Console.WriteLine($"{userInput} {tempature.Celsius} is {tempature.Kelvin}");
   return (tempInKelvin, tempature.Kelvin);

}

// Farenheit to Celsius
(double, tempature) FarenheitToCelsius (double tempInFarenheit)
{
    double tempInCelsius;
    tempInCelsius = (tempInFarenheit -32) * 5;
    Console.WriteLine($"{userInput} {tempature.Fahrenheit} is {tempInCelsius} {tempature.Celsius}");
    return(tempInCelsius, tempature.Celsius);
}


//Farenheit to Kelvin
(double, tempature)FarenheitToKelvin (double tempInFarenheit)
{
    double tempInKelvin;
    tempInKelvin = (tempInFarenheit +459.6732) * 5/9;
    Console.WriteLine($"{userInput} {tempature.Fahrenheit} is {tempInKelvin} {tempature.Kelvin}");
    return(tempInKelvin, tempature.Kelvin);
}

// kelvin to farenheit

(double, tempature) KelvinToFarenheit (double tempInKelvin)
{
    double tempInFarenheit;
    tempInFarenheit = (tempInKelvin * (9))/5 - 459.67;
    Console.WriteLine($"{userInput} {tempature.Kelvin} is {tempInFarenheit} {tempature.Fahrenheit}");
    return(tempInFarenheit, tempature.Fahrenheit);
}

// kelvin to celsius
(double, tempature) KelvinToCelsius( double tempInKelvin)
{
    double tempInCelsius;
    tempInCelsius = tempInKelvin - 273.15;
    Console.WriteLine($"{userInput} {tempature.Kelvin} is {tempInCelsius} {tempature.Celsius}");
    return(tempInCelsius, tempature.Celsius);

}

//inc to ft
(double, length) InchesToFeet (double lengthInInches){
    double lengthInFeet;
    lengthInFeet = lengthInInches/12;
    Console.WriteLine($"{userInput} {length.Inch} is {lengthInFeet} {length.Feet}");
    return (lengthInFeet, length.Feet);
}

// inc to yards
(double, length) InchesToYards (double lengthInInches){
    double lengthInYards;
    lengthInYards= lengthInInches/36;
    Console.WriteLine($"{userInput} {length.Inch} is {lengthInYards} {length.Yard}");
    return (lengthInYards, length.Yard);
}

// ft to inc
(double, length) FeetToInches (double lengthInFeet){
    double lengthInInches;
    lengthInInches= lengthInFeet* 12;
    Console.WriteLine($"{userInput} {length.Feet} is {lengthInInches} {length.Inch}");
    return (lengthInInches, length.Inch);
}

// ft to yards
(double, length) FeetToYards(double lengthInFeet){
    double lengthInYards;
    lengthInYards= lengthInFeet/3;
    Console.WriteLine($"{userInput} {length.Feet} is {lengthInYards} {length.Yard}");
    return (lengthInYards, length.Yard);
}

//yards to inc

(double, length) YardsToInches (double lengthInYards){
    double lengthInInches;
    lengthInInches= lengthInYards* 36;
    Console.WriteLine($"{userInput} {length.Yard} is {lengthInInches} {length.Inch}");
    return (lengthInInches, length.Inch);
}

//yards to ft

(double, length) YardsToFeet (double lengthInYards){
    double lengthInFeet;
    lengthInFeet= lengthInYards* 3;
    Console.WriteLine($"{userInput} {length.Yard} is {lengthInFeet} {length.Feet}");
    return (lengthInFeet, length.Feet);
}


//Seconds To Minutes

(double, time) SecondsToMinutes(double timeInSeconds){
    double timeInMinutes ;
    timeInMinutes = timeInSeconds / 60;
 Console.WriteLine($"{userInput} {time.Seconds} is {timeInMinutes} {time.Minutes}");
    return (timeInMinutes, time.Minutes);
}

// Seconds to Hours 
(double, time) SecondsToHours(double timeInSeconds){
    double timeInHours ;
    timeInHours = timeInSeconds / 3600;
 Console.WriteLine($"{userInput} {time.Seconds} is {timeInHours} {time.Hours}");
    return (timeInHours, time.Hours);
}

// Hours to Seconds
(double, time) HoursToSeconds(double timeInHours){
    double timeInSeconds ;
    timeInSeconds = timeInHours * 3600;
 Console.WriteLine($"{userInput} {time.Hours} is {timeInSeconds} {time.Seconds}");
    return (timeInSeconds, time.Seconds);
    
}

//Hours to Minutes
(double, time) HoursToMinutes(double timeInHours){
    double timeInMinutes ;
    timeInMinutes = timeInHours * 60;
 Console.WriteLine($"{userInput} {time.Hours} is {timeInMinutes} {time.Minutes}");
    return (timeInMinutes, time.Minutes);

}

// Minutes to Hours
(double, time) MinutesToHours (double timeInMinutes){
    double timeInHours ;
    timeInHours = timeInMinutes / 60;
 Console.WriteLine($"{userInput} {time.Minutes} is {timeInHours} {time.Hours}");
    return (timeInHours, time.Hours);

}


// Minutes to seconds

(double, time) MinutesToSeconds (double timeInMinutes){
    double timeInSeconds ;
    timeInSeconds = timeInMinutes * 60;
 Console.WriteLine($"{userInput} {time.Minutes} is {timeInSeconds} {time.Seconds}");
    return (timeInSeconds, time.Seconds);

}
//Driver program
void DriverProgram()

{
    string MeasurementConversions = Console.ReadLine();

    if (MeasurementConversions == "1") // Celsius to Fahrenheit
    {
        Console.WriteLine("Please enter temperature in Celsius");
        userInput = double.Parse(Console.ReadLine());
        CelsiusToFarenheit(userInput);
    }

    else if ( MeasurementConversions == "2") // Farhenheit to Celsius
    {
        Console.WriteLine("Please enter temperature in Farenheit");
        userInput = double.Parse(Console.ReadLine());
        FarenheitToCelsius(userInput);
    }

    else if (MeasurementConversions == "3") // Celsius to Kelvin
    {
        Console.WriteLine("Please enter temperature in Celsius");
        userInput = double.Parse(Console.ReadLine());
        CelsiusToKelvin(userInput);
    }

    else if (MeasurementConversions == "4") // Kelvin to Celsius
    {
        Console.WriteLine("Please enter temperature in Kelvin");
        userInput = double.Parse(Console.ReadLine());
        KelvinToCelsius(userInput);
    }

    else if (MeasurementConversions == "5") // Fahrenheit to Kelvin
    {
        Console.WriteLine("Please enter temperature in Farenheit");
        userInput = double.Parse(Console.ReadLine());
       FarenheitToKelvin(userInput);
    }

    else if (MeasurementConversions == "6") // Kelvin to Fahrenheit
    {
        Console.WriteLine("Please enter temperature in Kelvin");
        userInput = double.Parse(Console.ReadLine());
        KelvinToFarenheit(userInput);
    }

    else if ( MeasurementConversions== "7") // Inches to Feet
    {
        Console.WriteLine("Please enter length in inches");
        userInput = double.Parse(Console.ReadLine());
        InchesToFeet(userInput);
    }

    else if ( MeasurementConversions== "8") // Feet to Inches
    {
        Console.WriteLine("Please enter length in feet");
        userInput = double.Parse(Console.ReadLine());
        FeetToInches(userInput);
    }

    else if (MeasurementConversions == "9") // Inches to Yards
    {
        Console.WriteLine("Please enter length in inches");
        userInput = double.Parse(Console.ReadLine());
        InchesToYards(userInput);
    }

    else if (MeasurementConversions == "10") // Yards to Inches
    {
        Console.WriteLine("Please enter length in yards");
        userInput = double.Parse(Console.ReadLine());
        YardsToInches(userInput);
    }

    else if (MeasurementConversions == "11") // Feet to Yards
    {
        Console.WriteLine("Please enter length in feet");
        userInput = double.Parse(Console.ReadLine());
        FeetToYards(userInput);
    }

    else if (MeasurementConversions == "12") // Yards to Feet
    {
        Console.WriteLine("Please enter length in yards");
        userInput = double.Parse(Console.ReadLine());
        YardsToFeet(userInput);
    }

    else if (MeasurementConversions == "13") // Seconds to Minutes
    {
        Console.WriteLine("Please enter time in seconds");
        userInput = double.Parse(Console.ReadLine());
        SecondsToMinutes(userInput);
    }

    else if ( MeasurementConversions== "14") // Minutes to Seconds
    {
        Console.WriteLine("Please enter time in minutes");
        userInput = double.Parse(Console.ReadLine());
        MinutesToSeconds(userInput);
    }

    else if (MeasurementConversions == "15") // Seconds to Hours
    {
        Console.WriteLine("Please enter time in seconds");
        userInput = double.Parse(Console.ReadLine());
        SecondsToHours(userInput);
    }

    else if ( MeasurementConversions== "16") // Hours to Seconds
    {
        Console.WriteLine("Please enter time in hours");
        userInput = double.Parse(Console.ReadLine());
        HoursToSeconds(userInput);
    }

    else if (MeasurementConversions == "17") // Hours to Minutes
    {
        Console.WriteLine("Please enter time in hours");
        userInput = double.Parse(Console.ReadLine());
        HoursToMinutes(userInput);
    }

    else if ( MeasurementConversions== "18") // Minutes to Hours
    {
        Console.WriteLine("Please enter time in minutes");
        userInput = double.Parse(Console.ReadLine());
        MinutesToHours(userInput);
    }

    else
    {
        Console.WriteLine("Invalid response. Please choose a number through 1 to 18.");
        DriverProgram();
    }

    Console.WriteLine("Would you like to do another conversion? 'Y' or 'N'");
    string anotherConversion = Console.ReadLine();

    if (anotherConversion == "Y" || anotherConversion == "y")
    {
        ConversionOptions();
        DriverProgram();
    }
}

void ConversionOptions()
{
    Console.WriteLine("Which conversion would you like to do?");
    Console.WriteLine("1. Celsius to Farenheit");
    Console.WriteLine("2. Farenheitt to Celsius");
    Console.WriteLine("3. Celsius to Kelvin");
    Console.WriteLine("4. Kelvin to Celsius");
    Console.WriteLine("5. Fahrenheit to Kelvin");
    Console.WriteLine("6. Kelvin to Farenheit");
    Console.WriteLine("7. Inches to Feet");
    Console.WriteLine("8. Feet to Inches");
    Console.WriteLine("9. Inches to Yards");
    Console.WriteLine("10. Yards to Inches");
    Console.WriteLine("11. Feet to Yards");
    Console.WriteLine("12. Yards to Feet");
    Console.WriteLine("13. Seconds to Minutes");
    Console.WriteLine("14. Minutes to Seconds");
    Console.WriteLine("15. Seconds to Hours");
    Console.WriteLine("16. Hours to Seconds");
    Console.WriteLine("17. Hours to Minutes");
    Console.WriteLine("18. Minutes to Hours");
    Console.Write("Please enter a number: ");
}

  ConversionOptions();
        DriverProgram();

enum tempature {
    Celsius,
    Fahrenheit,
    Kelvin
}
enum length{
    Inch,
    Feet,
    Yard
}
enum time{
    Seconds,
    Minutes,
    Hours
}
