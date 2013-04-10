using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RomanNumeral
{
    [TestFixture]
    public class RomanNumeralParserTest
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XII", 12)]
        [TestCase("XIII", 13)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVI", 16)]
        [TestCase("XVII", 17)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("XX", 20)]
        [TestCase("XXIV", 24)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("LX", 60)]
        [TestCase("LXIV", 64)]
        [TestCase("LXX", 70)]
        [TestCase("LXXX", 80)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("IIX",8)]
        public void givenRomanReturnsExpectedArabic(string roman, int expectedArabic)
        {
            var actualArabic = roman.RomanToArabic();
            Assert.AreEqual(expectedArabic, actualArabic);
        }
    }
}
