using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        //[InlineData("33.524131, -86.724876, Taco Bell Birmingham...", -86.724876)]
        //[InlineData("32.465342, -84.919767, Taco Bell Columbus...", - 84.919767)]
        //[InlineData("31.306794,-85.714414,Taco Bell Daleville...", -85.714414)]
        //[InlineData("34.741158,-86.662532,Taco Bell Huntsville...", -86.662532)]
        //[InlineData("34.019885,-84.528291,Taco Bell Marietta...", -84.528291)]
        //[InlineData("30.188307,-85.757511,Taco Bell Panama City Beach...", -85.757511)]


        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            ;
            
            //Assert
            
        }


        //TODO: Create a test ShouldParseLatitude

    }
}
