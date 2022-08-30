// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.InteropServices;

//setting up data
bool booleanVar = new Boolean();
sbyte SByte = 127;
byte Byte = 255;
short Short = 100;

//calling DataType
var dataType = new DataTypes(
    booleanVar, SByte, Byte, Short);

//printing output
Console.WriteLine(JsonConvert.SerializeObject(dataType));

//size of datatypes
Console.WriteLine("Size of bool: " + sizeof(bool));
Console.WriteLine("Size of sbyte: " + sizeof(sbyte));
Console.WriteLine("Size of byte: " + sizeof(byte));
Console.WriteLine("Size of short: " + sizeof(short));
Console.WriteLine("Size of ushort: " + sizeof(ushort));
Console.WriteLine("Size of int: " + sizeof(int));
Console.WriteLine("Size of uint: " + sizeof(uint));
Console.WriteLine("Size of long: " + sizeof(long));
Console.WriteLine("Size of ulong: " + sizeof(ulong));


public class DataTypes
{
    public DataTypes( bool @bool, sbyte sByte, byte @byte, short @short)
    {
        Bool = @bool;
        SByte = sByte;
        Byte = @byte;
        Short = @short;
    }

    public bool Bool { get; set; }

    public sbyte SByte { get; set; }

    public byte Byte { get; set; }

    public short Short { get; set; }

}
