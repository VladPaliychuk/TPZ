using NUnit.Framework;
using NUnit.Framework.Internal;
using TPZ.Repositories;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class ConverterIntToRomanTest
    {
        private ConverterIntToRoman _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new ConverterIntToRoman();
        }
        
        [Test]
        public void whenNumberIs_1_ThenReturn_I()
        {
            var result = _converter.Convert(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void whenNumberIs_2_ThenReturn_II()
        {
            var result = _converter.Convert(2);
            Assert.AreEqual("II", result);
        }

        [Test]
        public void whenNumberIs_3_ThenReturn_III()
        {
            var result = _converter.Convert(3);
            Assert.AreEqual("III", result);
        }

        [Test]
        public void whenNumberIs_4_ThenReturn_IV()
        {
            var result = _converter.Convert(4);
            Assert.AreEqual("IV", result);
        }

        [Test]
        public void whenNumberIs_5_ThenReturn_V()
        {
            var result = _converter.Convert(5);
            Assert.AreEqual("V", result);
        }

        [Test]
        public void whenNumberIs_6_ThenReturn_VI()
        {
            var result = _converter.Convert(6);
            Assert.AreEqual("VI", result);
        }

        [Test]
        public void whenNumberIs_7_ThenReturn_VII()
        {
            var result = _converter.Convert(7);
            Assert.AreEqual("VII", result);
        }

        [Test]
        public void whenNumberIs_8_ThenReturn_VIII()
        {
            var result = _converter.Convert(8);
            Assert.AreEqual("VIII", result);
        }

        [Test]
        public void whenNumberIs_9_ThenReturn_IX()
        {
            var result = _converter.Convert(9);
            Assert.AreEqual("IX", result);
        }

        [Test]
        public void whenNumberIs_10_ThenReturn_X()
        {
            var result = _converter.Convert(10);
            Assert.AreEqual("X", result);
        }

        [Test]
        public void whenNumberIs_20_ThenReturn_XX()
        {
            var result = _converter.Convert(20);
            Assert.AreEqual("XX", result);
        }

        [Test]
        public void whenNumberIs_30_ThenReturn_XXX()
        {
            var result = _converter.Convert(30);
            Assert.AreEqual("XXX", result);
        }

        [Test]
        public void whenNumberIs_40_ThenReturn_XL()
        {
            var result = _converter.Convert(40);
            Assert.AreEqual("XL", result);
        }

        [Test]
        public void whenNumberIs_50_ThenReturn_L()
        {
            var result = _converter.Convert(50);
            Assert.AreEqual("L", result);
        }

        [Test]
        public void whenNumberIs_60_ThenReturn_LX()
        {
            var result = _converter.Convert(60);
            Assert.AreEqual("LX", result);
        }

        [Test]
        public void whenNumberIs_70_ThenReturn_LXX()
        {
            var result = _converter.Convert(70);
            Assert.AreEqual("LXX", result);
        }

        [Test]
        public void whenNumberIs_80_ThenReturn_LXXX()
        {
            var result = _converter.Convert(80);
            Assert.AreEqual("LXXX", result);
        }

        [Test]
        public void whenNumberIs_90_ThenReturn_XC()
        {
            var result = _converter.Convert(90);
            Assert.AreEqual("XC", result);
        }

        [Test]
        public void whenNumberIs_100_ThenReturn_C()
        {
            var result = _converter.Convert(100);
            Assert.AreEqual("C", result);
        }

        [Test]
        public void whenNumberIs_200_ThenReturn_CC()
        {
            var result = _converter.Convert(200);
            Assert.AreEqual("CC", result);
        }

        [Test]
        public void whenNumberIs_300_ThenReturn_CCC()
        {
            var result = _converter.Convert(300);
            Assert.AreEqual("CCC", result);
        }
        
        [Test]
        public void whenNumberIs_399_ThenReturn_CCCXCIX()
        {
            var result = _converter.Convert(399);
            Assert.AreEqual("CCCXCIX", result);
        }

        [Test]
        public void whenNumberIs_400_ThenReturn_CD()
        {
            var result = _converter.Convert(400);
            Assert.AreEqual("CD", result);
        }

        [Test]
        public void whenNumberIs_500_ThenReturn_D()
        {
            var result = _converter.Convert(500);
            Assert.AreEqual("D", result);
        }

        [Test]
        public void whenNumberIs_600_ThenReturn_DC()
        {
            var result = _converter.Convert(600);
            Assert.AreEqual("DC", result);
        }

        [Test]
        public void whenNumberIs_700_ThenReturn_DCC()
        {
            var result = _converter.Convert(700);
            Assert.AreEqual("DCC", result);
        }

        [Test]
        public void whenNumberIs_800_ThenReturn_DCCC()
        {
            var result = _converter.Convert(800);
            Assert.AreEqual("DCCC", result);
        }

        [Test]
        public void whenNumberIs_900_ThenReturn_CM()
        {
            var result = _converter.Convert(900);
            Assert.AreEqual("CM", result);
        }

        [Test]
        public void whenNumberIs_1000_ThenReturn_M()
        {
            var result = _converter.Convert(1000);
            Assert.AreEqual("M", result);
        }

        [Test]
        public void whenNumberIs_2000_ThenReturn_MM()
        {
            var result = _converter.Convert(2000);
            Assert.AreEqual("MM", result);
        }

        [Test]
        public void whenNumberIs_3000_ThenReturn_MMM()
        {
            var result = _converter.Convert(3000);
            Assert.AreEqual("MMM", result);
        }

        [Test]
        public void whenNumberIs_1987_ThenReturn_MCMLXXXVII()
        {
            var result = _converter.Convert(1987);
            Assert.AreEqual("MCMLXXXVII", result);
        }

        [Test]
        public void whenNumberIs_3999_ThenReturn_MMMCMXCIX()
        {
            var result = _converter.Convert(3999);
            Assert.AreEqual("MMMCMXCIX", result);
        }

        [Test]
        public void whenNumberIs_444_ThenReturn_CDXLIV()
        {
            var result = _converter.Convert(444);
            Assert.AreEqual("CDXLIV", result);
        }

        [Test]
        public void whenNumberIs_999_ThenReturn_CMXCIX()
        {
            var result = _converter.Convert(999);
            Assert.AreEqual("CMXCIX", result);
        }

        [Test]
        public void whenNumberIs_49_ThenReturn_XLIX()
        {
            var result = _converter.Convert(49);
            Assert.AreEqual("XLIX", result);
        }

        [Test]
        public void whenNumberIs_58_ThenReturn_LVIII()
        {
            var result = _converter.Convert(58);
            Assert.AreEqual("LVIII", result);
        }

        [Test]
        public void whenNumberIs_1994_ThenReturn_MCMXCIV()
        {
            var result = _converter.Convert(1994);
            Assert.AreEqual("MCMXCIV", result);
        }

        [Test]
        public void whenNumberIs_2421_ThenReturn_MMCDXXI()
        {
            var result = _converter.Convert(2421);
            Assert.AreEqual("MMCDXXI", result);
        }

        [Test]
        public void whenNumberIs_3888_ThenReturn_MMMDCCCLXXXVIII()
        {
            var result = _converter.Convert(3888);
            Assert.AreEqual("MMMDCCCLXXXVIII", result);
        }
        
        public void Convert_ShouldReturnCorrectRomanNumeral(int input, string expected)
        {
            var result = _converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
    }
}