using System;
using Xunit;

namespace test
{
    public class MarsRoverTest
    {

        static string North = "N";
        static int[] AnyPosition = { 1, 2 };

        // input 
        /// initialpos: [x, y]
        /// initialdirection: 'E' | 'N' | 'W' | 'S'
        /// commands list "fbrl"

        // output 
        /// currentpos: [x1, y1]
        /// currentdir: 'N' 
        /// OR BLOCKED

        [Fact]
        public void InAbsenceOfCommandsTheCurrentStateIsTheInitialState()
        {
            var initialDirection = North;
            int[] initialPosition = AnyPosition;

            Tuple<string, int[]> roverState = MoveRover(initialDirection, initialPosition, "");

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(initialPosition, roverState.Item2);

            // 1.
            // at the moment no public boundary, so no problem using string
            // at the moment this is readable

            // 2.
            // There is a concept lurking in "state", what is it?
        }

        [Fact]
        public void MoveOneStepForward()
        {
            var initialDirection = North;
            int[] initialPosition = { 1, 2 };
            var commands = "f";

            Tuple<string, int[]> roverState = MoveRover(initialDirection, initialPosition, commands);

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(new int[] { 1, 3 }, roverState.Item2);
        }

        [Fact]
        public void MoveTwoStepsForward()
        {
            var initialDirection = North;
            int[] initialPosition = { 1, 2 };
            var commands = "ff";

            Tuple<string, int[]> roverState = MoveRover(initialDirection, initialPosition, commands);

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(new int[] { 1, 4 }, roverState.Item2);
        }

        private static Tuple<string, int[]> MoveRover(string initialDirection, int[] initialPosition, string commands)
        {
            var currentDirection = initialDirection;
            var deltaOnYAxis = commands.Length;
            int[] currentPosition = { initialPosition[0], initialPosition[1] + deltaOnYAxis };
            var roverState = new Tuple<string, int[]>(currentDirection, currentPosition);
            return roverState;
        }
    }
}
