using System;
using Xunit;

namespace test
{
    public class MarsRoverTest
    {

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
            var initialDirection = "N";

            string currentDirection = initialDirection;

            Assert.Equal(initialDirection, currentDirection);
        }
    }
}
