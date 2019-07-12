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

            const string none = "";
            Tuple<string, Position> roverState = new Commands(none).MoveRover(initialDirection, initialPosition);

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

            Tuple<string, Position> roverState = new Commands(commands).MoveRover(initialDirection, initialPosition);

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(new Position(1, 3), roverState.Item2);
        }

        [Fact]
        public void MoveTwoStepsForward()
        {
            var initialDirection = North;
            var initialPosition = new Position(1, 2);
            var commands = "ff";

            Tuple<string, Position> roverState = new Commands(commands).MoveRover(initialDirection, initialPosition);

            Assert.Equal(initialDirection, roverState.Item1);
            Assert.Equal(new Position(1, 4), roverState.Item2);
        }

    }

    public class Commands
    {
        private readonly string commands;

        public Commands(string commands)
        {
            this.commands = commands;
        }

        public Tuple<string, Position> MoveRover(string initialDirection, Position initialPosition)
        {
            var currentDirection = initialDirection;
            var deltaOnYAxis = commands.Length;

            Position currentPosition = initialPosition.Add(deltaOnYAxis);
            // 3.
            // Johan looks for more proof to refactor, question is if we want to wrap Direction right now?
            // Besides constraint, what proof do we need to wrap it? Needs behaviour or at least mean something in domain.
            // Let's wait with the refactoring of deltaOnYAxis and reevaluate after each "green".

            var roverState = new Tuple<string, Position>(currentDirection, currentPosition);
            return roverState;
        }
    }

    public class Position
    {

        private readonly int x;
        private readonly int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position Add(int deltaOnYAxis)
        {
            return new Position(x, y + deltaOnYAxis);
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
