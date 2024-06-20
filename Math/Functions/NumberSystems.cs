namespace BlokMath.Functions
{
    public static class NumberSystems
    {
        // Decimal to other bases
        public static string DecimalToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        public static string DecimalToOctal(int number)
        {
            return Convert.ToString(number, 8);
        }

        public static string DecimalToHex(int number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }

        // Binary to other bases
        public static int BinaryToDecimal(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static string BinaryToOctal(string binary)
        {
            int decimalNumber = BinaryToDecimal(binary);
            return DecimalToOctal(decimalNumber);
        }

        public static string BinaryToHex(string binary)
        {
            int decimalNumber = BinaryToDecimal(binary);
            return DecimalToHex(decimalNumber);
        }

        // Octal to other bases
        public static int OctalToDecimal(string octal)
        {
            return Convert.ToInt32(octal, 8);
        }

        public static string OctalToBinary(string octal)
        {
            int decimalNumber = OctalToDecimal(octal);
            return DecimalToBinary(decimalNumber);
        }

        public static string OctalToHex(string octal)
        {
            int decimalNumber = OctalToDecimal(octal);
            return DecimalToHex(decimalNumber);
        }

        // Hex to other bases
        public static int HexToDecimal(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        public static string HexToBinary(string hex)
        {
            int decimalNumber = HexToDecimal(hex);
            return DecimalToBinary(decimalNumber);
        }

        public static string HexToOctal(string hex)
        {
            int decimalNumber = HexToDecimal(hex);
            return DecimalToOctal(decimalNumber);
        }
    }
}
