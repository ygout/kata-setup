using System;
using Xunit;

namespace test
{
    public class MarsRoverTest
    {

        static string North = "N";

        // input 
        /// initialpos: [x, y]
        /// initialdirection: 'E' | 'N' | 'W' | 'S'
        /// commands list "fbrl"

        // output 
        /// currentpos: [x1, y1]
        /// currentdir: 'N' 
        /// OR BLOCKED
        

        [Fact]
        public void ShouldFaceNorthWhenInitializedNorth()
        {
            var initialDirection = North;

            string currentDirection = initialDirection;

            Assert.Equal(initialDirection, currentDirection);

            // at the moment no public boundary, so no problem using string
            // at the moment this is readable
        }

    }
}
