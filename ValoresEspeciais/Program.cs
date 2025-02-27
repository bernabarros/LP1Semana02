using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte sbyte_value;
            short short_value;
            int int_value;
            long long_value;
            byte byte_value;
            ushort ushort_value;
            uint uint_value;
            ulong ulong_value;
            float float_value;
            double double_value;
            decimal decimal_value;

            double special_num;

            sbyte_value = sbyte.MaxValue;
            short_value = short.MaxValue;
            int_value = int.MaxValue;
            long_value = long.MaxValue;
            byte_value = byte.MaxValue;
            ushort_value = ushort.MaxValue;
            uint_value = uint.MaxValue;
            ulong_value = ulong.MaxValue;
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
            Console.WriteLine($"floatMax: {float_value}");
            Console.WriteLine($"doubleMax: {double_value}");
            Console.WriteLine($"decimalMax: {decimal_value}");

            sbyte_value = sbyte.MinValue;
            short_value = short.MinValue;
            int_value = int.MinValue;
            long_value = long.MinValue;
            byte_value = byte.MinValue;
            ushort_value = ushort.MinValue;
            uint_value = uint.MinValue;
            ulong_value = ulong.MinValue;
            float_value = float.MinValue;
            double_value = double.MinValue;
            decimal_value = decimal.MinValue;

            Console.WriteLine($"sbyteMin: {sbyte_value}");
            Console.WriteLine($"shortMin: {short_value}");
            Console.WriteLine($"intMin: {int_value}");
            Console.WriteLine($"longMin: {long_value}");
            Console.WriteLine($"byteMin: {byte_value}");
            Console.WriteLine($"ushortMin: {ushort_value}");
            Console.WriteLine($"uintMin: {uint_value}");
            Console.WriteLine($"ulongMin: {ulong_value}");
            Console.WriteLine($"floatMin: {float_value}");
            Console.WriteLine($"doubleMin: {double_value}");
            Console.WriteLine($"decimalMin: {decimal_value}");

            special_num = double.PositiveInfinity;

            Console.WriteLine($"{special_num}");

            special_num = double.NegativeInfinity;

            Console.WriteLine($"{special_num}");

            special_num = float.NaN;

            Console.WriteLine($"{special_num}");
        }
    }
}
