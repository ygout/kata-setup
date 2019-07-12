using System;
using Xunit;

namespace test
{
    public class MarsRoverTest
    {

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
            var initialDirection = Direction.North;
            var initialPosition = AnyPosition;

            const string none = "";
            var roverState = new Commands(none).MoveRover(new Rover(initialDirection, initialPosition));

            Assert.Equal(initialDirection, roverState.Direction);
            Assert.Equal(initialPosition, roverState.Position);
        }

        [Fact]
        public void MoveOneStepForward()
        {
            var initialDirection = Direction.North;
            var initialPosition = new Position(1, 2);
            var commands = "f";

            var roverState = new Commands(commands).MoveRover(new Rover(initialDirection, initialPosition));

            Assert.Equal(initialDirection, roverState.Direction);
            Assert.Equal(new Position(1, 3), roverState.Position);
        }

        [Fact]
        public void MoveTwoStepsForward()
        {
            var initialDirection = Direction.North;
            var initialPosition = new Position(1, 2);
            var commands = "ff";

            var roverState = new Commands(commands).MoveRover(new Rover(initialDirection, initialPosition));

            Assert.Equal(initialDirection, roverState.Direction);
            Assert.Equal(new Position(1, 4), roverState.Position);
        }

    }


    public class Rover
    {
        public Rover(Direction direction, Position position)
        {
            Direction = direction;
            Position = position;
        }

        public Direction Direction { get; private set; }
        public Position Position { get; private set; }
    }

    public class Commands
    {
        private readonly string commands;

        public Commands(string commands)
        {
            this.commands = commands;
        }

        public Rover MoveRover(Rover rover)
        {
            var currentDirection = rover.Direction;
            var deltaOnYAxis = commands.Length;

            Position currentPosition = rover.Position.Add(deltaOnYAxis);
            // 3.
            // Johan looks for more proof to refactor, question is if we want to wrap Direction right now?
            // Besides constraint, what proof do we need to wrap it? Needs behaviour or at least mean something in domain.
            // Let's wait with the refactoring of deltaOnYAxis and reevaluate after each "green".

            var roverState = new Rover(currentDirection, currentPosition);
            return roverState;
        }
    }

    public enum Direction {
        North
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
