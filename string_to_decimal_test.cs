/*Console.WriteLine("Signed integral types:");
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

using System;
using System.Globalization;

//define out variables
double total=0;
string message = "";
//test input values
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

foreach (string mvalue in values)
{
    double numericValue;
    //Requires CultureInfo to kepp the period separator : 
    // with out CultureInfo, 12.3 -> 123 
    // with CultureInfo  12.3 -> 12,3
    if ( double.TryParse(mvalue, NumberStyles.Any, CultureInfo.InvariantCulture,out numericValue) )
    {
        //Console.WriteLine($"converting: {mvalue} to {numericValue}");        
        total += numericValue;
    }
    else 
    {
        message = message + mvalue;
    }
}

Console.WriteLine($"message: {message}");
Console.WriteLine($"total with , sep : {total}");
Console.WriteLine($"total with . sep : {total.ToString("0.0", CultureInfo.InvariantCulture)}");
