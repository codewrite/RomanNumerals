namespace RomanNumeral
{
    public static class RomanNumeralParser
    {
        public static int RomanToArabic(this string romanNumeral)
        {
            var runningTotal = 0;

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                var symbol = romanNumeral[i];
                if (symbol == 'I')
                {
                    if (MoreCharacters(romanNumeral, i) && romanNumeral[i + 1] != 'I')
                    {
                        runningTotal -= 1;
                    }
                    else
                    {
                        runningTotal += 1;
                    }
                }
                else if (symbol == 'V')
                    runningTotal += 5;
                else if (symbol == 'X')
                {
                    if (MoreCharacters(romanNumeral, i) && (romanNumeral[i + 1] == 'L' || romanNumeral[i + 1] == 'C'))
                    {
                        runningTotal -= 10;
                    }
                    else
                    {
                        runningTotal += 10;
                    }
                }
                else if (symbol == 'L')
                    runningTotal += 50;
                else if (symbol == 'C')
                    runningTotal += 100;
            }

            return runningTotal;
        }

        private static bool MoreCharacters(string romanNumeral, int i)
        {
            return i < romanNumeral.Length - 1;
        }
    }
}
