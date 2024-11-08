using UnitTests;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace GroßbuchstabenTest
{
    public class UnitTest1
    {
        [Fact]
        public void ZahlenPruefung()
        {
            //Arrange
            string test = "All THOSE moments wILL Be loSt in TimE, like tEArs in rain.";
            string expected = "All Those Moments Will Be Lost In Time, Like Tears In Rain.";


            //Act
            
            string tests = UnitTests.Program.GroßBuchstabenKonvertierung(test);

            //Assert
            Assert.Equal(expected, tests );
        }

    }
}