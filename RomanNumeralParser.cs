namespace RomanNumeral
{
    public static class RomanNumeralParser
    {
        private static char[] romanLetters = { 'I', 'V', 'X', 'L', 'C' };
        private static int[] arabicNumbers = { 1, 5, 10, 50, 100 };

        public static int RomanToArabic(this string romanNumeral)
        {
            var runningTotal = 0;

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                var symbol = romanNumeral[i];

                for (int j = 0; j < romanLetters.Length; j++)
                {
                    if (symbol == romanLetters[j])
                    {
                        bool needToAdd = false;
                        if (MoreCharacters(romanNumeral, i))
                        {
                            for (int k = 0; k <= j; k++)
                            {
                                if (romanLetters[k] == romanNumeral[i + 1])
                                {
                                    needToAdd = true;
                                    break;
                                }
                            }
                        }
                        else
                            needToAdd = true;

                        if (needToAdd)
                        {
                            runningTotal += arabicNumbers[j];
                        }
                        else
                        {
                            runningTotal -= arabicNumbers[j];
                        }
                        break;
                    }
                }
            }

            return runningTotal;
        }

        private static bool MoreCharacters(string romanNumeral, int i)
        {
            return i < romanNumeral.Length - 1;
        }
    }
}
