using Newtonsoft.Json.Linq;
using Tyuiu.AtanaevRI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.AtanaevRI.Sprint3.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            
    
                // Arrange
                string input = "!bt, g567kid f!";
                DataService ds = new DataService();
                int expected = 567;

                // Act
                int actual = ds.ConvertStringToInt(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void GetDigitFromString_StringWithMultipleNumbers_ReturnsConcatenatedNumber()
            {
                // Arrange
                string input = "a1b2c3d4";
                DataService ds = new DataService();
                int expected = 1234;

                // Act
                int actual = ds.ConvertStringToInt(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void GetDigitFromString_StringWithoutDigits_ThrowsException()
            {
                // Arrange
                string input = "!bt, gkid f!";
                DataService ds = new DataService();

                // Act
                int result = ds.ConvertStringToInt(input);
            }

            [TestMethod]
            public void GetDigitFromString_EmptyString_ThrowsException()
            {
                // Arrange
                string input = "";
                DataService ds = new DataService();

                // Act & Assert
                Assert.ThrowsException<ArgumentException>(() => ds.ConvertStringToInt(input));
            }

            [TestMethod]
            public void GetDigitFromString_StringWithOnlyDigits_ReturnsSameNumber()
            {
                // Arrange
                string input = "12345";
                DataService ds = new DataService();
                int expected = 12345;

                // Act
                int actual = ds.ConvertStringToInt(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }


    


    

