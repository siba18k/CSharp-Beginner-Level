﻿namespace _4._Non_Primitive_Types;

//A set of name/value pairs(constants)- it is also a data type
// We use them when we have a number of related constants

internal abstract partial class Program
{
    public static void Main(string[] args)
    {
        const int regularAirMail = 1;
        const int registeredAirMail = 2;
        const int express = 3;
        Console.WriteLine("Number of customers registered via Regular Air Mail: " + registeredAirMail);
        Console.WriteLine("Number of customers registered via Registered Air Mail: " + regularAirMail);
        Console.WriteLine("Number of customers registered via Express Air Mail: " + express);
        Demo_Enums.DemoEnums();
        
    }

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
        
    
    }
}
// So in simple terms:
// Use enums where you have a number of related constants instead of declaring constants reperatedly
// By default it is set to type "int" so if you want to change it