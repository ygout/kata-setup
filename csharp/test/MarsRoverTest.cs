using System;
using Xunit;

namespace test
{
    public class MarsRoverTest
    {

        static string North = "N";
        static Position AnyPosition = new Position(1, 2);

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
            var initialPosition = AnyPosition;

            Tuple<string, Position> roverState = MoveRover(initialDirection, initialPosition, "");

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
            var initialPosition = new Position(1, 2);
            var commands = "f";

            Tuple<string, Position> roverState = MoveRover(initialDirection, initialPosition, commands);

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(new Position(1, 3), roverState.Item2);
        }

        [Fact]
        public void MoveTwoStepsForward()
        {
            var initialDirection = North;
            var initialPosition = new Position(1, 2);
            var commands = "ff";

            Tuple<string, Position> roverState = MoveRover(initialDirection, initialPosition, commands);

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(new Position(1, 4), roverState.Item2);
        }

        private static Tuple<string, Position> MoveRover(string initialDirection, Position initialPosition, string commands)
        {
            var currentDirection = initialDirection;
            var deltaOnYAxis = commands.Length;
            Position currentPosition = new Position( initialPosition.x, initialPosition.y + deltaOnYAxis );
            var roverState = new Tuple<string, Position>(currentDirection, currentPosition);
            return roverState;
        }
    }

    public class Position
    {

        public int x {get;}
        public int y {get;}

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Position p = (Position)obj;
            return (x == p.x) && (y == p.y);
        }

        public override int GetHashCode()
        {
            return (x << 2) ^ y;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }
}
