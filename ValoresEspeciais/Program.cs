using System;
using System.Text;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            sbyte sbyte_value;
            short short_value;
            int int_value;
            long long_value;
            byte byte_value;
            ushort ushort_value;
            uint uint_value;
            ulong ulong_value;
            char char_value;
            float float_value;
            double double_value;
            decimal decimal_value;

            sbyte_value = sbyte.MaxValue;
            short_value = short.MaxValue;
            int_value = int.MaxValue;
            long_value = long.MaxValue;
            byte_value = byte.MaxValue;
            ushort_value = ushort.MaxValue;
            uint_value = uint.MaxValue;
            ulong_value = ulong.MaxValue;
            char_value = char.MaxValue;
            float_value = float.MaxValue;
            double_value = double.MaxValue;
            decimal_value = decimal.MaxValue;


            Console.WriteLine($"sbyteMax: {sbyte_value}");
            Console.WriteLine($"shortMax: {short_value}");
            Console.WriteLine($"intMax: {int_value}");
            Console.WriteLine($"longMax: {long_value}");
            Console.WriteLine($"byteMax: {byte_value}");
            Console.WriteLine($"ushortMax: {ushort_value}");
            Console.WriteLine($"uintMax: {uint_value}");
            Console.WriteLine($"ulongMax: {ulong_value}");
            Console.WriteLine($"charMax: {char_value}");
            Console.WriteLine($"floatMax: {float_value}");
            Console.WriteLine($"doubleMax: {double_value}");
            Console.WriteLine($"decimalMax: {decimal_value}");
        }
    }
}
