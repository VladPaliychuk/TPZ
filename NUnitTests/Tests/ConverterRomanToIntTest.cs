using NUnit.Framework;
using TPZ.Repositories;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class ConverterRomanToIntTest
    {
        private ConverterRomanToInt _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new ConverterRomanToInt();
        }

        // 10 Tests for exceptions
        [Test]
        public void whenRomanNumeralIsInvalid_ThenThrowException_1()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("IIII"));
        }

        [Test]
        public void whenRomanNumeralIsInvalid_ThenThrowException_2()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("VV"));
        }

        [Test]
        public void whenRomanNumeralIsCyrillic_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("Рим"));
        }

        [Test]
        public void whenRomanNumeralIsInteger_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("123"));
        }

        [Test]
        public void whenRomanNumeralIsEmpty_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert(""));
        }
        
        [Test]
        public void whenRomanNumeralIsLowerCase_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("iv"));
        }
        
        [Test]
        public void whenRomanNumeralIsMixedCase_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("iV"));
        }
        
        [Test]
        public void whenRomanNumeralIsWhitespace_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert(" "));
        }
        
        [Test]
        public void whenRomanNumeralIsNull_ThenThrowException()
        {
            Assert.Throws<System.ArgumentNullException>(() => _converter.Convert(null));
        }

        [Test]
        public void whenRomanNumeralIsSpecialCharacters_ThenThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => _converter.Convert("@#$%"));
        }

        // 5 Tests for conversion
        [Test]
        public void whenRomanNumeralIs_I_ThenReturn_1()
        {
            var result = _converter.Convert("I");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void whenRomanNumeralIs_IV_ThenReturn_4()
        {
            var result = _converter.Convert("IV");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void whenRomanNumeralIs_XL_ThenReturn_40()
        {
            var result = _converter.Convert("XL");
            Assert.AreEqual(40, result);
        }

        [Test]
        public void whenRomanNumeralIs_CM_ThenReturn_900()
        {
            var result = _converter.Convert("CM");
            Assert.AreEqual(900, result);
        }

        [Test]
        public void whenRomanNumeralIs_MCMXCIV_ThenReturn_1994()
        {
            var result = _converter.Convert("MCMXCIV");
            Assert.AreEqual(1994, result);
        }
    }
}